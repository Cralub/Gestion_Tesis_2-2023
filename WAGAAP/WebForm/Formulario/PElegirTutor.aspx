<%@ Page Title="Lista Proyectos General" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PElegirTutor.aspx.cs" Inherits="WebForm_Formulario_PElegirTutor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Estilos/SBase.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
    <div class="contenedor">
        <h1>Eleccion de Tutor</h1>
        <div class="Menu">
            <asp:TextBox runat="server" MaxLength="15" ID="txbBuscarTutor" OnTextChanged="txbBuscarTutor_TextChanged" CssClass="txtBusqueda" AutoPostBack="true" placeholder="Buscar por nombre o codigo"></asp:TextBox>
            <asp:Label runat="server" ID="lblMensajeElegirTutor" Text=""></asp:Label>
        </div>

        <div class="contenedorTabla">
            <asp:GridView ID="grvTutores" DataKeyNames="CodigoUsuario" CssClass="EstiloTable" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowCommand="grvTutores_RowCommand">
                <Columns>
                    <asp:BoundField DataField="CodigoUsuario" HeaderText="Codigo Tutor" />
                    <asp:BoundField DataField="NombreCompletoUsuario" HeaderText="Nombre Completo Tutor" />
                    <asp:ButtonField ButtonType="Button" CommandName="btnVer" Text="Ver"  ControlStyle-CssClass="Btntabla" />
                    <asp:ButtonField ButtonType="Button" CommandName="btnElegirTutor" Text="ElegirTutor"  ControlStyle-CssClass="Btntabla" />
                </Columns>
            </asp:GridView>
        </div>
       
        <div>
            <asp:Button ID="btnVolver" runat="server" Text="Volver" CssClass="Btntabla" OnClick="btnVolver_Click" />
        </div>
    </div>
</asp:Content>
