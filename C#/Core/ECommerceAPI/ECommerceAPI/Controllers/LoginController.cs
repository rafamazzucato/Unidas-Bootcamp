using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ECommerceAPI.Models;
using ECommerceAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using ECommerceAPI.Services;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UsuarioRepository _usuarioRepository;

        public LoginController(UsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpPost]
        public ActionResult<dynamic> Login([FromBody]Usuario usuario)
        {
            var user = _usuarioRepository.BuscaPorLoginEmailSenha(usuario.Login, usuario.Email, usuario.Senha);

            if(user == null)
            {
                return NotFound(new { message = "Usuário ou senha inválidos" });
            }

            if (user.Ativo == false)
            {
                return NotFound(new { message = "Usuário inátivo, entre em contato com o administrador" });
            }

            var token = TokenServico.GenerateToken(user);

            return new
            {
                login = user.Login,
                token
            };
        }
    }
}
