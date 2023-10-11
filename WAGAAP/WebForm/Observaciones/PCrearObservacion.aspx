<%@ Page Language="C#" Title="Crear Observacion" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PCrearObservacion.aspx.cs" Inherits="WebForm_Observaciones_PCrearObservacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <div>
            <asp:Label runat="server">Tipo de Observación:</asp:Label>
            <br />
            <asp:RadioButton ID="rbObservacionFondo" runat="server" Text="Observación de Fondo" GroupName="gpTipoObservacion" Checked="true" />
            <asp:RadioButton ID="rbObservacionForma" runat="server" Text="Observación de Forma" GroupName="gpTipoObservacion" />
        </div>
        <br />
        <div>
            <asp:TextBox ID="txtComentario" runat="server" TextMode="MultiLine" Rows="10" Columns="50"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnCrearObservacion" Text="Crear Nueva Observacion" runat="server" OnClick="btnCrearObservacion_Click" />
        </div>
    </div>
</asp:Content>
