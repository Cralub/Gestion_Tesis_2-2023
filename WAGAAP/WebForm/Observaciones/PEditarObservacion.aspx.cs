using SWLNGAAP;
using System;

public partial class WebForm_Observaciones_PEditarObservacion : System.Web.UI.Page
{
    #region Controladoras
    CObservacion cObservacion = new CObservacion();
    #endregion
    #region Metodos privados

    private bool ValidarEntradas(EGObservacion eGObservacion)
    {
        bool res = false;
        if(eGObservacion.ComentarioObservacion.Length > 10)        
            res = true;
        
        return res;
    }

    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CargarDatosObservacion();
        }
    }
    void CargarDatosObservacion()
    {
        if(Session["CodigoObservacion"] != null)
        {
            EGObservacion eGObservacion = cObservacion.Obtener_GObservacion_O_CodigoObservacion(int.Parse(Session["CodigoObservacion"].ToString()));
            if (eGObservacion.TipoObservacion == 'O') rbObservacionFondo.Checked = true; else rbObservacionForma.Checked = true;
            txtComentario.Text = eGObservacion.ComentarioObservacion;
        }
    }
    protected void btnBuscarObservacion_Click(object sender, EventArgs e)
    {
        CargarDatosObservacion();
    }
    

    protected void btnEditarObservacion_Click(object sender, EventArgs e)
    {
        if(Session["CodigoObservacion"] != null && Session["UsuarioSesion"] != null)
        {
            EGObservacion observacion = cObservacion.Obtener_GObservacion_O_CodigoObservacion(int.Parse(Session["CodigoObservacion"].ToString()));

            EUsuarioSesionGAAP usuario = Session["UsuarioSesion"] as EUsuarioSesionGAAP;

            EGObservacion eGObservacion = new EGObservacion()
            {
                CodigoObservacion = observacion.CodigoObservacion,
                CodigoProyecto = observacion.CodigoProyecto,
                CodigoSubEtapa = observacion.CodigoSubEtapa,
                CodigoUsuarioObservacion = usuario.CodigoUsuario,
                TipoObservacion = rbObservacionFondo.Checked ? 'O' : 'A',
                ComentarioObservacion = txtComentario.Text,
                EstadoObservacion = SDatosGlobales.ESTADO_ACTIVO
            };
            if (ValidarEntradas(eGObservacion))
            {
                cObservacion.Actualizar_GObservacion_A(
                    eGObservacion.CodigoObservacion,
                    eGObservacion.CodigoProyecto,
                    eGObservacion.CodigoSubEtapa,
                    eGObservacion.CodigoUsuarioObservacion,
                    eGObservacion.ComentarioObservacion,
                    eGObservacion.TipoObservacion,
                    eGObservacion.EstadoObservacion);
            }
            Session["CodigoObservacion"] = null;
            Response.Redirect("~/WebForm/Observaciones/PListaObservacion.aspx");
        }
    }
}