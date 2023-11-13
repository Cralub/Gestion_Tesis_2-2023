using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PaginaMaestra_Default : System.Web.UI.Page
{
    #region Controladores
    CUsuarioNetvalle cUsuarioNetvalle = new CUsuarioNetvalle();
    CUsuario cUsuario = new CUsuario();
    CUsuarioRol cUsuarioRol = new CUsuarioRol();
    CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
    bool estaLogueado = false;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LimpiarVariables();
            FiltrarInterfazUsuario();
        }
    }
    
    void MostrarInformacion()
    {
        if (Session["UsuarioSesion"] != null)
        {
            EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            if (usuarioSesion != null)
                lblUsuarioLogueado.Text = usuarioSesion.NombreCompleto;
            else
                lblUsuarioLogueado.Text = "No usuario encontrado";
        }
    }
    protected void btnCodigoUsuarioSesion_Click(object sender, EventArgs e)
    {
        if (txbCodigoUsuarioSesion.Text.Trim().Length > 4)
        {
            EUsuarioNetvalle eUsuarioNetvalle = cUsuarioNetvalle.Obtener_UsuarioNetvalle_O_CodigoUsuario(txbCodigoUsuarioSesion.Text);

            if (eUsuarioNetvalle != null)
            {
                EGUsuario eGUsuario = cUsuario.Obtener_GUsuario_O_CodigoUsuario(eUsuarioNetvalle.CodigoUsuarioNetvalle);
                List<EGUsuarioRol> rolesEnSistema = cUsuarioRol.Obtener_GUsuarioRol_O_CodigoUsuario(eUsuarioNetvalle.CodigoUsuarioNetvalle);
                bool esEstudiante = rolesEnSistema.Any(w => w.CodigoRol == SDatosGlobales.ROL_ESTUDIANTE);
                
                EUsuarioSesionGAAP usuarioSesion = new EUsuarioSesionGAAP(eGUsuario, rolesEnSistema.Select(s => s.CodigoRol).ToList(), esEstudiante);
                Session["UsuarioSesion"] = usuarioSesion;
                if (usuarioSesion.esEstudiante)
                {
                    AccederInterfazEstudiante(usuarioSesion);
                }


                MostrarInformacion();
                FiltrarInterfazUsuario();
            }
        }

    }

    private void AccederInterfazEstudiante(EUsuarioSesionGAAP usuarioSesion)
    {
        List<EGUsuarioProyecto> proyectoEstudiante = cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoUsuario(usuarioSesion.CodigoUsuario);
        if (proyectoEstudiante != null)
        {
            Session["CodigoProyecto"] = proyectoEstudiante.First().CodigoProyecto;
            Session["PaginaAnterior"]= HttpContext.Current.Request.Url.PathAndQuery;
            Response.Redirect("~/WebForm/Informacion/PGraficasAvance.aspx");
        }
        else
            lblUsuarioLogueado.Text = string.Format("Estudiante: {0} contactese con su director de carrera ", usuarioSesion.NombreCompleto);
    }

    protected void btnCrearProyecto_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/WebForm/Proyecto/PCrearProyecto.aspx");
    }

    protected void btnFormularios_Click(object sender, EventArgs e)
    {
        if (Session["UsuarioSesion"] != null)        
            Response.Redirect("~/WebForm/Proyecto/PListarProyectosRevision.aspx");
        
    }

    protected void btnFiltrarProyectos_Click(object sender, EventArgs e)
    {
        if (Session["UsuarioSesion"] != null)        
            Response.Redirect("~/WebForm/Proyecto/PListarProyectos.aspx");
    }

    protected void btnInformacion_Click(object sender, EventArgs e)
    {

    }

    protected void btnLimpiar_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        lblUsuarioLogueado.Text = string.Empty;
    }

    protected void btnTutorExterno_Click(object sender, EventArgs e)
    {
        if (Session["UsuarioSesion"] != null)
            Response.Redirect("~/WebForm/ControlesDirector/TutorExterno/PListarTutoresExternos.aspx");
    }
    private void LimpiarVariables()
    {
        Session["CorrespondeRevision"] = null;
        Session["PaginaAnterior"] = null;
        Session["CodigoProyecto"] = null;
        Session["UsuarioSesion"] = null;
    }
    void FiltrarInterfazUsuario()
    {
        if (Session["UsuarioSesion"] != null)
        {
            EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;

            btnCrearProyecto.Enabled = !usuarioSesion.esEstudiante;
            btnCrearProyecto.Visible = !usuarioSesion.esEstudiante;

            btnFiltrarProyectos.Enabled = !usuarioSesion.esEstudiante;
            btnFiltrarProyectos.Visible = !usuarioSesion.esEstudiante;

            btnTutorExterno.Enabled = !usuarioSesion.esEstudiante;
            btnTutorExterno.Visible = !usuarioSesion.esEstudiante;

            btnFormularios.Enabled = !usuarioSesion.esEstudiante;
            btnFormularios.Visible = !usuarioSesion.esEstudiante;
        }
        else
        {
            btnCrearProyecto.Enabled = false;
            btnCrearProyecto.Visible = false;

            btnFiltrarProyectos.Enabled = false;
            btnFiltrarProyectos.Visible = false;

            btnTutorExterno.Enabled = false;
            btnTutorExterno.Visible = false;

            btnInformacion.Enabled = false;
            btnInformacion.Visible = false;

            btnFormularios.Enabled = false;
            btnFormularios.Visible = false;
        }


    }
}