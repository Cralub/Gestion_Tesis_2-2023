using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNGAAP;

public partial class WebForm_UsuarioRol_PEditarUsuarioRol : System.Web.UI.Page
{
    #region Controladoras
        CUsuarioRol cUsuarioRol = new CUsuarioRol();
        CRol cRol = new CRol();
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillRoleDropDown();
            string codigoUsuarioRol = Request.QueryString["CodigoUsuarioRol"];
            string codigoUsuario = Request.QueryString["CodigoUsuario"];
            string codigoRol = Request.QueryString["CodigoRol"];
            txbIdUsuarioRol.Text = codigoUsuarioRol;
            txbIdUsuario.Text = codigoUsuario;
            ddlUsuarioRol.SelectedValue = codigoRol;
        }
    }

    void fillRoleDropDown()
    {
        List<EGRol> listaRoles = cRol.Obtener_GRol_O().ToList();
        ddlUsuarioRol.DataSource = listaRoles;
        ddlUsuarioRol.DataTextField = "DescripcionRol";
        ddlUsuarioRol.DataValueField = "CodigoRol";
        ddlUsuarioRol.DataBind();

    }



    protected void btnEditar_Click(object sender, EventArgs e)
    {
        string codigoUsuarioRol = txbIdUsuarioRol.Text;
        string codigoUsuario = txbIdUsuario.Text;
        string codigoRol = ddlUsuarioRol.SelectedValue;
        cUsuarioRol.Actualizar_GUsuarioRol_A(codigoUsuario, codigoRol, int.Parse(codigoUsuarioRol));
        Response.Redirect("PListarUsuarioRol.aspx");
    }



    protected void ddlUsuarioRol_SelectedIndexChanged(object sender, EventArgs e)
    {


    }
}