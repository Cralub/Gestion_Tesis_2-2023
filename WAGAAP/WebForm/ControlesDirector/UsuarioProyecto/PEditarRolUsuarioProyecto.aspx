<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PEditarRolUsuarioProyecto.aspx.cs" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" Inherits="WebForm_Usuario_EditarRolUsuarioProyecto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../../Estilos/SBase.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contenedor">
        <h1>Seleccione Rol a Cambiar</h1>
        <asp:Label ID="lblCodigoUsuarioProyecto" runat="server" Visible="false" />
        <asp:Label ID="lblCodigoUsuario" runat="server" Visible="false" />
        <asp:Label ID="lblCodigoProyecto" runat="server" Visible="false" />
        <asp:Label ID="lblRol" runat="server"></asp:Label>
        <div class="ContenedorCombo">
            <asp:DropDownList ID="ddlRol" runat="server" CssClass="comboOpciones" />
        </div>
        <div> 
            <asp:Label runat="server" ID="lblMensajeEditarUsuarioProyecto" CssClass="Datos"></asp:Label>

            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="Btntabla" OnClick="btnGuardar_Click" />

    <asp:Button CssClass="Btntabla" ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
</div>
    </div>

</asp:Content>
