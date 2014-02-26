using AutoInsurance.Business;
using AutoInsurance.Model;
using AutoInsurance.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoInsurance.Web.Controllers
{
    public class ProposalController : Controller
    {
        public ActionResult Index(ProposalViewModel pvm)
        {
            pvm.ProposalValue = (Double)new Random().Next(1, 3000);
            return View(pvm);
        }

        public ActionResult Save(ProposalViewModel obj)
        {
            ProposalBusiness proposalBusiness = new ProposalBusiness();

            Proposal proposal = new Proposal();
            proposal.Insured = new Insured();
            proposal.Insured.FirstName = obj.FirstName;
            proposal.Insured.LastName = obj.LastName;
            proposal.Insured.Age = obj.Age;
            CarBusiness carBusiness = new CarBusiness();
            proposal.Car = carBusiness.Find(obj.CarId);

            InsuredBusiness insuredBusiness = new InsuredBusiness();
            insuredBusiness.Insert(proposal.Insured);
            proposalBusiness.Insert(proposal);

            return RedirectToAction("List", "Proposal");
        }
        public ActionResult List()
        {
            List<ProposalListModel> proposalListModel = FindAllProposal();


            return View(proposalListModel);
        }

        private List<ProposalListModel> FindAllProposal()
        {
            List<Proposal> list = new List<Proposal>();
            ProposalBusiness proposalBusiness = new ProposalBusiness();
            List<ProposalListModel> proposalListModel = new List<ProposalListModel>();
            list = proposalBusiness.FindAll();

            foreach (var item in list)
            {
                ProposalListModel plm = new ProposalListModel();
                plm.CarModel = item.Car.Model;
                plm.FirstName = item.Insured.FirstName;
                plm.LastName = item.Insured.LastName;
                plm.Value = item.Value;

                proposalListModel.Add(plm);
            }
            return proposalListModel;
        }

        public ActionResult Search(string searchTerm)
        {
            List<ProposalListModel> proposalList = FindAllProposal();
            return View("List", proposalList.FindAll(i => i.FirstName.Contains(searchTerm)));
        }
    }
}