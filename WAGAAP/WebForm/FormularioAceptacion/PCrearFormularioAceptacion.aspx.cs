using System;
using System.Collections.Generic;
using System.Linq;
using SWLNGAAP;

public partial class WebForm_Observaciones_PCrearFormularioAceptacion : System.Web.UI.Page
{
    #region Controladores
    CFormularioAceptacion cFormularioAceptacion = new CFormularioAceptacion();
    CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
    #endregion
    #region Metodos privados
    private bool ValidarEntradas(EGFormularioAceptacion eGFormularioAceptacion)
    {
        bool res = true;
        //No validados

        //
        return res;
    }
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
    }



    public void btnAgregar_Click(object sender, EventArgs e)
    {
        if (Session["CodigoProyecto"] != null && Session["UsuarioSesion"] != null)
        {
            string codigoProyecto = Session["CodigoProyecto"].ToString();
            EUsuarioSesionGAAP eUsuarioSesionGAAP = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            List<EGUsuarioProyecto> eGUsuarioProyectos = cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto);
            string codigoEstudiante = eGUsuarioProyectos.FirstOrDefault(usuario => usuario.CodigoRol == SDatosGlobales.ROL_ESTUDIANTE).CodigoUsuario;
            if (!string.IsNullOrEmpty(codigoEstudiante))
            {
                cFormularioAceptacion
                .Insertar_GFormularioAceptacion_I(
                    cFormularioAceptacion.Obtener_GFormularioAceptacion_O_SiguienteCodigoFormularioAceptacion(),
                    codigoProyecto,
                    eGUsuarioProyectos.FirstOrDefault(usuario => usuario.CodigoRol == SDatosGlobales.ROL_ESTUDIANTE).CodigoUsuario,
                    eUsuarioSesionGAAP.CodigoUsuario,
                    char.Parse(rbPreguntaFormatoYForma1.SelectedValue),
                    char.Parse(rbPreguntaFormatoYForma2.SelectedValue),
                    char.Parse(rbPreguntaFormatoYForma3.SelectedValue),
                    char.Parse(rbPreguntaFormatoYForma4.SelectedValue),
                    char.Parse(rbPreguntaFormatoYForma5.SelectedValue),
                    char.Parse(rbPreguntaFormatoYForma6.SelectedValue),
                    char.Parse(rbPreguntaFormatoYForma7.SelectedValue),
                    char.Parse(rbPreguntaFormatoYForma8.SelectedValue),
                    char.Parse(rbPreguntaFormatoYForma9.SelectedValue),
                    char.Parse(rbPreguntaFormatoYForma10.SelectedValue),
                    char.Parse(rbPreguntaFondo1.SelectedValue),
                    char.Parse(rbPreguntaFondo2.SelectedValue),
                    char.Parse(rbPreguntaFondo3.SelectedValue),
                    char.Parse(rbPreguntaFondo4.SelectedValue),
                    char.Parse(rbPreguntaFondo5.SelectedValue),
                    char.Parse(rbPreguntaFondo6.SelectedValue),
                    char.Parse(rbPreguntaFondo7.SelectedValue),
                    char.Parse(rbPreguntaFondo8.SelectedValue),
                    char.Parse(rbPreguntaFondo9.SelectedValue),
                    char.Parse(rbPreguntaFondo10.SelectedValue)
                    );
                Response.Redirect("~/WebForm/FormularioAceptacion/PListaFormularioAceptacion.aspx");
            }
        }
    }
        

}