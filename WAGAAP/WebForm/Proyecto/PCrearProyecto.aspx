<%@ Page Title="Elegir Tutor" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PCrearProyecto.aspx.cs" Inherits="WebForm_Proyecto_PCrearProyecto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <div>
            <asp:Label runat="server" Text="Buscar Estudiante CodigoSIU: "></asp:Label>
            <asp:TextBox ID="txbCodigoUsuario" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscarUsuario" Text="Buscar" runat="server" OnClick="btnBuscarUsuario_Click" />

        </div>
        <div>
            <asp:TextBox ID="txbCodigoProyecto" runat="server"></asp:TextBox>
            <asp:Button ID="btnCrearProyecto" Text="Crear Nuevo Proyecto" runat="server" OnClick="btnCrearProyecto_Click" />
        </div>
        <div>
            <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
        </div>
    </div>
</asp:Content>
