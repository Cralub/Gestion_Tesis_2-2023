<%@ Page Title="Lista General Proyectos" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PListarProyectos.aspx.cs" Inherits="WebForm_Proyecto_PListarProyectos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Estilos/SBase.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contenedor">
        <h1>Lista General Proyectos</h1>
        <div class="Menu">
            <div class="buscador">
                <asp:TextBox runat="server" MaxLength="15" ID="txbCodigoUsuario" CssClass="txtBusqueda" OnTextChanged="txbCodigoUsuario_TextChanged" placeholder="Buscar por nombre o codigo usuario" AutoPostBack="true"></asp:TextBox>

            </div>
            <div class="ContenedorCombo">
                <asp:DropDownList ID="ddlEstadoProyecto" CssClass="comboOpciones" runat="server" OnSelectedIndexChanged="ddlEstadoProyecto_SelectedIndexChanged" AutoPostBack="true">
                    <asp:ListItem Text="ESTADO" Value="X" Selected="True"></asp:ListItem>
                    <asp:ListItem Text="Activo" Value="A"></asp:ListItem>
                    <asp:ListItem Text="Retrasado" Value="R"></asp:ListItem>
                    <asp:ListItem Text="Finalizado" Value="F"></asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="ddlEtapaProyecto" CssClass="comboOpciones" runat="server" OnSelectedIndexChanged="ddlEtapaProyecto_SelectedIndexChanged" AutoPostBack="true">
                    <asp:ListItem Text="ETAPA" Value="X" Selected="True"></asp:ListItem>
                    <asp:ListItem Text="Tema" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Perfil" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Privada" Value="3"></asp:ListItem>
                    <asp:ListItem Text="Publica" Value="4"></asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="ddlTipoProyecto" CssClass="comboOpciones" runat="server" OnSelectedIndexChanged="ddlTipoProyecto_SelectedIndexChanged" AutoPostBack="true">
                    <asp:ListItem Text="TIPO" Value="X" Selected="True"></asp:ListItem>
                    <asp:ListItem Text="Trabajo Dirigido" Value="D"></asp:ListItem>
                    <asp:ListItem Text="Proyecto de grado" Value="P"></asp:ListItem>
                    <asp:ListItem Text="Tesis de grado" Value="T"></asp:ListItem>
                    <asp:ListItem Text="Sin Modalidad" Value="-"></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="contenedorTabla">

            <asp:GridView ID="grvListaProyectos" DataKeyNames="CodigoProyecto" CssClass="EstiloTable" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowDataBound="gvListaProyectos_RowDataBound" OnRowCommand="gvListaProyectos_RowCommand">
                <Columns>
                    <asp:BoundField DataField="CodigoProyecto"  Visible="false" />
                    <asp:BoundField DataField="CodigoRol" HeaderText="Rol En Proyecto" Visible="true"/>
                    
                    <asp:TemplateField HeaderText="Estudiantes">
                        <ItemTemplate>
                            <asp:DropDownList ID="ddlEstudiantes" runat="server" OnSelectedIndexChanged="ddlEstudiantes_SelectedIndexChanged" CssClass="comboOpciones" AutoPostBack="true">
                            </asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="CodigoTutor" HeaderText="Tutor" />
                    <asp:BoundField DataField="TituloProyecto" HeaderText="Titulo" />
                    <asp:BoundField DataField="ModalidadProyecto" HeaderText="Modalidad" />
                    <asp:TemplateField HeaderText="Acciones" ItemStyle-CssClass="btnLinea">
                        <ItemTemplate>
                            <asp:Button ID="btnVer" runat="server" Text="Ver" CommandName="btnVer" CommandArgument='<%# Container.DataItemIndex %>' CssClass="Btntabla" />
                            <asp:Button ID="btnFormularioAceptacion" runat="server" Text="F. Aceptacion" CommandName="btnFormularioAceptacion" CommandArgument='<%# Container.DataItemIndex %>' CssClass="Btntabla" />
                            <asp:Button ID="btnObservaciones" runat="server" Text="Observaciones" CommandName="btnObservaciones" CommandArgument='<%# Container.DataItemIndex %>' CssClass="Btntabla" />
                            <asp:Button ID="btnInfo" runat="server" Text="Grafica" CommandName="btnInfo" CommandArgument='<%# Container.DataItemIndex %>' CssClass="Btntabla" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Label ID="label" runat="server" Text=""></asp:Label>

        </div>
        <%--<asp:Button ID="btnVolver" runat="server" Text="Volver" CssClass="Btntabla" OnClick="btnVolver_Click" />--%>
    </div>
</asp:Content>
