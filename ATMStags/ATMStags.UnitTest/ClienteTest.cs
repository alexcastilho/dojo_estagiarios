﻿using System;
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
            cartao.Cliente = cliente;
            cartao.DataValidade = DateTime.Now.AddYears(5);
            cartao.Id = 1;
            cartao.Conta.Saldo = 100;
            maquina.Saldo = Int64.MaxValue;
            maquinaBusiness.Sacar(cartao, 50, maquina);
            Assert.AreEqual(50, cartao.Conta.Saldo);
        }
        [TestMethod]
        [ExpectedException(typeof(SaldoInsuficienteException))]
        public void TestSaldoInsuficiente()
        {
            cartao.Conta = conta;
            cartao.Cliente = cliente;
            cartao.DataValidade = DateTime.Now.AddYears(5);
            cartao.Id = 1;
            cartao.Conta.Saldo = 100;
            maquina.Saldo = Int64.MaxValue;
            maquinaBusiness.Sacar(cartao, 101, maquina);
            Assert.AreEqual(100, cartao.Conta.Saldo);
        }

        [TestMethod]
        [ExpectedException(typeof(CartaoInvalidoException))]
        public void TestCartaoInvalido()
        {

            cartao.Conta = conta;
            cartao.Cliente = cliente;
            cartao.DataValidade = DateTime.Now.AddYears(-5);
            cartao.Id = 1;
            cartao.Conta.Saldo = 100;
            maquina.Saldo = Int64.MaxValue;
            maquinaBusiness.Sacar(cartao, 10, maquina);


            //throw new CartaoInvalidoException();


        }
    }
}