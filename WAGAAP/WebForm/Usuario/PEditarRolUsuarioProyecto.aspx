<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PEditarRolUsuarioProyecto.aspx.cs" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" Inherits="WebForm_Usuario_EditarRolUsuarioProyecto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="lblCodigoUsuarioProyecto" runat="server" Visible="false"/>
    <asp:Label ID="lblCodigoUsuario" runat="server" Visible="false"/>
    <asp:Label ID="lblCodigoProyecto" runat="server" Visible="false"/>
    <asp:DropDownList ID="ddlRol" runat="server" CssClass="form-control" />
    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
</asp:Content>