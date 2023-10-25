using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Formulario_PListarProyectosFormulario : System.Web.UI.Page
{
    #region Controladores
    CProyectoCompleja cProyectoCompleja = new CProyectoCompleja();
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CargarListaProyectos();
        }
        
    }
    public static List<EProyectoCompleja> lstProyectos = new List<EProyectoCompleja>();
    private void CargarListaProyectos()
    {
        EUsuarioNetvalle eUsuarioNetvalle = Session["UsuarioSesion"] as EUsuarioNetvalle;
        lblCodigoUsuario.Text = eUsuarioNetvalle.CodigoUsuarioNetvalle;
        lblNombreUsuario.Text = eUsuarioNetvalle.NombreCompletoUsuarioNetvalle;
        lstProyectos = new List<EProyectoCompleja>();
        lstProyectos = cProyectoCompleja.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(eUsuarioNetvalle.CodigoUsuarioNetvalle).ToList();
        gvListaProyectos.DataSource = lstProyectos;
        gvListaProyectos.DataBind();
        
    }
   
    protected void gvListaProyectos_RowDataBound(object sender, GridViewRowEventArgs e)
    { 
        if (lstProyectos.Count > 0)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DropDownList ddlEstudiantes = (DropDownList)e.Row.FindControl("ddlEstudiantes");
                if (ddlEstudiantes != null)
                {
                    // Obtener el índice de la fila actual
                    int rowIndex = e.Row.RowIndex;
                    List<string> valores = lstProyectos.ElementAt(rowIndex).CodigosEstudiantes.ToList(); // Suponiendo que los valores están en la posición correspondiente al índice de la fila

                    // Cargar los valores en el DropDownList
                    ddlEstudiantes.Items.Add("Estudiantes");
                    foreach (string valor in valores)
                    {
                        ddlEstudiantes.Items.Add(valor);
                    }
                }
            }
        }
    }


    protected void ddlEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["CodigoUsuario"] = null;
        string Estudiante = ((DropDownList)sender).SelectedValue;
        if(((DropDownList)sender).SelectedIndex > 0)
        {
            Session["CodigoUsuario"] = Estudiante;
            Response.Redirect("~/WebForm/Informacion/PListarProyectosFormulario.aspx");
        }
        
    }

    protected void gvListaProyectos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        string CodigoProyecto = gvListaProyectos.DataKeys[index].Value.ToString();
        EProyectoCompleja proyectoCompleja = lstProyectos.Where(w => w.CodigoProyecto == CodigoProyecto).FirstOrDefault();
        Session["proyectoCompleja"] = proyectoCompleja;
        if (e.CommandName == "btnVer")
        {
            Response.Redirect("PFormularioEstudiante.aspx");
        }
        if (e.CommandName == "btnObservaciones")
        {
            Response.Redirect("~/WebForm/Observaciones/PListaObservacion.aspx");
        }

    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/PaginaMaestra/Default.aspx");
    }
}