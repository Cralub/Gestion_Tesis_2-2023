using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNGAAP;

public partial class WebForm_UsuarioRol_PEliminarUsuarioRol : System.Web.UI.Page
{
    #region Controladoras
    CUsuarioRol cUsuarioRol = new CUsuarioRol();
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        string codigoUsuarioRol = Request.QueryString["CodigoUsuarioRol"];
        eliminarUsuarioRol(codigoUsuarioRol);

    }

    void eliminarUsuarioRol(string codigoUsuarioRol)
    {
        int codigoUsuarioRolInt = int.Parse(codigoUsuarioRol);
        cUsuarioRol.Eliminar_GUsuarioRol_E(codigoUsuarioRolInt);
        Response.Redirect("PUsuarioRol.aspx");
    }
}