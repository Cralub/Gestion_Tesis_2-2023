using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.UI.WebControls;

public partial class WebForm_Observaciones_PListaFormularioAceptacion : System.Web.UI.Page
{
    #region Controladores
    CFormularioAceptacion cFormularioAceptacion = new CFormularioAceptacion();
    #endregion
    static List<EGFormularioAceptacion> lstFormulariosAceptacion=new List<EGFormularioAceptacion>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LimpiarVariables();
            CargarFormularios();
            FiltrarInterfazUsuario();
        }
        
    }

    private void LimpiarVariables()
    {
        Session["CodigoFormularioAceptacion"] = null;
    }

    private void CargarFormularios()
    {
        if (Session["CodigoProyecto"] != null)
        {
            string codigoProyecto =  Session["CodigoProyecto"].ToString();
            lstFormulariosAceptacion = cFormularioAceptacion.Obtener_GFormularioAceptacion_O_CodigoProyecto(codigoProyecto);

            grvListaFormularioAceptacion.DataSource = lstFormulariosAceptacion;
            grvListaFormularioAceptacion.DataBind();
        }
    }
    protected void grvListaFormularioAceptacion_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int rowIndex = Convert.ToInt32(e.CommandArgument);
        if (e.CommandName == "btnVer" && lstFormulariosAceptacion.Count > 0)
        {
            Session["FormularioAceptacion"] = lstFormulariosAceptacion.ElementAt(rowIndex);
        }
    }

    protected void btnCrearFormularioAceptacion_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/WebForm/FormularioAceptacion/PCrearFormularioAceptacion.aspx");
    }

    protected void grvListaFormularioAceptacion_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        int codigoRolColumnIndex = grvListaFormularioAceptacion.Columns.IndexOf(grvListaFormularioAceptacion.Columns
           .Cast<DataControlField>()
           .FirstOrDefault(field => field.HeaderText == "Responsable"));

        if (codigoRolColumnIndex >= 0)
        {
            try
            {
                // Modifica el contenido de la celda en esa columna para cada fila
                string codigoTribunal = e.Row.Cells[codigoRolColumnIndex].Text;
                if (codigoTribunal != "Responsable")
                    e.Row.Cells[codigoRolColumnIndex].Text = SUtil.ObtenerNombrePorCodigo(codigoTribunal); // Puedes cambiar "Nuevo valor" por el valor que quieras mostrar
            }
            catch (Exception) { }

        }
    }
    void FiltrarInterfazUsuario()
    {
        if (Session["CodigoProyecto"] != null && Session["UsuarioSesion"] != null)
        {
            EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            if (SUtil.CorrespondeRevision(Session["CodigoProyecto"].ToString(), usuarioSesion.CodigoUsuario))
            {
                btnCrearFormularioAceptacion.Enabled = usuarioSesion.Roles.Any(c => c == SDatosGlobales.ROL_TRIBUNAL_1 || c == SDatosGlobales.ROL_TRIBUNAL_2);
                btnCrearFormularioAceptacion.Visible = btnCrearFormularioAceptacion.Enabled;
            }
        }
    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Session["CodigoProyecto"] = null;
        Response.Redirect("~/WebForm/Proyecto/PListarProyectos.aspx");
    }
}
