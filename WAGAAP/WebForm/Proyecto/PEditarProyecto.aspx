<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PEditarProyecto.aspx.cs" Inherits="WebForm_Proyecto_PEditarProyecto" %>

<asp:Content ID="Head" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content" ContentPlaceHolderID="content" Runat="Server">
    <h2>Editar datos del Proyecto</h2>
    <br />
    <form id="form1" runat="server" >    
        <asp:Label Text="Código Proyecto " runat="server" />
        <asp:TextBox runat="server" ID="txbCodigoProyecto" />
        <br />
        <asp:Label Text="Modalidad del proyecto " runat="server" />
        <asp:TextBox runat="server" ID="txbModalidad" />
        <br />
        <asp:Label Text="Titulo del proyecto " runat="server" />
        <asp:TextBox runat="server" ID="txbTitulo" />
        <br />
        <asp:Label Text="Objetivo general " runat="server" />
        <asp:TextBox runat="server" ID="txbObjetivoGeneral" />
        <br />
        <asp:Label Text="Objetivo especifico" runat="server" />
        <asp:TextBox runat="server" ID="txbObjetivoEspecifico" />
        <br />
        <asp:Label Text="Alcance" runat="server" />
        <asp:TextBox runat="server" ID="txbAlcance" />
        <br />
        <asp:Label Text="Enlace documento" runat="server" />
        <asp:TextBox runat="server" ID="txbEnlace" />
        <br />
        <asp:Button Text="OBTENER" runat="server" ID="btnObtener" OnClick="btnObtener_Click" />
        <asp:Button Text="EDITAR" runat="server" ID="btnEditar" OnClick="btnEditar_Click" />
        <br />
        <asp:Label runat="server" ID="lblSms" />
    </form>
</asp:Content>