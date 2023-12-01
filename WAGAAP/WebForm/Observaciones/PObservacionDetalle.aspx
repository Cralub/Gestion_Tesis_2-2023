<%@ Page Title="Detalle Observacion" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PObservacionDetalle.aspx.cs" Inherits="WebForm_PObservacionDetalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Estilos/Observaciones/SObservacion.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="observacion">
        <p class="letras">Observación: </p>
        <div class="info">
            <p>Estado:  </p>
            <asp:Label runat="server" ID="lblEstado"></asp:Label>
        </div>
        <div class="contenedor">
            <p>Tipo:  </p>
            <asp:Label CssClass="posicion lineas" ID="lblTipoObservacion" runat="server"></asp:Label>

        </div>
        <div class="contenedor">
            <p>Observador:  </p>
            <asp:Label CssClass="posicion" ID="lblObservador" runat="server"></asp:Label>
        </div>
        <div class="contenedor">
            <p>Fecha Observacion:  </p>
            <asp:Label CssClass="posicion lineas" ID="lblFechaRegistro" runat="server"></asp:Label>
        </div>
        <div class="contenedor">
            <p>Descripción:  </p>
            <asp:Label CssClass="posicion lineas" ID="lblComentarioObservacion" runat="server"></asp:Label>
        </div>

        <div> 
            <asp:Button CssClass="btn" runat="server" ID="btnEditarObservacion" Text="Editar Observacion" OnClick="btnEditarObservacion_Click" />
            <asp:Button CssClass="btn" runat="server" ID="btnCorregido" Text="Observacion Corregida" OnClick="btnCorregido_Click" />
            <asp:Button CssClass="btn" ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
        </div>

    </div>



</asp:Content>
