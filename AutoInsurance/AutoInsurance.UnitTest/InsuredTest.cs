using AutoInsurance.Business;
using AutoInsurance.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoInsurance.UnitTest
{

    [TestClass]
    public class InsuredTest
    {
        InsuredBusiness insuredBusiness;
        Insured insured;

        [TestInitialize]
        public void Init()
        {
            insuredBusiness = new InsuredBusiness();
            insured = new Insured();
        }

        [TestMethod]
        public void TestInsert()
        {
            insured.FirstName = "FName";
            insured.LastName = "LName";
            insured.Age = 40;

            insuredBusiness.Insert(insured);

            Assert.IsTrue(insured.Id > 0);
        }

        [TestMethod]
        public void TestDelete()
        {
            insured.FirstName = "FName";
            insured.LastName = "LName";
            insured.Age = 40;

            insuredBusiness.Insert(insured);
            insuredBusiness.Delete(insured.Id);

            Assert.IsNull(insuredBusiness.Find(insured.Id));
        }
    }
}