using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using teste_entity_framework.business;
using teste_entity_framework.model;
using System.Text.RegularExpressions;

namespace teste_entity_framework.unittest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Client client = new Client();
            client.Name = "Test";
            client.Year = DateTime.Now;
            client.LastName = "Test";

            ClientBusiness clientBusiness = new ClientBusiness();
            clientBusiness.Insert(client);

            Assert.IsTrue(client.Id > 0);
       }
    }
}