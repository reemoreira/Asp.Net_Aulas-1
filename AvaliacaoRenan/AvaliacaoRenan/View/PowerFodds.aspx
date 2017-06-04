<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PowerFodds.aspx.cs" Inherits="AvaliacaoRenan.View.PowerFodds" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div>
            <asp:GridView ID="gvwSuplemento" runat="server"></asp:GridView>
        </div>
    </div>
    <div>
        <div>
            <asp:Label ID="lblTipo" runat="server" Text="Lista por tipo"></asp:Label>
            <asp:DropDownList ID="ddlTipo" runat="server" OnSelectedIndexChanged="ddlTipo_SelectedIndexChanged">
                <asp:ListItem>Nome</asp:ListItem>
                <asp:ListItem>Origem</asp:ListItem>
                <asp:ListItem>Forma</asp:ListItem>
            </asp:DropDownList>
        </div>           
    </div>
      <div>
        <div>
            <asp:GridView ID="gvwTipo" runat="server"></asp:GridView>
        </div>
    </div>
    <div>
    <h3>Trabalhamos com essas marcas</h3>
    <asp:GridView ID="gvwMarcas" runat="server"></asp:GridView>
    </div>
</asp:Content>
