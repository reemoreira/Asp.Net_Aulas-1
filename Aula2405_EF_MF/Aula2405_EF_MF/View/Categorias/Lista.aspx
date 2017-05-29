<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="Aula2405_EF_MF.View.Categorias.Lista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Categorias</h1>
    <asp:GridView ID="gvCategorias" runat="server"></asp:GridView>
    <div class="from-group"
    <h1>Categorias Excluidas</h1>
    <asp:GridView ID="gvCategoriasInativas" runat="server"></asp:GridView>
    </div>
</asp:Content>
