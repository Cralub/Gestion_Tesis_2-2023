<%@ Page Title="Opciones Director" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PMenuOpcionesDirector.aspx.cs" Inherits="WebForm_ControlesDirector_PMenuOpcionesDirector" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Estilos/SBase.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <asp:Button ID="btnCrearProyecto" CssClass="Btntabla" runat="server" Text="Nuevo Proyecto" OnClick="btnCrearProyecto_Click" />
    </div>
    <div>
        <asp:Button ID="btnTutorExterno" CssClass="Btntabla" runat="server" Text="Agregar Tutor Externo" OnClick="btnTutorExterno_Click" />
    </div>
    <div>
    <asp:Button ID="btnUsuarioProyecto" CssClass="Btntabla" runat="server" Text="Administrar Usuarios en Proyectos" OnClick="btnUsuarioProyecto_Click" />
</div>
    
</asp:Content>
