<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" CodeFile="PListarUsuarioRol.aspx.cs" Inherits="WebForm_Usuario_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
   
   
    <asp:TextBox ID="txtCodigoUsuarioRol" runat="server"></asp:TextBox>
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
    <asp:DropDownList ID="ddlCodigoRol" runat="server"/>
    <asp:Button ID="btnInsertar" runat="server" Text="Insertar" OnClick="btnInsertar_Click" />
    <asp:GridView ID="gvListaUsuarioRol" DataKeyNames="CodigoUsuarioRol" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True"  AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="CodigoUsuarioRol" HeaderText="CodigoUsuarioRol" ReadOnly="True" SortExpression="CodigoUsuarioRol" />
            <asp:BoundField DataField="CodigoRol" HeaderText="CodigoRol" SortExpression="CodigoRol" />
            <asp:BoundField DataField="CodigoUsuario" HeaderText="CodigoUsuario" SortExpression="CodigoUsuario" />
            <asp:TemplateField HeaderText="Editar">
                <ItemTemplate>
                    <asp:Button ID="btnEditar" runat="server" Text="Editar" PostBackUrl='<%# "PEditarUsuarioRol.aspx?CodigoUsuarioRol=" + Eval("CodigoUsuarioRol") + "&CodigoUsuario=" + Eval("CodigoUsuario") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CommandArgument='<%# "PEliminarUsuarioRol.aspx?CodigoUsuarioRol="+Eval("CodigoUsuarioRol") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
