<%@ Page Language="C#" Title="Listar Usuarios Por Proyecto" AutoEventWireup="true" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" CodeFile="PListarUsuariosProyecto.aspx.cs" Inherits="WebForm_ControlesDirector_UsuarioProyecto_PListarUsuariosProyecto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../../Estilos/SBase.css" rel="stylesheet" />
    <link href="../../../Estilos/Modal/SModalConfirmacion.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contenedor">
        <h1>Listar Usuarios Por Proyecto</h1>
        <div class="Menu">
            <div class="buscador">
                <asp:TextBox runat="server" MaxLength="15" ID="txbCodigoProyecto" CssClass="txtBusqueda" OnTextChanged="txbCodigoProyecto_TextChanged" placeholder="Buscar por Codigo de Proyecto" AutoPostBack="true"></asp:TextBox>
            </div>
            <asp:Button ID="btnCrearUsuarioProyecto" runat="server" CssClass="Btntabla" Text="Agregar Usuario al Proyecto" Width="500" OnClick="btnCrearUsuarioProyecto_Click"  />
            <asp:Label runat="server" ID="lblMensajeCrearUsuarioProyecto" CssClass="Datos"></asp:Label>
        </div>
        <div class="contenedorTabla">
            <asp:GridView ID="grvListaUsuariosProyecto" DataKeyNames="CodigoUsuarioProyecto" runat="server" CssClass="EstiloTable" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowDataBound="grvListaUsuariosProyecto_RowDataBound" OnRowCommand="grvListaUsuariosProyecto_RowCommand">

                <Columns>
                    <asp:BoundField DataField="CodigoUsuarioProyecto" HeaderText="CodigoUsuarioProyecto" InsertVisible="False" ReadOnly="True" SortExpression="CodigoUsuarioProyecto" Visible="false" />
                    <asp:BoundField DataField="CodigoUsuario" HeaderText="CodigoUsuario" SortExpression="CodigoUsuario" />
                    <asp:BoundField DataField="CodigoRol" HeaderText="Codigo Rol" SortExpression="CodigoRol" Visible="false"/>
                    <asp:BoundField DataField="CodigoRol" HeaderText="Rol"  Visible="true"/>
                    <asp:BoundField DataField="EstadoUsuarioProyecto" HeaderText="Estado" SortExpression="EstadoUsuarioProyecto" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnEditarRol" CssClass="Btntabla" runat="server" Text="Editar Rol" CommandName="Editar" PostBackUrl='<%# "PEditarRolUsuarioProyecto.aspx?CodigoUsuarioProyecto=" + Eval("CodigoUsuarioProyecto") + "&CodigoRol=" + Eval("CodigoRol") + "&CodigoUsuario="+Eval("CodigoUsuario") + "&CodigoProyecto=" + Eval("CodigoProyecto")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:ButtonField ButtonType="Button" ControlStyle-CssClass="Btntabla" runat="server" Text="Eliminar Usuario Proyecto" CommandName="btnEliminar"  />
                   
                </Columns>
            </asp:GridView>
        </div>
    </div>
     <div class="modal-container" id="modalContainer">
     <div class="modal" id="modalConfirmacion">
         <div>
             <div class="divCentro">
                 <asp:Label ID="lblMensajeConfirmacionModal" Text="" runat="server"></asp:Label>
             </div>
             <div class="contenedor-botones">
                 <asp:Button CssClass="boton-model boton-aceptar" ID="btnConfirmar" runat="server" Text="Aceptar" OnClick="btnConfirmar_Click" />

                 <asp:Button CssClass="boton-model" ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
             </div>
         </div>
     </div>
 </div>

 <script accesskey="ModalConfirmacion" src="../../../Guiones/JModalConfirmacion.js"></script>    
</asp:Content>
