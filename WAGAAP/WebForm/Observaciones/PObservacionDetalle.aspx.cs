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
            CargaDatos_Observacion();
            RevisionEstudiante();
            FiltrarInterfazUsuario();
        }
    }

    private void RevisionEstudiante()
    {
        if (Session["UsuarioSesion"] != null)
        {
            EUsuarioSesionGAAP usuario = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            if (usuario.esEstudiante) 
            {
                cObservacion.Actualizar_GObservacion_A_EstadoObservacion(int.Parse(Session["CodigoObservacion"].ToString()), SDatosGlobales.ESTADO_REVISADO);
            }
        }
    }

    private void FiltrarInterfazUsuario()
    {
        if (Session["UsuarioSesion"] != null &&  Session["CodigoProyecto"] != null)
        {
            string codigoProyecto = Session["CodigoProyecto"].ToString();
            EUsuarioSesionGAAP usuario = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            //Editable solo si es el autor de la observacion y no es una observacion que pertenece a otra iteracion
            string codigoUsuarioObservacion = eGObservacion.CodigoUsuarioObservacion.Trim().ToUpper();
            string codigoUsuarioSesion = usuario.CodigoUsuario.Trim().ToUpper();

            if (SUtil.CorrespondeRevision(codigoProyecto, usuario.CodigoUsuario) && usuario.CodigoUsuario == codigoUsuarioObservacion)
            {
                btnEditarObservacion.Enabled = eGObservacion.EstadoObservacion == SDatosGlobales.ESTADO_ACTIVO;
                btnEditarObservacion.Visible = btnEditarObservacion.Enabled;

                btnCorregido.Enabled = eGObservacion.EstadoObservacion == SDatosGlobales.ESTADO_REVISADO;
                btnCorregido.Visible = btnCorregido.Enabled;
            }
            else
            {
                btnEditarObservacion.Enabled = btnEditarObservacion.Visible = false;
                btnCorregido.Enabled = btnCorregido.Visible = false;
            }
        }
        
    }

    private void CargaDatos_Observacion()
    {
        eGObservacion = cObservacion.Obtener_GObservacion_O_CodigoObservacion(int.Parse(Session["CodigoObservacion"].ToString()));
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

    protected void btnEditarObservacion_Click(object sender, EventArgs e)
    {        
        Response.Redirect("~/WebForm/Observaciones/PEditarObservacion.aspx");
    }

    protected void btnCorregido_Click(object sender, EventArgs e)
    {
        if(Session["CodigoObservacion"] != null)
        {
            cObservacion.Actualizar_GObservacion_A_EstadoObservacion(int.Parse(Session["CodigoObservacion"].ToString()), SDatosGlobales.ESTADO_CORREGIDO);
            Session["CodigoObservacion"] = null;
            Response.Redirect("~/WebForm/Observaciones/PListaObservacion.aspx");
        }
        
    }
}



