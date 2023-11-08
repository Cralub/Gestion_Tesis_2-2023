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
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            FiltrarInterfazUsuario();
        }
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
        if (txbCodigoUsuarioSesion.Text.Trim().Length > 9)
        {
            EUsuarioNetvalle eUsuarioNetvalle = cUsuarioNetvalle.Obtener_UsuarioNetvalle_O_CodigoUsuario(txbCodigoUsuarioSesion.Text);

            if (eUsuarioNetvalle != null)
            {
                EGUsuario eGUsuario = cUsuario.Obtener_GUsuario_O_CodigoUsuario(eUsuarioNetvalle.CodigoUsuarioNetvalle);
                List<EGUsuarioRol> rolesEnSistema = cUsuarioRol.Obtener_GUsuarioRol_O_CodigoUsuario(eUsuarioNetvalle.CodigoUsuarioNetvalle);
                bool esEstudiante = rolesEnSistema.Any(w => w.CodigoRol == SDatosGlobales.ROL_ESTUDIANTE);
                
                EUsuarioSesionGAAP usuarioSesion = new EUsuarioSesionGAAP(eGUsuario, rolesEnSistema.Select(s => s.CodigoRol).ToList(), esEstudiante);
                Session["UsuarioSesion"] = usuarioSesion;
                MostrarInformacion();
                FiltrarInterfazUsuario();
            }
        }

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

    }
}