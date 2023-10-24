using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
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
        gvListaTutoresExternos.DataSource = listaTutoresExternos;
        gvListaTutoresExternos.DataBind();
    }

    private void BuscarTutorExterno()
    {
        gvListaTutoresExternos.DataSource = null;
        gvListaTutoresExternos.DataBind();
        try
        {
            if (txbCodigoTutorExterno.Text != "")
            {
               
                listaTutoresExternos.Add(cTutorExterno.Obtener_GTutorExterno_O_CodigoTutorExterno(int.Parse(txbCodigoTutorExterno.Text)));
                gvListaTutoresExternos.DataSource = listaTutoresExternos;
                gvListaTutoresExternos.DataBind();
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
        if (e.CommandName == "Editar")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = gvListaTutoresExternos.Rows[index];
            string CodigoTutorExterno = row.Cells[0].Text;
            Response.Redirect("PEditarTutorExterno.aspx?CodigoTutorExterno=" + CodigoTutorExterno);
        }
        
    }

    protected void gvListaTutoresExternos_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        gvListaTutoresExternos.DataSource = null;
        gvListaTutoresExternos.DataBind();
        try
        {
            
            BuscarTutorExterno();
        }
        catch (Exception)
        {
            throw;
        }
    }
}