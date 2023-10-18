using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNGAAP;


public partial class WebForm_PListaObservacion : System.Web.UI.Page
{
    #region Controladores
    CObservacion cObservacion = new CObservacion();
    #endregion

    private static char TipoObservacion = 'O';
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CargarObservacionesTipo();  
        }
    }
    private void CargarObservacionesTipo()
    {
        List<EGObservacion> listaObservaciones = cObservacion.Obtener_GObservacion_O_TipoObservacion(TipoObservacion);

        grvListaObservacionesTipo.DataSource = listaObservaciones;
        grvListaObservacionesTipo.DataBind();
    }

    protected void grvListaObservacionesTipo_RowCommand(object sender, GridViewCommandEventArgs e)
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