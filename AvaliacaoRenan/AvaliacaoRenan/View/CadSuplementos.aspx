<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadSuplementos.aspx.cs" Inherits="AvaliacaoRenan.View.CadSuplementos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row"> 
            <div class="MyDiv">
        <asp:Label ID="lblNome"  CssClass="MyLabel" runat="server" Text="Nome"></asp:Label>
        <asp:TextBox ID="txtNome" CssClass="Mytextbox" runat="server"></asp:TextBox>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="MyDiv">
        <asp:Label ID="lblDescricao"  CssClass="MyLabel"  runat="server" Text="Descrição"></asp:Label>
        <asp:TextBox ID="txtDescricao" CssClass="Mytextbox" runat="server"></asp:TextBox>
            </div>
        </div>
    </div>
    <div="container">
        <div>
            <asp:Label ID="lblMarca"  CssClass="MyLabel" runat="server" Text="Marca"></asp:Label>
            <asp:TextBox ID="txtMarca"  CssClass="Mytextbox" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="MyDiv">
        <asp:Label ID="lblForma" CssClass="MyLabel" runat="server" Text="Forma"></asp:Label>
        <asp:TextBox ID="txtForma"  CssClass="Mytextbox" runat="server"></asp:TextBox>
             </div>
        </div>
    </div>
   <div class="container">
        <div class="row">
            <div class="MyDiv">
        <asp:Label ID="lblOrigem"  CssClass="MyLabel" runat="server" Text="Origem"></asp:Label>
        <asp:DropDownList ID="ddlOrigem" runat="server" Height="16px" Width="134px">
            <asp:ListItem>Nacional</asp:ListItem>
            <asp:ListItem>Importado</asp:ListItem>
            </asp:DropDownList>
             </div>   
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="MyDiv">
            <asp:Label ID="lblAtivo"  CssClass="MyLabel" runat="server" Text="Ativo"></asp:Label>
            <asp:DropDownList ID="ddlAtivo" runat="server">
                <asp:ListItem Value="True">Ativo</asp:ListItem>
                <asp:ListItem Value="Falso">Inativo</asp:ListItem>
            </asp:DropDownList>
              </div>
        </div>
    </div>
  <div class="container">
        <div class="row">
            <div class="MyDiv">
            <asp:Button ID="btnSalvar" class="btn btn-success" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            <asp:Button ID="Button2" class="btn btn-danger" runat="server" Text="Cancelar" OnClick="Button2_Click" />
            <asp:Button ID="btnAlterar" class="btn btn-warning" runat="server" Text="Alterar" />
            <asp:Button ID="btnExucluir" class="btn btn-info" runat="server" Text="Excluir" OnClick="btnExucluir_Click" />
            </div>
        </div>
    </div>
     <div class="container">
        <div class="row">
            <div class="MyDiv">
            <asp:Label ID="lblBuscar"  CssClass="MyLabel" runat="server" Text="Buscar"></asp:Label>
            <asp:TextBox ID="txtBuscar" CssClass="Mytextbox" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscar" class="btn btn-default" runat="server" Text="Buscar Suplemento Para alterar ou excluir" OnClick="btnBuscar_Click" />
            </div>
        </div>
    </div>
     <%--ListarInativo--%>
    <<div class="container">
        <div class="row">
            <div class="MyDiv">
            <h3>Suplementos Desativados</h3>
            <asp:GridView ID="gvwInativos" runat="server"></asp:GridView>
                </div>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="MyDiv">
            <h3>Marcas Ativas</h3>
            <asp:GridView ID="gvwMarcas" runat="server"></asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
