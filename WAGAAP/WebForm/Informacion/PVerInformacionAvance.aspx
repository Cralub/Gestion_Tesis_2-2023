<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" CodeFile="PVerInformacionAvance.aspx.cs" Inherits="WebForm_Informacion_PVerInformacionAvance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Estilos/Informacion/SInformacionAvance.css" rel="stylesheet" />
    <link href="../../Estilos/Estudiante/SVistaDatosEstudiante.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contenedor">
        <div class="ContenedorPorcentaje">
            <div class="div-contenedor">
                <div>
                    <p>Porcentaje de total del procediento de titulacion</p>
                </div>
                <div class="barra-progreso">
                    <div class="barra" id="barra-progreso"></div>
                </div>
                <asp:Label runat="server" ID="lblPorcentajeTotal" Text="0%"></asp:Label>
            </div>
        </div>

        <div class="Contenedor1">
            <div class="Contenedor-Botones">
                <asp:Button runat="server" CssClass="Botones" Text="TEMA" ID="btnTema" OnClick="btnTema_Click" />
                <asp:Button runat="server" CssClass="Botones" Text="PERFIL" ID="btnPerfil" OnClick="btnPerfil_Click" />
                <asp:Button runat="server" CssClass="Botones" Text="PRIVADA" ID="btnPrivada" OnClick="btnPrivada_Click" />
                <asp:Button runat="server" CssClass="Botones" Text="PUBLICA" ID="btnPublica" OnClick="btnPublica_Click" />

              
            </div>
            <div class="Contenedor-SubEtapas">
                <asp:Panel ID="pnlEtapa1" runat="server">
                    <!-- Coloca los asp:Label de la Etapa 1 aquí -->
                    
                    <asp:Label Visible="true" ID="lblE1S1" Text="·ESTUDIANTE:​ Llena los datos, y elije tutor​" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                    <asp:Label Visible="true" ID="lblE1S2" Text="·TUTOR: Evalúa y aprueba​" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                    <asp:Label Visible="true" ID="lblE1S3" Text="·DAAP: Verifica y registra​" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                    <asp:Label Visible="true" ID="lblE1S4" Text="·DIRECTOR: Da el procedimiento, asigna fechas, guía​" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                </asp:Panel>
                <asp:Panel ID="pnlEtapa2" runat="server">
                    <!-- Coloca los asp:Label de la Etapa 1 aquí -->
                    <asp:Label Visible="true" ID="lblE2S1" Text="·ESTUDIANTE: Elabora" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                    <asp:Label Visible="true" ID="lblE2S2" Text="·TUTOR: Confirma y remite" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                    <asp:Label Visible="true" ID="lblE2S3" Text="·DIRECTOR: Remite y asigna tribunales" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                    <asp:Label Visible="true" ID="lblE2S4" Text="·TRIBUNAL 1: Revisa y remite" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                    <asp:Label Visible="true" ID="lblE2S5" Text="·TRIBUNAL 2: Revisa y remite" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                    <asp:Label Visible="true" ID="lblE2S6" Text="·DAAP: Verifica plagio y aprueba y remite" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                    <asp:Label Visible="true" ID="lblE2S7" Text="·DIRECTOR: Aprueba y comunica e informa" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                </asp:Panel>
                <asp:Panel ID="pnlEtapa3" runat="server">
                    <!-- Coloca los asp:Label de la Etapa 1 aquí -->
                    <asp:Label Visible="true" ID="lblE3S1" Text="·ESTUDIANTE: Elabora" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                    <asp:Label Visible="true" ID="lblE3S2" Text="·TUTOR: Confirma y remite" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                    <asp:Label Visible="true" ID="lblE3S3" Text="·DIRECTOR: Revisa y remite​" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                    <asp:Label Visible="true" ID="lblE3S4" Text="·TRIBUNAL 1: Revisa y remite" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                    <asp:Label Visible="true" ID="lblE3S5" Text="·TRIBUNAL 2: Revisa y remite" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                    <asp:Label Visible="true" ID="lblE3S6" Text="·DAAP: Verifica, aprueba y remite" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                    <asp:Label Visible="true" ID="lblE3S7" Text="·DIRECTOR: Aprueba y habilita la defensa " CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                </asp:Panel>
                <asp:Panel ID="pnlEtapa4" runat="server">
                    <!-- Coloca los asp:Label de la Etapa 1 aquí -->
                    <asp:Label Visible="true" ID="lblE4S1" Text="·ESTUDIANTE: Elabora" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                    <asp:Label Visible="true" ID="lblE4S2" Text="·TUTOR: Confirma y remite" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                    <asp:Label Visible="true" ID="lblE4S3" Text="·DIRECTOR: Remite y recibe informe de ambos subida del acta​" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                    <asp:Label Visible="true" ID="lblE4S4" Text="·TRIBUNAL 1: Revisa y remite" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                    <asp:Label Visible="true" ID="lblE4S5" Text="·TRIBUNAL 2: Revisa y remite" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                    <asp:Label Visible="true" ID="lblE4S6" Text="·DAAP: Verifica y remite" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                    <asp:Label Visible="true" ID="lblE4S7" Text="·DIRECTOR: Aprueba y habilita la defensa, “Correcto”" CssClass="Estilo-SubEtapas" runat="server"></asp:Label>
                </asp:Panel>

                </div>
            </div>
          <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" CssClass="botones"/>
        </div>
        <script accesskey="ActualizarProgreso" src="../../Guiones/Informacion/JBarraProgresoTotal.js"></script>
        <script accesskey="MostrarBotones" src="../../Guiones/Informacion/JInformacionAvance.js"></script>
</asp:Content>
