<%@ Page Title="Observacion" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PObservacion.aspx.cs" Inherits="WebForm_Observaciones_PObservacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <asp:label ID="lblComentarioObservacion" runat="server" Text=""></asp:label>
        <asp:label ID="lblTipoObservacion" runat="server" Text=""></asp:label>
        <asp:label ID="lblEstadoObservacion" runat="server" Text=""></asp:label>
   </div>
</asp:Content>
