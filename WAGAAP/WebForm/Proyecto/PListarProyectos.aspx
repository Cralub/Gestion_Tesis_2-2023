<%@ Page Title="Lista Proyectos General" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PListarProyectos.aspx.cs" Inherits="WebForm_Proyecto_PListarProyectos" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <span id="ContentPlaceHolder2_cuAutenticar_Label2" class="TextoLogin">Nombre:</span>
        <asp:TextBox runat="server" MaxLength="15" ID="txbCodigoUsuario" class="TextBox" OnTextChanged="txbCodigoUsuario_TextChanged" AutoPostBack="true"></asp:TextBox>
        <asp:DropDownList ID="ddlTipoProyecto" runat="server" OnSelectedIndexChanged="ddlTipoProyecto_SelectedIndexChanged"  AutoPostBack="true">
            <asp:ListItem Text="Todos" Value="X"  Selected></asp:ListItem>
            <asp:ListItem Text="Trabajo Dirigido" Value="D"></asp:ListItem>
            <asp:ListItem Text="Proyecto de grado" Value="P"></asp:ListItem>
            <asp:ListItem Text="Tesis de grado" Value="T"></asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="ddlEstadoProyecto" runat="server" OnSelectedIndexChanged="ddlEstadoProyecto_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem Text="Todos" Value="X"  Selected></asp:ListItem>
            <asp:ListItem Text="Activo" Value="A"></asp:ListItem>
            <asp:ListItem Text="Retrasado" Value="R"></asp:ListItem>
            <asp:ListItem Text="Finalizado" Value="F"></asp:ListItem>
        </asp:DropDownList> 
        <asp:GridView ID="grvListaProyectos" DataKeyNames="CodigoProyecto" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowDataBound="gvListaProyectos_RowDataBound" OnRowCommand="gvListaProyectos_RowCommand">
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
                <asp:ButtonField ButtonType="Button" CommandName="btnObservaciones" Text="Observaciones" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton" />
                <asp:ButtonField ButtonType="Button" CommandName="btnInfo" Text="Grafica" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Width="55" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton" />
            </Columns>
        </asp:GridView>
        <asp:Label ID="label" runat="server" Text=""></asp:Label>
        <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
    </div>
</asp:Content>
