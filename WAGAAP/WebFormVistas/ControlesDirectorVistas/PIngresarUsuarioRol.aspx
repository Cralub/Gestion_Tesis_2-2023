<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PIngresarUsuarioRol.aspx.cs" Inherits="WebForm_ControlesDirector_PIngresarUsuarioRol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="fondo">
        <h2>Lista de Usuarios de Netvalle</h2>
        <p></p>
        <asp:TextBox ID="txtBusqueda" runat="server" CssClass="txtBuscar" Placeholder="Buscar por apellido o nombre del estudiante" Width="315px" Height="28px"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" CssClass="boton-busqueda" Width="30px" Height="18px" />
        <p></p>
        <div class="fondo3">
            <table class="tabla-personas">
                <tr>
                    <th style="width: 40%;">NOMBRE DE LOS USUARIOS</th>
                    <th style="width: 30%;">CARRERA</th>
                    <th style="width: 20%;">ROL</th>
                    <th style="width: 210px;">ACCIONES</th>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Christian Gonzales" CssClass="lbl-blanco"></asp:Label></td>
                    <td>
                        <asp:Label runat="server" Text="ISI" CssClass="lbl-blanco"></asp:Label></td>
                    <td>
                        <select id="ddlRol" class="ddl-rol">
                            <option value="Estudiante">Estudiante</option>
                            <option value="Admin">Admin</option>
                            <option value="Docente">Docente</option>
                        </select>

                    </td>
                    <td>
                        <asp:Button runat="server" Text="Crear Proyecto" CssClass="boton" />
                    </td>
                </tr>

            </table>
        </div>
    </div>
</asp:Content>

