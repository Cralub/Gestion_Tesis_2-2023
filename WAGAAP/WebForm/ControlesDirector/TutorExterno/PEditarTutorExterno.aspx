<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" CodeFile="PEditarTutorExterno.aspx.cs" Inherits="WebForm_TutorExterno_PEditarTutorExterno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Codigo"></asp:Label>
            <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Nombres"></asp:Label>
            <asp:TextBox ID="txtNombres" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Apellidos"></asp:Label>
            <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Carrera"></asp:Label>
            <asp:TextBox ID="txtCarrera" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Direccion de Trabajo"></asp:Label>
            <asp:TextBox ID="txtDireccionTrabajo" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label6" runat="server" Text="Descripcion"></asp:Label>
            <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label7" runat="server" Text="Sede"></asp:Label>
            <asp:TextBox ID="txtSede" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnGuardar" runat="server" Text="Editar" OnClick="btnGuardar_Click" />
        </div>
    </div>
</asp:Content>
