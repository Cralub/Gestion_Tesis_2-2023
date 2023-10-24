using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Usuario_PEditarCelular : System.Web.UI.Page
{
    private CCelular cCelular = new CCelular();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            EGCelular celular = new EGCelular();
            celular = cCelular.Obtener_GCelular_O(int.Parse(Session["CodigoCelular"].ToString()));
            txbCodigoUsuario.Text = celular.CodigoUsuario;
            txbCodigoArea.Text = celular.CodigoAreaCelular;
            txbNumeroCelular.Text = celular.NumeroCelular.ToString();
        }
    }

    protected void btnEditarCelular_Click(object sender, EventArgs e)
    {
        cCelular.Actualizar_GCelular_A(int.Parse(Session["CodigoCelular"].ToString()), txbCodigoUsuario.Text, txbCodigoArea.Text, int.Parse(txbNumeroCelular.Text));
        Response.Redirect("PPerfilUsuario.aspx");
    }

    protected void btnEliminarCelular_Click(object sender, EventArgs e)
    {
        cCelular.Eliminar_GCelular_E(int.Parse(Session["CodigoCelular"].ToString()));
        Response.Redirect("PPerfilUsuario.aspx");
    }
}