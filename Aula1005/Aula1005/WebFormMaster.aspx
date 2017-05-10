<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormMaster.aspx.cs" Inherits="Aula1005.WebFormMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Upload de arquivo"></asp:Label>
    <asp:FileUpload ID="FileUpload1" runat="server" />
</asp:Content>
