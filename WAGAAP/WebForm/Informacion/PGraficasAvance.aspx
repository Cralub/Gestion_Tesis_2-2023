<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PGraficasAvance.aspx.cs" Inherits="WebForm_PGraficasAvance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" href="../Estilo/CSSGraficasAvance.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
            <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
        </div>
    <div class="ContenedorPrincipal">
        <div class="Tarjeta">
            <div class="Tarjeta_Encabezado">
                <h4>Porcentaje de avance general de la tesis</h4>
            </div>
            <div class="Tarjeta_Cuerpo">
                <div class="Progreso">
                    <div runat="server" class="ProgresoBarra" id="barraProgreso">
                        <asp:Label runat="server" ID="lblProgresoTotal" class="ProgresoBarra_Valor"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
        <div class="Fila">
            <div class="Tarjeta">
                <div class="Tarjeta_Cuerpo">
                    <div class="Columna">
                        <h2><asp:Label runat="server" ID="lblEtapaActiva"></asp:Label></h2>
                        <asp:Label runat="server" ID="lblProgresoEtapaActiva"></asp:Label>
                        <div>
                            <h4>REVISADO POR</h4>
                            <ul>
                                <li>
                                    <div>
                                        <h4>Estudiante</h4>
                                        <small>Ing. Sistemas</small>
                                    </div>
                                    <div>
                                        <asp:CheckBox ID="chkEstudianteActual" runat="server" Enabled="False" />
                                    </div>
                                </li>
                                <li>
                                    <div>
                                        <h4>Tutor</h4>
                                        <small>Tutor del Estudiante</small>
                                    </div>
                                    <div>
                                        <asp:CheckBox ID="chkTutorActual" runat="server" Enabled="False" />
                                    </div>
                                </li>
                                <li runat="server" id="tribunalParticipaActual">
                                    <div>
                                        <h4>Tribunales</h4>
                                        <small>2</small>
                                    </div>
                                    <div>
                                        <asp:CheckBox ID="chkTribunalesActual" runat="server" Enabled="False" Visible="true" />
                                    </div>
                                </li>
                                <li>
                                    <div>
                                        <h4>Director</h4>
                                        <small>Director de Carrera</small>
                                    </div>
                                    <div>
                                        <asp:CheckBox ID="chkDirectorActual" runat="server" Enabled="False" />
                                    </div>
                                </li>
                                <li>
                                    <div>
                                        <h4>DAAP</h4>
                                        <small>Departamento de Apoyo a Proyectos</small>
                                    </div>
                                    <div>
                                        <asp:CheckBox ID="chkDAAPActual" runat="server" Enabled="False" />
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class="Columna">
                        <div class="Grafica">
                            <div runat="server" class="ProgresoCircular_Activo" id="graficaEtapaActiva">
                                <asp:Label runat="server" ID="lblValorActivo" CssClass="ProgresoValor"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="Tarjeta">
            </div>
        </div>
        <div class="Fila">
            <div class="Tarjeta">
                <div class="Tarjeta_Cuerpo">
                    <div class="Columna">
                        <h2><asp:Label runat="server" ID="lblEtapa"></asp:Label></h2>
                        <asp:Label runat="server" ID="lblProgresoEtapa"></asp:Label>
                        <div>
                            <h4>REVISADO POR</h4>
                            <ul>
                                <li>
                                    <div>
                                        <h4>Estudiante</h4>
                                        <small>Ing. Sistemas</small>
                                    </div>
                                    <div>
                                        <asp:CheckBox ID="chkEstudiante" runat="server" Enabled="False" />
                                    </div>
                                </li>
                                <li>
                                    <div>
                                        <h4>Tutor</h4>
                                        <small>Tutor del Estudiante</small>
                                    </div>
                                    <div>
                                        <asp:CheckBox ID="chkTutor" runat="server" Enabled="False" />
                                    </div>
                                </li>
                                <li runat="server" id="tribunalParticipa">
                                    <div>
                                        <h4>Tribunales</h4>
                                        <small>2</small>
                                    </div>
                                    <div>
                                        <asp:CheckBox ID="chkTribunales" runat="server" Enabled="False" Visible="true" />
                                    </div>
                                </li>
                                <li>
                                    <div>
                                        <h4>Director</h4>
                                        <small>Director de Carrera</small>
                                    </div>
                                    <div>
                                        <asp:CheckBox ID="chkDirector" runat="server" Enabled="False" />
                                    </div>
                                </li>
                                <li>
                                    <div>
                                        <h4>DAAP</h4>
                                        <small>Departamento de Apoyo a Proyectos</small>
                                    </div>
                                    <div>
                                        <asp:CheckBox ID="chkDAAP" runat="server" Enabled="False" />
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class="Columna">
                        <div class="Grafica">
                            <div runat="server" class="ProgresoCircular" id="graficaEtapa">
                                <asp:Label runat="server" ID="lblValor" CssClass="ProgresoValor"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="Tarjeta">
                <div class="Tarjeta_Cuerpo">
                    <div class="Columna">
                        <h2>ETAPA 3</h2>
                        <div>Total de Avance - 0%</div>
                        <div>
                            <h4>REVISADO POR</h4>
                            <ul>
                                <li>
                                    <div>
                                        <h4>Estudiante</h4>
                                        <small>Ing. Sistemas</small>
                                    </div>
                                    <div>
                                        <asp:CheckBox ID="chkEstudianteTercero" runat="server" Enabled="False" />
                                    </div>
                                </li>
                                <li>
                                    <div>
                                        <h4>Tutor</h4>
                                        <small>Tutor del Estudiante</small>
                                    </div>
                                    <div>
                                        <asp:CheckBox ID="chkTutorTercero" runat="server" Enabled="False" />
                                    </div>
                                </li>
                                <li>
                                    <div>
                                        <h4>Tribunales</h4>
                                        <small>2</small>
                                    </div>
                                    <div>
                                        <asp:CheckBox ID="chkTribunalesSegundo" runat="server" Enabled="False" Visible="true" />
                                    </div>
                                </li>
                                <li>
                                    <div>
                                        <h4>Director</h4>
                                        <small>Director de Carrera</small>
                                    </div>
                                    <div>
                                        <asp:CheckBox ID="chkDirectorTercero" runat="server" Enabled="False" />
                                    </div>
                                </li>
                                <li>
                                    <div>
                                        <h4>DAAP</h4>
                                        <small>Departamento de Apoyo a Proyectos</small>
                                    </div>
                                    <div>
                                        <asp:CheckBox ID="chkDAAPTercero" runat="server" Enabled="False" />
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class="Columna">
                        <div class="Grafica">
                            <div runat="server" class="ProgresoCircular" id="graficaEtapa3">
                                <asp:Label runat="server" ID="lblValorTercero" CssClass="ProgresoValor">0%</asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="Tarjeta">
                <div class="Tarjeta_Cuerpo">
                    <div class="Columna">
                        <h2>ETAPA 4</h2>
                        <div>Total de Avance - 0%</div>
                        <div>
                            <h4>REVISADO POR</h4>
                            <ul>
                                <li>
                                    <div>
                                        <h4>Estudiante</h4>
                                        <small>Ing. Sistemas</small>
                                    </div>
                                    <div>
                                        <asp:CheckBox ID="chkEstudianteCuarto" runat="server" Enabled="False" />
                                    </div>
                                </li>
                                <li>
                                    <div>
                                        <h4>Tutor</h4>
                                        <small>Tutor del Estudiante</small>
                                    </div>
                                    <div>
                                        <asp:CheckBox ID="chkTutorCuarto" runat="server" Enabled="False" />
                                    </div>
                                </li>
                                <li>
                                    <div>
                                        <h4>Tribunales</h4>
                                        <small>2</small>
                                    </div>
                                    <div>
                                        <asp:CheckBox ID="chkTribunalesTercero" runat="server" Enabled="False" Visible="true" />
                                    </div>
                                </li>
                                <li>
                                    <div>
                                        <h4>Director</h4>
                                        <small>Director de Carrera</small>
                                    </div>
                                    <div>
                                        <asp:CheckBox ID="chkDirectorCuarto" runat="server" Enabled="False" />
                                    </div>
                                </li>
                                <li>
                                    <div>
                                        <h4>DAAP</h4>
                                        <small>Departamento de Apoyo a Proyectos</small>
                                    </div>
                                    <div>
                                        <asp:CheckBox ID="chkDAAPCuarto" runat="server" Enabled="False" />
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class="Columna">
                        <div class="Grafica">
                            <div runat="server" class="ProgresoCircular" id="graficaEtapa4">
                                <asp:Label runat="server" ID="lblValorCuarto" CssClass="ProgresoValor">0%</asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

