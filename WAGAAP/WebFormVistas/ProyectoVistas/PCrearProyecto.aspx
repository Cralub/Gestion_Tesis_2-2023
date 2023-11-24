<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PCrearProyecto.aspx.cs" Inherits="WebForm_Proyecto_PCrearProyecto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2>Nuevo Proyecto</h2>
    <asp:TextBox ID="txtBusqueda" runat="server" CssClass="txtBuscar" Placeholder="Buscar por apellido o nombre del estudiante" Width="315px" Height="28px"></asp:TextBox>
    <asp:Button ID="btnBuscar" runat="server" CssClass="boton-busqueda" Width="30px" Height="18px" />
    <p></p>
    <div class="fondo3">
        <table class="tabla-personas">
            <tr>
                <th style="width: 40%;">NOMBRE</th>
                <th style="width: 30%;">CARRERA</th>
                <th style="width: 220px;">ACCIONES</th>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Christian Gonzales" CssClass="lbl-blanco"></asp:Label></td>
                <td>
                    <asp:Label runat="server" Text="ISI" CssClass="lbl-blanco"></asp:Label></td>
                <td>
                    <asp:Button runat="server" Text="Crear Proyecto" CssClass="boton" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Marcelo Apala" CssClass="lbl-blanco"></asp:Label></td>
                <td>
                    <asp:Label runat="server" Text="ISI" CssClass="lbl-blanco"></asp:Label></td>
                <td>
                    <asp:Button runat="server" Text="Crear Proyecto" CssClass="boton" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Juan Perez" CssClass="lbl-blanco"></asp:Label></td>
                <td>
                    <asp:Label runat="server" Text="ISI" CssClass="lbl-blanco"></asp:Label></td>
                <td>
                    <asp:Button runat="server" Text="Ver Proyecto" CssClass="boton" />
                </td>
            </tr>
        </table>

    </div>
</asp:Content>

