<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PResponsable.aspx.cs" Inherits="WebForm_Usuario_PResponsable" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Estilos/Usuario/SResponsable.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contenedor">
        <div class="Menu">
            <div class="buscador">
                <input class="txtBusqueda" type="text" id="Buscar" name="Buscar" placeholder="Buscar por apellido o nombre responsable" />
            </div>
            <div class="ContenedorCombo">
                <select class="comboOpciones" id="estado" name="estado">
                    <option value="">ESTADO</option>
                    <option value="">ACTIVO</option>
                    <option value="">INACTIVO</option>
                    <option value="">EN ESPERA</option>
                </select>
                <select class="comboOpciones" id="tipo" name="tipo">
                    <option value="">TIPO</option>
                    <option value="tesis">TESIS</option>
                </select>
            </div>
        </div>
        <div class="contenedorTabla">
            <table class="EstiloTable">
                <thead>
                    <tr>
                        <th>NOMBRE DEL RESPONSABLE</th>
                        <th>TIPO</th>
                        <th>ESTADO</th>
                        <th>FECHA</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Cristian Bueno</td>
                        <td>tipo</td>
                        <td>estado</td>
                        <td>04/09/23</td>
                        <td class="btnLinea">
                            <button class="Btntabla">Editar</button>
                            <button class="Btntabla">Eliminar</button></td>
                    </tr>
                    <tr>
                        <td>Cristian Encinas</td>
                        <td>tipo</td>
                        <td>estado</td>
                        <td>04/09/23</td>
                        <td class="btnLinea">
                            <button class="Btntabla">Editar</button>
                            <button class="Btntabla">Eliminar</button></td>
                    </tr>
                </tbody>
            </table>

        </div>
    </div>
</asp:Content>

