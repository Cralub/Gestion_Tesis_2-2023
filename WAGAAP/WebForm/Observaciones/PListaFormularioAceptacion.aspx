<%@  Page Language="C#" Title="Crear Formulario de Aceptacion" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PListaFormularioAceptacion.aspx.cs" Inherits="WebForm_Observaciones_PListaFormularioAceptacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
       <div>
           <h2>Lista Formularios de Aceptacion</h2>

           <asp:GridView ID="grvListaFormularioAceptacion" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowCommand="grvListaFormularioAceptacion_RowCommand">
                <Columns>
                    <asp:BoundField DataField="CodigoFormularioAceptacion" HeaderText="Código Formulario Aceptación" Visible="True" />
                    <asp:BoundField DataField="CodigoProyecto" HeaderText="Código Proyecto" Visible="True" />
                    <asp:ButtonField ButtonType="Button" CommandName="btnVer" Text="Ver" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Width="55" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton"/>
                </Columns>
            </asp:GridView>
       </div>
</asp:Content>
