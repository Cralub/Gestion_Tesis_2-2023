<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PListarUsuarioCodigo.aspx.cs" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" Inherits="WebForm_Usuario_PListarUsuarioCodigo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <asp:TextBox runat="server" MaxLength="15" ID="txbCodigoUsuario" class="TextBox"></asp:TextBox>
        <asp:Button runat="server" ID="btnBuscar" Text="Buscar" OnClick="btnBuscar_Click" class="Boton" />
        <br />
        <br />
        <asp:GridView ID="gvListaUsuarios" DataKeyNames="CodigoUsuario" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False">
            <Columns >
                <asp:BoundField DataField="CodigoUsuario" HeaderText="Codigo" />
                <asp:BoundField DataField="NombreCompletoUsuario" HeaderText="Nombres" />
                <asp:BoundField DataField="SedeUsuario" HeaderText="Apellidos" />


