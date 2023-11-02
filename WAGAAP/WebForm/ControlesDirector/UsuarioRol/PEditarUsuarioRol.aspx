<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="PEditarUsuarioRol.aspx.cs" Inherits="WebForm_UsuarioRol_PEditarUsuarioRol" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:TextBox ID="txbIdUsuarioRol" runat="server" Visible="False"/>
        <asp:TextBox ID="txbIdUsuario" runat="server" Visible="False"/>
        <asp:DropDownList ID="ddlUsuarioRol" runat="server" OnSelectedIndexChanged="ddlUsuarioRol_SelectedIndexChanged" CssClass="form-control" AutoPostBack="True"></asp:DropDownList>
        <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="btn btn-primary" OnClick="btnEditar_Click"/>
    </div>
</asp:Content>