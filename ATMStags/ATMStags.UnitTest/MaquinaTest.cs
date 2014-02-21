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
            cliente.Cartao = cartao;
            cliente.Conta = conta;
            cliente.Conta.Saldo = Int16.MaxValue;
            cliente.Cartao.DataValidade = DateTime.Now.AddYears(5);
            cliente.Cartao.Id = 1;
            
            maquina.Saldo = 100;

            maquinaBusiness.Sacar(cliente, 50, maquina);
            
            Assert.AreEqual(50, maquina.Saldo);
        }

        [TestMethod]
        [ExpectedException(typeof(MaquinaSaldoInsuficienteException))]
        public void TestSaldoInsuficienteException()
        {
            cliente.Conta = conta;
            cliente.Conta.Saldo = int.MaxValue;
            maquina.Saldo = 0;

            maquinaBusiness.Sacar(cliente, 50, maquina);
        }
    }
}