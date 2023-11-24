using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_FormularioAceptacion_PVerFormularioAceptacion : System.Web.UI.Page
{
    #region Controladores
    CFormularioAceptacion cFormularioAceptacion = new CFormularioAceptacion();
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CargarFormularioAceptacion();
        }
    }
    private void CargarFormularioAceptacion()
    {
        if (Session["FormularioAceptacion"] != null)
        {
            EGFormularioAceptacion formularionAceptacion = Session["FormularioAceptacion"] as EGFormularioAceptacion;
            rbPreguntaFormatoYForma1.SelectedValue = formularionAceptacion.PreguntaFormatoYForma1.ToString();
            rbPreguntaFormatoYForma2.SelectedValue = formularionAceptacion.PreguntaFormatoYForma2.ToString();
            rbPreguntaFormatoYForma3.SelectedValue = formularionAceptacion.PreguntaFormatoYForma3.ToString();
            rbPreguntaFormatoYForma4.SelectedValue = formularionAceptacion.PreguntaFormatoYForma4.ToString();
            rbPreguntaFormatoYForma5.SelectedValue = formularionAceptacion.PreguntaFormatoYForma5.ToString();
            rbPreguntaFormatoYForma6.SelectedValue = formularionAceptacion.PreguntaFormatoYForma6.ToString();
            rbPreguntaFormatoYForma7.SelectedValue = formularionAceptacion.PreguntaFormatoYForma7.ToString();
            rbPreguntaFormatoYForma8.SelectedValue = formularionAceptacion.PreguntaFormatoYForma8.ToString();
            rbPreguntaFormatoYForma9.SelectedValue = formularionAceptacion.PreguntaFormatoYForma9.ToString();
            rbPreguntaFormatoYForma10.SelectedValue = formularionAceptacion.PreguntaFormatoYForma10.ToString();
            rbPreguntaFondo1.SelectedValue = formularionAceptacion.PreguntaFondo1.ToString();
            rbPreguntaFondo2.SelectedValue = formularionAceptacion.PreguntaFondo2.ToString();
            rbPreguntaFondo3.SelectedValue = formularionAceptacion.PreguntaFondo3.ToString();
            rbPreguntaFondo4.SelectedValue = formularionAceptacion.PreguntaFondo4.ToString();
            rbPreguntaFondo5.SelectedValue = formularionAceptacion.PreguntaFondo5.ToString();
            rbPreguntaFondo6.SelectedValue = formularionAceptacion.PreguntaFondo6.ToString();
            rbPreguntaFondo7.SelectedValue = formularionAceptacion.PreguntaFondo7.ToString();
            rbPreguntaFondo8.SelectedValue = formularionAceptacion.PreguntaFondo8.ToString();
            rbPreguntaFondo9.SelectedValue = formularionAceptacion.PreguntaFondo9.ToString();
            rbPreguntaFondo10.SelectedValue = formularionAceptacion.PreguntaFondo10.ToString();
        }
    }
}