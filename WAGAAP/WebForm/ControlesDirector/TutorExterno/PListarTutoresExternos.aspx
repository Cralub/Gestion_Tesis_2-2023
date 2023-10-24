<%@ Page Title="Lista Tutores Externos" Language="C#" AutoEventWireup="true" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" CodeFile="PListarTutoresExternos.aspx.cs" Inherits="WebForm_TutorExterno_PListarTutoresExternos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <asp:TextBox runat="server" MaxLength="15" ID="txbCodigoTutorExterno" class="TextBox"></asp:TextBox>
        <asp:Button runat="server" ID="btnBuscar" Text="Buscar" OnClick="btnBuscar_Click" class="Boton" />
        <br />
        <br />
        <asp:GridView ID="gvListaTutoresExternos" DataKeyNames="CodigoTutorExterno" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowDataBound="gvListaTutoresExternos_RowDataBound" OnRowCommand="gvListaTutoresExternos_RowCommand">
            <Columns >
                <asp:BoundField DataField="CodigoTutorExterno" HeaderText="Codigo" />
                <asp:BoundField DataField="NombresTutorExterno" HeaderText="Nombres" />
                <asp:BoundField DataField="ApellidosTutorExterno" HeaderText="Apellidos" />
                <asp:BoundField DataField="DescripcionTutorExterno" HeaderText="Descripcion" />
                <asp:BoundField DataField="CarreraTutorExterno" HeaderText="Carrera" />
                <asp:BoundField DataField="DireccionTrabajoTutorExterno" HeaderText="Direccion"/>
                <asp:BoundField DataField="SedeTutorExterno" HeaderText="Sede"/>
                <asp:TemplateField HeaderText="Editar">
                    <ItemTemplate>
                        <!-- button that sends the CodigoTutorExterno of that row as an url and redirects to PEditarTutorExerno -->
                        <asp:Button runat="server" ID="btnEditar" Text="Editar" CommandName="Editar" CommandArgument='<%# Eval("CodigoTutorExterno") %>' class="Boton" />

                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
