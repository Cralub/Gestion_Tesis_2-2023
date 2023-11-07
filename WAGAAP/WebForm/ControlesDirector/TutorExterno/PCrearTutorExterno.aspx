<%@ Page Title="Crear Tutor Externo" Language="C#" AutoEventWireup="true" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" CodeFile="PCrearTutorExterno.aspx.cs" Inherits="WebForm_TutorExterno_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>
            <asp:Label ID="lblCodigo" runat="server" Text="Codigo"></asp:Label>
            <asp:TextBox ID="txbCodigo" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblNombres" runat="server" Text="Nombres"></asp:Label>
            <asp:TextBox ID="txbNombres" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblApellidos" runat="server" Text="Apellidos"></asp:Label>
            <asp:TextBox ID="txbApellidos" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblCarrera" runat="server" Text="Carrera"></asp:Label>
            <asp:TextBox ID="txbCarrera" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblDireccionTrabajo" runat="server" Text="Direccion de Trabajo"></asp:Label>
            <asp:TextBox ID="txbDireccionTrabajo" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblDescripcion" runat="server" Text="Descripcion"></asp:Label>
            <asp:TextBox ID="txbDescripcion" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblSede" runat="server" Text="Sede"></asp:Label>
            <asp:TextBox ID="txbSede" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnGuardar" runat="server" Text="Crear" OnClick="btnCrear_Click" />
        </div>
    </div>

</asp:Content>
