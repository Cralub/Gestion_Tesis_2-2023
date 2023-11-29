using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using SWLNGAAP;

public partial class WebForm_TutorExterno_PListarTutoresExternos : System.Web.UI.Page
{
    #region Controladoras
    CTutorExterno cTutorExterno = new CTutorExterno();        
    #endregion
    public static List<EGTutorExterno> listaTutoresExternos = new List<EGTutorExterno>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            CargarListaTutoresExternos();
        }
    }

    private void CargarListaTutoresExternos()
    {
        listaTutoresExternos = cTutorExterno.Obtener_GTutorExterno_O().ToList();
        
        grvListaTutoresExternos.DataSource = listaTutoresExternos;
        grvListaTutoresExternos.DataBind();
    }

    private void BuscarTutorExterno()
    {
        grvListaTutoresExternos.DataSource = null;
        grvListaTutoresExternos.DataBind();
        try
        {
            if (txbCodigoTutorExterno.Text != "")
            {
               
                listaTutoresExternos.Add(cTutorExterno.Obtener_GTutorExterno_O_CodigoTutorExterno(txbCodigoTutorExterno.Text));
                grvListaTutoresExternos.DataSource = listaTutoresExternos;
                grvListaTutoresExternos.DataBind();
            }
            else
            {
                CargarListaTutoresExternos();
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void gvListaTutoresExternos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        if (e.CommandName == "btnEditar")
        {
            GridViewRow row = grvListaTutoresExternos.Rows[index];
            string CodigoTutorExterno = row.Cells[0].Text;
            Response.Redirect("PEditarTutorExterno.aspx?CodigoTutorExterno=" + CodigoTutorExterno);
        }
        
    }

    protected void gvListaTutoresExternos_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        grvListaTutoresExternos.DataSource = null;
        grvListaTutoresExternos.DataBind();
        try
        {
            BuscarTutorExterno();
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void btnCrearTutorExterno_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/WebForm/ControlesDirector/TutorExterno/PCrearTutorExterno.aspx");
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/PaginaMaestra/Default.aspx");
    }
}