<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadMarcas.aspx.cs" Inherits="AvaliacaoRenan.View.CadMarcas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%--#divone{ position:absolute/fixed/relative; width:300px; height:300px;  }--%>  
    
    <div id ="divone">
        <div>
        <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label> 
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        </div>
    </div>
    <div>
        <div>
        <asp:Label ID="lblDescricao" runat="server" Text="Descricao"></asp:Label> 
        <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
        </div>
    </div>
    <div>
        <div>
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
        </div>
    </div>
</asp:Content>
