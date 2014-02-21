using ATMStags.Business;
using ATMStags.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATMStags.Web
{
    public partial class RealizarSaque : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSacar_Click(object sender, EventArgs e)
        {
            ClienteModel cliente = new ClienteModel();
            ClienteBusiness clienteBusiness = new ClienteBusiness();

            ContaModel conta = new ContaModel();
            ContaBusiness contaBusiness = new ContaBusiness();

            CartaoModel cartao = new CartaoModel();
            CartaoBusiness cartaoBusiness = new CartaoBusiness();
        }
    }
}