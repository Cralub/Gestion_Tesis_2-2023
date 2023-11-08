<%@ Page Title="Informacion Usuario" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PInformacionUsuario.aspx.cs" Inherits="WebForm_Usuario_PInformacionUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="stylesheet" href="../Estilos/Estudiante/SVistaDatosEstudiante.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="divInformacion">
        <table >
          <tr>

            <td rowspan="7" >
              <img src="../../Imagenes/Iconos/CambiarUsuario.png" class="iconoCambiarUsuario">
              <button>Cambiar foto</button>
            </td>        
            
            <td class="nombre">                        <asp:Label ID="lblNombreCompleto" runat="server" Text=""></asp:Label>
</td>
        
          </tr> 
        
          <tr>

            <td class="carrera">                        <asp:Label ID="lblCarrera" runat="server" Text=""></asp:Label>
</td>
        
          </tr>
        
          <tr>
        
            <td colspan="3">                        <asp:Label ID="lblRol" runat="server" Text=""></asp:Label>
</td>     

          </tr>
        
          <tr>
        
            <td colspan="2">                        <asp:Label ID="lblFacultad" runat="server" Text=""></asp:Label>
</td>
        
          </tr>
          
          <tr>

            <td colspan="2">                        <asp:Label ID="lblSede" runat="server" Text=""></asp:Label>
</td>
        
          </tr>
        
          <tr>
        
            <td colspan="2">                        <asp:Label ID="lblDireccion" runat="server" Text=""></asp:Label>
</td>     

          </tr>
        
          <tr>
        
            <td colspan="2">                        <asp:Label ID="lblDireccionTrabajo" runat="server" Text=""></asp:Label>
</td>
        
          </tr>
                      <tr>
        
            <td colspan="2">                                               <asp:Label ID="lblCelular" runat="server" Text=""></asp:Label>

        
          </tr>

          <tr>
        
            <td>ESTUDIANTE</td>
            <td class="centro">Gestión: 1-2023</td>
            <td> <button>Editar datos</button> </td> 
        
          </tr>
        </table>
         <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
      </div>



    
</asp:Content>
