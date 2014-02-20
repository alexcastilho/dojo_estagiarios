using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ATMStags.Business;
using ATMStags.Model;

namespace ATMStags.UnitTest
{
    [TestClass]
    public class ContaTest
    {
        ContaBusiness contaBusiness;
        ContaModel conta;

        [TestInitialize]
        public void Init()
        {
            contaBusiness = new ContaBusiness();
            conta = new ContaModel();
        }

        [TestMethod]
        public void TestInserir()
        {
            conta.Saldo = 1;
            contaBusiness.Inserir(conta);

            Assert.IsTrue(conta.Id > 0);
        }
    }
}
