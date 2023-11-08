using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

public partial class WebForm_Proyecto_PListarProyectos : System.Web.UI.Page
{
    #region Controladores
    CProyectoCompleja cProyectoCompleja = new CProyectoCompleja();
    CUsuario cUsuario = new CUsuario();
    CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
    #endregion
    
    public static List<EProyectoCompleja> lstProyectos = new List<EProyectoCompleja>();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CargarListaProyectos();
        }
    }

    private void CargarListaProyectos()
    {

        EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;

        lstProyectos = cProyectoCompleja.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(usuarioSesion.CodigoUsuario).ToList();
        grvListaProyectos.DataSource = lstProyectos;
        grvListaProyectos.DataBind();

    }
    
    protected void FiltrarProyectos()
    {
        char tipoSeleccionado = Convert.ToChar(ddlTipoProyecto.SelectedValue);
        char estadoSeleccionado = Convert.ToChar(ddlEstadoProyecto.SelectedValue);
        string nombreUsuario = txbCodigoUsuario.Text;


        var proyectosFiltrados = lstProyectos
                                .Where(w => (tipoSeleccionado == 'X' || w.ModalidadProyecto == tipoSeleccionado) &&
                                            (estadoSeleccionado == 'X' || w.EstadoProyecto == estadoSeleccionado) &&
                                            (string.IsNullOrEmpty(nombreUsuario) || w.NombresEstudiantes.Contains(nombreUsuario.ToUpper())));

        grvListaProyectos.DataSource = proyectosFiltrados.ToList();
        grvListaProyectos.DataBind();
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
                    List<string> valores = lstProyectos.ElementAt(rowIndex).NombresEstudiantes.ToList(); // Suponiendo que los valores están en la posición correspondiente al índice de la fila

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
        string nombreEstudiante = ((DropDownList)sender).SelectedValue;
        int pos = ((DropDownList)sender).SelectedIndex;

        if (pos > 0)
        {
            // Se filtra el proyecto según el estudiante seleccionado
            var proyecto = lstProyectos.FirstOrDefault(w => w.NombresEstudiantes.Contains(nombreEstudiante));

            if (proyecto != null)
            {
                // Se obtiene el código del estudiante y se almacena en la sesión
                string codigoEstudiante = proyecto.CodigosEstudiantes.ElementAt(pos - 1);
                Session["CodigoUsuario"] = codigoEstudiante;
                Response.Redirect("~/WebForm/Informacion/PInformacionUsuario.aspx");
            }
            else
            {
                // Manejo si no se encuentra el proyecto para el estudiante seleccionado
                // Por ejemplo, mostrar un mensaje de error o manejar la situación de otra manera.
            }
        }


    }

    protected void gvListaProyectos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        string CodigoProyecto = grvListaProyectos.DataKeys[index].Value.ToString();
        if (e.CommandName == "btnVer")
        {
            Session["CodigoProyecto"] = CodigoProyecto;
            Response.Redirect("PVerProyecto.aspx");
        }
        if (e.CommandName == "btnObservaciones")
        {
            Session["CodigoProyecto"] = CodigoProyecto;
            Response.Redirect("~/WebForm/Observaciones/PListaObservacion.aspx");
        }
        if (e.CommandName == "btnInfo")
        {
            Session["CodigoProyecto"] = CodigoProyecto;
            Response.Redirect("~/WebForm/Informacion/PGraficasAvance.aspx");
        }

    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/PaginaMaestra/Default.aspx");
    }

    protected void ddlTipoProyecto_SelectedIndexChanged(object sender, EventArgs e)
    {
        FiltrarProyectos();
    }

    protected void ddlEstadoProyecto_SelectedIndexChanged(object sender, EventArgs e)
    {
        FiltrarProyectos();
    }
    protected void txbCodigoUsuario_TextChanged(object sender, EventArgs e)
    {
        FiltrarProyectos();
    }

    
}