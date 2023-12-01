using SWLNGAAP;
using System;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

public partial class WebForm_Proyecto_PEditarProyecto : System.Web.UI.Page
{
    #region Controladores
     CProyecto cProyecto = new CProyecto();
    CProyectoCompleja cProyectoCompleja = new CProyectoCompleja();
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CargarInformacionProyecto();
        }
    }
    private void CargarInformacionProyecto()
    {
        if (Session["UsuarioSesion"] != null && Session["CodigoProyecto"] != null)
        {
            string codigoProyecto = Session["CodigoProyecto"].ToString();
            EUsuarioSesionGAAP usuario = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            EProyectoCompleja proyectoCompleto = cProyectoCompleja.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(usuario.CodigoUsuario).FirstOrDefault(p =>p.CodigoProyecto == codigoProyecto);
            Session["ProyectoComplejo"] = proyectoCompleto;
            lblRevision.Text = proyectoCompleto.NumeroRevisionesProyecto.ToString();
            lblCodigoProyecto.Text = proyectoCompleto.CodigoProyecto;
            txbObjetivosEspecificos.Text = proyectoCompleto.ObjetivosEspecificosProyecto;
            txbAlcance.Text = proyectoCompleto.AlcanceProyecto;
            lkbEnlaceDocumento.Text = proyectoCompleto.EnlaceDocumentoProyecto;
            txbTitulo.Text = proyectoCompleto.TituloProyecto;
            ddlModalidades.SelectedValue = proyectoCompleto.ModalidadProyecto.ToString();
            txbObjetivoGeneral.Text = proyectoCompleto.ObjetivoGeneralProyecto;

            grvListaUsuarios.DataSource = null;

            grvListaUsuarios.DataSource = SUtil.ListarUsuariosRolesPorProyecto(proyectoCompleto.CodigoProyecto);
            grvListaUsuarios.DataBind();


            
            //txbObjetivosEspecificos.Enabled = correspondeRevision;
            //txbAlcance.Enabled = correspondeRevision;
            //ddlModalidades.Enabled = correspondeRevision;
            //txbObjetivoGeneral.Enabled = correspondeRevision;
            //txbTitulo.Enabled = correspondeRevision;
            //btnActualizarInformacion.Enabled = correspondeRevision;
            //btnActualizarInformacion.Visible = correspondeRevision;

            //btnAgregarDocumento.Enabled = correspondeRevision;
           

        }
    }
    protected void btnActualizarInformacion_Click(object sender, EventArgs e)
    {
        if (Session["ProyectoComplejo"] != null && Session["UsuarioSesion"] != null)
        {
            EProyectoCompleja proyectoC = Session["ProyectoComplejo"] as EProyectoCompleja;
            EGProyecto proyecto = cProyecto.Obtener_GProyecto_O_CodigoProyecto(proyectoC.CodigoProyecto);
            cProyecto.Actualizar_GProyecto_A(proyecto.CodigoProyecto,
                                                 char.Parse(ddlModalidades.SelectedValue.Trim()),
                                                 txbTitulo.Text.Trim(),
                                                 txbObjetivoGeneral.Text.Trim(),
                                                 txbObjetivosEspecificos.Text.Trim(),
                                                 txbAlcance.Text.Trim(),
                                                 proyecto.NumeroRevisionesProyecto,
                                                 lkbEnlaceDocumento.Text.Trim()
                                                 );
        }
        CargarInformacionProyecto();
    }

    protected void btnAgregarDocumento_Click(object sender, EventArgs e)
    {

    }

    protected void grvListaUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        string CodigoUsuario = grvListaUsuarios.DataKeys[index].Value.ToString();

        if (e.CommandName == "btnVer")
        {
            Session["CodigoUsuario"] = CodigoUsuario;
            Session["PaginaAnterior"] = HttpContext.Current.Request.Url.PathAndQuery;
            Response.Redirect("~/WebForm/Informacion/PInformacionUsuario.aspx");
        }
    }

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {

    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {

    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Session["CodigoProyecto"] = null;
        Response.Redirect("~/WebForm/Proyecto/PListarProyectos.aspx");
    }
}