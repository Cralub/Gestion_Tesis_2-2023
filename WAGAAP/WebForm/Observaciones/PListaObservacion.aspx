<%@ Page Title="Lista Observaciones" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PListaObservacion.aspx.cs" Inherits="WebForm_PListaObservacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Estilos/SBase.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contenedor">
        <div class="Menu">
            <div class="buscador">
                <asp:TextBox runat="server" MaxLength="15" ID="txbObservador" CssClass="txtBusqueda" OnTextChanged="txbObservador_TextChanged" placeholder="Buscar por nombre observador" AutoPostBack="true"></asp:TextBox>
            </div>
            <div class="ContenedorCombo">

                <asp:DropDownList ID="ddlTipoObservacion" runat="server" CssClass="comboOpciones" OnSelectedIndexChanged="ddlTipoObservacion_SelectedIndexChanged" AutoPostBack="true">
                    <asp:ListItem Text="TIPO" Value="X" Selected="True"></asp:ListItem>
                    <asp:ListItem Text="Fondo" Value="O"></asp:ListItem>
                    <asp:ListItem Text="Forma" Value="A"></asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="ddlEstadoObservacion" runat="server" CssClass="comboOpciones" OnSelectedIndexChanged="ddlEstadoObservacion_SelectedIndexChanged" AutoPostBack="true">
                    <asp:ListItem Text="ESTADO" Value="X" Selected="True"></asp:ListItem>
                    <asp:ListItem Text="Activo" Value="A"></asp:ListItem>
                    <asp:ListItem Text="Revisado" Value="V"></asp:ListItem>
                    <asp:ListItem Text="Corregido" Value="C"></asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="btnCrearObservacion" runat="server" CssClass="Btntabla" Text="Crear Nueva Observacion" OnClick="btnCrearObservacion_Click" Visible="false" Enabled="false" />
            </div>
        </div>
         <div class="contenedorTabla">
     <asp:GridView ID="grvListaObservaciones" DataKeyNames="CodigoObservacion" CssClass="EstiloTable" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowCommand="grvListaObservaciones_RowCommand" OnRowDataBound="grvListaObservaciones_RowDataBound">
         <Columns>
             <asp:BoundField DataField="CodigoObservacion" Visible="false" />
             <asp:BoundField DataField="NombreUsuarioObservacion" Visible="true"  HeaderText="Nombre Observador"/>
             <asp:BoundField DataField="NombreTipoObservacion" HeaderText="Tipo" Visible="true" />
             <asp:BoundField DataField="EstadoObservacion" HeaderText="Estado" Visible="true" />
            
             <asp:BoundField DataField="ComentarioObservacion" HeaderText="Comentario" />
             <asp:ButtonField ButtonType="Button" CommandName="btnVer" Text="Ver" ControlStyle-CssClass="Btntabla"/>
         </Columns>
     </asp:GridView>
 </div>
    </div>
   



    <div>
        <asp:Button ID="btnVolver" runat="server" Text="Volver" CssClass="Btntabla" OnClick="btnVolver_Click" />
    </div>
</asp:Content>
