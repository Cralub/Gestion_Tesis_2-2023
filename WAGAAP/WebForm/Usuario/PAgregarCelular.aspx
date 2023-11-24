<%@ Page Title="Agregar Celular" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PAgregarCelular.aspx.cs" Inherits="WebForm_Usuario_PAgregarCelular" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Estilos/SBase.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2>Agregar un número de celular</h2>
    <br />
  
    <div>
        <asp:Label runat="server" Text="Código de área"></asp:Label>
        <asp:TextBox ID="txbCodigoArea" runat="server" MaxLength="5"></asp:TextBox>
    </div>

    <br />
    <div>
        <asp:Label runat="server" Text="Número de celular"></asp:Label>
        <asp:TextBox ID="txbNumeroCelular" runat="server" MaxLength="10"></asp:TextBox>
    </div>

    <br />
    <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
    <asp:Button ID="btnAgregarCelular" Text="AGREGAR" runat="server" OnClick="btnAgregarCelular_Click" />
   
</asp:Content>


