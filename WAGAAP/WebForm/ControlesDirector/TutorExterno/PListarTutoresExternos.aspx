<%@ Page Title="Lista Tutores Externos" Language="C#" AutoEventWireup="true" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" CodeFile="PListarTutoresExternos.aspx.cs" Inherits="WebForm_TutorExterno_PListarTutoresExternos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../../Estilos/SBase.css" rel="stylesheet" />

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contenedor">
        <h1>Lista Tutores Externos</h1>
        <div class="Menu">
            <div class="buscador">
                <asp:TextBox runat="server" MaxLength="15" ID="txbCodigoTutorExterno" CssClass="txtBusqueda" OnTextChanged="txbCodigoTutorExterno_TextChanged" placeholder="Buscar por nombre o codigo usuario" AutoPostBack="true" title="Presione Enter para Buscar"></asp:TextBox>
            </div>
        </div>
        <br />
        <div class="contenedorTabla">
            <asp:GridView ID="grvListaTutoresExternos" DataKeyNames="CodigoTutorExterno" CssClass="EstiloTable" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowDataBound="gvListaTutoresExternos_RowDataBound" OnRowCommand="gvListaTutoresExternos_RowCommand">
                <Columns>
                    <asp:BoundField DataField="CodigoTutorExterno" HeaderText="Codigo" />
                    <asp:BoundField DataField="NombreCompletoTutorExterno" HeaderText="Nombres" />
                    <asp:BoundField DataField="DescripcionTutorExterno" HeaderText="Descripcion" />
                    <asp:BoundField DataField="CarreraTutorExterno" HeaderText="Carrera" />
                    <asp:BoundField DataField="DireccionTrabajoTutorExterno" HeaderText="Direccion" />
                    <asp:BoundField DataField="SedeTutorExterno" HeaderText="Sede" />
                    <asp:ButtonField ButtonType="Button" CommandName="btnEditar" Text="Editar" ControlStyle-CssClass="Btntabla" />

                </Columns>
            </asp:GridView>
        </div>

    </div>
    
</asp:Content>
