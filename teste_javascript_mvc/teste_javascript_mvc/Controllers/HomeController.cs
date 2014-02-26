using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using teste_javascript_mvc.Models;

namespace teste_javascript_mvc.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Get()
        {
            List<Cliente> clientes = new List<Cliente>();
            Cliente cliente = new Cliente();
            cliente.Id = 1;
            cliente.Nome = "Teste";
            cliente.Data = DateTime.Now;

            clientes.Add(cliente);
            clientes.Add(cliente);
            clientes.Add(cliente);

            return Json(clientes, JsonRequestBehavior.AllowGet);
        }
    }
}