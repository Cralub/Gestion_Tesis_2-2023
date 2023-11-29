using SWLNGAAP;
using System;

public partial class WebForm_Observaciones_PCrearObservacion : System.Web.UI.Page
{
    #region Controladoras
    CObservacion cObservacion = new CObservacion();
    CEtapa cEtapa = new CEtapa();
    CSubEtapa cSubEtapa = new CSubEtapa();
    #endregion
    #region Metodos privados
    private bool ValidarEntradas(EGObservacion eGObservacion)
    {
        bool res = false;
        if (eGObservacion.ComentarioObservacion.Length > 10)
            res = true;

        return res;
    }

    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCrearObservacion_Click(object sender, EventArgs e)
    {
        if (Session["UsuarioSesion"] != null && Session["CodigoProyecto"] != null)
        {
            EUsuarioSesionGAAP usuario = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            string codigoProyecto = Session["CodigoProyecto"].ToString();
            EGEtapa etapa = cEtapa.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto, SDatosGlobales.ESTADO_ACTIVO);
            EGSubEtapa subEtapa = cSubEtapa.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(etapa.CodigoEtapa, SDatosGlobales.ESTADO_ACTIVO);
            
            EGObservacion eGObservacion = new EGObservacion()
            {
                CodigoObservacion = cObservacion.Obtener_GObsevacion_O_SiguienteCodigoObservacion(),
                CodigoProyecto = codigoProyecto,
                CodigoSubEtapa = subEtapa.CodigoSubEtapa,
                CodigoUsuarioObservacion = usuario.CodigoUsuario,
                TipoObservacion = rbObservacionFondo.Checked ? 'O' : 'A',
                ComentarioObservacion = txbComentario.Text,
                EstadoObservacion = SDatosGlobales.ESTADO_ACTIVO
            };
            if (ValidarEntradas(eGObservacion))
            {
                cObservacion.Insertar_GObservacion_I(
                    eGObservacion.CodigoObservacion,
                    eGObservacion.CodigoProyecto,
                    eGObservacion.CodigoSubEtapa,
                    eGObservacion.CodigoUsuarioObservacion,
                    eGObservacion.ComentarioObservacion,
                    eGObservacion.TipoObservacion,
                    eGObservacion.EstadoObservacion);
            }
        }
        Response.Redirect("~/WebForm/Observaciones/PListaObservacion.aspx");
    }
}