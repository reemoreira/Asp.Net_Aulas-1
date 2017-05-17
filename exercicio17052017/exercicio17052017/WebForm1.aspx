<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exercicio17052017.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br>
    <asp:Label ID="lblValor" runat="server" Text="Valor 1"></asp:Label>
    <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
    <br>
    <asp:Label ID="lblValortwo" runat="server" Text="Valor 2"></asp:Label>
    <asp:TextBox ID="txtValortwo" runat="server"></asp:TextBox>
    <br>
    <asp:Button ID="btnSoma" runat="server" Text="Soma" OnClick="btnSoma_Click" />
    &nbsp;
    <asp:Button ID="btnIgual" runat="server" Text="Button" OnClick="btnIgual_Click"/>
    <br><br>
    <asp:Label ID="lblSomaresult" runat="server" Text="Soma é :"></asp:Label>
    &nbsp;
    <asp:TextBox ID="txtSomaresult" runat="server"></asp:TextBox>


</asp:Content>
