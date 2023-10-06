<%@ Page Title="Informacion Usuario" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PInformacionUsuario.aspx.cs" Inherits="WebForm_Usuario_PInformacionUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link href="https://fonts.googleapis.com/css2?family=Roboto&display=swap" rel="stylesheet" />

    <link rel="stylesheet" href="../../Estilo/CSSGraficasAvance.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">




    <div class="Tarjeta">
        <div class="Tarjeta_Encabezado">
           

                <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
            
        </div>
        <div class="Tarjeta_Cuerpo">
            <ul>
                <li>
                    <div>
                        <h4>Nombre: </h4>
                        <asp:Label ID="lblNombreCompleto" runat="server" Text=""></asp:Label>
                    </div>
                </li>
                <li>
                    <div>
                        <h4>Rol: </h4>
                        <asp:Label ID="lblRol" runat="server" Text=""></asp:Label>
                    </div>
                </li>
                <li>
                    <div>
                        <h4>Carrera: </h4>
                        <asp:Label ID="lblCarrera" runat="server" Text=""></asp:Label>
                    </div>
                </li>
                <li>
                    <div>
                        <h4>Facultad: </h4>
                        <asp:Label ID="lblFacultad" runat="server" Text=""></asp:Label>
                    </div>
                </li>
                <li>
                    <div>
                        <h4>Sede: </h4>
                        <asp:Label ID="lblSede" runat="server" Text=""></asp:Label>
                    </div>
                </li>
                <li>
                    <div>
                        <h4>Direccion: </h4>
                        <asp:Label ID="lblDireccion" runat="server" Text=""></asp:Label>
                    </div>
                </li>
                <li>
                    <div>
                        <h4>Direccion Trabajo: </h4>
                        <asp:Label ID="lblDireccionTrabajo" runat="server" Text=""></asp:Label>
                    </div>
                </li>
                <li>
                    <div>
                        <h4>Celular: </h4>
                        <asp:Label ID="lblCelular" runat="server" Text=""></asp:Label>
                    </div>
                </li>
            </ul>
        </div>
    </div>
</asp:Content>
