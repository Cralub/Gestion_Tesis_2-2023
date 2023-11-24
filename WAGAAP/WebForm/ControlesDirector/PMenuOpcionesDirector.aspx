<%@ Page Title="Opciones Director" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PMenuOpcionesDirector.aspx.cs" Inherits="WebForm_ControlesDirector_PMenuOpcionesDirector" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <asp:Button ID="btnCrearProyecto" runat="server" Text="Nuevo Proyecto" OnClick="btnCrearProyecto_Click" />
    </div>
    <div>
        <asp:Button ID="btnTutorExterno" runat="server" Text="Agregar Tutor Externo" OnClick="btnTutorExterno_Click" />
    </div>
    
</asp:Content>
