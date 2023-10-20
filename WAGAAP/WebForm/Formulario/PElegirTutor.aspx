<%@ Page Title="Seleccion Tutor" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PElegirTutor.aspx.cs" Inherits="WebForm_Formulario_PElegirTutor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <asp:DropDownList ID="ddlTutores" runat="server" Width="165px" Height="30px"></asp:DropDownList>
    </div>
    <div>
        <asp:Button ID="btnElegirTutor" runat="server" Text="Elegir Tutor" OnClick="btnElegirTutor_Click" />
    </div>
    <div>
        <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
    </div>
</asp:Content>
