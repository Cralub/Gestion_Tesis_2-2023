<%@ Page Title="Detalle Proyecto" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PVerProyecto.aspx.cs" Inherits="WebForm_Proyecto_PVerProyecto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
    </div>
    <div>
        <div>
            <asp:Label runat="server">Titulo:</asp:Label>
            <asp:Label ID="lblTitulo" runat="server"></asp:Label>
        </div>
        
        <br />

        <div>
            <asp:Label runat="server">Modalidad:</asp:Label>
            <asp:Label ID="lblModalidad" runat="server"></asp:Label>
        </div>
        <br />
        <div>
            <asp:Label runat="server">Objetivo General:</asp:Label>
            <asp:Label ID="lblObjetivoGeneral" runat="server"></asp:Label>
        </div>
        <br />
        <div>
            <asp:Label runat="server">Objetivos Especificos:</asp:Label>
            <asp:Label ID="lblObjetivosEspecificos" runat="server"></asp:Label>
        </div>
        <br />
        <div>
            <asp:Label runat="server">Alcance del proyecto:</asp:Label>
            <asp:Label ID="lblAlcanceProyecto" runat="server"></asp:Label>
        </div>
        <br />
        <div>
            <asp:Label runat="server">EnlaceDocumento:</asp:Label>
            <asp:LinkButton ID="lkbEnlaceDocumento" runat="server"></asp:LinkButton>
        </div>
        <br />
        <asp:GridView ID="grvListaUsuarios" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowCommand="gvListaUsuarios_RowCommand" DataKeyNames="CodigoUsuario">
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Usuario" />
                <asp:BoundField DataField="CodigoUsuario" HeaderText="Codigo" />
                <asp:BoundField DataField="CodigoRol" HeaderText="Rol En Proyecto" />
                <asp:ButtonField ButtonType="Button" CommandName="btnVer" Text="Ver" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Width="55" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
