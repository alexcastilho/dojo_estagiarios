using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ATMStags.Business;
using ATMStags.Model;
using ATMStags.Business.Exceptions;

namespace ATMStags.UnitTest
{
    [TestClass]
    public class ClienteTest
    {
        MaquinaBusiness maquinaBusiness;
        MaquinaModel maquina;
        ClienteModel cliente;
        CartaoModel cartao;
        ContaModel conta;

        [TestInitialize]
        public void Init()
        {
            maquinaBusiness = new MaquinaBusiness();
            maquina = new MaquinaModel();
            cliente = new ClienteModel();
            cartao = new CartaoModel();
            conta = new ContaModel();
        }

        [TestMethod]
        public void TestSaldoSuficiente()
        {
            cliente.Conta = conta;
            cliente.Cartao = cartao;
            cliente.Cartao.DataValidade = DateTime.Now.AddYears(5);
            cliente.Id = 1;
            cliente.Conta.Saldo = 100;
            maquina.Saldo = Int64.MaxValue;
            
            maquinaBusiness.Sacar(cliente, 50, maquina);

            Assert.AreEqual(50, cliente.Conta.Saldo);
        }

        [TestMethod]
        [ExpectedException(typeof(SaldoInsuficienteException))]
        public void TestSaldoInsuficiente()
        {
            cliente.Conta = conta;
            cliente.Cartao = cartao;
            cliente.Cartao.DataValidade = DateTime.Now.AddYears(5);
            cliente.Id = 1;
            cliente.Conta.Saldo = 100;
            maquina.Saldo = Int64.MaxValue;

            maquinaBusiness.Sacar(cliente, 101, maquina);

            Assert.AreEqual(100, cliente.Conta.Saldo);
        }

        [TestMethod]
        [ExpectedException(typeof(CartaoInvalidoException))]
        public void TestCartaoInvalido()
        {
            cliente.Conta = conta;
            cliente.Cartao = cartao;
            cliente.Cartao.DataValidade = DateTime.Now.AddYears(-5);
            cliente.Id = 1;
            cliente.Conta.Saldo = 100;
            maquina.Saldo = Int64.MaxValue;

            maquinaBusiness.Sacar(cliente, 10, maquina);
        }


        [TestMethod]
        public void TestInserir()
        {
            ClienteBusiness clienteBusiness = new ClienteBusiness();
            CartaoBusiness cartaoBusiness = new CartaoBusiness();
            ContaBusiness contaBusiness = new ContaBusiness();

            cliente.Cartao = cartao;
            cliente.Cartao.DataValidade = DateTime.Now;
            cartaoBusiness.Inserir(cliente.Cartao);

            conta.Saldo = 1000;
            contaBusiness.Inserir(conta);

            cliente.Nome = "Joao";
            cliente.RG = "37749564-x";
            cliente.Sobrenome = "Da Silva";
            cliente.Idade = 103;
            cliente.CPF= "00000000001";
            cliente.IdCartao = cartao.Id;
            cliente.IdConta = conta.Id;

            clienteBusiness.Inserir(cliente);

            Assert.IsTrue(cartao.Id > 0);
        }
    }
}