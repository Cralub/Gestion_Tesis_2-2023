using SWLNGAAP;
using System;

public partial class PaginaMaestra_Default : System.Web.UI.Page
{
    #region Controladores
    CUsuarioNetvalle cUsuarioNetvalle = new CUsuarioNetvalle();
    CUsuario cUsuario = new CUsuario();
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            if (Session["UsuarioSesion"] != null)
            {
                EUsuarioNetvalle eUsuarioNetvalle = Session["UsuarioSesion"] as EUsuarioNetvalle;
                txbCodigoUsuarioSesion.Text = eUsuarioNetvalle.CodigoUsuarioNetvalle;
            }
        }
    }
    void MostrarInformacion(string codigoUsuario)
    {
        if (Session["UsuarioSesion"] != null)
        {
            EGUsuario eGUsuario = cUsuario.Obtener_GUsuario_O_CodigoUsuario(codigoUsuario);
            if (eGUsuario != null)
                lblUsuarioLogueado.Text = eGUsuario.NombreCompletoUsuario.ToString();
            else
                lblUsuarioLogueado.Text = "No usuario encontrado";
        }
    }
    protected void btnCodigoUsuarioSesion_Click(object sender, EventArgs e)
    {
        if (txbCodigoUsuarioSesion.Text.Trim().Length > 9)
        {
            //Simulacion de validacion de codigo Netvalle
            EUsuarioNetvalle eUsuarioNetvalle = cUsuarioNetvalle.Obtener_UsuarioNetvalle_O_CodigoUsuario(txbCodigoUsuarioSesion.Text.Trim());
            if (eUsuarioNetvalle != null)
            {
                Session["UsuarioSesion"] = eUsuarioNetvalle;
                MostrarInformacion(eUsuarioNetvalle.CodigoUsuarioNetvalle);
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