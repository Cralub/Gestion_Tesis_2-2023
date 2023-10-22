<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PAgregarCelular.aspx.cs" Inherits="WebForm_Usuario_PAgregarCelular" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Agregar un número de celular</h2>
<br />
<%--<form id="form1" runat="server">--%>
    <asp:Label runat="server" Text="Código de área"></asp:Label>
    <asp:TextBox ID="txbCodigoArea" runat="server"></asp:TextBox>
    <br />
    <asp:Label runat="server" Text="Número de celular"></asp:Label>
    <asp:TextBox ID="txbNumeroCelular" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnAgregarCelular" Text="AGREGAR" runat="server" OnClick="btnAgregarCelular_Click" />
<%--</form>--%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

