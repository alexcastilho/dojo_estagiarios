using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoInsurance.Business;
using AutoInsurance.Model;

namespace AutoInsurance.UnitTest
{
    [TestClass]
    public class ProposalTest
    {
        ProposalBusiness proposalBusiness;
        Proposal proposal;

        [TestInitialize]
        public void Init() 
        {
            proposalBusiness = new ProposalBusiness();
            proposal = new Proposal();            
        }

        [TestMethod]
        public void TestInsert()
        {
            CarBusiness carBusiness = new CarBusiness();
            InsuredBusiness insuredBusiness = new InsuredBusiness();

            proposal.Car = carBusiness.Find(1);
            proposal.Insured = insuredBusiness.Find(1);
            proposal.Value = 100;

            proposalBusiness.Insert(proposal);

            Assert.IsTrue(proposal.Id > 0);
        }
    }
}