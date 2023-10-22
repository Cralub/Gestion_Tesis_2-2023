using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNGAAP;

public partial class WebForm_Usuario_PListarUsuarioCodigo : System.Web.UI.Page
{
    #region Controladoras
    CUsuario cUsuario = new CUsuario();
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        string codigoUsuario = txbCodigoUsuario.Text;
        EGUsuario eGUsuario = cUsuario.Obtener_GUsuario_O_CodigoUsuario(codigoUsuario);
        gvListaUsuarios.DataSource = eGUsuario;
        gvListaUsuarios.DataBind();

    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        Response.Redirect("PInsertarUsuario.aspx");
    }
}