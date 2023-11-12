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

    private bool ValidarEntradas(EGProyecto proyecto)
    {
        bool res = true;
        
            return res;
    }
    private bool ValidacionDeEstados(EProyectoCompleja proyecto)
    {
        bool res = false;
        EGEtapa eGEtapa = cEtapa.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(proyecto.CodigoProyecto, SDatosGlobales.ESTADO_ACTIVO);
        EGSubEtapa eGSubEtapa = cSubEtapa.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(eGEtapa.CodigoEtapa, SDatosGlobales.ESTADO_ACTIVO);
        res = cProyectoCompleja.Verificar_GProyecto_CorrespondeRevision(proyecto.CodigoRol, eGEtapa.NumeroEtapa, eGSubEtapa.NumeroSubEtapa);
        return res;
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
                ddlModalidades.Enabled = false;
                txbObjetivoGeneral.Enabled = false;
                txbTitulo.Enabled = false;
                btnAgregar.Enabled = false;
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
            proyecto.ModalidadProyecto = char.Parse(ddlModalidades.SelectedValue.Trim());
            proyecto.TituloProyecto = txbTitulo.Text.Trim();
            proyecto.ObjetivoGeneralProyecto = txbObjetivoGeneral.Text.Trim();
            proyecto.ObjetivosEspecificosProyecto = txbObjetivosEspecificos.Text.Trim();
            proyecto.AlcanceProyecto = txbAlcanceProyecto.Text.Trim();
            proyecto.EnlaceDocumentoProyecto = lkbEnlaceDocumento.Text.Trim();
            proyecto.ObjetivosEspecificosProyecto = txbObjetivosEspecificos.Text.Trim();
            proyecto.AlcanceProyecto = txbAlcanceProyecto.Text.Trim();
            if (ValidarEntradas(proyecto))
            {
                cProyecto.Actualizar_GProyecto_A(proyecto.CodigoProyecto,
                                                 proyecto.ModalidadProyecto,
                                                 proyecto.TituloProyecto,
                                                 proyecto.ObjetivoGeneralProyecto,
                                                 proyecto.ObjetivosEspecificosProyecto,
                                                 proyecto.AlcanceProyecto,
                                                 proyecto.NumeroRevisiones,
                                                 proyecto.EnlaceDocumentoProyecto
                                                 );
            }
        }

    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/WebForm/Informacion/PGraficasAvance.aspx");
    }



    protected void btnAvanzar_Click(object sender, EventArgs e)
    {

        if (Session["ProyectoComplejo"] != null)
            cProyectoCompleja.Actualizar_Etapa_SubEtapa_AvanzarEnFlujo((Session["proyectoCompleja"] as EProyectoCompleja).CodigoProyecto);
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
}