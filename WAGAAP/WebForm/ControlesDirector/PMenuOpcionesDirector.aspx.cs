using System;

public partial class WebForm_ControlesDirector_PMenuOpcionesDirector : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCrearProyecto_Click(object sender, EventArgs e)
    {
        if (Session["UsuarioSesion"] != null)
            Response.Redirect("~/WebForm/Proyecto/PCrearProyecto.aspx");
    }

    protected void btnTutorExterno_Click(object sender, EventArgs e)
    {
        if (Session["UsuarioSesion"] != null)
            Response.Redirect("~/WebForm/ControlesDirector/TutorExterno/PListarTutoresExternos.aspx");
    }

    protected void btnUsuarioProyecto_Click(object sender, EventArgs e)
    {
        if (Session["UsuarioSesion"] != null)
            Response.Redirect("~/WebForm/ControlesDirector/UsuarioProyecto/PListarUsuariosProyecto.aspx");
    }
}