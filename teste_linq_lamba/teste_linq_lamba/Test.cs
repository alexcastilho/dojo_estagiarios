using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace teste_linq_lambda
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Year { get; set; }
    }


    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestMethod()
        {
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            var numQuery = from num in numbers
                           where (num % 2) == 0
                           select num;

            Assert.AreEqual(4, numQuery.Count());
        }

        [TestMethod]
        public void MyTestMethod()
        {
            List<Client> clients = new List<Client>();

            clients.Add(new Client() { Id = 1, Name = "Mary0", Year = DateTime.Now.AddYears(-50) });
            clients.Add(new Client() { Id = 2, Name = "John1", Year = DateTime.Now.AddYears(-30) });
            clients.Add(new Client() { Id = 3, Name = "John2", Year = DateTime.Now.AddYears(-90) });

            bool exist = clients.Exists(i => i.Id == 1);
        }
    }
}