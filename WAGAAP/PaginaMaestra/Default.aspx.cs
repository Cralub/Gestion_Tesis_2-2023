using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

public partial class PaginaMaestra_Default : System.Web.UI.Page
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
            LimpiarVariables();
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
                else
                {
                    Response.Redirect("~/WebForm/Proyecto/PListarProyectosRevision.aspx");
                }
                MostrarInformacion();
                
            }
        }

    }

    private void AccederInterfazEstudiante(EUsuarioSesionGAAP usuarioSesion)
    {
        List<EGUsuarioProyecto> proyectoEstudiante = cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoUsuario(usuarioSesion.CodigoUsuario);
        if (proyectoEstudiante != null)
        {
            Session["CodigoProyecto"] = proyectoEstudiante.First().CodigoProyecto;
            //Session["PaginaAnterior"]= HttpContext.Current.Request.Url.PathAndQuery;
            Response.Redirect("~/WebForm/Informacion/PGraficasAvance.aspx");
        }
        else
            lblUsuarioLogueado.Text = string.Format("Estudiante: {0} contactese con su director de carrera ", usuarioSesion.NombreCompleto);
    }   

    protected void btnLimpiar_Click(object sender, EventArgs e)
    {
        LimpiarVariables();
        lblUsuarioLogueado.Text = string.Empty;
    }

    
    private void LimpiarVariables()
    {
        Session.Clear();
        Session.Abandon();
    }   

    protected void btnCelularInfo_Click(object sender, EventArgs e)
    {
        if (Session["UsuarioSesion"] != null)
        {
            EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            EGCelular celular = cCelular.Obtener_GCelular_O_CodigoUsuario(usuarioSesion.CodigoUsuario);
            if (celular != null)
            {
                Session["Celular"] = celular;
                Response.Redirect("~/WebForm/Usuario/PEditarCelular.aspx");
            }
            else
            {
                Response.Redirect("~/WebForm/Usuario/PAgregarCelular.aspx");
            }
        }
    }
}