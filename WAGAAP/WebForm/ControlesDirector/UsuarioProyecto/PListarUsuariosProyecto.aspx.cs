using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_ControlesDirector_UsuarioProyecto_PListarUsuariosProyecto : System.Web.UI.Page
{
    #region Controladoras
    CUsuario cUsuario = new CUsuario();
    CRol cRol = new CRol();
    CProyectoCompleja cProyectoCompleja = new CProyectoCompleja();
    CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
    CUsuarioRol cUsuarioRol = new CUsuarioRol();
    #endregion

    public List<EProyectoCompleja> eGProyectoCompleja = new List<EProyectoCompleja>();
    public List<EGUsuarioProyecto> eGUsuarioProyecto = new List<EGUsuarioProyecto>();
    public List<EGUsuarioRol> eGUsuarioRol = new List<EGUsuarioRol>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LimpiarVariables();
            //cargarListaProyectoUsuario("PR001");
        }
    }

    private void LimpiarVariables()
    {
        Session["CodigoProyecto"] = null;
        lblMensajeCrearUsuarioProyecto.Text = string.Empty;
    }

    void cargarListaProyectoUsuario(string codigoProyecto)
    {
        eGUsuarioProyecto = cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto);
        grvListaUsuariosProyecto.DataSource = eGUsuarioProyecto;
        grvListaUsuariosProyecto.DataBind();
        if(eGUsuarioProyecto.Count > 0)
        {
            Session["CodigoProyecto"] = codigoProyecto;
        }
    }
    protected void txbCodigoProyecto_TextChanged(object sender, EventArgs e)
    {
        string codigoProyecto = txbCodigoProyecto.Text.Trim().ToUpper();
        if (!string.IsNullOrEmpty(codigoProyecto))
        {
            cargarListaProyectoUsuario(codigoProyecto);
        }
    }

    protected void btnBuscarUsuarioProyecto_Click(object sender, EventArgs e)
    {

    }

    protected void grvListaUsuariosProyecto_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        #region Cambiar codigoRol por Descripcion Rol
        int codigoRolColumnIndex = grvListaUsuariosProyecto.Columns.IndexOf(grvListaUsuariosProyecto.Columns
            .Cast<DataControlField>()
            .FirstOrDefault(field => field.HeaderText == "Rol"));

        if (codigoRolColumnIndex >= 0)
        {
            try
            {
                string rol = e.Row.Cells[codigoRolColumnIndex].Text;
                if (rol != "Rol")
                    e.Row.Cells[codigoRolColumnIndex].Text = SUtil.ObtenerNombreRolPorCodigo(rol); // Puedes cambiar "Nuevo valor" por el valor que quieras mostrar
            }
            catch (Exception) { }

        }
        #endregion
        #region Cambiar codigoRol por Descripcion Rol
        int estadoUsuarioProyectoColumnIndex = grvListaUsuariosProyecto.Columns.IndexOf(grvListaUsuariosProyecto.Columns
            .Cast<DataControlField>()
            .FirstOrDefault(field => field.HeaderText == "Estado"));

        if (estadoUsuarioProyectoColumnIndex >= 0)
        {
            try
            {
                string rol = e.Row.Cells[estadoUsuarioProyectoColumnIndex].Text;
                if (rol != "Estado")
                    e.Row.Cells[estadoUsuarioProyectoColumnIndex].Text = SUtil.ObtenerNombreEstado(char.Parse(rol)); // Puedes cambiar "Nuevo valor" por el valor que quieras mostrar
            }
            catch (Exception) { }

        }
        #endregion

    }

    protected void btnCrearUsuarioProyecto_Click(object sender, EventArgs e)
    {
        if(Session["CodigoProyecto"] != null)
        {
            Response.Redirect("~/WebForm/ControlesDirector/UsuarioProyecto/PCrearUsuarioProyecto.aspx");
        }
        else        
            lblMensajeCrearUsuarioProyecto.Text = "Ingrese un Proyecto";
        
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "ModalConfirmacion", "Close()", true);
    }
    //ScriptManager.RegisterStartupScript(this, this.GetType(), "ModalConfirmacion", "Open()", true);

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        if(Session["CodigoUsuarioProyecto"] != null)
        {
            cUsuarioProyecto.Eliminar_GUsuarioProyecto_E(int.Parse(Session["CodigoUsuarioProyecto"].ToString()));
        }

        ScriptManager.RegisterStartupScript(this, this.GetType(), "ModalConfirmacion", "Close()", true);
    }


    protected void grvListaUsuariosProyecto_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        string CodigoUsuarioProyecto = grvListaUsuariosProyecto.DataKeys[index].Value.ToString();
        if (e.CommandName == "btnEliminar")
        {
            Session["CodigoUsuarioProyecto"] = CodigoUsuarioProyecto;
            lblMensajeConfirmacionModal.Text = "¿ Esta seguro de eliminar el usuario del proyecto ?";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "ModalConfirmacion", "Open()", true);
        }
    }
}