using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Usuario_PListadoProyectos : System.Web.UI.Page
{
    #region Controladores
    CProyectoTiempoEntrega cProyectoEntrega = new CProyectoTiempoEntrega();
    #endregion
    List<EProyectoTiempoEntrega> lstEProyectoTiempoEntrega;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["CodigoProyecto"] != null)
            {
                lstEProyectoTiempoEntrega = cProyectoEntrega.Obtener_EProyectoTiempoEntrega_O(Session["CodigoProyecto"] as string).ToList();
                rptProyectos.DataSource = lstEProyectoTiempoEntrega;
                rptProyectos.DataBind();
                VerificarEstado();
            }
        }
    }

    private void VerificarEstado()
    {
        int i = 0;
        foreach (var entrega in lstEProyectoTiempoEntrega)
        {
            Label lbl = (Label)rptProyectos.Items[i].FindControl("lblEstadoEntrega");
            
            if (DateTime.Now >= entrega.FechaEntrega)
            {
                lbl.Text = "Atrasado";
                lbl.Attributes.Add("style", "background-color: Red;");
            }
            else if(DateTime.Now < entrega.FechaEntrega) 
            {
                lbl.Text = "A tiempo";
                lbl.Attributes.Add("style", "background-color: Green;");
            }
            i++;
        }
    }
}