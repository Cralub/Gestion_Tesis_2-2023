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
            CargarFormularios();
        }
        LimpiarVariables();
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
}
