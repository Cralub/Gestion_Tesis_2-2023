using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

public partial class WebForm_Proyecto_PVerProyecto : System.Web.UI.Page
{
    #region Contructores
    CProyecto cProyecto = new CProyecto();
    CRol cRol = new CRol();
    CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
    CUsuario cUsuario = new CUsuario();
    #endregion
    EGProyecto eGProyecto = new EGProyecto();
    List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LimpiarVariables();
            CargarDatos();
        }

    }
    private void CargarDatos()
    {
        if(Session["CodigoProyecto"] != null)
        {
            string codigoProyecto = Session["CodigoProyecto"].ToString();
            eGProyecto = cProyecto.Obtener_GProyecto_O_CodigoProyecto(codigoProyecto);
            

            switch (eGProyecto.ModalidadProyecto)
            {
                case SDatosGlobales.CHAR_MODALIDAD_TESIS:
                    lblModalidad.Text = SDatosGlobales.STRING_MODALIDAD_TESIS;
                    break;
                case SDatosGlobales.CHAR_MODALIDAD_PROYECTO_DE_GRADO:
                    lblModalidad.Text = SDatosGlobales.STRING_MODALIDAD_PROYECTO_DE_GRADO;
                    break;
                case SDatosGlobales.CHAR_MODALIDAD_TRABAJO_DIRIGIDO:
                    lblModalidad.Text = SDatosGlobales.STRING_MODALIDAD_TRABAJO_DIRIGIDO;
                    break;
                default:
                    lblModalidad.Text = "Desconocida";
                    break;
            }
            lblTitulo.Text = eGProyecto.TituloProyecto;
            lblObjetivoGeneral.Text = eGProyecto.ObjetivoGeneralProyecto;
            lblObjetivosEspecificos.Text = eGProyecto.ObjetivosEspecificosProyecto;
            lblAlcanceProyecto.Text = eGProyecto.AlcanceProyecto;
            lkbEnlaceDocumento.Text = eGProyecto.EnlaceDocumentoProyecto;

            grvListaUsuarios.DataSource = null;
            grvListaUsuarios.DataSource = SUtil.ListarUsuariosRolesPorProyecto(codigoProyecto);
            grvListaUsuarios.DataBind();
        }
        

    }
    private void cargarListaParticipantes()
    {

    }
   



    protected void gvListaUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //int index = Convert.ToInt32(e.CommandArgument);
        //string CodigoUsuario = System.Net.WebUtility.HtmlDecode(grvListaUsuarios.Rows[index].Cells[0].Text);
        int index = Convert.ToInt32(e.CommandArgument);
        string CodigoUsuario = grvListaUsuarios.DataKeys[index].Value.ToString();

        if (e.CommandName == "btnVer")
        {
            Session["CodigoUsuario"] = CodigoUsuario;
            Session["PaginaAnterior"] = HttpContext.Current.Request.Url.PathAndQuery;
            Response.Redirect("~/WebForm/Informacion/PInformacionUsuario.aspx");
        }
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/WebForm/Proyecto/PListarProyectos.aspx");
    }
    private void LimpiarVariables()
    {        
        Session["PaginaAnterior"] = null;        
    }
}
