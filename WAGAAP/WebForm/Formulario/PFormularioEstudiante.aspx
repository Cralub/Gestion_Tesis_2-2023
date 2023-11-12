<%@ Page Title="Formulario" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PFormularioEstudiante.aspx.cs" Inherits="WebForm_Formulario_PFormularioEstudiante" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div>
        <h2>Formulario Proyecto</h2>
        <div>
            <asp:Label runat="server" Text="Código de Proyecto:"></asp:Label>
            <asp:Label runat="server" ID="lblCodigoProyecto" type="text" />
        </div>
        <div>
            <asp:Label runat="server" Text="Intentos Restantes:"></asp:Label>
            <asp:Label runat="server" ID="lblRevision" type="text" />
        </div>

        <div>
            <asp:Label runat="server" Text="Enlace al documento"></asp:Label>
            <asp:LinkButton runat="server" ID="lkbEnlaceDocumento" type="text"></asp:LinkButton>
            <asp:Button ID="btnAgregarDocumento" runat="server" Text="Agregar Documento" OnClick="btnAgregarDocumento_Click" />

        </div>

        <div>
            <asp:Label runat="server" Text="Título:"></asp:Label>
            <asp:TextBox runat="server" ID="txbTitulo" name="txtTitulo" type="text" />
        </div>
        <div>
            <asp:Label runat="server" Text="Objetivo General:"></asp:Label>
            <asp:TextBox runat="server" ID="txbObjetivoGeneral"></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server" Text="Objetivos Especificos:"></asp:Label>
            <asp:TextBox runat="server" ID="txbObjetivosEspecificos"></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server" Text="Alcance:"></asp:Label>
            <asp:TextBox runat="server" ID="txbAlcanceProyecto"></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server" for="ddlModalidades" Text="Modalidad:"></asp:Label>
            <asp:DropDownList ID="ddlModalidades" runat="server" Width="165px" Height="30px">
                <asp:ListItem Value="X" Selected="True">Seleccionar ...</asp:ListItem>
                <asp:ListItem Value="D">Trabajo Dirigido</asp:ListItem>
                <asp:ListItem Value="P">Proyecto de Grado</asp:ListItem>
                <asp:ListItem Value="T">Tesis</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            <asp:Button ID="btnTutor" runat="server" Text="Seleccionar Tutor" OnClick="btnTutor_Click" />
            <asp:Label runat="server" ID="lblMensajeElegirNuevoTutor" Text=""></asp:Label>
            <asp:GridView ID="grvListaUsuarios" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowCommand="gvListaUsuarios_RowCommand" DataKeyNames="CodigoUsuario">
                <Columns>
                    <asp:BoundField DataField="Nombre" HeaderText="Usuario" />
                    <asp:BoundField DataField="CodigoUsuario" HeaderText="Codigo" />
                    <asp:BoundField DataField="CodigoRol" HeaderText="Rol En Proyecto" />
                    <asp:ButtonField ButtonType="Button" CommandName="btnVer" Text="Ver" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Width="55" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton" />
                </Columns>
            </asp:GridView>
        </div>

    </div>

    <br />

    <div>
        <asp:Button ID="btnAgregar" runat="server" Text="Actualizar Informacion" OnClick="btnAgregar_Click" />
    </div>
    <br />
    <div>
        <asp:Button ID="btnAvanzar" runat="server" Text="Enviar" OnClick="btnAvanzar_Click" />
    </div>
    <br />
    <div>
        <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
    </div>
</asp:Content>

