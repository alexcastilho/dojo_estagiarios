using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ATMStags.Business;
using ATMStags.Model;

namespace ATMStags.UnitTest
{
    [TestClass]
    public class CartaoTest
    {
        CartaoBusiness cartaoBusiness;
        CartaoModel cartao;

        [TestInitialize]
        public void Init()
        {
            cartaoBusiness = new CartaoBusiness();
            cartao = new CartaoModel();
        }

        [TestMethod]
        public void TestInserir()
        {
            cartao.DataValidade = DateTime.Now;

            cartaoBusiness.Inserir(cartao);

            Assert.IsTrue(cartao.Id > 0);
        }

        [TestMethod]
        public void TestBuscar()
        {
            cartao.DataValidade = DateTime.Now;
            cartaoBusiness.Inserir(cartao);

            Assert.IsNotNull(cartaoBusiness.Buscar(cartao.Id));
        }

        [TestMethod]
        public void TestBuscarTodos()
        {
            cartao.DataValidade = DateTime.Now;
            cartaoBusiness.Inserir(cartao);
            Assert.IsTrue(cartaoBusiness.BuscarTodos().Count > 0);
        }
    }
}