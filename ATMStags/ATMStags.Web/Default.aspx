<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ATMStags.Web._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>ATM Stags.</h1>
                <h2>Bem-vindo ao SUPER banco diferenciado</h2>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>O que você precisa?</h3>
    <ol class="round">
        <li class="one">
            <h5>Clientes:</h5>
            <a href="CadastrarCliente.aspx">Cadastrar</a><br />
            <a href="ConsultarCliente.aspx">Consultar</a>
        </li>
        <li class="two">
            <h5>Operações:</h5>
            <a href="RealizarSaque.aspx">Realizar Saque</a>
        </li>
    </ol>
</asp:Content>
