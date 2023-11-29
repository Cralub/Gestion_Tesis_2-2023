<%@ Page Language="C#" Title="Crear Formulario de Aceptacion" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PListaFormularioAceptacion.aspx.cs" Inherits="WebForm_Observaciones_PListaFormularioAceptacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Estilos/SBase.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contenedor">
        <h1>Lista Formularios de Aceptacion</h1>
        <asp:Button CssClass="Btntabla" ID="btnCrearFormularioAceptacion"  runat="server"  Text="Crear Nuevo Formulario" OnClick="btnCrearFormularioAceptacion_Click" Visible="false" Enabled="false"/>
        <div class="contenedorTabla">
             <asp:GridView ID="grvListaFormularioAceptacion" DataKeyNames="CodigoFormularioAceptacion" CssClass="EstiloTable" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowCommand="grvListaFormularioAceptacion_RowCommand" OnRowDataBound="grvListaFormularioAceptacion_RowDataBound">
     <Columns>
         <asp:BoundField DataField="CodigoFormularioAceptacion" HeaderText="Código Formulario Aceptación" Visible="false" />
         <asp:BoundField DataField="CodigoTribunal" HeaderText="Responsable" Visible="True" />
         <asp:BoundField DataField="EstadoFormularioAceptacion" HeaderText="Estado" Visible="True" />
         <asp:BoundField DataField="FechaRegistro" HeaderText="Fecha Registro" Visible="True" />

         <asp:ButtonField ButtonType="Button" CommandName="btnVer" Text="Ver"  ControlStyle-CssClass="Btntabla" />
     </Columns>
 </asp:GridView>
        </div>
       
    </div>
    <div>
    <asp:Button ID="btnVolver" runat="server" Text="Volver" CssClass="Btntabla" OnClick="btnVolver_Click" />
</div>
</asp:Content>
