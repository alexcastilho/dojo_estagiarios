using ATMStags.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATMStags.Web
{
    public partial class ConsultarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void CarregarClientes()
        {
            ClienteBusiness clienteBusiness = new ClienteBusiness();

            
            grdClientes.DataSource = clienteBusiness.BuscarTodasInformacoes();
            grdClientes.DataBind();

        }
    }
}