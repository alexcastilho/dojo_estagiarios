using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Palindrome.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAna()
        {
            Palindrome.Lib.Palindrome palindrome = new Palindrome.Lib.Palindrome();
            Assert.AreEqual(true, palindrome.Verificar("ana"));
        }
        [TestMethod]
        public void TestArara()
        {
            Palindrome.Lib.Palindrome palindrome = new Palindrome.Lib.Palindrome();
            Assert.AreEqual(true, palindrome.Verificar("arara"));
        }
        [TestMethod]
        public void TestRegras()
        {
            Palindrome.Lib.Palindrome palindrome = new Palindrome.Lib.Palindrome();
            Assert.AreEqual(false, palindrome.Verificar("regras"));
        }
        [TestMethod]
        public void TestOvo()
        {
            Palindrome.Lib.Palindrome palindrome = new Palindrome.Lib.Palindrome();
            Assert.AreEqual(true, palindrome.Verificar("ovo"));
        }
        [TestMethod]
        public void TestPhrase()
        {
            Palindrome.Lib.Palindrome palindrome = new Palindrome.Lib.Palindrome();
            Assert.AreEqual(true, palindrome.Verificar("Socorram-me subi no onibus em marrocos"));
        }
        [TestMethod]
        public void TestdaBia()
        {
            Palindrome.Lib.Palindrome palindrome = new Palindrome.Lib.Palindrome();
            Assert.AreEqual(true, palindrome.Verificar("Aí Bia."));
        }
        [TestMethod]
        public void TestPhraseFail()
        {
            Palindrome.Lib.Palindrome palindrome = new Palindrome.Lib.Palindrome();
            Assert.AreEqual(false, palindrome.Verificar("Esta frase nao rola"));
        }
        [TestMethod]
        public void VerificaExistencia()
        {
            Palindrome.Lib.Palindrome palindrome = new Palindrome.Lib.Palindrome();
            Assert.IsTrue(palindrome.ArquivoExiste(@"C:\Users\thiagom\Desktop\lista_frases.txt"));

        }
        [TestMethod]
        public void LerSalvar()
        {
            Palindrome.Lib.Palindrome palindrome = new Palindrome.Lib.Palindrome();
            palindrome.LerArquivo(@"C:\Users\thiagom\Desktop\lista_frases.txt");
        }
        [TestMethod]
        public void MyTestMethod()
        {
            Palindrome.Lib.Palindrome palindrome = new Palindrome.Lib.Palindrome();
            Assert.AreEqual(true, palindrome.Verificar("renner"));           
        }
    }
}