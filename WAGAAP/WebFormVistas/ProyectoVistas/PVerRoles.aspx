<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PVerRoles.aspx.cs" Inherits="WebForm_Proyecto_PVerRoles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Estilos/Proyecto/SVerRoles.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="" class="container">
        <div class="search-container">
            <asp:TextBox ID="txtBusqueda" runat="server" CssClass="txtBuscar2" Placeholder="Buscar..." Width="315px" Height="28px"></asp:TextBox>
            <button onclick="applyFilters()">Buscar</button>
        </div>
    </div>
    <p></p>
    <div class="container">
        <div class="tabla-split2 fondo22">
            <table>
                <tr>
                    <th style="width: 30%;">Nombre</th>
                    <th style="width: 30%;">Rol</th>
                    <th style="width: 40%;">Acciones</th>
                </tr>
                <tr>
                    <td>Cristian Bueno</td>
                    <td>
                        <select class="ddl-rol">
                            <option value="" disabled selected>ROL</option>
                            <option value="estudiante">Estudiante</option>
                            <option value="tutor">Tutor</option>
                        </select>
                    </td>
                    <td>
                        <button>Añadir</button>
                    </td>
                </tr>
                <tr>
                    <td>Otro Estudiante</td>
                    <td>
                        <select class="ddl-rol">
                            <option value="" disabled selected>ROL</option>
                            <option value="estudiante">Estudiante</option>
                            <option value="tutor">Tutor</option>
                        </select>
                    </td>
                    <td>
                        <button>Añadir</button>
                    </td>
                </tr>
            </table>
        </div>
        <!-- Segunda tabla -->
        <div class="tabla-split2 fondo22">
            <table>
                <tr>
                    <th style="width: 50%;">Nombre</th>
                    <th style="width: 70%;">Rol en Proyecto</th>
                    <th style="width: 100%;">Acciones</th>
                </tr>
                <tr>
                    <td>Cristian Bueno</td>
                    <td>Estudiante</td>
                    <td>
                        <button>Editar</button>
                    </td>
                </tr>
                <tr>
                    <td>Cristian Encinas</td>
                    <td>Tutor</td>
                    <td>
                        <button>Editar</button>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    <script src="../../Guiones/Proyecto/JVerRoles.js"></script>
</asp:Content>

