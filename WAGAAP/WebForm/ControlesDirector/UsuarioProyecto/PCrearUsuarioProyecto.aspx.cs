using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_ControlesDirector_UsuarioProyecto_PCrearUsuarioProyecto : System.Web.UI.Page
{
    #region Controladoras
    CUsuarioRol cUsuarioRol = new CUsuarioRol();
    CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto(); 
    #endregion
    static List<EGUsuarioRol> eGUsuarioRols = new List<EGUsuarioRol>();
    static List<EGUsuarioRol> eGUsuarioRolsFiltrados = new List<EGUsuarioRol>();
    static int rolSeleccionado = -1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack )
        {
            CargarUsuariosRol();
        }
    }
    void CargarUsuariosRol()
    {
        if(ddlRoles.SelectedIndex >= 0)
        {
            if (rolSeleccionado != ddlRoles.SelectedIndex)
            {
                rolSeleccionado = ddlRoles.SelectedIndex;
                eGUsuarioRols = new List<EGUsuarioRol>();
                eGUsuarioRols = cUsuarioRol.Obtener_GUsuarioRol_O_CodigoRol(ddlRoles.SelectedValue);
            }
            grvListaUsuariosRol.DataSource = null;
            FiltrarUsuariosProyecto();
            if (eGUsuarioRols.Count > 0 && eGUsuarioRols.Count == eGUsuarioRolsFiltrados.Count)
            {
                grvListaUsuariosRol.DataSource = eGUsuarioRols;
                grvListaUsuariosRol.DataBind();
            }
            else
            {
                grvListaUsuariosRol.DataSource = eGUsuarioRolsFiltrados;
                grvListaUsuariosRol.DataBind();
            }
        }
    }

    private void FiltrarUsuariosProyecto()
    {
        eGUsuarioRolsFiltrados = new List<EGUsuarioRol>();
        eGUsuarioRolsFiltrados = eGUsuarioRols
                .Where(w => string.IsNullOrEmpty(txbUsuario.Text.Trim()) || (w.CodigoUsuario
                    .Contains(txbUsuario.Text) || 
                        SUtil.ObtenerNombrePorCodigo(w.CodigoUsuario).Contains(txbUsuario.Text)) ).ToList();
    }

    protected void ddlRoles_SelectedIndexChanged(object sender, EventArgs e)
    {
        CargarUsuariosRol();
    }

    protected void txbUsuario_TextChanged(object sender, EventArgs e)
    {
        CargarUsuariosRol();
    }

    protected void grvListaUsuariosRol_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        int codigoRolColumnIndex = grvListaUsuariosRol.Columns.IndexOf(grvListaUsuariosRol.Columns
          .Cast<DataControlField>()
          .FirstOrDefault(field => field.HeaderText == "NombreUsuario"));

        if (codigoRolColumnIndex >= 0)
        {
            try
            {
                string codigoRol = e.Row.Cells[codigoRolColumnIndex].Text;
                if (codigoRol != "NombreUsuario")
                    e.Row.Cells[codigoRolColumnIndex].Text = SUtil.ObtenerNombrePorCodigo(codigoRol); // Puedes cambiar "Nuevo valor" por el valor que quieras mostrar
            }
            catch (Exception) { }

        }
    }

    protected void grvListaUsuariosRol_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        string CodigoUsuario = grvListaUsuariosRol.DataKeys[index].Value.ToString();
        string codigoRol = ddlRoles.SelectedValue.Trim();
        if (e.CommandName == "btnAgregar" && !string.IsNullOrEmpty(codigoRol) && Session["CodigoProyecto"] != null)
        {
            string codigoProyecto = Session["CodigoProyecto"].ToString();
            var buscarUsuario = cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto);
            if ((!buscarUsuario.Any( a => a.CodigoRol == codigoRol) && !buscarUsuario.Any(a => a.CodigoUsuario == CodigoUsuario)) || ddlRoles.SelectedValue == SDatosGlobales.ROL_ESTUDIANTE)
            {
                cUsuarioProyecto.Insertar_GUsuarioProyecto_I(cUsuarioProyecto.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto(), codigoProyecto, CodigoUsuario, codigoRol, SDatosGlobales.ESTADO_ACTIVO);
                Response.Redirect("~/WebForm/ControlesDirector/UsuarioProyecto/PListarUsuariosProyecto.aspx");
            }
            else
            {
                lblCrearUsuarioRol.Text = "Ya existe el Usuario en el Proyecto";
            }
        }
    }
}