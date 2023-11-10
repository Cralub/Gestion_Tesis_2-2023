using System;
using SWLNGAAP;

public partial class WebForm_PObservacionDetalle : System.Web.UI.Page
{
    #region Controladores
    CObservacion cObservacion = new CObservacion();
    EGObservacion eGObservacion = new EGObservacion();
    #endregion


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack && Session["CodigoObservacion"] != null)
        {
            CargaDatos_CodigoProyectoDetalle();
        }
    }

    private void FiltrarInterfazUsuario()
    {
        if (Session["UsuarioSesion"] != null)
        {
            EUsuarioSesionGAAP usuario = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            if (eGObservacion.CodigoUsuarioObservacion == usuario.CodigoUsuario )
                btnEditarObservacion.Enabled = true;
            else
                btnEditarObservacion.Enabled = false;

        }
        
    }

    private void CargaDatos_CodigoProyectoDetalle()
    {
        int CodigoObservacion = int.Parse(Session["CodigoObservacion"].ToString());
        eGObservacion = cObservacion.Obtener_GObservacion_O_CodigoObservacion(CodigoObservacion);
        lblObservador.Text = eGObservacion.CodigoUsuarioObservacion;
        lblTipoObservacion.Text = (eGObservacion.TipoObservacion == 'O') ? "Observacion Fondo" : "Observacion Forma";
        lblFechaRegistro.Text = eGObservacion.FechaRegistro.ToShortDateString();
        lblComentarioObservacion.Text = eGObservacion.ComentarioObservacion;
        FiltrarInterfazUsuario();
    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Session["CodigoObservacion"] = null;
        Response.Redirect("~/WebForm/Observaciones/PListaObservacion.aspx");
    }

    protected void btnEditarObservacion_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/WebForm/Observaciones/PEditarObservacion.aspx");
    }

    protected void btnCorregido_Click(object sender, EventArgs e)
    {
        Session["CodigoObservacion"] = null;
        Response.Redirect("~/WebForm/Observaciones/PListaObservacion.aspx");
    }
}



