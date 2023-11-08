using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Observaciones_PListaFormularioAceptacion : System.Web.UI.Page
{
    #region Controladores
    CFormularioAceptacion cFormularioAceptacion = new CFormularioAceptacion();
    #endregion

    private static string codigoProyecto = "q";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CargarFormularios();
        }
    }

    private void CargarFormularios()
    {
        List<EGFormularioAceptacion> listaFormularios = cFormularioAceptacion.Obtener_GFormularioAceptacion_O_CodigoProyecto(codigoProyecto);

        grvListaFormularioAceptacion.DataSource = listaFormularios;
        grvListaFormularioAceptacion.DataBind();
    }
    protected void grvListaFormularioAceptacion_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "btnVer")
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
        }
    }
}
