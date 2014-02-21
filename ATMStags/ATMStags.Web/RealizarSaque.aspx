<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="RealizarSaque.aspx.cs" Inherits="ATMStags.Web.RealizarSaque" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <asp:Label ID="lblCodigoCliente" runat="server" Text="Código Cliente" AssociatedControlID="txtCodigoCliente"></asp:Label>
    <asp:TextBox ID="txtCodigoCliente" runat="server"></asp:TextBox> <br />

    <asp:Label ID="lblValor" runat="server" Text="Valor" AssociatedControlID="txtValor"></asp:Label>
    <asp:TextBox ID="txtValor" runat="server"></asp:TextBox> <br />
    
    <asp:Button ID="btnSacar" runat="server" Text="Sacar" OnClick="btnSacar_Click"/>
</asp:Content>