<%@  Page Language="C#" Title="Crear Observacion" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PCrearObservacion.aspx.cs" Inherits="WebForm_Observaciones_PCrearObservacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<div>
    <div>
          <asp:Label runat="server">Observador</asp:Label>
            <asp:TextBox ID="lblObservador" runat="server"></asp:TextBox>
    </div>
</div>

    <br />
    <h2>OBSERVACIÓN</h2>
    <br />
    <asp:Label runat="server">Observador</asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <p>Cambiar a estado subsanado</p>
    <asp:Button ID="btnCambioEstado" Text="CAMBIAR ESTADO" runat="server" OnClick="btnCambioEstado_Click" />
    <asp:Label ID="lblSms" runat="server" />
</asp:Content>
