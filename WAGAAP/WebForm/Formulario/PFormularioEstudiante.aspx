<%@ Page Title="Formulario" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PFormularioEstudiante.aspx.cs" Inherits="WebForm_Formulario_PFormularioEstudiante" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <asp:Button ID="BtnTutor" runat="server"  Text="Seleccionar Tutor" OnClick="BtnTutor_Click"/>
        <div>
            <h2>Formulario 1: Tema</h2>
            <div>
                <asp:Label runat="server" Text="Estudiantes: "></asp:Label>
                 <asp:DropDownList ID="ddlEstudiantes" runat="server" Width="165px" Height="30px" OnSelectedIndexChanged="ddlEstudiantes_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList> 
            </div>
            <div>
                <asp:Label runat="server" Text="Enlace al documento" ></asp:Label>
                <asp:LinkButton runat="server" ID="lkbEnlaceDocumento" type="text"></asp:LinkButton>
            </div>
            <div>
                <asp:Label runat="server" Text="Código de Proyecto:"></asp:Label>
                <asp:TextBox runat="server" ID="txbCodigoProyecto"  type="text"/>
            </div>
            <div>
                <asp:Label runat="server" Text="Título:"></asp:Label>
                <asp:TextBox runat="server" ID="txbTitulo"  name="txtTitulo" type="text" />
            </div>
            <div>
                <asp:Label runat="server" Text="Objetivo General:"></asp:Label>
                <asp:TextBox runat="server" ID="txbObjetivoGeneral" ></asp:TextBox>
            </div> 
            <div>
                <asp:Label runat="server" for="ddlModalidades" Text="Modalidad:"></asp:Label>
                <asp:DropDownList ID="ddlModalidades" runat="server" Width="165px" Height="30px">
                    <asp:ListItem Value="T" Selected="True">Seleccionar ...</asp:ListItem>
                    <asp:ListItem Value="D">Trabajo Dirigido</asp:ListItem>
                    <asp:ListItem Value="P">Proyecto de Grado</asp:ListItem>
                    <asp:ListItem Value="T">Tesis</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
    <br />
        <div>
             <asp:Button ID="btnAgregar" runat="server"  Text="Actualizar Informacion" OnClick="btnAgregar_Click"/>
        </div>
    <br />
     <div>
             <asp:Button ID="btnAvanzar" runat="server"  Text="Enviar" OnClick="btnAvanzar_Click"/>
        </div>
    <br />
       <div>
           <asp:Button  ID="btnVolver" runat="server"   Text="Volver a Lista de Proyectos" OnClick="btnVolver_Click"/>
       </div>
</asp:Content>
     
