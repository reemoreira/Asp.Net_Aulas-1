<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadCategoria.aspx.cs" Inherits="Aula2405_EF_MF.View.Categorias.CadCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br><br>
    <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    <br><br>
    <asp:Label ID="lblDescricao" runat="server" Text="Descrição"></asp:Label>
    <br>
    <asp:TextBox ID="txtDescricao" runat="server" Height="70px" TextMode="MultiLine"></asp:TextBox>
    <br><br>
    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    &nbsp &nbsp
    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
</asp:Content>
