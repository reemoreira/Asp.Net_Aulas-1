<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroProjeto.aspx.cs" Inherits="Aula1505.CadastroProjeto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class:"row">
        <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvNome" runat="server" ErrorMessage="Campo Nome é obrigatório!" ControlToValidate="txtNome"></asp:RequiredFieldValidator>
    </div>
    <div class:"row">
        <asp:Label ID="lblAtivo" runat="server" Text="Ativo"></asp:Label>
        <asp:Checkbox ID="chkAtivo" runat="server"></asp:Checkbox>
    </div>
    <div class:"row">
        <asp:button id="btnsalvar" runat="server" text="Salvar" OnClick="btnsalvar_Click"></asp:button>
        <asp:button id="btncancelar" runat="server" text="Cancelar" onclick="btncancelar_click" causesvalidation="false"></asp:button>
    </div>

</asp:Content>
