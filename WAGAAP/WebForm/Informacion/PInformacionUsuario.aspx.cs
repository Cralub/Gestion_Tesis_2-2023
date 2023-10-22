using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Usuario_PInformacionUsuario : System.Web.UI.Page
{
    #region Controladores
    
    CUsuarioNetvalle cUsuarioNetvalle = new CUsuarioNetvalle();
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["CodigoUsuario"] != null)
            {

                var usuario = cUsuarioNetvalle.Obtener_UsuarioNetvalle_O_CodigoUsuario(Session["CodigoUsuario"] as string);

                lblNombreCompleto.Text = usuario.NombresUsuarioNetvalle + " " + usuario.ApellidosUsuarioNetvalle;
                lblCarrera.Text = usuario.CarreraUsuarioNetvalle;
                lblFacultad.Text = usuario.FacultadUsuarioNetvalle;
                lblSede.Text = usuario.SedeUsuarioNetvalle;
                lblDireccion.Text = usuario.DireccionUsuarioNetvalle;
                lblDireccionTrabajo.Text = usuario.DireccionTrabajoUsuarioNetvalle;
                lblCelular.Text = usuario.CelularUsuarioNetvalle;
            }
        }
    }

    

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Session["CodigoUsuario"] = null;
        Response.Redirect("~/PaginaMaestra/Default.aspx");
    }
}