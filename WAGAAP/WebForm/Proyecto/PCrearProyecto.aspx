<%@ Page Title="Crear Proyecto" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PCrearProyecto.aspx.cs" Inherits="WebForm_Proyecto_PCrearProyecto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Estilos/Modal/SModalConfirmacion.css" rel="stylesheet" />
    <link href="../../Estilos/SBase.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contenedor">
        <h1>Crear Proyecto</h1>
        <div>

            <div class="buscador">
                <asp:TextBox runat="server" MaxLength="25" ID="txbCodigoUsuario" CssClass="txtBusqueda" title="Presione Enter para Buscar" OnTextChanged="txbCodigoUsuario_TextChanged" placeholder="Buscar Estudiante por Codigo SIU" AutoPostBack="true"></asp:TextBox>

                <asp:Label ID="lblMensajeBuscarUsuarioCreacionProyecto" ForeColor="#850842" Font-Bold="true" runat="server" Text=""></asp:Label>
            </div>
            <div class="buscador">
                <asp:TextBox CssClass="txtBusqueda" ID="txbCodigoProyecto" placeholder="Ingrese el Codigo para el Proyecto" runat="server"></asp:TextBox>



            </div>
            <h3>
                <asp:Label ID="lblDAAP" runat="server" Height="30" Text="Elija un encargado de DAAP para el Proyecto"></asp:Label>
            </h3>
            <div class="ContenedorCombo">

                <asp:DropDownList runat="server" CssClass="comboOpciones" Height="65" ID="ddlUsuarioDAAP"></asp:DropDownList>
            </div>
            <div>
                <asp:Button ID="btnCrearProyecto" CssClass="Btntabla" Text="Crear Nuevo Proyecto" runat="server" OnClick="btnCrearProyecto_Click" />
                <asp:Label ID="lblMensajeCrearProyecto" ForeColor="#850842" Font-Bold="true" runat="server" Text=""></asp:Label>
            </div>
            <div>
                <asp:Button ID="btnVolver" runat="server" CssClass="Btntabla"  Text="Volver" OnClick="btnVolver_Click" />
            </div>
        </div>
        <div class="modal-container" id="modalContainer">
            <div class="modal" id="modalConfirmacion">
                <div>
                    <div class="divCentro">
                        <asp:Label ID="lblModal" Text="¿Esta seguro que quiero crear este proyecto?" runat="server"></asp:Label>
                    </div>
                    <div class="contenedor-botones">
                        <asp:Button CssClass="boton-model boton-aceptar" ID="btnConfirmar" runat="server" Text="Aceptar" OnClick="btnConfirmar_Click" />
                        <asp:Button CssClass="boton-model" ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script src="../../Guiones/JModalConfirmacion.js"></script>
</asp:Content>
