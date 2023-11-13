<%@ Page Title="Lista Observaciones" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PListaObservacion.aspx.cs" Inherits="WebForm_PListaObservacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <span id="ContentPlaceHolder2_cuAutenticar_Label2" class="TextoLogin">Nombre Observador:</span>
        <asp:TextBox runat="server" MaxLength="15" ID="txbObservador" class="TextBox" OnTextChanged="txbObservador_TextChanged" AutoPostBack="true"></asp:TextBox>
    </div>
    <div>

        <asp:DropDownList ID="ddlTipoObservacion" runat="server" OnSelectedIndexChanged="ddlTipoObservacion_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem Text="Todos" Value="X" Selected></asp:ListItem>
            <asp:ListItem Text="Fondo" Value="O"></asp:ListItem>
            <asp:ListItem Text="Forma" Value="A"></asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="ddlEstadoObservacion" runat="server" OnSelectedIndexChanged="ddlEstadoObservacion_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem Text="Todos" Value="X" Selected></asp:ListItem>
            <asp:ListItem Text="Activo" Value="A"></asp:ListItem>
            <asp:ListItem Text="Revisado" Value="V"></asp:ListItem>
            <asp:ListItem Text="Corregido" Value="C"></asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btnCrearObservacion" runat="server" Text="Crear Nueva Observacion" OnClick="btnCrearObservacion_Click" Visible="false" Enabled="false" />
    </div>
    <asp:GridView ID="grvListaObservaciones" DataKeyNames="CodigoObservacion" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowCommand="grvListaObservaciones_RowCommand" OnRowDataBound="grvListaObservaciones_RowDataBound">
        <Columns>
            <asp:BoundField DataField="CodigoObservacion" Visible="false" />
            <asp:BoundField DataField="NombreUsuarioObservacion" Visible="true" />
            <asp:BoundField DataField="TipoObservacion" HeaderText="Tipo" Visible="true" />
            <asp:BoundField DataField="EstadoObservacion" HeaderText="Estado" Visible="true" />
            <asp:BoundField DataField="ComentarioObservacion" HeaderText="Comentario" />
            <asp:ButtonField ButtonType="Button" CommandName="btnVer" Text="Ver" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Width="55" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton" />
        </Columns>
    </asp:GridView>


    <div>
        <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
    </div>
</asp:Content>
