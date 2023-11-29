<%@ Page Language="C#" Title="Detalle Proyecto" AutoEventWireup="true" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" CodeFile="PVerProyecto.aspx.cs" Inherits="WebForm_Proyecto_PVerProyecto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Estilos/Usuario/SFormularioUno.css" rel="stylesheet" />

    <link href="../../Estilos/Modal/SModalConfirmacion.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="contenedor">
        <div>
            <h1>Formulario Proyecto</h1>
            <div>
                <asp:Label runat="server" CssClass="Datos" Text="Código de Proyecto:"></asp:Label>
                <asp:Label runat="server" ID="lblCodigoProyecto" CssClass="Datos" Text="Código de Proyecto:"></asp:Label>
            </div>
            <div>
                <asp:Label runat="server" CssClass="Datos" Text="Intentos Restantes:"></asp:Label>
                <asp:Label runat="server" CssClass="Datos" ID="lblRevision" />
            </div>
            <div>
                <asp:Label runat="server" CssClass="Datos" Text="1. MODALIDAD DE TITULACIÓN: "></asp:Label>
                <asp:Label ID="lblModalidad" CssClass="Datos" runat="server"></asp:Label>
            </div>
            <div>
                <div>
                    <asp:Label runat="server" CssClass="Datos" Text="Enlace al documento"></asp:Label>
                    <asp:LinkButton runat="server" ID="lkbEnlaceDocumento" type="text"></asp:LinkButton>
                </div>
                <div>
                    <asp:Label runat="server" ID="lblMensajeEnlaceDocumento" type="text" />
                </div>
            </div>
            <div class="Datos">
                <span>2. DATOS DEL TRABAJO:</span>
            </div>
            <div class="Datos">
                <asp:Label runat="server" Text="Título:"></asp:Label>
                <asp:TextBox runat="server" ID="lblTitulo" CssClass="txtDatos" TextMode="MultiLine" Height="7%" MaxLength="160" />
            </div>
            <div class="Datos">
                <asp:Label runat="server" Text="Objetivo General:"></asp:Label>
                <asp:TextBox runat="server" ID="lblObjetivoGeneral" CssClass="txtDatos" TextMode="MultiLine" Height="7%" MaxLength="160"></asp:TextBox>

            </div>
            <div class="Datos">
                <asp:Label runat="server" Text="Objetivos Especificos:"></asp:Label>
                <asp:TextBox runat="server" ID="lblObjetivosEspecificos" CssClass="txtDatos" TextMode="MultiLine" Height="7%" MaxLength="160"></asp:TextBox>

            </div>
            <div class="Datos">
                <asp:Label runat="server" Text="Alcance:"></asp:Label>
                <asp:TextBox runat="server" ID="lblAlcance" CssClass="txtDatos" TextMode="MultiLine" Height="7%" MaxLength="160"></asp:TextBox>
            </div>
            <div class="Datos">
                <span>3. DATOS DE ASESORAMIENTO:</span>
            </div>
            <div>
                <div class="contenedorTabla">
                    <asp:GridView ID="grvListaUsuarios" CssClass="EstiloTable" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowCommand="gvListaUsuarios_RowCommand" DataKeyNames="CodigoUsuario">
                        <Columns>
                            <asp:BoundField DataField="Nombre" HeaderText="Usuario" />
                            <asp:BoundField DataField="CodigoUsuario" HeaderText="Codigo" />
                            <asp:BoundField DataField="CodigoRol" HeaderText="Rol En Proyecto" />
                            <asp:ButtonField ButtonType="Button" CommandName="btnVer" Text="Ver" ControlStyle-CssClass="Btntabla" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
            <br />
            <div>
                <div>
                    <asp:Button ID="btnDevolver" CssClass="botonFormulario" runat="server" Text="Devolver al Estudiante" OnClick="btnDevolver_Click" />
                </div>
                <div>
                    <asp:Button ID="btnAvanzar" CssClass="botonFormulario" runat="server" Text="Todo Correcto" OnClick="btnAvanzar_Click" />
                </div>
                <div>
                    <asp:Button ID="btnAceptarTutoria" CssClass="botonFormulario" runat="server" Text="Aceptar Tutoria" OnClick="btnAceptarTutoria_Click" Visible="false" />
                </div>

            </div>
            <div>
                <asp:Button ID="btnVolver" CssClass="botonFormulario" runat="server" Text="Volver" OnClick="btnVolver_Click" />
            </div>

        </div>

    </div>

    <div class="modal-container" id="modalContainer">
        <div class="modal" id="modalConfirmacion">
            <div>
                <div class="divCentro">
                    <asp:Label ID="lblMensajeConfirmacionModal" Text="" runat="server"></asp:Label>
                </div>
                <div class="contenedor-botones">
                    <asp:Button CssClass="boton-model boton-aceptar" ID="btnConfirmarAvance" runat="server" Text="Aceptar" OnClick="btnConfirmarAvance_Click" Visible="false" />
                    <asp:Button CssClass="boton-model boton-aceptar" ID="btnConfirmarTutoria" runat="server" Text="Aceptar" OnClick="btnConfirmarTutoria_Click" Visible="false" />
                    <asp:Button CssClass="boton-model boton-aceptar" ID="btnConfirmarDevolucion" runat="server" Text="Aceptar" OnClick="btnConfirmarDevolucion_Click" Visible="false" />

                    <asp:Button CssClass="boton-model" ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                </div>
            </div>
        </div>
    </div>

    <script accesskey="ModalConfirmacionMultiple" src="../../Guiones/JModalConfirmacion.js"></script>
</asp:Content>
