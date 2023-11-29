using SWLNGAAP;
using System;
using System.Linq;
using System.Web.UI.WebControls;
using System.Web;
using System.Web.UI;

public partial class WebForm_Formulario_PFormularioEstudiante : Page
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
        if (SUtil.ValidarSoloTextoYEspacio(txbTitulo.Text.Trim(), 0) &&
            SUtil.ValidarSoloTextoYEspacio(txbObjetivoGeneral.Text.Trim(), 0) &&
            SUtil.ValidarSoloTextoYEspacio(txbObjetivosEspecificos.Text.Trim(), 0) &&
            SUtil.ValidarSoloTextoYEspacio(txbAlcance.Text.Trim(), 0))
            res = true;
        return res;
    }
    private bool ValidacionDeEstados(EProyectoCompleja proyecto)
    {
        bool esValido = false;

        return esValido;
    }
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            CargarInformacionProyecto();
        }
        LimpiarVariables();
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
            txbAlcance.Text = proyectoCompleto.AlcanceProyecto;
            lkbEnlaceDocumento.Text = proyectoCompleto.EnlaceDocumentoProyecto;
            txbTitulo.Text = proyectoCompleto.TituloProyecto;
            ddlModalidades.SelectedValue = proyectoCompleto.ModalidadProyecto.ToString();
            txbObjetivoGeneral.Text = proyectoCompleto.ObjetivoGeneralProyecto;

            grvListaUsuarios.DataSource = null;

            grvListaUsuarios.DataSource = SUtil.ListarUsuariosRolesPorProyecto(proyectoCompleto.CodigoProyecto);
            grvListaUsuarios.DataBind();



            //bool EsModificable = ValidacionDeEstados(proyectoCompleto);
            if (!SUtil.CorrespondeRevision(proyectoCompleto.CodigoProyecto, usuario.CodigoUsuario))
            {
                txbObjetivosEspecificos.Enabled = false;
                txbAlcance.Enabled = false;
                ddlModalidades.Enabled = false;
                txbObjetivoGeneral.Enabled = false;
                txbTitulo.Enabled = false;
                btnActualizarInformacion.Enabled = false;
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




    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/WebForm/Informacion/PGraficasAvance.aspx");
    }
    bool FormularioCompletoEnOrden()
    {
        EProyectoCompleja proyectoC = Session["ProyectoComplejo"] as EProyectoCompleja;

        bool tieneTutor = !string.IsNullOrEmpty(proyectoC.CodigoTutor);


        if (tieneTutor)
            return true;
        return false;
    }

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        if (Session["ProyectoComplejo"] != null && Session["UsuarioSesion"] != null && FormularioCompletoEnOrden())
        {
            string codigoProyecto = (Session["ProyectoComplejo"] as EProyectoCompleja).CodigoProyecto;
            EUsuarioSesionGAAP usuario = Session["UsuarioSesion"] as EUsuarioSesionGAAP;

            var usuarioProyecto = cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto);
            var usuarioP = usuarioProyecto.Where(w => w.CodigoUsuario == usuario.CodigoUsuario).FirstOrDefault();
            cProyectoCompleja.Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(codigoProyecto, usuario.CodigoUsuario, usuarioP.CodigoRol);
            CargarInformacionProyecto();
        }
        ScriptManager.RegisterStartupScript(this, this.GetType(), "modalConfirmacion", "Close()", true);

    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "modalConfirmacion", "Close()", true);
    }
    protected void btnAvanzar_Click(object sender, EventArgs e)
    {
        var proyecto = Session["ProyectoComplejo"] as EProyectoCompleja;
        if (!string.IsNullOrEmpty(proyecto.NombreTutor))
        {
            lblModal.Text = string.Format("¿Esta seguro que quiero crear este proyecto a {0}?", proyecto.NombreTutor);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "modalConfirmacion", "Open()", true);
        }
        lblMensajeTutor.Text = "*Escoja un Tutor antes de continuar";
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
                lblMensajeTutor.Text = string.Format("El proyecto ya posee un Tutor Confirmado");

        }
    }
    private void LimpiarVariables()
    {
        Session["PaginaAnterior"] = null;
        Session["CodigoUsuario"] = null;
        lblMensajeEnlaceDocumento.Text = string.Empty;
        lblMensajeTitulo.Text = string.Empty;
        lblMensajeModalidad.Text = string.Empty;
        lblMensajeObjetivoGeneral.Text = string.Empty;
        lblMensajeObjetivosEspecificos.Text = string.Empty;
        lblMensajeAlcance.Text = string.Empty;
        lblMensajeTutor.Text = string.Empty;
    }

    protected void btnAgregarDocumento_Click(object sender, EventArgs e)
    {

    }
    protected void btnActualizarInformacion_Click(object sender, EventArgs e)
    {
        if (Session["ProyectoComplejo"] != null && Session["UsuarioSesion"] != null)
        {
            EProyectoCompleja proyectoC = Session["ProyectoComplejo"] as EProyectoCompleja;
            EGProyecto proyecto = cProyecto.Obtener_GProyecto_O_CodigoProyecto(proyectoC.CodigoProyecto);
            cProyecto.Actualizar_GProyecto_A(proyecto.CodigoProyecto,
                                                 char.Parse(ddlModalidades.SelectedValue.Trim()),
                                                 txbTitulo.Text.Trim(),
                                                 txbObjetivoGeneral.Text.Trim(),
                                                 txbObjetivosEspecificos.Text.Trim(),
                                                 txbAlcance.Text.Trim(),
                                                 proyecto.NumeroRevisionesProyecto,
                                                 lkbEnlaceDocumento.Text.Trim()
                                                 );
        }
        CargarInformacionProyecto();
    }
    protected void btnCVTutorExterno_Click(object sender, EventArgs e)
    {
        if (Session["ProyectoComplejo"] != null)
        {
            /*Enviar codigoProyecto adjunto a CV tutor al Director*/

        }

    }
}