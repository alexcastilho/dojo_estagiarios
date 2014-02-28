<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CadastrarCliente.aspx.cs" Inherits="ATMStags.Web.CadastrarCliente" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <asp:Label ID="lblMensagem" runat="server"></asp:Label>

    <asp:Label ID="lblNome" runat="server" Text="Label" AssociatedControlID="txtNome">Nome:</asp:Label>
    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br />

    <asp:Label ID="lblSobrenome" runat="server" Text="Label" AssociatedControlID="txtSobrenome">Sobrenome:</asp:Label>
    <asp:TextBox ID="txtSobrenome" runat="server"></asp:TextBox><br />

    <asp:Label ID="lblCPF" runat="server" Text="Label" AssociatedControlID="txtCPF">CPF:</asp:Label>
    <asp:TextBox ID="txtCPF" runat="server"></asp:TextBox><br />

    <asp:Label ID="lblRG" runat="server" Text="Label" AssociatedControlID="txtRG">RG:</asp:Label>
    <asp:TextBox ID="txtRG" runat="server"></asp:TextBox><br />

    <asp:Label ID="lblIdade" runat="server" Text="Label" AssociatedControlID="txtIdade">Idade:</asp:Label>
    <asp:TextBox ID="txtIdade" runat="server"></asp:TextBox><br />

    <asp:Button ID="btnGravar" runat="server" Text="Gravar" OnClick="btnGravar_Click"/>
</asp:Content>
