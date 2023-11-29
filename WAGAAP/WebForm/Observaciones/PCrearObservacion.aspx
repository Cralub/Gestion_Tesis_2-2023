<%@ Page Language="C#" Title="Crear Observacion" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PCrearObservacion.aspx.cs" Inherits="WebForm_Observaciones_PCrearObservacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Estilos/Usuario/SFormularioUno.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contenedor">
        <h1>Nueva Observacion</h1>
        <br />
        <div>
            <asp:Label CssClass="Datos" runat="server">Tipo de Observación:</asp:Label>

        </div>
        <div class="radio">
            <asp:RadioButton CssClass="radioBoton" ID="rbObservacionFondo" runat="server" Text="Fondo" GroupName="gpTipoObservacion" Checked="true" />
            <asp:RadioButton CssClass="radioBoton" ID="rbObservacionForma" runat="server" Text="Forma" GroupName="gpTipoObservacion" />

            <br />
            <div>
            </div>
            <div>
            </div>
        </div>
        <br />
        <div>
            <asp:TextBox CssClass="txtDatos" ID="txbComentario" runat="server" TextMode="MultiLine" Rows="10" Columns="50"></asp:TextBox>
        </div>
        <div>
            <asp:Button CssClass="botonFormulario" ID="btnCrearObservacion" Text="Crear Observacion" runat="server" OnClick="btnCrearObservacion_Click" />
        </div>

    </div>
</asp:Content>
