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
            if (Session["proyectoCompleja"] != null)
            {
                CargaDatos_CodigoProyecto();
            }
               
        }

    }

    private void CargaDatos_CodigoProyecto()
    {
        EProyectoCompleja eProyectoCompleja = Session["proyectoCompleja"] as EProyectoCompleja;
        List<EGObservacion> eGObservacionList = cObservacion.Obtener_GObservacion_O_CodigoProyecto(eProyectoCompleja.CodigoProyecto).ToList();
        grvListaObservaciones.DataSource = null;
        grvListaObservaciones.DataSource = eGObservacionList;
        grvListaObservaciones.DataBind();

    }
    

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Session["proyectoCompleja"] = null;
        Response.Redirect("~/WebForm/Formulario/PListarProyectosFormulario.aspx");
    }

    protected void grvListaObservaciones_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        string CodigoObervacion = System.Net.WebUtility.HtmlDecode(grvListaObservaciones.Rows[index].Cells[0].Text);
        Session["CodigoObservacion"] = CodigoObervacion;
        if (e.CommandName == "btnVer")
        {
            Response.Redirect("PFormularioEstudiante.aspx");
        }
       
    }
}