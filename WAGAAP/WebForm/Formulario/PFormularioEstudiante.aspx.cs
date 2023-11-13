using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using System.Web;

public partial class WebForm_Formulario_PFormularioEstudiante : System.Web.UI.Page
{
    #region Controladores
    CEtapa cEtapa = new CEtapa();
    CSubEtapa cSubEtapa = new CSubEtapa();
    CProyecto cProyecto = new CProyecto();
    CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
    CProyectoCompleja cProyectoCompleja = new CProyectoCompleja();
    #endregion
    #region Metodos privados

    private bool ValidarEntradas()
    {
        bool res = false;
        if(SUtil.ValidarSoloTextoYEspacios(txbTitulo.Text.Trim(), 10) &&
           SUtil.ValidarSoloTextoYEspacios(txbObjetivoGeneral.Text.Trim(), 10) &&
           SUtil.ValidarSoloTextoYEspacios(txbObjetivosEspecificos.Text.Trim(), 10) &&
           SUtil.ValidarSoloTextoYEspacios(txbAlcanceProyecto.Text.Trim(), 10))
           res = true;
        return res;
    }
    private bool ValidacionDeEstados(EProyectoCompleja proyecto)
    {
        bool esValido = false;
        EGEtapa eGEtapa = cEtapa.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(proyecto.CodigoProyecto, SDatosGlobales.ESTADO_ACTIVO);
        EGSubEtapa eGSubEtapa = cSubEtapa.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(eGEtapa.CodigoEtapa, SDatosGlobales.ESTADO_ACTIVO);
        esValido = cProyectoCompleja.Verificar_GProyecto_CorrespondeRevision(proyecto.CodigoRol, eGEtapa.NumeroEtapa, eGSubEtapa.NumeroSubEtapa);
        return esValido;
    }
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CargarInformacionProyecto();
            LimpiarVariables();
        }
    }

    private void CargarInformacionProyecto()
    {
        if (Session["UsuarioSesion"] != null)
        {
            EUsuarioSesionGAAP usuario = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            EProyectoCompleja proyectoCompleto = cProyectoCompleja.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(usuario.CodigoUsuario).First();
            Session["ProyectoComplejo"] = proyectoCompleto;
            lblRevision.Text = proyectoCompleto.NumeroRevisionesProyecto.ToString();
            lblCodigoProyecto.Text = proyectoCompleto.CodigoProyecto;
            txbObjetivosEspecificos.Text = proyectoCompleto.ObjetivosEspecificosProyecto;
            txbAlcanceProyecto.Text = proyectoCompleto.AlcanceProyecto;
            lkbEnlaceDocumento.Text = proyectoCompleto.EnlaceDocumentoProyecto;
            txbTitulo.Text = proyectoCompleto.TituloProyecto;
            ddlModalidades.Text = proyectoCompleto.ModalidadProyecto.ToString();
            txbObjetivoGeneral.Text = proyectoCompleto.ObjetivoGeneralProyecto;

            grvListaUsuarios.DataSource = null;

            grvListaUsuarios.DataSource = SUtil.ListarUsuariosRolesPorProyecto(proyectoCompleto.CodigoProyecto);
            grvListaUsuarios.DataBind();


            bool EsModificable = ValidacionDeEstados(proyectoCompleto);
            if (!EsModificable)
            {
                txbObjetivosEspecificos.Enabled = false;
                txbAlcanceProyecto.Enabled = false;
                ddlModalidades.Enabled = false;
                txbObjetivoGeneral.Enabled = false;
                txbTitulo.Enabled = false;
                btnAgregar.Enabled = false;
                btnAgregarDocumento.Enabled = false;
                btnAvanzar.Enabled = false;
                btnTutor.Enabled = false;
            }
        }
    }
    protected void gvListaUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        string CodigoUsuario = grvListaUsuarios.DataKeys[index].Value.ToString();

        if (e.CommandName == "btnVer")
        {
            Session["CodigoUsuario"] = CodigoUsuario;
            Session["PaginaAnterior"] = HttpContext.Current.Request.Url.PathAndQuery;
            Response.Redirect("~/WebForm/Informacion/PInformacionUsuario.aspx");
        }
    }



    public void btnAgregar_Click(object sender, EventArgs e)
    {
        if (Session["ProyectoComplejo"] != null)
        {
            EProyectoCompleja proyectoC = Session["ProyectoComplejo"] as EProyectoCompleja;
            EGProyecto proyecto = cProyecto.Obtener_GProyecto_O_CodigoProyecto(proyectoC.CodigoProyecto);          
            if (ValidarEntradas())
            {
                cProyecto.Actualizar_GProyecto_A(proyecto.CodigoProyecto,
                                                 char.Parse(ddlModalidades.SelectedValue.Trim()),
                                                 txbTitulo.Text.Trim(),
                                                 txbObjetivoGeneral.Text.Trim(),
                                                 txbObjetivosEspecificos.Text.Trim(),
                                                 txbAlcanceProyecto.Text.Trim(),
                                                 proyecto.NumeroRevisiones,
                                                 lkbEnlaceDocumento.Text.Trim()
                                                 );
            }
        }
        CargarInformacionProyecto();
    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/WebForm/Informacion/PGraficasAvance.aspx");
    }
    bool FormularioCompletoEnOrden()
    {
        EProyectoCompleja proyectoC = Session["ProyectoComplejo"] as EProyectoCompleja;
        bool esCorrectoEntradasTexto = ValidarEntradas();
        bool tieneTutor = !string.IsNullOrEmpty(proyectoC.CodigoTutor);
        bool tieneModalidadCorrecta = char.Parse(ddlModalidades.SelectedValue) != '-';

        if (esCorrectoEntradasTexto && tieneTutor && tieneModalidadCorrecta)        
            return true;        
        return false;
    }


    protected void btnAvanzar_Click(object sender, EventArgs e)
    {

        if (Session["ProyectoComplejo"] != null && FormularioCompletoEnOrden())
            cProyectoCompleja.Actualizar_Etapa_SubEtapa_AvanzarEnFlujo((Session["ProyectoComplejo"] as EProyectoCompleja).CodigoProyecto);
    }

    protected void btnTutor_Click(object sender, EventArgs e)
    {
        if (Session["ProyectoComplejo"] != null)
        {
            EProyectoCompleja proyecto = Session["ProyectoComplejo"] as EProyectoCompleja;
            bool existeTutorActivo = cUsuarioProyecto
                    .Obtener_GUsuarioProyecto_O_CodigoProyecto(proyecto.CodigoProyecto)
                    .Any(w => w.CodigoRol == SDatosGlobales.ROL_TUTOR
                    && w.EstadoUsuarioProyecto == SDatosGlobales.ESTADO_ACTIVO);
            if (!existeTutorActivo)            
                Response.Redirect("~/WebForm/Formulario/PElegirTutor.aspx");            
            else            
                lblMensajeElegirNuevoTutor.Text = string.Format("El proyecto ya posee un Tutor Confirmado");
            
        }
    }
    private void LimpiarVariables()
    {        
        Session["PaginaAnterior"] = null;
        Session["CodigoUsuario"] = null;
        lblMensajeElegirNuevoTutor.Text = string.Empty;
    }

    protected void btnAgregarDocumento_Click(object sender, EventArgs e)
    {
        
    }

    protected void btnCVTutorExterno_Click(object sender, EventArgs e)
    {
        if (Session["ProyectoComplejo"] != null)
        {
            /*Enviar codigoProyecto adjunto a CV tutor al Director*/
                
        }

    }
}