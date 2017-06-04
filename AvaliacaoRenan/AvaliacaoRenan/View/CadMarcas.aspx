<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadMarcas.aspx.cs" Inherits="AvaliacaoRenan.View.CadMarcas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%--#divone{ position:absolute/fixed/relative; width:300px; height:300px;  }--%>  
    <br /><br />
    <div>
        <div class="input-group">
        <asp:Label ID="lblNome" class="col-sm-2 control-label" runat="server" Text="Nome"></asp:Label> 
            &nbsp &nbsp
        <asp:TextBox ID="txtNome" class="form-group" runat="server"></asp:TextBox>
        </div>
    </div>
    <div >
        <div class="input-group">
        <asp:Label ID="lblDescricao" class="col-sm-2 control-label"  runat="server" Text="Descricao"></asp:Label> 
            &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
        <asp:TextBox ID="txtDescricao"  class="form-group" runat="server" Height="100px" TextMode="MultiLine" Width="197px"></asp:TextBox>
        </div>
    </div>
    <div>
        <div>
            <asp:Label ID="lblAtivo" runat="server" Text="Status"></asp:Label>
            <asp:DropDownList ID="ddlAtivo" runat="server" Width="97px">
                <asp:ListItem Value="True">Ativo</asp:ListItem>
                <asp:ListItem Value="False">Inativo</asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
    <div class="col-md-4">
        <div class="input-group" >
            <asp:Button ID="btnSalvar"  class="btn btn-success" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            <asp:Button ID="btnCancelar" class="btn btn-danger" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
            <asp:Button ID="btnAlterar" class="btn btn-warning" runat="server" Text="Alterar" OnClick="btnAlterar_Click" />
            <asp:Button ID="btnExcluir" class="btn btn-info" runat="server" Text="Excluir" OnClick="btnExcluir_Click"/>
        </div>
    </div>
    <div>
        <div>
        </div>
    </div>
     <div>
        <div>
            <asp:Label ID="lblBuscar" class="col-sm-2 control-label" runat="server" Text="Buscar Por Nome:"></asp:Label>
            <asp:TextBox ID="txtBuscar"   class="form-group" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscar" class="btn btn-default" runat="server" Text="Buscar Marca Para alterar ou excluir" OnClick="btnBuscar_Click" />
        </div>
    </div>
    <div>
        <div>
            <h3>Marcas Desativadas</h3>
            <asp:GridView ID="gvwInativos" runat="server"></asp:GridView>
        </div>
    </div>   
</asp:Content>

