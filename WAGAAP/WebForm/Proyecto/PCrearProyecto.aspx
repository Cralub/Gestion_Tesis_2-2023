<%@ Page Title="Elegir Tutor" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PCrearProyecto.aspx.cs" Inherits="WebForm_Proyecto_PCrearProyecto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Estilos/Modal/SModalConfirmacion.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <div>
            <asp:Label runat="server" Text="Buscar Estudiante CodigoSIU: "></asp:Label>
            <asp:TextBox ID="txbCodigoUsuario" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscarUsuario" Text="Buscar" runat="server" OnClick="btnBuscarUsuario_Click" />
            <asp:Label ID="lblMensajeBuscarUsuarioCreacionProyecto" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="txbCodigoProyecto" runat="server"></asp:TextBox>
            <asp:DropDownList runat="server" ID="ddlUsuarioDAAP"></asp:DropDownList>
            <asp:Button ID="btnCrearProyecto" Text="Crear Nuevo Proyecto" runat="server" OnClick="btnCrearProyecto_Click" />
            <asp:Label ID="lblMensajeCrearProyecto" runat="server" Text=""></asp:Label>

        </div>
        <div>
            <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
        </div>
    </div>
    <div class="modal-container" id="modalContainer">
            <div class="modal" id="modalConfirmacion">
                <div>
                    <div class="divCentro">
                        <asp:Label ID="lblModal" Text="¿Esta seguro que quiero crear este proyecto?" runat="server"></asp:Label>
                    </div>
                    <div class="contenedor-botones">
                        <asp:Button CssClass="boton-model boton-aceptar" ID="btnConfirmar" runat="server" Text="Aceptar" OnClick="btnConfirmar_Click"/>
                        <asp:Button CssClass="boton-model" ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click"/>
                    </div>
                </div>
            </div>
        </div>
    <script src="../../Guiones/JModalConfirmacion.js"></script>
</asp:Content>
