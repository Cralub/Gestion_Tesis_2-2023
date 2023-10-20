using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PaginaMaestra_MPNavegacion : System.Web.UI.MasterPage
{
    #region Controladores
    CUsuarioNetvalle cUsuarioNetvalle = new CUsuarioNetvalle();
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //if (Session["UsuarioSesion"] != null)
            //{
            //    EUsuarioNetvalle eUsuarioNetvalle = Session["UsuarioSesion"] as EUsuarioNetvalle;
            //    txbCodigoUsuarioSesion.Text = eUsuarioNetvalle.CodigoUsuarioNetvalle;
            //}
        }
    }
    //protected void btnCodigoUsuarioSesion_Click(object sender, EventArgs e)
    //{
    //    if (txbCodigoUsuarioSesion.Text.Trim().Length == 10)
    //    {
    //        EUsuarioNetvalle eUsuarioNetvalle = cUsuarioNetvalle.Obtener_UsuarioNetvalle_O_CodigoUsuario(txbCodigoUsuarioSesion.Text.Trim());
    //        if (eUsuarioNetvalle != null)
    //        {
    //            Session["UsuarioSesion"] = eUsuarioNetvalle;
    //        }
    //    }

    //}
    //protected void btnCrearProyecto_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("~/WebForm/Proyecto/PCrearProyecto.aspx");
    //}

    //protected void btnFormularios_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("~/WebForm/Formulario/PListarProyectosFormulario.aspx");
    //}

    //protected void btnFiltrarProyectos_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("~/WebForm/Proyecto/PListarProyectos.aspx");
    //}

    //protected void btnInformacion_Click(object sender, EventArgs e)
    //{

    //}

    //protected void btnLimpiar_Click(object sender, EventArgs e)
    //{
    //    Session.RemoveAll();
    //}


}
