using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SWLNGAAP;

public partial class WebForm_Usuario_EditarRolUsuarioProyecto : System.Web.UI.Page
{
    #region Controladoras
    CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
    CUsuarioRol cUsuarioRol = new CUsuarioRol();
    CRol cRol = new CRol();

    #endregion

    public List<EGRol> eGRols = new List<EGRol>();

    public List<EGUsuarioProyecto> eGUsuarioProyecto = new List<EGUsuarioProyecto>();


    protected void Page_Load(object sender, EventArgs e)
    {
        string codigoUsuarioProyecto = Request.QueryString["CodigoUsuarioProyecto"];
        Session["CodigoUsuarioProyecto"] = codigoUsuarioProyecto;
        lblCodigoUsuarioProyecto.Text = codigoUsuarioProyecto;
        string codigoUsuario = Request.QueryString["CodigoUsuario"];
        Session["CodigoUsuario"] = codigoUsuario;
        lblCodigoUsuario.Text = codigoUsuario;
        string codigoRol = Request.QueryString["codigoRol"];
        Session["CodigoRol"] = codigoRol;
        string codigoProyecto = Request.QueryString["CodigoProyecto"];
        Session["CodigoProyecto"] = codigoProyecto;
        lblCodigoProyecto.Text = codigoProyecto;
        if (!IsPostBack)
        {
            cargarListaRoles(codigoUsuario, codigoRol);
        }

    }
    void cargarListaRoles(string codigoUsuario, string codigoRol)
    {
        var usuarioRols = cUsuarioRol.Obtener_GUsuarioRol_O_CodigoUsuario(codigoUsuario);
        eGRols = usuarioRols.Select(s => new EGRol
        {
            CodigoRol = s.CodigoRol,
            DescripcionRol = SUtil.ObtenerNombreRolPorCodigo(s.CodigoRol)
        }).ToList();
        ddlRol.DataSource = eGRols;
        ddlRol.DataTextField = "DescripcionRol";
        ddlRol.DataValueField = "CodigoRol";
        ddlRol.DataBind();
        lblRol.Text = string.Format("Rol Actual: {0}", SUtil.ObtenerNombreRolPorCodigo(codigoRol));
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if(Session["CodigoRol"] != null && Session["CodigoUsuario"] != null && Session["CodigoProyecto"] != null && Session["CodigoUsuarioProyecto"] != null)
        {
            string codigoUsuario = Session["CodigoUsuario"].ToString();
            string codigoRol = ddlRol.SelectedValue;
            string codigoProyecto = Session["CodigoProyecto"].ToString();
            string codigoUsuarioProyecto = Session["CodigoUsuarioProyecto"].ToString();
            var buscarUsuario = cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto);

            if (!buscarUsuario.Any(a => a.CodigoRol == codigoRol ) || codigoRol == SDatosGlobales.ROL_ESTUDIANTE || buscarUsuario.Count(a => a.CodigoRol == SDatosGlobales.ROL_ESTUDIANTE) < 4)
            {
                cUsuarioProyecto.Actualizar_GUsuarioProyecto_A(int.Parse(lblCodigoUsuarioProyecto.Text), lblCodigoProyecto.Text, lblCodigoUsuario.Text, codigoRol, SDatosGlobales.ESTADO_ACTIVO);
            }
            else
            {
                lblMensajeEditarUsuarioProyecto.Text = "Ya existe un Usuario con ese rol en el Proyecto";
            }
            

            

            Response.Redirect("PUsuarioProyecto.aspx");
        }
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Session["CodigoRol"] = null;
        Response.Redirect("~/WebForm/ControlesDirector/UsuarioProyecto/PListarUsuariosProyecto.aspx");
    }
}