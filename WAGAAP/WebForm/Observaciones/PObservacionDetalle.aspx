<%@ Page Title="Detalle Observacion" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PObservacionDetalle.aspx.cs" Inherits="WebForm_PObservacionDetalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Estilos/Observaciones/SObservacion.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div>
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
    </div>

    <div>
        <asp:Button runat="server" ID="btnEditarObservacion" Text="Editar Observacion" OnClick="btnEditarObservacion_Click" />
    </div>
    <div>
        <asp:Button runat="server" ID="btnCorregido" Text="Observacion Corregida" OnClick="btnCorregido_Click" />
    </div>
    <div>
        <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
    </div>
</asp:Content>
