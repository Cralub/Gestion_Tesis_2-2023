using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNGAAP;

public partial class WebForm_Usuario_Default : System.Web.UI.Page
{
    #region Controladoras
    CUsuarioRol cUsuarioRol = new CUsuarioRol();
    #endregion
    public static List<EGUsuarioRol> listaUsuarioRol = new List<EGUsuarioRol>();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    void cargarListaUsuarioRol()
    {
        string codigoUsuario = txtCodigoUsuarioRol.Text;
        listaUsuarioRol = cUsuarioRol.Obtener_GUsuarioRol_O_CodigoUsuario(codigoUsuario).ToList();
        gvListaUsuarioRol.DataSource = listaUsuarioRol;
        gvListaUsuarioRol.DataBind();


    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        cargarListaUsuarioRol();
        gvListaUsuarioRol.DataBind();
    }
}