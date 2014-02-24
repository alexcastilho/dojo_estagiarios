using AutoInsurance.Business;
using AutoInsurance.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoInsurance.Web.Controllers
{
    public class CarController : Controller
    {
        //
        // GET: /Car/

        public ActionResult Index(ProposalViewModel pvm)
        {
            CarBusiness car = new CarBusiness();
            pvm.Cars = car.FindAll();
            return View(pvm);
        }

    }
}
