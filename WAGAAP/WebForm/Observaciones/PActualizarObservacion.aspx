<%@ Page Language="C#" Title="Actualizar Observacion" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PActualizarObservacion.aspx.cs" Inherits="WebForm_Observaciones_PActualizarObservacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <div>
            <asp:Label runat="server">Codigo Observación</asp:Label>
            <asp:TextBox ID="txtCodigoObservación" runat="server"></asp:TextBox>
            <%--   <asp:RegularExpressionValidator ID="revNumero" runat="server"
                ControlToValidate="txtCodigoObservación"
                ValidationExpression="^\d+$"
                ErrorMessage="Ingresa solo números"
                Display="Dynamic"
                ForeColor="Red">
            </asp:RegularExpressionValidator>--%>
            <asp:Button ID="btnBuscarObservacion" Text="Buscar Observacion" runat="server" OnClick="btnBuscarObservacion_Click" />
        </div>

        <br />
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
            <asp:Button ID="btnActualizarObservacion" Text="Actualizar Observacion" runat="server" OnClick="btnActualizarObservacion_Click" />
        </div>

    </div>
</asp:Content>
