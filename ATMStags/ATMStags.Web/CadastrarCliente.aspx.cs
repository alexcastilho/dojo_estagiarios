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
    public partial class CadastrarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            SerasaWebService.SerasaSoapClient serasaValidator = new SerasaWebService.SerasaSoapClient();
            if (serasaValidator.ValidarCPF(txtCPF.Text))
            {
                ClienteBusiness clienteBusiness = new ClienteBusiness();
                ClienteModel cliente = new ClienteModel();

                CartaoBusiness cartaoBusiness = new CartaoBusiness();
                CartaoModel cartao = new CartaoModel();
                cartao.DataValidade = DateTime.Now.AddYears(5);
                cartaoBusiness.Inserir(cartao);

                ContaBusiness contaBusiness = new ContaBusiness();
                ContaModel conta = new ContaModel();
                conta.Saldo = 202013401;
                contaBusiness.Inserir(conta);

                cliente.Nome = txtNome.Text;
                cliente.Sobrenome = txtSobrenome.Text;
                cliente.CPF = txtCPF.Text;
                cliente.Idade = Convert.ToInt32(txtIdade.Text);
                cliente.RG = txtRG.Text;
                cliente.IdCartao = cartao.Id;
                cliente.IdConta = conta.Id;

                clienteBusiness.Inserir(cliente);
                lblMensagem.Text = "Cliente cadastrado com sucesso!";
                lblMensagem.Style.Add("color", "green");
            }
            else
            {
                lblMensagem.Style.Add("color", "red");
                lblMensagem.Text = "CPF Inválido";
            }
        }


    }
}