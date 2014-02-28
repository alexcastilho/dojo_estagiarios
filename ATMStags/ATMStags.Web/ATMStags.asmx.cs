using ATMStags.Business;
using ATMStags.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ATMStags.Teia
{
    /// <summary>
    /// Summary description for ATMStags
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ATMStags : System.Web.Services.WebService
    {

        [WebMethod]
        public void Debitar(int value, int id)
        {
            ContaBusiness contaBusiness = new ContaBusiness();
            ClienteBusiness clienteBusiness = new ClienteBusiness();
            ClienteModel cliente = clienteBusiness.Buscar(id);

            contaBusiness.Debitar(cliente.Conta, value);
        }
    }
}
