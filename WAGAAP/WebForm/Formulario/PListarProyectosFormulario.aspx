<%@ Page Title="Lista Proyectos" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" Language="C#" AutoEventWireup="true" CodeFile="PListarProyectosFormulario.aspx.cs" Inherits="WebForm_Formulario_PListarProyectosFormulario" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div style="margin-left: 40px">
             <div>
                <asp:Label ID="lblCodigoUsuario" runat="server"></asp:Label>
                 <asp:Label ID="lblNombreUsuario" runat="server"></asp:Label>
                 <asp:Button  ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click"/>
            </div>
            <asp:GridView ID="gvListaProyectos" DataKeyNames="CodigoProyecto" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False"  OnRowDataBound="gvListaProyectos_RowDataBound" OnRowCommand="gvListaProyectos_RowCommand">
                <Columns>
                    <asp:BoundField DataField="CodigoRol" HeaderText="Rol En Proyecto" />
                    <asp:TemplateField HeaderText="Estudiantes">
                        <ItemTemplate >
                            <asp:DropDownList ID="ddlEstudiantes" runat="server" OnSelectedIndexChanged="ddlEstudiantes_SelectedIndexChanged" AutoPostBack="true" >
                            </asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="CodigoTutor" HeaderText="CodigoTutor " />
                    <asp:BoundField DataField="CodigoProyecto" HeaderText="CodigoProyecto" Visible="False" />
                    <asp:BoundField DataField="TituloProyecto" HeaderText="Titulo" />
                    <asp:BoundField DataField="ModalidadProyecto" HeaderText="Modalidad" />
                    <asp:ButtonField ButtonType="Button" CommandName="btnVer" Text="Ver" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Width="55" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton"/>
                    <asp:ButtonField ButtonType="Button" CommandName="btnObservaciones" Text="Observaciones" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Width="55" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton"/>
                </Columns>
            </asp:GridView>
        </div>
    </asp:Content>

