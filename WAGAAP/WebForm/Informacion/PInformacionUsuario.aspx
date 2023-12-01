<%@ Page Title="Informacion Usuario" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PInformacionUsuario.aspx.cs" Inherits="WebForm_Usuario_PInformacionUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Estilos/Estudiante/SVistaDatosEstudiante.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="divInformacion">
        <table>
            
            <tr>
                <td rowspan="20">
                    <img src="../../Imagenes/Iconos/CambiarUsuario.png" class="iconoCambiarUsuario">
                </td>
                <td class="nombre">
                    <asp:Label ID="lblNombreCompleto" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="carrera">
                    <asp:Label ID="lblCarrera" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:Label ID="lblRol" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:Label ID="lblFacultad" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:Label ID="lblSede" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:Label ID="lblDireccion" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:Label ID="lblDireccionTrabajo" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:Label ID="lblCelular" runat="server" Text=""></asp:Label>
                    <asp:Button ID="btnEditaCelular" runat="server" Text="Editar/Añadir Celular" CssClass="botones" OnClick="btnEditaCelular_Click" />
                </td>
            </tr>
            <tr>
                <%--<td>ESTUDIANTE</td>--%>
                <td class="centro">Gestión: 2-2023</td>

            </tr>
        </table>
       
    </div>
     <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" CssClass="botones"/>
</asp:Content>
