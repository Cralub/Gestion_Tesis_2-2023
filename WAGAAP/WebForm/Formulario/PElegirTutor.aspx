<%@ Page Title="Lista Proyectos General" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PElegirTutor.aspx.cs" Inherits="WebForm_Formulario_PElegirTutor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <div>
            <span class="TextoLogin">Nombre:</span>
            <asp:TextBox runat="server" MaxLength="15" ID="txbBuscarTutor" OnTextChanged="txbBuscarTutor_TextChanged" class="TextBox" AutoPostBack="true"></asp:TextBox>
            <asp:Label runat="server" ID="lblMensajeElegirTutor" Text=""></asp:Label>
        </div>

        <div>
            <asp:GridView ID="grvTutores" DataKeyNames="CodigoUsuario" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowCommand="grvTutores_RowCommand">
                <Columns>
                    <asp:BoundField DataField="CodigoUsuario" HeaderText="Codigo Tutor" />
                    <asp:BoundField DataField="NombreCompletoUsuario" HeaderText="Nombre Completo Tutor" />
                    <asp:ButtonField ButtonType="Button" CommandName="btnVer" Text="Ver" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Width="55" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton" />
                    <asp:ButtonField ButtonType="Button" CommandName="btnElegirTutor" Text="ElegirTutor" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Width="55" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton" />
                </Columns>
            </asp:GridView>
        </div>
       
        <div>
            <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
        </div>
    </div>
</asp:Content>
