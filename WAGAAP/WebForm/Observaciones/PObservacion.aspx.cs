using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNGAAP;

public partial class WebForm_Observaciones_PObservacion : System.Web.UI.Page
{
    #region Controladores
    CObservacion cObservacion = new CObservacion();
    #endregion

    private static int CodigoObservacion = 1;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CargarObservacionesTipo();
        }
    }
    private void CargarObservacionesTipo()
    {
        EGObservacion Observaciones = cObservacion.Obtener_GObservacion_O_CodigoObservacion(CodigoObservacion);

        lblComentarioObservacion.Text = Observaciones.ComentarioObservacion.ToString();
        lblTipoObservacion.Text = Observaciones.TipoObservacion.ToString();
        lblEstadoObservacion.Text = Observaciones.EstadoObservacion.ToString();
    }

    protected void grvObservaciones_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        {
            Response.Redirect("PFormularioEstudiante.aspx");
        }
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Session["proyectoCompleja"] = null;
        Response.Redirect("~/WebForm/Formulario/PListarProyectosFormulario.aspx");
    }
}