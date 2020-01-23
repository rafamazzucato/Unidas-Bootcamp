﻿using ECommerceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceAPI.Repository
{
    interface UsuarioRepository
    {
        void Gravar(Usuario usuario);
        List<Usuario> ListarTodos();
        Usuario SelecionarPorId(int id);
        Usuario BuscaPorLoginEmailSenha(string login, string email, string senha);
    }
}
