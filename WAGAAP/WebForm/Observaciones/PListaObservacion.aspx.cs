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

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CargarObservacionesTipo();
        }
        Session["CodigoProyecto"] = "GP123";
    }
    
    private void CargarObservacionesTipo()
    {
        if (Session["CodigoProyecto"] != null)
        {
            string codigoProyecto = Session["CodigoProyecto"].ToString();
            List<EGObservacion> listaObservaciones = cObservacion.Obtener_GObservacion_O_CodigoProyecto(codigoProyecto);
            gvListaObservaciones.DataSource = listaObservaciones;
            gvListaObservaciones.DataBind();
        }
    }
    protected void grvListaObservaciones_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        string CodigoObservacion = gvListaObservaciones.DataKeys[index].Value.ToString();
        if (e.CommandName == "btnVer")
        {
            Session["CodigoObservacion"] = CodigoObservacion;
            Response.Redirect("PObservacionDetalle.aspx");
        }
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Session["proyectoCompleja"] = null;
        Response.Redirect("~/WebForm/Formulario/PListarProyectosFormulario.aspx");
    }
}