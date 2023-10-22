<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PInsertarUsuario.aspx.cs" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" Inherits="WebForm_Usuario_PInsertarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Codigo Usuario Proyecto"></asp:Label>
        <asp:TextBox ID="txbCodigoUsuarioProyecto" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Estado Usuario Proyecto"></asp:Label>
        <asp:TextBox ID="txbEstadoUsuarioProyecto" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Codigo Usuario Rol"></asp:Label>
        <asp:TextBox ID="txbCodigoUsuarioRol" runat="server"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="Codigo"></asp:Label>
        <asp:TextBox ID="txbCodigoUsuario" runat="server"></asp:TextBox>
        <asp:Label ID="Labe5" runat="server" Text="Nombres"></asp:Label>
        <asp:TextBox ID="txbNombres" runat="server"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="Apellidos"></asp:Label>
        <asp:TextBox ID="txbApellidos" runat="server"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" Text="Sede"></asp:Label>
        <asp:TextBox ID="txbSede" runat="server"></asp:TextBox>
        <asp:DropDownList ID="ddlProyectos" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProyectos_SelectedIndexChanged"/>
        <asp:DropDownList ID="ddlRoles" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlRoles_SelectedIndexChanged"/>
        <asp:Button ID="btnInsertar" runat="server" Text="Insertar" OnClick="btnInsertar_Click" />

    </div>
</asp:Content>

