<%@ Page Title="Agregar Celular" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PAgregarCelular.aspx.cs" Inherits="WebForm_Usuario_PAgregarCelular" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Estilos/SBase.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contenedor">
        <h2>Editar número de celular</h2>
        <br />
        <div>
            <asp:Label runat="server" Text="Código de área"></asp:Label>
            <asp:TextBox CssClass="txtBusqueda" ID="txbCodigoArea" runat="server" MaxLength="5"></asp:TextBox>
        </div>

        <br />
        <div>
            <asp:Label runat="server" Text="Número de celular"></asp:Label>
            <asp:TextBox CssClass="txtBusqueda" ID="txbNumeroCelular" runat="server" MaxLength="10"></asp:TextBox>
        </div>

        <br />
        <div>
            <asp:Button CssClass="Btntabla" ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
            <asp:Button CssClass="Btntabla" ID="btnAgregarCelular" Text="Agreagar Celular" runat="server" OnClick="btnAgregarCelular_Click" />
        </div>
    </div>


</asp:Content>


