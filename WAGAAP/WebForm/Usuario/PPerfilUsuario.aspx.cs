using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 
public partial class WebForm_Usuario_PPerfilUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SSesion.CodigoUsuario = "ADMIN"; // Se carga en el inicio de sesión
            SSesion.CodigoCelular = 1;
            txbNumeroCelular.Text = "76980976";
            if (txbNumeroCelular.Text.Equals(string.Empty))
            {
                btnNuevo.Visible = true;
                btnEditar.Visible = false;
            }
            else
            {
                btnNuevo.Visible = false;
                btnEditar.Visible = true;
            }
        }
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        Response.Redirect("PEditarCelular.aspx");
    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        Response.Redirect("PAgregarCelular.aspx");
    }
}