<%@ Page Language="C#" Title="Ver Formulario Aceptacion"  MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PVerFormularioAceptacion.aspx.cs" Inherits="WebForm_FormularioAceptacion_PVerFormularioAceptacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
       <div>
           <h2>Formulario de Aceptacion</h2>
           <div class="horizontal-align">
                <asp:Label runat="server" Text="¿El titulo es adecuado?"></asp:Label>
                <asp:RadioButtonList runat="server" ID="rbPreguntaFormatoYForma1" Enabled="false">
                    <asp:ListItem Text="Sí" Value="S" />
                    <asp:ListItem Text="No" Value="N" />
                </asp:RadioButtonList>
           </div>
           <div>
                <asp:Label runat="server" Text="¿Presenta indice de contenido?"></asp:Label>
                <asp:RadioButtonList runat="server" ID="rbPreguntaFormatoYForma2" Enabled="false">
                    <asp:ListItem Text="Sí" Value="S" />
                    <asp:ListItem Text="No" Value="N" />
                </asp:RadioButtonList>
           </div>
           <div>
                <asp:Label runat="server" Text="¿Orden de contenido según la guia?"></asp:Label>
                <asp:RadioButtonList runat="server" ID="rbPreguntaFormatoYForma3" Enabled="false">
                    <asp:ListItem Text="Sí" Value="S" />
                    <asp:ListItem Text="No" Value="N" />
                </asp:RadioButtonList>
           </div>
           <div>
                <asp:Label runat="server" Text="¿Se encuentra en el formato solicitado?"></asp:Label>
                <asp:RadioButtonList runat="server" ID="rbPreguntaFormatoYForma4" Enabled="false">
                    <asp:ListItem Text="Sí" Value="S" />
                    <asp:ListItem Text="No" Value="N" />
                </asp:RadioButtonList>
           </div>
           <div>
                <asp:Label runat="server" Text="¿Numero de hojas(no supera las 25 o contiene las necesarias)?"></asp:Label>
                <asp:RadioButtonList runat="server" ID="rbPreguntaFormatoYForma5" Enabled="false">
                    <asp:ListItem Text="Sí" Value="S" />
                    <asp:ListItem Text="No" Value="N" />
                </asp:RadioButtonList>
           </div>
           <div>
                <asp:Label runat="server" Text="¿Cuenta con todas las etapas del proceso de investigación? o al menos las mas importantes?"></asp:Label>
                <asp:RadioButtonList runat="server" ID="rbPreguntaFormatoYForma6" Enabled="false">
                    <asp:ListItem Text="Sí" Value="S" />
                    <asp:ListItem Text="No" Value="N" />
                </asp:RadioButtonList>
           </div>
           <div>
                <asp:Label runat="server" Text="¿Cronograma acorde a sus actividades y objetivos?"></asp:Label>
                <asp:RadioButtonList runat="server" ID="rbPreguntaFormatoYForma7" Enabled="false">
                    <asp:ListItem Text="Sí" Value="S" />
                    <asp:ListItem Text="No" Value="N" />
                </asp:RadioButtonList>
            </div>
            <div>
                 <asp:Label runat="server" Text="¿Presenta citas bibliograficas?"></asp:Label>
                 <asp:RadioButtonList runat="server" ID="rbPreguntaFormatoYForma8" Enabled="false">
                    <asp:ListItem Text="Sí" Value="S" />
                    <asp:ListItem Text="No" Value="N" />
                </asp:RadioButtonList>
            </div>
            <div>
                 <asp:Label runat="server" Text="¿Presenta referencias bibliograficas?"></asp:Label>
                  <asp:RadioButtonList runat="server" ID="rbPreguntaFormatoYForma9" Enabled="false">
                    <asp:ListItem Text="Sí" Value="S" />
                    <asp:ListItem Text="No" Value="N" />
                </asp:RadioButtonList>
            </div>
            <div>
                 <asp:Label runat="server" Text="¿Redaccion y ortografia adecuadas?"></asp:Label>
                   <asp:RadioButtonList runat="server" ID="rbPreguntaFormatoYForma10" Enabled="false">
                    <asp:ListItem Text="Sí" Value="S" />
                    <asp:ListItem Text="No" Value="N" />
                </asp:RadioButtonList>
            </div>
            <div>
                 <asp:Label runat="server" Text="¿Está bien definido el problema que se quiere investigar, con claridad, precisión, pruebas de su existencia y pertinencia como iniciativa de investigación?"></asp:Label>
                    <asp:RadioButtonList runat="server" ID="rbPreguntaFondo1" Enabled="false">
                        <asp:ListItem Text="Bueno" Value="B" />
                        <asp:ListItem Text="Regular" Value="R" />
                        <asp:ListItem Text="Malo" Value="M" />
                    </asp:RadioButtonList>
            </div>
            <div>
                 <asp:Label runat="server" Text="¿Es clara su justificación desde el punto de vista académico, científico, tecnológico, social, económico y legal (según lo requerido)?"></asp:Label>
                 <asp:RadioButtonList runat="server" ID="rbPreguntaFondo2" Enabled="false">
                    <asp:ListItem Text="Bueno" Value="B" />
                    <asp:ListItem Text="Regular" Value="R" />
                    <asp:ListItem Text="Malo" Value="M" />
                </asp:RadioButtonList>
            </div>
            <div>
                 <asp:Label runat="server" Text="¿La literatura mencionada en el proyecto provienen de fuentes confiables y está actualizada con respecto al problema que se va a estudiar?"></asp:Label>
                 <asp:RadioButtonList runat="server" ID="rbPreguntaFondo3" Enabled="false">
                    <asp:ListItem Text="Bueno" Value="B" />
                    <asp:ListItem Text="Regular" Value="R" />
                    <asp:ListItem Text="Malo" Value="M" />
                </asp:RadioButtonList>
            </div>
            <div>
                 <asp:Label runat="server" Text="¿La literatura, esta críticamente analizada?"></asp:Label>
                 <asp:RadioButtonList runat="server" ID="rbPreguntaFondo4" Enabled="false">
                    <asp:ListItem Text="Bueno" Value="B" />
                    <asp:ListItem Text="Regular" Value="R" />
                    <asp:ListItem Text="Malo" Value="M" />
                </asp:RadioButtonList>
            </div>
            <div>
                 <asp:Label runat="server" Text="¿Es clara la perspectiva de la teórica desde donde se ubica el problema?"></asp:Label>
                  <asp:RadioButtonList runat="server" ID="rbPreguntaFondo5" Enabled="false">
                    <asp:ListItem Text="Bueno" Value="B" />
                    <asp:ListItem Text="Regular" Value="R" />
                    <asp:ListItem Text="Malo" Value="M" />
                </asp:RadioButtonList>
            </div>
            <div>
                 <asp:Label runat="server" Text="¿La teória está vinculada con el problema planteado, los objetivos y/o la hipótesis propuesta?"></asp:Label>
                  <asp:RadioButtonList runat="server" ID="rbPreguntaFondo6" Enabled="false">
                    <asp:ListItem Text="Bueno" Value="B" />
                    <asp:ListItem Text="Regular" Value="R" />
                    <asp:ListItem Text="Malo" Value="M" />
                </asp:RadioButtonList>
            </div>
            <div>
                 <asp:Label runat="server" Text="¿Los objetivos son viables, claros, concretos y son alcanzables, de acuerdo con el estudio y los métodos?"></asp:Label>
                  <asp:RadioButtonList runat="server" ID="rbPreguntaFondo7">
                    <asp:ListItem Text="Bueno" Value="B" />
                    <asp:ListItem Text="Regular" Value="R" />
                    <asp:ListItem Text="Malo" Value="M" />
                </asp:RadioButtonList>
            </div>
            <div>
                 <asp:Label runat="server" Text="¿Existe coherencia entre el objetivo general y los específicos?"></asp:Label>
                  <asp:RadioButtonList runat="server" ID="rbPreguntaFondo8" Enabled="false">
                    <asp:ListItem Text="Bueno" Value="B" />
                    <asp:ListItem Text="Regular" Value="R" />
                    <asp:ListItem Text="Malo" Value="M" />
                </asp:RadioButtonList>
            </div>
            <div>
                 <asp:Label runat="server" Text="¿La metodología y las técnicas previstas son claras y pertinentes en relación con los objetivos?"></asp:Label>
                   <asp:RadioButtonList runat="server" ID="rbPreguntaFondo9" Enabled="false">
                        <asp:ListItem Text="Bueno" Value="B" />
                        <asp:ListItem Text="Regular" Value="R" />
                        <asp:ListItem Text="Malo" Value="M" />
                    </asp:RadioButtonList>
            </div>
            <div>
                 <asp:Label runat="server" Text="¿La metodología responde a los objetivos y/o hipótesis planteados?"></asp:Label>
                 <asp:RadioButtonList runat="server" ID="rbPreguntaFondo10" Enabled="false">
                     <asp:ListItem Text="Bueno" Value="B" />
                    <asp:ListItem Text="Regular" Value="R" />
                    <asp:ListItem Text="Malo" Value="M" />
                 </asp:RadioButtonList>
            </div>
           
       </div>
</asp:Content>