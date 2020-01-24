﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ECommerceAPI.Models;
using ECommerceAPI.Repository;
using Microsoft.AspNetCore.Authorization;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InitialController : ControllerBase
    {
        private readonly ProdutoRepository _produtoRepository;
        private readonly PerfilRepository _perfilRepository;
        private readonly UsuarioRepository _usuarioRepository;
        private readonly EstoqueRepository _estoqueRepository;

        public InitialController(PerfilRepository perfilRepository,
                ProdutoRepository produtoRepository,
                UsuarioRepository usuarioRepository,
                EstoqueRepository estoqueRepository)
        {
            _perfilRepository = perfilRepository;
            _produtoRepository = produtoRepository;
            _usuarioRepository = usuarioRepository;
            _estoqueRepository = estoqueRepository;
        }

        [HttpGet]
        public ActionResult Initiate()
        {
            var perfilAdmin = new Perfil() { Nome = "ADMIN" };
            var perfilUser = new Perfil() { Nome = "USER" };

            _perfilRepository.Gravar(perfilAdmin);
            _perfilRepository.Gravar(perfilUser);

            var userAdmin = new Usuario() { IdPerfil = perfilAdmin.Id, DataModificacao = DateTime.Now, Ativo = true, Nome = "Rafael Thomazelli", Email = "rafael@verzel.com.br", Login = "rafael", Senha = "1234" };
            _usuarioRepository.Gravar(userAdmin);
            var userAdmin2 = new Usuario() { IdPerfil = perfilAdmin.Id, DataModificacao = DateTime.Now, Ativo = true, Nome = "Admin", Email = "admin@verzel.com.br", Login = "admin", Senha = "1234" };
            _usuarioRepository.Gravar(userAdmin2);
            var userAdmin3 = new Usuario() { IdPerfil = perfilAdmin.Id, DataModificacao = DateTime.Now, Ativo = false, Nome = "Inativo", Email = "inativo@verzel.com.br", Login = "inativo", Senha = "1234" };
            _usuarioRepository.Gravar(userAdmin3);

            var userFinal = new Usuario() { IdPerfil = perfilUser.Id, DataModificacao = DateTime.Now, Ativo = true, Nome = "User 1", Email = "user1@verzel.com.br", Login = "user1", Senha = "user123" };
            _usuarioRepository.Gravar(userFinal);
            var userFinal2 = new Usuario() { IdPerfil = perfilUser.Id, DataModificacao = DateTime.Now, Ativo = true, Nome = "User 2", Email = "user2@verzel.com.br", Login = "user2", Senha = "user123" };
            _usuarioRepository.Gravar(userFinal2);
            var userFinal3 = new Usuario() { IdPerfil = perfilUser.Id, DataModificacao = DateTime.Now, Ativo = false, Nome = "User 3 Inativo", Email = "user3@verzel.com.br", Login = "user3", Senha = "user123" };
            _usuarioRepository.Gravar(userFinal3);

            var produto1 = new Produto() { Nome = "TV Smart 32 4k", Preco = 1000.90m, Ativo = true, Descricao = "TV Smart 4K, 3 USBs, 3HDMI", DataModificacao = DateTime.Now, IdUsuario = userAdmin.Id };
            _produtoRepository.Cadastrar(produto1);

            var produto2 = new Produto() { Nome = "Microondas LG", Preco = 399.78m, Ativo = true, Descricao = "Microondas LG", DataModificacao = DateTime.Now, IdUsuario = userAdmin2.Id };
            _produtoRepository.Cadastrar(produto2);

            var produto3 = new Produto() { Nome = "Fogão Brastemp", Preco = 899.99m, Ativo = true, Descricao = "Fogão Brastemp", DataModificacao = DateTime.Now, IdUsuario = userAdmin3.Id };
            _produtoRepository.Cadastrar(produto3);

            var produto4 = new Produto() { Nome = "Notebook Game Acer", Preco = 3800.00m, Ativo = true, Descricao = "Notebook Game Acer", DataModificacao = DateTime.Now, IdUsuario = userAdmin.Id };
            _produtoRepository.Cadastrar(produto4);

            var produto5 = new Produto() { Nome = "Geladeira Samsung", Preco = 2850.25m, Ativo = false, Descricao = "Geladeira Samsung", DataModificacao = DateTime.Now, IdUsuario = userAdmin2.Id };
            _produtoRepository.Cadastrar(produto5);

            var produto6 = new Produto() { Nome = "Liquidificador Philco", Preco = 1000.90m, Ativo = false, Descricao = "Liquidificador Philco", DataModificacao = DateTime.Now, IdUsuario = userAdmin3.Id };
            _produtoRepository.Cadastrar(produto6);

            var produto7 = new Produto() { Nome = "Cama Box Baú King", Preco = 1500.00m, Ativo = true, Descricao = "Cama Box Baú King", DataModificacao = DateTime.Now, IdUsuario = userAdmin.Id };
            _produtoRepository.Cadastrar(produto7);

            var produto8 = new Produto() { Nome = "Colchão King", Preco = 2200.89m, Ativo = true, Descricao = "Colchão King", DataModificacao = DateTime.Now, IdUsuario = userAdmin2.Id };
            _produtoRepository.Cadastrar(produto8);

            var estoque1 = new Estoque() { IdProduto = produto1.Id, Quantidade = 3, DataModificacao = DateTime.Now };
            _estoqueRepository.Cadastrar(estoque1);

            var estoque2 = new Estoque() { IdProduto = produto2.Id, Quantidade = 5, DataModificacao = DateTime.Now };
            _estoqueRepository.Cadastrar(estoque2);

            var estoque3 = new Estoque() { IdProduto = produto3.Id, Quantidade = 20, DataModificacao = DateTime.Now };
            _estoqueRepository.Cadastrar(estoque3);

            var estoque4 = new Estoque() { IdProduto = produto4.Id, Quantidade = 1, DataModificacao = DateTime.Now };
            _estoqueRepository.Cadastrar(estoque4);

            var estoque5 = new Estoque() { IdProduto = produto5.Id, Quantidade = 3, DataModificacao = DateTime.Now };
            _estoqueRepository.Cadastrar(estoque5);

            var estoque6 = new Estoque() { IdProduto = produto6.Id, Quantidade = 22, DataModificacao = DateTime.Now };
            _estoqueRepository.Cadastrar(estoque6);

            var estoque7 = new Estoque() { IdProduto = produto7.Id, Quantidade = 7, DataModificacao = DateTime.Now };
            _estoqueRepository.Cadastrar(estoque7);

            var estoque8 = new Estoque() { IdProduto = produto8.Id, Quantidade = 3, DataModificacao = DateTime.Now };
            _estoqueRepository.Cadastrar(estoque8);

            return Created("initial", new
            {
                Perfis = _perfilRepository.ListarTodos(),
                Usuarios = _usuarioRepository.ListarTodos(),
                Produtos = _produtoRepository.ListarTodos(),
                Estoques = _estoqueRepository.ListarTodos()
            });
        }
    }
}
