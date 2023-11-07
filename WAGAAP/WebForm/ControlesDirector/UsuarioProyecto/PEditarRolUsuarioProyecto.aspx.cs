using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNGAAP;

public partial class WebForm_Usuario_EditarRolUsuarioProyecto : System.Web.UI.Page
{
    #region Controladoras
    CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
    CUsuarioRol cUsuarioRol = new CUsuarioRol();
    CRol cRol = new CRol();
    #endregion

    public List<EGRol> eGRols= new List<EGRol>();
    public List<EGUsuarioProyecto> eGUsuarioProyecto = new List<EGUsuarioProyecto>();


    protected void Page_Load(object sender, EventArgs e)
    {
        string codigoUsuarioProyecto = Request.QueryString["CodigoUsuarioProyecto"];
        lblCodigoUsuarioProyecto.Text = codigoUsuarioProyecto;
        string codigoUsuario = Request.QueryString["CodigoUsuario"];
        lblCodigoUsuario.Text = codigoUsuario;
        string codigoRol = Request.QueryString["codigoRol"];
        string codigoProyecto = Request.QueryString["CodigoProyecto"];
        lblCodigoProyecto.Text = codigoProyecto;
        if(!IsPostBack)
        {
            cargarListaRoles(codigoRol);
        }

    }
    void cargarListaRoles(string codigoRol)
    {
        eGRols = cRol.Obtener_GRol_O().ToList();
        ddlRol.DataSource = eGRols;
        ddlRol.DataTextField = "DescripcionRol";
        ddlRol.DataValueField = "CodigoRol";
        ddlRol.DataBind();
        ddlRol.SelectedValue = codigoRol.ToString();
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        string codigoRol = ddlRol.SelectedValue;

        cUsuarioProyecto.Actualizar_GUsuarioProyecto_A(int.Parse(lblCodigoUsuarioProyecto.Text), lblCodigoProyecto.Text, lblCodigoUsuario.Text, codigoRol, char.Parse("A"));

        Response.Redirect("PUsuarioProyecto.aspx");

    }
}