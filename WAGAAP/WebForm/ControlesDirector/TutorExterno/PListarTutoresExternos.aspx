<%@ Page Title="Lista Tutores Externos" Language="C#" AutoEventWireup="true" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" CodeFile="PListarTutoresExternos.aspx.cs" Inherits="WebForm_TutorExterno_PListarTutoresExternos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <asp:Button ID="btnCrearTutorExterno" runat="server" Text="Agregar" OnClick="btnCrearTutorExterno_Click" />
        <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
        <asp:TextBox runat="server" MaxLength="15" ID="txbCodigoTutorExterno" class="TextBox"></asp:TextBox>
        <asp:Button runat="server" ID="btnBuscar" Text="Buscar" OnClick="btnBuscar_Click" class="Boton" />
        <br />
        <br />
        <asp:GridView ID="grvListaTutoresExternos" DataKeyNames="CodigoTutorExterno" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowDataBound="gvListaTutoresExternos_RowDataBound" OnRowCommand="gvListaTutoresExternos_RowCommand">
            <Columns>
                <asp:BoundField DataField="CodigoTutorExterno" HeaderText="Codigo" />
                <asp:BoundField DataField="NombreCompletoTutorExterno" HeaderText="Nombres" />
                <asp:BoundField DataField="DescripcionTutorExterno" HeaderText="Descripcion" />
                <asp:BoundField DataField="CarreraTutorExterno" HeaderText="Carrera" />
                <asp:BoundField DataField="DireccionTrabajoTutorExterno" HeaderText="Direccion" />
                <asp:BoundField DataField="SedeTutorExterno" HeaderText="Sede" />
                <asp:ButtonField ButtonType="Button" CommandName="btnEditar" Text="Editar" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Width="55" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton" />
                
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
