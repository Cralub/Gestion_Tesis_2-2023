using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNGAAP;

public partial class WebForm_Usuario_PEliminarUsuarioProyecto : System.Web.UI.Page
{
    #region Controladoras
    CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        string codigoUsuarioProyecto = Request.QueryString["CodigoUsuarioProyecto"];
        lblMensaje.Text = codigoUsuarioProyecto;
        EliminarUsuarioProyecto(codigoUsuarioProyecto);
    }

    void EliminarUsuarioProyecto(string codigoUsuarioProyecto)
    {
        int codigoUsuarioProyectoInt = int.Parse(codigoUsuarioProyecto);
        cUsuarioProyecto.Eliminar_GUsuarioProyecto_E(codigoUsuarioProyectoInt);
        Response.Redirect("PUsuarioProyecto.aspx");
    }
}