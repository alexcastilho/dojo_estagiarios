using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using teste_webservice.model;

namespace teste_webservice.Webservice
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<Cliente> GetCliente()
        {
            List<Cliente> clientes = new List<Cliente>();

            for (int i = 0; i < 5; i++)
            {
                Cliente cliente = new Cliente();
                cliente.Id = i + 1;
                cliente.Nome = "Cliente " + i + 1;
                cliente.Ano = DateTime.Now;

                clientes.Add(cliente);
            }

            return clientes;
        }

        [WebMethod]
        public void UpdateCliente(int id)
        {

        }
    }
}