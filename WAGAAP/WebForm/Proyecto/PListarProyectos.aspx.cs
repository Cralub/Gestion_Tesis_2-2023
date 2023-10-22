using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

public partial class WebForm_Proyecto_PListarProyectos : System.Web.UI.Page
{
    #region Controladores
    CProyectoCompleja cProyectoCompleja = new CProyectoCompleja();
    #endregion
    EUsuarioNetvalle eUsuarioNetvalle = new EUsuarioNetvalle();
    public static List<EProyectoCompleja> lstProyectos = new List<EProyectoCompleja>();
    //private static int index;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CargarListaProyectos();
        }
        
    }
    
    private void CargarListaProyectos()
    {
        EUsuarioNetvalle eUsuarioNetvalle = Session["UsuarioSesion"] as EUsuarioNetvalle;
        lstProyectos = cProyectoCompleja.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(eUsuarioNetvalle.CodigoUsuarioNetvalle).ToList();
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
        if (((DropDownList)sender).SelectedIndex > 0)
        {
            Session["CodigoUsuario"] = Estudiante;
            Response.Redirect("~/WebForm/Informacion/PInformacionUsuario.aspx");
        }

    }

    protected void gvListaProyectos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        string CodigoProyecto = gvListaProyectos.DataKeys[index].Value.ToString();
        if (e.CommandName == "btnVer")
        {
            Session["CodigoProyecto"] = CodigoProyecto;
            Response.Redirect("PVerProyecto.aspx");
        }
        if (e.CommandName == "btnInfo")
        {
            Session["CodigoProyecto"] = CodigoProyecto;
            Response.Redirect("~/WebForm/Informacion/PGraficasAvance.aspx");
        }

    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {

    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/PaginaMaestra/Default.aspx");
    }
}