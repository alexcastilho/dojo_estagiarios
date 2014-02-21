<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ConsultarCliente.aspx.cs" Inherits="ATMStags.Web.ConsultarCliente" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <h1>Lista de Clientes:</h1><br />
    <asp:GridView ID="grdClientes" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Nome" HeaderText="Nome" />
            <asp:BoundField DataField="Sobrenome" HeaderText="Sobrenome" />
            <asp:BoundField DataField="CPF" HeaderText="CPF" />
            <asp:BoundField DataField="RG" HeaderText="RG"/>
            <asp:BoundField DataField="Idade" HeaderText="Idade" />
            <asp:BoundField DataField="NumeroCartao" HeaderText="Numero do Cartao" />
            <asp:BoundField DataField="DataValidadeCartao" HeaderText="Validade" />
            <asp:BoundField DataField="Saldo" HeaderText="Saldo" />

            
        </Columns>
    </asp:GridView>

</asp:Content>
