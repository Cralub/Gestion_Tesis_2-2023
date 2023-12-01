<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PEditarProyecto.aspx.cs" Inherits="WebForm_Proyecto_PEditarProyecto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Estilos/Usuario/SFormularioUno.css" rel="stylesheet" />
    <link href="../../Estilos/Modal/SModalConfirmacion.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contenedor">
        <div>
            <h1>Formulario Proyecto</h1>
            <div>
                <asp:Label runat="server" CssClass="Datos" Text="Código de Proyecto:"></asp:Label>
                <asp:Label runat="server" CssClass="Datos" ID="lblCodigoProyecto" type="text" />
            </div>
            <div>
                <asp:Label runat="server" CssClass="Datos" Text="Intentos Restantes:"></asp:Label>
                <asp:Label runat="server" CssClass="Datos" ID="lblRevision" type="text" />
            </div>

            <div>
                <asp:Label runat="server" for="ddlModalidades" CssClass="Datos" Text="1. MODALIDAD DE TITULACIÓN: "></asp:Label>
                <asp:DropDownList ID="ddlModalidades" runat="server" CssClass="botonFormulario">
                    <asp:ListItem Value="-" Selected="True">Seleccionar ...</asp:ListItem>
                    <asp:ListItem Value="D">Trabajo Dirigido</asp:ListItem>
                    <asp:ListItem Value="P">Proyecto de Grado</asp:ListItem>
                    <asp:ListItem Value="T">Tesis</asp:ListItem>
                </asp:DropDownList>
                <asp:Label runat="server" ID="lblMensajeModalidad" type="text" />
            </div>
            <div>
                <div>
                    <asp:Label runat="server" CssClass="Datos" Text="Enlace al documento"></asp:Label>
                    <asp:LinkButton runat="server" ID="lkbEnlaceDocumento" type="text"></asp:LinkButton>
                </div>
                <div>
                    <asp:Button ID="btnAgregarDocumento" runat="server" Text="Agregar Documento" CssClass="botonFormulario" OnClick="btnAgregarDocumento_Click" />
                    <asp:Label runat="server" ID="lblMensajeEnlaceDocumento" type="text" />
                </div>
            </div>
            <div class="Datos">
                <span>2. DATOS DEL TRABAJO:</span>
            </div>
            <div class="Datos">
                <asp:Label runat="server" Text="Título:"></asp:Label>
                <asp:TextBox runat="server" ID="txbTitulo" CssClass="txtDatos" TextMode="MultiLine" Height="6%" MaxLength="160" />
                <asp:Label runat="server" ID="lblMensajeTitulo" type="text" />
            </div>
            <div class="Datos">
                <asp:Label runat="server" Text="Objetivo General:"></asp:Label>
                <asp:TextBox runat="server" ID="txbObjetivoGeneral" CssClass="txtDatos" TextMode="MultiLine" Height="6%" MaxLength="160"></asp:TextBox>
                <asp:Label runat="server" ID="lblMensajeObjetivoGeneral" type="text" />

            </div>
            <div class="Datos">
                <asp:Label runat="server" Text="Objetivos Especificos:"></asp:Label>
                <asp:TextBox runat="server" ID="txbObjetivosEspecificos" CssClass="txtDatos" TextMode="MultiLine" Height="6%" MaxLength="160"></asp:TextBox>
                <asp:Label runat="server" ID="lblMensajeObjetivosEspecificos" type="text" />

            </div>
            <div class="Datos">
                <asp:Label runat="server" Text="Alcance:"></asp:Label>
                <asp:TextBox runat="server" ID="txbAlcance" CssClass="txtDatos" TextMode="MultiLine" Height="6%" MaxLength="160"></asp:TextBox>
                <asp:Label runat="server" ID="lblMensajeAlcance" type="text" />
            </div>
            <div class="Datos">
                <span>3. DATOS DE ASESORAMIENTO:</span>
            </div>
            <div>
               

                <div class="contenedorTabla">
                    <asp:GridView ID="grvListaUsuarios" CssClass="EstiloTable" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowCommand="grvListaUsuarios_RowCommand" DataKeyNames="CodigoUsuario">
                        <Columns>
                            <asp:BoundField DataField="Nombre" HeaderText="Usuario" />
                            <asp:BoundField DataField="CodigoUsuario" HeaderText="Codigo" />
                            <asp:BoundField DataField="CodigoRol" HeaderText="Rol En Proyecto" />
                            <asp:ButtonField ButtonType="Button" CommandName="btnVer" Text="Ver" ControlStyle-CssClass="Btntabla" />
                        </Columns>
                    </asp:GridView>
                </div>
                <asp:Label runat="server" ID="lblMensajeTutor" BackColor="White" Text=""></asp:Label>
            </div>
        </div>
        <div class="modal-container" id="modalContainer">
            <div class="modal" id="modalConfirmacion">
                <div>
                    <div class="divCentro">
                        <asp:Label ID="lblModal" Text="¿Esta seguro que quiero enviar este proyecto?" runat="server"></asp:Label>
                    </div>
                    <div class="contenedor-botones">
                        <asp:Button CssClass="boton-model boton-aceptar" ID="btnConfirmar" runat="server" Text="Aceptar" OnClick="btnConfirmar_Click" />
                        <asp:Button CssClass="boton-model" ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                    </div>
                </div>
            </div>
        </div>
        <br />
        <div>
            <asp:Button ID="btnActualizarInformacion" runat="server" Text="Actualizar Informacion" CssClass="botonFormulario" OnClick="btnActualizarInformacion_Click" />
        </div>
        <br />
        <div>
            <asp:Button ID="btnVolver" runat="server" Text="Volver" CssClass="botonFormulario" OnClick="btnVolver_Click" />
            
        </div>
        <br />
        <div>
        </div>
    </div>
    <script accesskey="modalConfirmacion" src="../../Guiones/JModalConfirmacion.js"></script>
    <script src="../../Guiones/Usuario/JFormularioUno.js"></script>
</asp:Content>

