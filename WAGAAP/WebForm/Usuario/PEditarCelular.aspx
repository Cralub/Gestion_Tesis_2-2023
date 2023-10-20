<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PEditarCelular.aspx.cs" Inherits="WebForm_Usuario_PEditarCelular" %>

<asp:Content ID="Head" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content" ContentPlaceHolderID="content" Runat="Server">
    <h2>Editar número de celular</h2>
    <br />
    <form id="form1" runat="server">
        <asp:Label runat="server" Text="Código de usuario"></asp:Label>
        <asp:TextBox ID="txbCodigoUsuario" runat="server"></asp:TextBox>
        <br />
        <asp:Label runat="server" Text="Código de área"></asp:Label>
        <asp:TextBox ID="txbCodigoArea" runat="server"></asp:TextBox>
        <br />
        <asp:Label runat="server" Text="Número de celular"></asp:Label>
        <asp:TextBox ID="txbNumeroCelular" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnEditarCelular" Text="EDITAR" runat="server" OnClick="btnEditarCelular_Click" />
        <asp:Button ID="btnEliminarCelular" Text="ELIMINAR" runat="server" OnClick="btnEliminarCelular_Click" />
    </form>
</asp:Content>