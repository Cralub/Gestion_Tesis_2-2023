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
    CRol cRol = new CRol();
    #endregion
    public static List<EGUsuarioRol> listaUsuarioRol = new List<EGUsuarioRol>();
    public static List<EGRol> listaRol = new List<EGRol>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            cargarListaRoles();
        }
    }

    void cargarListaRoles()
    {
        listaRol = cRol.Obtener_GRol_O().ToList();
        ddlCodigoRol.DataSource = listaRol;
        ddlCodigoRol.DataTextField = "DescripcionRol";
        ddlCodigoRol.DataValueField = "CodigoRol";
        ddlCodigoRol.DataBind();
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
        
    }



    protected void btnInsertar_Click(object sender, EventArgs e)
    {
        
        string codigoUsuario = txtCodigoUsuarioRol.Text;
        string codigoRol = ddlCodigoRol.SelectedValue;
        cUsuarioRol.Insertar_GUsuarioRol_I(cUsuarioRol.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol(), codigoRol, codigoUsuario);

    }
}