<%@ Page Language="C#" Title="Agregar Usuarios A Proyecto" AutoEventWireup="true" CodeFile="PCrearUsuarioProyecto.aspx.cs" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" Inherits="WebForm_ControlesDirector_UsuarioProyecto_PCrearUsuarioProyecto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../../Estilos/SBase.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contenedor">
        <h1>Agregar Usuarios Por Proyecto</h1>
        <div class="Menu">
            <div class="buscador">
                <asp:TextBox runat="server" MaxLength="15" ID="txbUsuario" CssClass="txtBusqueda" OnTextChanged="txbUsuario_TextChanged" placeholder="Buscar por Nombre o Codigo Usuario" AutoPostBack="true"></asp:TextBox>
            </div>
            <div class="ContenedorCombo">
                <asp:DropDownList ID="ddlRoles" CssClass="comboOpciones" runat="server" OnSelectedIndexChanged="ddlRoles_SelectedIndexChanged" AutoPostBack="true">
                    <%--<asp:ListItem Text="TUTOR EXTERNO" Value="TU"></asp:ListItem>--%>
                    <asp:ListItem Text="TRIBUNAL 1" Value="T1" Selected="True"></asp:ListItem>
                    <asp:ListItem Text="TRIBUNAL 2" Value="T2"></asp:ListItem>
                    <asp:ListItem Text="TUTOR" Value="TU"></asp:ListItem>
                    <asp:ListItem Text="DAAP" Value="DP"></asp:ListItem>
                    <asp:ListItem Text="ESTUDIANTE" Value="ES" ></asp:ListItem>

                </asp:DropDownList>
            </div>
        </div>
        <div class="contenedorTabla">
            <asp:GridView ID="grvListaUsuariosRol" DataKeyNames="CodigoUsuario" runat="server" CssClass="EstiloTable" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowDataBound="grvListaUsuariosRol_RowDataBound" OnRowCommand="grvListaUsuariosRol_RowCommand">

                <Columns>
                    <asp:BoundField DataField="CodigoUsuario" HeaderText="Codigo Usuario Proyecto" InsertVisible="False" ReadOnly="True" />
                    <asp:BoundField DataField="CodigoUsuario" HeaderText="NombreUsuario"  ReadOnly="True" />

                    <asp:ButtonField ButtonType="Button" ControlStyle-CssClass="Btntabla" runat="server" Text="Agregar al Proyecto" CommandName="btnAgregar" />

                </Columns>
            </asp:GridView>
        </div>
            <asp:Label runat="server" ID="lblCrearUsuarioRol" CssClass="Datos"></asp:Label>

    </div>

</asp:Content>
