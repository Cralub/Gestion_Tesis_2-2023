<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PUsuarioProyecto.aspx.cs" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" Inherits="WebForm_Usuario_PInsertarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <asp:Label ID="lbl2" runat="server" Text="Codigo Usuario Proyecto" />
        <asp:TextBox ID="txbCodigoUsuarioProyecto" runat="server" />
        <asp:DropDownList ID="ddlListaProyectos" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlListaProyectos_SelectedIndexChanged"/>
        <asp:Label ID="lbl1" Text="Buscar por codigo usuario" runat="server" />
        <asp:TextBox ID="txbCodigoUsuario" runat="server" />
        <asp:Button ID="btnBuscarUsuario" runat="server" Text="Buscar Usuario" OnClick="btnBuscar_Click"/>
        <asp:Label ID="lblCodigoUsuario" runat="server" />
        <asp:Label ID="lblNombreUsuario" runat="server" />
        <asp:DropDownList ID="ddlListaRoles" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlListaRoles_SelectedIndexChanged"/>
        <asp:Button ID="btnInsertarUsuario" runat="server" Text="Insertar Usuario" OnClick="btnInsertarUsuario_Click"/>
    </div>

    <div>
        <asp:TextBox ID="txbCodigoProyecto" runat="server" />
        <asp:Button ID="btnBuscarUsuarioProyecto" runat="server" Text="Buscar Usuario Proyecto" OnClick="btnBuscarUsuarioProyecto_Click"/>
        <asp:GridView ID="gvListaUsuariosProyecto" runat="server" CssClass="gridview" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowDataBound="gvListaUsuariosProyecto_RowDataBound">
            <Columns>
                <asp:BoundField DataField="CodigoUsuarioProyecto" HeaderText="CodigoUsuarioProyecto" InsertVisible="False" ReadOnly="True" SortExpression="CodigoUsuarioProyecto" />
                <asp:BoundField DataField="CodigoUsuario" HeaderText="CodigoUsuario" SortExpression="CodigoUsuario" />
                <asp:BoundField DataField="CodigoRol" HeaderText="Codigo Rol" SortExpression="CodigoRol" />
                <asp:BoundField DataField="EstadoUsuarioProyecto" HeaderText="Estado Usuario Proyecto" SortExpression="EstadoUsuarioProyecto" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnEditarRol" runat="server" Text="Editar Rol" CommandName="Editar"  PostBackUrl='<%# "PEditarRolUsuarioProyecto.aspx?CodigoUsuarioProyecto=" + Eval("CodigoUsuarioProyecto") + "&CodigoRol=" + Eval("CodigoRol") + "&CodigoUsuario="+Eval("CodigoUsuario") + "&CodigoProyecto=" + Eval("CodigoProyecto")%>'/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnEliminarUsuarioProyecto" runat="server" Text="Eliminar Usuario Proyecto" CommandName="Eliminar" PostBackUrl='<%#"PEliminarUsuarioProyecto.aspx?CodigoUsuarioProyecto=" + Eval("CodigoUsuarioProyecto") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>



