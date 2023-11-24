<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PBuscarProyecto.aspx.cs" Inherits="WebForm_Proyecto_PBuscarProyecto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Estilos/Proyecto/SBuscarProyecto.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2>Lista de Revisión / Proyectos</h2>
    <div id="container">
        <div class="filters">
            <div class="filter-controls">
                <div class="search-filter">
                    <input type="text" placeholder="Buscar...">
                    <button onclick="applyFilters">Buscar</button>
                </div>
                <div class="select-filters2">
                    <select id="filter1" class="ddl-rol2">
                        <option value="activo">Activo</option>
                        <option value="inactivo">Inactivo</option>
                    </select>
                    <select id="filter2" class="ddl-rol2">
                        <option value="tema">Tema</option>
                        <option value="web">Web</option>
                        <option value="movil">Móvil</option>
                    </select>
                    <select id="filter3" class="ddl-rol2">
                        <option value="tesis">Tesis</option>
                        <option value="pdg">PdG</option>
                        <option value="maestria">Maestría</option>
                    </select>
                </div>
            </div>
        </div>
        <div class="fondo3">
            <table id="dataTable" class="tabla-personas">
                <thead>
                    <tr>
                        <th ">PROYECTOS</th>
                        <th style="width: 20%;">ESTUDIANTES</th>
                        <th style="width: 10%;">TIPO</th>
                        <th style="width: 20%;">ETAPA</th>
                        <th style="width: 10%;">ESTADO</th>
                        <th style="width: 20%;">ACCIONES</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>PR001</td>
                        <td>JUAN P</td>
                        <td>TESIS</td>
                        <td>TEMA</td>
                        <td>ACTIVO</td>
                        <td>
                            <button>Ver</button>
                        </td>
                    </tr>
                    <tr>
                        <td>PR002</td>
                        <td>MARIA J</td>
                        <td>WEB</td>
                        <td>TESIS</td>
                        <td>INACTIVO</td>
                        <td>
                            <button>Ver</button>
                        </td>
                    </tr>
                    <tr>
                        <td>PR003</td>
                        <td>JOSE M</td>
                        <td>MOVIL</td>
                        <td>MAESTRIA</td>
                        <td>ACTIVO</td>
                        <td>
                            <button>Ver</button>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
    <script src="../../Guiones/Proyecto/JBuscarProyecto.js"></script>
</asp:Content>

