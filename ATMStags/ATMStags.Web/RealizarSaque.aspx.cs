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
            ClienteBusiness clienteBusiness = new ClienteBusiness();
            ClienteModel cliente = clienteBusiness.Buscar(Convert.ToInt32(txtCodigoCliente.Text.Trim()));

            MaquinaBusiness maquinaBusiness = new MaquinaBusiness();
            MaquinaModel maquinaFake = new MaquinaModel();
            maquinaFake.Saldo = double.MaxValue; //não fizemos a persistência das informações de máquina

            maquinaBusiness.Sacar(cliente, Convert.ToDouble(txtValor.Text.Trim()), maquinaFake);
        }
    }
}