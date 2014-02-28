using AutoInsurance.Business;
using AutoInsurance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AutoInsurance.Web.Webservice
{
    /// <summary>
    /// Summary description for AutoInsurance
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AutoInsurance : System.Web.Services.WebService
    {
        [WebMethod]
        public List<Proposal> GetProposals()
        {
            ProposalBusiness proposalBusiness = new ProposalBusiness();
            return proposalBusiness.FindAll();
        }
    }
}
