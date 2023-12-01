<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="PaginaMaestra_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <div>
            <asp:Button ID="btnCodigoUsuarioSesion" runat="server" Text="ID Usuario" OnClick="btnCodigoUsuarioSesion_Click" />
            <asp:TextBox runat="server" ID="txbCodigoUsuarioSesion"></asp:TextBox>
            <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" />
            <asp:Label runat="server" ID="lblUsuarioLogueado" Text="Ningun usuario"></asp:Label>
        </div>

    </div>
</asp:Content>

