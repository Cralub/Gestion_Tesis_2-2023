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
    CCelular cCelular = new CCelular();
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["CodigoUsuario"] != null)
            {

                var usuario = cUsuarioNetvalle.Obtener_UsuarioNetvalle_O_CodigoUsuario(Session["CodigoUsuario"] as string);

                lblNombreCompleto.Text = usuario.NombreCompletoUsuarioNetvalle;
                lblCarrera.Text = usuario.CarreraUsuarioNetvalle;
                lblFacultad.Text = usuario.FacultadUsuarioNetvalle;
                lblSede.Text = usuario.SedeUsuarioNetvalle;
                lblDireccion.Text = usuario.DireccionUsuarioNetvalle;
                lblDireccionTrabajo.Text = usuario.DireccionTrabajoUsuarioNetvalle;
                EGCelular celular = cCelular.Obtener_GCelular_O_CodigoUsuario(usuario.CodigoUsuarioNetvalle);
                lblCelular.Text = (celular != null) ? celular.NumeroCelular.ToString(): "";
            }
        }
    }

    

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Session["CodigoUsuario"] = null;
        
        if (Session["PaginaAnterior"] != null)
        {
            string paginaAnterior = Session["PaginaAnterior"].ToString();
            Session["PaginaAnterior"] = null;
            Response.Redirect(paginaAnterior);
        }
        else        
            Response.Redirect("~/PaginaMaestra/Default.aspx");
        
    }
}