using SWLNGAAP;
using System;

public partial class WebForm_Usuario_PInformacionUsuario : System.Web.UI.Page
{
    #region Controladores
    CUsuarioNetvalle cUsuarioNetvalle = new CUsuarioNetvalle();
    CCelular cCelular = new CCelular();
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["CodigoUsuario"] != null && Session["UsuarioSesion"] != null)
            {
                CargarInformacionUsuario();
            }
            LimpiarVariables();
        }
    }
    void CargarInformacionUsuario()
    {
        var usuario = cUsuarioNetvalle.Obtener_UsuarioNetvalle_O_CodigoUsuario(Session["CodigoUsuario"] as string);

        lblNombreCompleto.Text = usuario.NombreCompletoUsuarioNetvalle;
        lblCarrera.Text = usuario.CarreraUsuarioNetvalle;
        lblFacultad.Text = usuario.FacultadUsuarioNetvalle;
        lblSede.Text = usuario.SedeUsuarioNetvalle;
        lblDireccion.Text = usuario.DireccionUsuarioNetvalle;
        lblDireccionTrabajo.Text = usuario.DireccionTrabajoUsuarioNetvalle;
        EGCelular celular = cCelular.Obtener_GCelular_O_CodigoUsuario(usuario.CodigoUsuarioNetvalle);
        lblCelular.Text = (celular != null) ? celular.NumeroCelular.ToString() : "";
        if (Session["UsuarioSesion"] != null)
        {
            EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            btnEditaCelular.Enabled = usuarioSesion.CodigoUsuario == usuario.CodigoUsuarioNetvalle;
            btnEditaCelular.Visible = btnEditaCelular.Enabled;
        }
            
    }
    void LimpiarVariables()
    {
        Session["Celular"] = null;

    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        if (Session["UsuarioSesion"] != null)
        {
            EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            Session["CodigoUsuario"] = null;

            if (Session["PaginaAnterior"] != null)
            {
                string paginaAnterior = Session["PaginaAnterior"].ToString();
                Session["PaginaAnterior"] = null;
                Response.Redirect(paginaAnterior);
            }
            else if(usuarioSesion.esEstudiante)
                Response.Redirect("~/WebForm/Informacion/PGraficasAvance.aspx");
            else
                Response.Redirect("~/WebForm/Proyecto/PListarProyectosRevision.aspx");

        }
    }

    protected void btnEditaCelular_Click(object sender, EventArgs e)
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