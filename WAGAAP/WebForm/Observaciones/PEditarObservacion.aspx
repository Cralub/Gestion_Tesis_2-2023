<%@ Page Language="C#" Title="Editar Observacion" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PEditarObservacion.aspx.cs" Inherits="WebForm_Observaciones_PEditarObservacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Estilos/Usuario/SFormularioUno.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contenedor">
        <h1>Editar Observacion</h1>
        <br />
        <div>
            <asp:Label CssClass="Datos" runat="server">Tipo de Observación:</asp:Label>

        </div>
        <div class="radio">
            <asp:RadioButton CssClass="radioBoton" ID="rbObservacionFondo" runat="server" Text="Fondo" GroupName="gpTipoObservacion" Checked="true" />
            <asp:RadioButton CssClass="radioBoton" ID="rbObservacionForma" runat="server" Text="Forma" GroupName="gpTipoObservacion" />

        </div>
        <br />
        <div>
            <asp:TextBox CssClass="txtDatos" ID="txbComentario" runat="server" TextMode="MultiLine" Rows="10" Columns="50"></asp:TextBox>
        </div>
        <div>
            <asp:Button CssClass="botonFormulario" ID="btnEditarObservacion" Text="Editar Observacion" runat="server" OnClick="btnEditarObservacion_Click" />
        </div>
    </div>
    <div>
        <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" CssClass="botonFormulario" />
    </div>
</asp:Content>
