<%@ Page Title="Lista Proyectos General" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PListarProyectos.aspx.cs" Inherits="WebForm_Proyecto_PListarProyectos" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <span id="ContentPlaceHolder2_cuAutenticar_Label2" class="TextoLogin">Codigo:</span>
        <asp:TextBox runat="server" MaxLength="15" ID="txbCodigoUsuario" class="TextBox"></asp:TextBox>
        <asp:DropDownList ID="ddlRol" runat="server">
        </asp:DropDownList>
        <asp:Button ID="btnBuscar" runat="server" Text="BUSCAR" OnClick="btnBuscar_Click" />
        <asp:GridView ID="gvListaProyectos" DataKeyNames="CodigoProyecto" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowDataBound="gvListaProyectos_RowDataBound" OnRowCommand="gvListaProyectos_RowCommand">
            <Columns>
                <asp:BoundField DataField="CodigoProyecto" HeaderText="CodigoProyecto" Visible="False" />
                <asp:BoundField DataField="Rol" HeaderText="Rol En Proyecto" />
                <asp:TemplateField HeaderText="Estudiantes">
                    <ItemTemplate>
                        <asp:DropDownList ID="ddlEstudiantes" runat="server" OnSelectedIndexChanged="ddlEstudiantes_SelectedIndexChanged" AutoPostBack="true">
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="CodigoTutor" HeaderText="CodigoTutor " />

                <asp:BoundField DataField="TituloProyecto" HeaderText="Titulo" />
                <asp:BoundField DataField="ModalidadProyecto" HeaderText="Modalidad" />
                <asp:ButtonField ButtonType="Button" CommandName="btnVer" Text="Ver" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Width="55" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton" />
                <asp:ButtonField ButtonType="Button" CommandName="btnInfo" Text="Grafica" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Width="55" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
    </div>
</asp:Content>
