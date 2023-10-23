using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNGAAP;

public partial class WebForm_PObservacionDetalle : System.Web.UI.Page
{
    #region Controladores
    CObservacion cObservacion = new CObservacion();
    #endregion


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["CodigoObservacion"] != null)
            {
                CargaDatos_CodigoProyectoDetalle();
            }
        }
    }

    private void CargaDatos_CodigoProyectoDetalle()
    {
        int CodigoObservacion = int.Parse(Session["CodigoObservacion"].ToString());
        EGObservacion eGObservacion = cObservacion.Obtener_GObservacion_O_CodigoObservacion(CodigoObservacion);
        lblObservador.Text = eGObservacion.CodigoUsuarioObservacion;
        lblTipoObservacion.Text = (eGObservacion.TipoObservacion == 'O') ? "Observacion Fondo" : "Observacion Forma";
        lblFechaRegistro.Text = eGObservacion.FechaRegistro.ToShortDateString();
        lblComentarioObservacion.Text = eGObservacion.ComentarioObservacion;
    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Session["CodigoObservacion"] = null;
        Response.Redirect("~/WebForm/Observaciones/PListaObservacion.aspx");

    }
}



