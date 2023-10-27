using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.EnterpriseServices;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    public List<EGProyecto> eGProyecto = new List<EGProyecto>();
    public List<EGUsuarioProyecto> eGUsuarioProyecto = new List<EGUsuarioProyecto>();
    public List<EGUsuarioRol> eGUsuarioRol = new List<EGUsuarioRol>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            cargarListaRoles();
            cargarListaProyectos();
        }


    }

    protected void btnBuscarUsuarioProyecto_Click(object sender, EventArgs e)
    {
        cargarListaProyectoUsuario(txbCodigoProyecto.Text);
    }

    void cargarListaProyectoUsuario(string codigoProyecto)
    {
        eGUsuarioProyecto = cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto);
        gvListaUsuariosProyecto.DataSource = eGUsuarioProyecto;
        gvListaUsuariosProyecto.DataBind();
        
    }

    void cargarListaRoles()
    {
        List<EGRol> eGRol = cRol.Obtener_GRol_O_Todo().ToList();
        ddlListaRoles.DataSource = eGRol;
        ddlListaRoles.DataTextField = "DescripcionRol";
        ddlListaRoles.DataValueField = "CodigoRol";
        ddlListaRoles.DataBind();
    }

    void cargarListaProyectos()
    {
        eGProyecto = cProyecto.Obtener_GProyecto_O_Todo();
        ddlListaProyectos.DataSource = eGProyecto;
        ddlListaProyectos.DataTextField = "TituloProyecto";
        ddlListaProyectos.DataValueField = "CodigoProyecto";
        ddlListaProyectos.DataBind();
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        string codigoUsuario = txbCodigoUsuario.Text;
        fillUsuarios(codigoUsuario);
    }


    void fillUsuarios(string codigoUsuario)
    { 
        EGUsuario eGUsuario = cUsuario.Obtener_GUsuario_O_CodigoUsuario(codigoUsuario);
        lblNombreUsuario.Text = eGUsuario.NombreCompletoUsuario;
        lblCodigoUsuario.Text = eGUsuario.CodigoUsuario;
        
    }

    protected void ddlListaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }


    protected void ddlListaRoles_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ddlListaProyectos_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnInsertarUsuario_Click(object sender, EventArgs e)
    {
        string codigoUsuarioProyecto = txbCodigoUsuarioProyecto.Text;
        string nombreUsuario = lblNombreUsuario.Text;
        string codigoRol = ddlListaRoles.SelectedValue;
        string codigoProyecto = ddlListaProyectos.SelectedValue;
        string codigoUsuario = lblCodigoUsuario.Text;

        cUsuarioProyecto.Insertar_GUsuarioProyecto_I(int.Parse(codigoUsuarioProyecto), codigoProyecto, codigoUsuario, codigoRol, char.MaxValue);


    }
    
    protected void ddlRolesGridView_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnEditarRol_Click(object sender, EventArgs e)
    {
        

    }

    protected void gvListaUsuariosProyecto_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        

    }

    protected void gvListaUsuariosProyecto_RowCommandbtn(object sender, GridViewCommandEventArgs e)
    {
        
    }
}