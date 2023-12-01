<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PGraficasAvance.aspx.cs" Inherits="WebForm_PGraficasAvance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Estilos/Estudiante/SAvanceEstudiante.css" rel="stylesheet" />
     
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="contenedor">
        <div class="div-contenedor">
            <div>
                <p>Porcentaje de total del procediento de titulacion</p>
            </div>
            <div class="barra-progreso">
                <div class="barra" id="barra-progreso"></div>
            </div>
            <asp:Label runat="server" ID="lblPorcentajeTotal" Text="0%"></asp:Label>
        </div>
        <div class="div-contenedor">

            <div class="boton_detalle">
                <asp:Button runat="server" ID="btnDetalle" CssClass="Btntabla" Text="VER DETALLE" OnClick="btnDetalle_Click"/>

            </div>
            <div class="etapa">
                <asp:Label runat="server" ID="lblTituloNumeroEtapa">• Etapa 1</asp:Label>
            </div>
            <div class="alinear_vertical">
                <div class="lista-botones">
                    <asp:Button ID="btnTema" runat="server" CssClass="Btntabla" Text="TEMA" OnClick="btnTema_Click"/>
                    <asp:Button ID="btnPerfil" runat="server" CssClass="Btntabla" Text="PERFIL" OnClick="btnPerfil_Click"/>
                    <asp:Button ID="btnPrivada" runat="server" CssClass="Btntabla" Text="PRIVADA" OnClick="btnPrivada_Click"/>
                    <asp:Button ID="btnPublica" runat="server" CssClass="Btntabla" Text="PUBLICA" OnClick="btnPublica_Click"/>
                </div>

                <div class="progreso_Contenedor">
                    <div class="Columna">
                        <div class="Grafica">
                            <div class="ProgresoCircular_Activo" id="graficaEtapaActiva">
                                <label id="lblValorActivo" class="ProgresoValor"> </label>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="contenedor-estados">
                    <div class="revision">
                        <p>• Estado de la revisión</p>
                    </div>
                    <div class="item">
                            <asp:Label runat="server" ID="Label1" Text="Tutor:" CssClass="texto"></asp:Label>
                        <div >
                            <asp:Label runat="server" ID="lblPorcentajeTutor" Text="0%" CssClass="cuadro plomo"></asp:Label>
                        </div>
                    </div>
                    <div class="item">
                            <asp:Label runat="server" ID="Label2" Text="Dirección de Carrera:" CssClass="texto"></asp:Label>
                        <div >
                            <asp:Label runat="server" ID="lblPorcentajeDirector" Text="50%" CssClass="cuadro plomo"></asp:Label>
                        </div>
                    </div>
                    <div class="item">
                            <asp:Label runat="server" ID="Label3" Text="DAAP:" CssClass="texto"></asp:Label>                        
                        <div >
                            <asp:Label runat="server" ID="lblPorcentajeDAAP" Text="0%" CssClass="cuadro plomo"></asp:Label>
                        </div>
                    </div>
                    <div class="item">
                            <asp:Label runat="server" ID="lblTribunal1" Text="Tribunal - 1:" CssClass="texto"></asp:Label>                       
                        <div>
                            <asp:Label runat="server" ID="lblPorcentajeTribunal1" Text="0%" CssClass="cuadro plomo"></asp:Label>
                        </div>
                    </div>
                    <div class="item">
                            <asp:Label runat="server" ID="lblTribunal2" Text="Tribunal - 2:" CssClass="texto"></asp:Label>    
                        <div>
                            <asp:Label runat="server" ID="lblPorcentajeTribunal2" Text="0%" CssClass="cuadro plomo"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>

        </div>
       
        <div>
            <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" CssClass="Btntabla"/>
        </div>
    </div>

    <script accesskey="ActualizarProgreso" src="../../Guiones/Informacion/JBarraProgresoTotal.js"></script>
    <script accesskey="ActualizarProgreso" src="../../Guiones/Informacion/JBarraProgresoCircular.js"></script>

</asp:Content>

