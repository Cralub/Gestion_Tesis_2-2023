<%@ Page Title="Detalle Observacion" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PObservacionDetalle.aspx.cs" Inherits="WebForm_PObservacionDetalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <ul>
        <li>
            <asp:Label runat="server">Observador</asp:Label>
            <asp:Label ID="lblObservador" runat="server"></asp:Label>
        </li>
         <li>
            <asp:Label runat="server">Tipo Observacion</asp:Label>
            <asp:Label ID="lblTipoObservacion" runat="server"></asp:Label>
        </li>
         <li>
            <asp:Label runat="server">Fecha Observacion</asp:Label>
            <asp:Label ID="lblFechaRegistro" runat="server"></asp:Label>
        </li>
        <li>
            <asp:Label runat="server">Comentario</asp:Label>
            <asp:Label ID="lblComentarioObservacion" runat="server"></asp:Label>
        </li>
    </ul>
    <div></div>
</asp:Content>