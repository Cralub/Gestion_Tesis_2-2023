<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" CodeFile="PVerInformacionAvance.aspx.cs" Inherits="WebForm_Informacion_PVerInformacionAvance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Estilos/Informacion/SInformacionAvance.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contenedor">
        <div class="ContenedorPorcentaje">
            <div>
                <label>Porcentaje de total del avance general</label>
            </div>

            <div class="Contenedor1">
                <div class="barra-progreso">
                    <div class="barra" id="barra-progreso"></div>
                </div>
                <div id="porcentaje">0%</div>
                <button onclick="decrementoProgreso()">-</button>
                <button onclick="incrementoProgreso()">+</button>

            </div>
        </div>

        <div class="Contenedor1">
            <div class="Contenedor-Botones">
                <button type="button" class="Botones" id="Tema" onclick="mostrarDiv(0); return false;">PUBLICA</button>
                <button type="button" class="Botones" id="PERFIL" onclick="mostrarDiv(1); return false;">PERFIL</button>
                <button type="button" class="Botones" id="PRIVADA" onclick="mostrarDiv(2); return false;">PRIVADA</button>
                <button type="button" class="Botones" id="PUBLICA" onclick="mostrarDiv(3); return false;">PUBLICA</button>
            </div>
            <div class="Contenedor-SubEtapas OcultarDiv" id="Div1">
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
            </div>
            <div class="Contenedor-SubEtapas OcultarDiv" id="Div2">
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>

            </div>
            <div class="Contenedor-SubEtapas OcultarDiv" id="Div3">
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
            </div>
            <div class="Contenedor-SubEtapas OcultarDiv" id="Div4">
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
                <asp:Label class="Estilo-SubEtapas" runat="server">·Sub Etapa</asp:Label>
            </div>
        </div>
    </div>
    <script src="../../Guiones/Informacion/JInformacionAvance.js"></script>
</asp:Content>
