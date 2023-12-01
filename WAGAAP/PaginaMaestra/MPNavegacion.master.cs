using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public partial class PaginaMaestra_MPNavegacion : System.Web.UI.MasterPage
{
    #region Controladores
    CUsuarioNetvalle cUsuarioNetvalle = new CUsuarioNetvalle();
    CUsuario cUsuario = new CUsuario();
    CUsuarioRol cUsuarioRol = new CUsuarioRol();
    CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
    CCelular cCelular = new CCelular();
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
        }
        FiltrarInterfazUsuario();
    }

    private void FiltrarInterfazUsuario()
    {
        if (Session["UsuarioSesion"] != null)
        {
            EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            bool esDirector = usuarioSesion.Roles.Any(rol => rol == SDatosGlobales.ROL_DIRECTOR);
            pnlObservaciones.Visible = usuarioSesion.esEstudiante;
            pnlRevision.Visible = !pnlObservaciones.Visible;
            pnlInicio.Visible = true;
            pnlProyecto.Visible = true;
            pnlOpcionesDirector.Visible = esDirector;
        }
        else
        {
            pnlProyecto.Visible = false;
            pnlObservaciones.Visible=false;
            pnlInicio.Visible = false;
            pnlRevision.Visible=false;
            pnlOpcionesDirector.Visible=false;
        }
    }
    protected void lkbInicio_Click(object sender, EventArgs e)
    {
        if (Session["UsuarioSesion"] != null)
        {
            EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            if (usuarioSesion.esEstudiante)
            {
                Response.Redirect("~/WebForm/Informacion/PGraficasAvance.aspx");
            }
            else
            {
                Response.Redirect("~/WebForm/Proyecto/PListarProyectosRevision.aspx");
            }
        }
    }

    protected void lkbProyecto_Click(object sender, EventArgs e)
    {
        if (Session["UsuarioSesion"] != null)
        {
            EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            if (usuarioSesion.esEstudiante)
            {
                Response.Redirect("~/WebForm/Formulario/PFormularioEstudiante.aspx");
            }
            else
            {
                Response.Redirect("~/WebForm/Proyecto/PListarProyectos.aspx");
            }
        }
                
    }

    protected void lkbObservacion_Click(object sender, EventArgs e)
    {
        if (Session["UsuarioSesion"] != null)
        {
            EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            if (usuarioSesion.esEstudiante)
            {
                Response.Redirect("~/WebForm/Observaciones/PListaObservacion.aspx");
            }
            else
            {

            }
        }
    }

    protected void lkbRevision_Click(object sender, EventArgs e)
    {
        if (Session["UsuarioSesion"] != null)
        {
            EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            if (usuarioSesion.esEstudiante)
            {
                Response.Redirect("~/WebForm/Observaciones/PListaObservacion.aspx");
            }
            else
            {
                Response.Redirect("~/WebForm/Proyecto/PListarProyectosRevision.aspx");
            }
        }
    }
    protected void lkbUsuarioLogueado_Click(object sender, EventArgs e)
    {
        if (Session["UsuarioSesion"] != null)
        {
            EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            Session["CodigoUsuario"] = usuarioSesion.CodigoUsuario;
            Response.Redirect("~/WebForm/Informacion/PInformacionUsuario.aspx");
        }
    }
    protected void lkbOpcionesDirector_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/WebForm/ControlesDirector/PMenuOpcionesDirector.aspx");
    }
    protected void lkbConfiguracion_Click(object sender, EventArgs e)
    {
        //Configuraciones de la app
    }

    protected void lkbAyuda_Click(object sender, EventArgs e)
    {
        //Ayuda de la app
    }

    protected void lkbCerrarSesion_Click(object sender, EventArgs e)
    {
        Session["CorrespondeRevision"] = null;
        Session["PaginaAnterior"] = null;
        Session["CodigoProyecto"] = null;
        Session["UsuarioSesion"] = null;
        Response.Redirect("~/PaginaMaestra/Default.aspx");
    }
}
