using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using exemplo.model;
using exemplo.business;
using System.Collections.Generic;

namespace exemplo.unittest
{
    [TestClass]
    public class ClienteTest
    {
        UsuarioBusiness usuarioBusiness;

        [TestInitialize]
        public void Init()
        {
            usuarioBusiness = new UsuarioBusiness();
        }

        [TestMethod]
        public void TestInserirCliente()
        {
            Usuario usuario = new Usuario();

            usuario.Nome = "Usuario";
            usuario.Sobrenome = "Sobrenome";
            usuario.Rg = "123";
            usuario.Nascimento = DateTime.Now;
            
            usuarioBusiness.Inserir(usuario);

            Assert.IsTrue(usuario.Id > 0);
        }

        [TestMethod]
        public void TestBuscarTodosCliente()
        {
            List<Usuario> listaUsuarios = usuarioBusiness.BuscarTodos();
        }

        [TestMethod]
        public void TestDeletarCliente()
        {
            Usuario usuario = new Usuario();

            usuario.Nome = "Usuario";
            usuario.Sobrenome = "Sobrenome";
            usuario.Rg = "123";
            usuario.Nascimento = DateTime.Now;

            usuarioBusiness.Inserir(usuario);

            usuarioBusiness.Deletar(usuario.Id);
        }

        [TestMethod]
        public void TestAtualizarCliente()
        {
            Usuario usuario = new Usuario();
            usuario.Nascimento = DateTime.Now;
            usuario.Nome = "Usuario";
            usuario.Sobrenome = "Sobrenome";
            usuario.Rg = "123";

            usuarioBusiness.Inserir(usuario);

            usuario.Nome += "Alterado";


            usuarioBusiness.Atualizar(usuario);
        }
    }
}