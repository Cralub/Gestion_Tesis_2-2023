<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PObservacion.aspx.cs" Inherits="WebForm_Observaciones_PObservacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../../Estilos/Observaciones/SObservacion.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="observacion">
        <p class="letras">Observación: Verificar título</p>
        <div class="info">
            <p>Estado</p>
            <div class="estado"></div>
            <p>Tipo: Forma</p>
        </div>
        <div class="contenedor">
            <p>Responsable:</p> 
            <p class="posicion">Ing. Mario Moreno Morales</p>
        </div>
         <div class="contenedor">
            <p>Descripción: </p> 
            <p class="posicion lineas">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor 
                incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation
                ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in 
                voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non 
                proident, sunt in culpa qui officia deserunt mollit anim id est laborum.

            </p>
        </div>
     
        <button class="btn">Retroceder</button>
    </div>
</asp:Content>

