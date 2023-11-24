using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Proyecto_PVerProyecto : System.Web.UI.Page
{
    #region Contructores
    CProyecto cProyecto = new CProyecto();
    CRol cRol = new CRol();
    CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
    CUsuario cUsuario = new CUsuario();
    CProyectoCompleja cProyectoCompleja = new CProyectoCompleja();
    #endregion
    EGProyecto eGProyecto = new EGProyecto();
    List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack && Session["UsuarioSesion"] != null)
        {
            LimpiarVariables();
            CargarDatos();
            FiltrarInterfazUsuario();
        }
    }

    private void CargarDatos()
    {
        if (Session["CodigoProyecto"] != null)
        {
            string codigoProyecto = Session["CodigoProyecto"].ToString();
            eGProyecto = cProyecto.Obtener_GProyecto_O_CodigoProyecto(codigoProyecto);


            switch (eGProyecto.ModalidadProyecto)
            {
                case SDatosGlobales.CHAR_MODALIDAD_TESIS:
                    lblModalidad.Text = SDatosGlobales.STRING_MODALIDAD_TESIS;
                    break;
                case SDatosGlobales.CHAR_MODALIDAD_PROYECTO_DE_GRADO:
                    lblModalidad.Text = SDatosGlobales.STRING_MODALIDAD_PROYECTO_DE_GRADO;
                    break;
                case SDatosGlobales.CHAR_MODALIDAD_TRABAJO_DIRIGIDO:
                    lblModalidad.Text = SDatosGlobales.STRING_MODALIDAD_TRABAJO_DIRIGIDO;
                    break;
                default:
                    lblModalidad.Text = "Desconocida";
                    break;
            }
            lblCodigoProyecto.Text = eGProyecto.CodigoProyecto;
            lblRevision.Text = eGProyecto.NumeroRevisionesProyecto.ToString();
            lblTitulo.Text = eGProyecto.TituloProyecto;
            lblObjetivoGeneral.Text = eGProyecto.ObjetivoGeneralProyecto;
            lblObjetivosEspecificos.Text = eGProyecto.ObjetivosEspecificosProyecto;
            lblAlcance.Text = eGProyecto.AlcanceProyecto;
            lkbEnlaceDocumento.Text = eGProyecto.EnlaceDocumentoProyecto;

            grvListaUsuarios.DataSource = null;
            grvListaUsuarios.DataSource = SUtil.ListarUsuariosRolesPorProyecto(codigoProyecto);
            grvListaUsuarios.DataBind();
        }
    }
    private void FiltrarInterfazUsuario()
    {
        if (Session["UsuarioSesion"] != null && Session["CodigoProyecto"] != null)
        {
            EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            string codigoProyecto = Session["CodigoProyecto"].ToString();
            if (usuarioSesion.Roles.Any(rol => rol == SDatosGlobales.ROL_TUTOR))
            {
                List<EGUsuarioProyecto> eGUsuarioProyecto = cUsuarioProyecto
                                                                .Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto)
                                                                .Where(w => w.CodigoRol == SDatosGlobales.ROL_TUTOR)
                                                                .ToList();

                if (eGUsuarioProyecto.Count > 0)
                {
                    bool esTutorConfirmado = eGUsuarioProyecto.First().EstadoUsuarioProyecto == SDatosGlobales.ESTADO_ACTIVO;
                    btnAceptarTutoria.Enabled = !esTutorConfirmado;
                    btnAceptarTutoria.Visible = !esTutorConfirmado;
                }

            }
            bool correspondeRevision = SUtil.CorrespondeRevision(codigoProyecto, usuarioSesion.CodigoUsuario);
            btnDevolver.Enabled = correspondeRevision;
            btnDevolver.Visible = correspondeRevision;

            btnAvanzar.Enabled = correspondeRevision;
            btnAvanzar.Visible = correspondeRevision;
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
        Response.Redirect("~/WebForm/Proyecto/PListarProyectos.aspx");
    }
    private void LimpiarVariables()
    {
        Session["PaginaAnterior"] = null;
    }

    protected void btnDevolver_Click(object sender, EventArgs e)
    {
        PrepararModalConfirmacion("¿Devolver el Formulario al Estudiante?", false, true, false);
    }

    protected void btnAceptarTutoria_Click(object sender, EventArgs e)
    {
        PrepararModalConfirmacion("¿Aceptar la tutoría del proyecto?", false, false, true);
    }

    protected void btnAvanzar_Click(object sender, EventArgs e)
    {
        PrepararModalConfirmacion("¿Está conforme con el desarrollo del proyecto?", true, false, false);
    }
    private void PrepararModalConfirmacion(string mensaje, bool mostrarAvance, bool mostrarDevolucion, bool mostrarTutoria)
    {
        lblMensajeConfirmacionModal.Text = mensaje;
        ScriptManager.RegisterStartupScript(this, this.GetType(), "ModalConfirmacionMultiple", "Open()", true);
        btnConfirmarAvance.Visible = mostrarAvance;
        btnConfirmarAvance.Enabled = mostrarAvance;
        btnConfirmarDevolucion.Visible = mostrarDevolucion;
        btnConfirmarDevolucion.Enabled = mostrarDevolucion;
        btnConfirmarTutoria.Enabled = mostrarTutoria;
        btnConfirmarTutoria.Visible = mostrarTutoria;
    }

    protected void btnConfirmarTutoria_Click(object sender, EventArgs e)
    {
        if (Session["UsuarioSesion"] != null && Session["CodigoProyecto"] != null)
        {
            string codigoProyecto = Session["CodigoProyecto"].ToString();
            EGUsuarioProyecto eGUsuarioProyecto = cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto).Where(w => w.CodigoRol == SDatosGlobales.ROL_TUTOR).FirstOrDefault();

            EUsuarioSesionGAAP eUsuarioSesionGAAP = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            cUsuarioProyecto.Actualizar_GUsuarioProyecto_A(eGUsuarioProyecto.CodigoUsuarioProyecto, codigoProyecto, eUsuarioSesionGAAP.CodigoUsuario, SDatosGlobales.ROL_TUTOR, SDatosGlobales.ESTADO_ACTIVO);
            CargarDatos();
            FiltrarInterfazUsuario();
        }
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Close()", true);
    }
    protected void btnConfirmarDevolucion_Click(object sender, EventArgs e)
    {
        if (Session["CodigoProyecto"] != null && Session["UsuarioSesion"] != null)
        {
            string codigoProyecto = Session["CodigoProyecto"].ToString();
            EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            var lstUsuarioProyecto = cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto);
            var codigoRol = lstEGUsuarioProyecto.FirstOrDefault(rol => rol.CodigoUsuario == usuarioSesion.CodigoUsuario).CodigoRol;

            cProyectoCompleja.Actualizar_Etapa_SubEtapa_SaltarASubEtapa(codigoProyecto, usuarioSesion.CodigoUsuario, codigoRol, (byte)1);
        }
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Close()", true);
        Response.Redirect("~/WebForm/Proyecto/PListarProyectos.aspx");
    }
    protected void btnConfirmarAvance_Click(object sender, EventArgs e)
    {
        if (Session["CodigoProyecto"] != null && Session["UsuarioSesion"] != null)
        {
            string codigoProyecto = Session["CodigoProyecto"].ToString();
            EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            var lstUsuarioProyecto = cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto);
            var codigoRol = lstEGUsuarioProyecto.FirstOrDefault(rol => rol.CodigoUsuario == usuarioSesion.CodigoUsuario).CodigoRol;
            cProyectoCompleja.Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(codigoProyecto, usuarioSesion.CodigoUsuario, codigoRol);
        }
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Close()", true);
        Response.Redirect("~/WebForm/Proyecto/PListarProyectos.aspx");
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Close()", true);
    }

}