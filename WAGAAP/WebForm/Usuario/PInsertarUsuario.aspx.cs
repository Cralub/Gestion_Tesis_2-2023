using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNGAAP;



public partial class WebForm_Usuario_PInsertarUsuario : System.Web.UI.Page
{
    #region Controladoras
    CUsuario cUsuario = new CUsuario();
    CRol cRol = new CRol();
    CProyecto cProyecto = new CProyecto();
    CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
    CUsuarioRol cUsuarioRol = new CUsuarioRol();
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillRoleDropDown();
            fillProjectDropDown();
        }

    }

    void fillRoleDropDown()
    {
        List<EGRol> listaRoles = cRol.Obtener_GRol_O_Todo().ToList();
        ddlRoles.DataSource = listaRoles;
        ddlRoles.DataTextField = "DescripcionRol";
        ddlRoles.DataValueField = "CodigoRol";
        ddlRoles.DataBind();
    }

    void fillProjectDropDown()
    {
        List<EGProyecto> listaProyectos = cProyecto.Obtener_GProyecto_O_Todo().ToList();
        ddlProyectos.DataSource = listaProyectos;
        ddlProyectos.DataTextField = "NombreProyecto";
        ddlProyectos.DataValueField = "TituloProyecto";
        ddlProyectos.DataBind();
    }

    protected void btnInsertar_Click(object sender, EventArgs e)
    {
        string codigoUsuario = txbCodigoUsuario.Text;
        string nombreCompleto = txbNombres.Text + " " + txbApellidos.Text;
        string sedeUsuario = txbSede.Text;
        cUsuario.Insertar_GUsuario_I(codigoUsuario, nombreCompleto, sedeUsuario);
        string codigoRol = ddlRoles.SelectedValue;
        string codigoUsuarioRol = txbCodigoUsuarioRol.Text;
        cUsuarioRol.Insertar_GUsuarioRol_I(int.Parse(codigoUsuarioRol),codigoUsuario, codigoRol);
        string codigoUsuarioProyecto = txbCodigoUsuarioProyecto.Text;
        string tituloProyecto = ddlProyectos.SelectedValue;
        string estadoUsuarioProyecto = txbEstadoUsuarioProyecto.Text;
        cUsuarioProyecto.Insertar_GUsuarioProyecto_I(int.Parse(codigoUsuarioProyecto), tituloProyecto, codigoUsuario, codigoRol, char.Parse(estadoUsuarioProyecto));
        Response.Redirect("PListarUsuarioCodigo.aspx");

    }

    protected void ddlRoles_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    protected void ddlProyectos_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
}