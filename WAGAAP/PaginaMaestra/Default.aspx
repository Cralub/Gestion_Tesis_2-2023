<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="PaginaMaestra_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
            <div>
                <asp:Button ID="btnCodigoUsuarioSesion" runat="server" Text="ID Usuario" OnClick="btnCodigoUsuarioSesion_Click" />
                <asp:TextBox runat="server" ID="txbCodigoUsuarioSesion"></asp:TextBox>
                <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click"/>
            </div>
            <div>
                <asp:Button ID="btnCrearProyecto" runat="server" Text="Nuevo Proyecto" OnClick="btnCrearProyecto_Click" />
                <asp:Button ID="btnFormularios" runat="server" Text="Proyectos-Formularios" OnClick="btnFormularios_Click" />
                <asp:Button ID="btnFiltrarProyectos" runat="server" Text="Filtros Proyectos(General)" OnClick="btnFiltrarProyectos_Click" />
                <asp:Button ID="btnInformacion" runat="server" Text="Informacion Proyectos" OnClick="btnInformacion_Click" />
            </div>
        </div>
</asp:Content>

