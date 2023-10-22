<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PPerfilUsuario.aspx.cs" Inherits="WebForm_Usuario_PPerfilUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Perfil del Usuario</h2>
<br />
<%--<form id="form1" runat="server">--%>
    <asp:Label Text="Número de celular" runat="server" />
    <asp:TextBox ID="txbNumeroCelular" Enabled="false" runat="server" />
    <br />
    <asp:Button ID="btnEditar" Text="EDITAR" Visible="false" runat="server" OnClick="btnEditar_Click" />
    <asp:Button ID="btnNuevo" Text="NUEVO" Visible="false" runat="server" OnClick="btnNuevo_Click" />
<%--</form>--%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

