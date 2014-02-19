using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ATMStags.Business;
using ATMStags.Model;
using ATMStags.UnitTest;

namespace ATMStags.MaquinaTest
{
    [TestClass]
    public class MaquinaTeste
    {
        MaquinaBusiness maquinaBusiness;
        
        MaquinaModel maquina;
        CartaoModel cartao;
        ClienteModel cliente;
        ContaModel conta;

        [TestInitialize]
        public void Init()
        {
            maquinaBusiness = new MaquinaBusiness();

            maquina = new MaquinaModel();
            cartao = new CartaoModel();
            cliente = new ClienteModel();
            conta = new ContaModel();
        }


        [TestMethod]
        public void TestSaldoSuficiente()
        {
            cartao.Conta = conta;
            cartao.Conta.Saldo = Int16.MaxValue;
            cartao.Cliente = cliente;
            cartao.DataValidade = DateTime.Now.AddYears(5);
            cartao.Id = 1;
            maquina.Saldo = 100;
            maquinaBusiness.Sacar(cartao, 50, maquina);
            Assert.AreEqual(50, maquina.Saldo);
        }

        [TestMethod]
        public void TestSaldoInsuficiente()
        {
            cartao.Conta = conta;
            cartao.Conta.Saldo = int.MaxValue;
            cartao.Cliente = cliente;
            maquina.Saldo = 0;

            maquinaBusiness.Sacar(cartao, 50, maquina);
            Assert.AreEqual(0, maquina.Saldo);
        }

        [TestMethod]
        [ExpectedException(typeof(SaldoInsuficienteException))]
        public void TestSaldoInsuficienteException()
        {
            cartao.Conta = conta;
            cartao.Conta.Saldo = int.MaxValue;
            cartao.Cliente = cliente;
            maquina.Saldo = 0;

            maquinaBusiness.Sacar(cartao, 50, maquina);
        }
    }
}