using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Proyecto_PListarProyectosRevision : System.Web.UI.Page
{
    #region Controladores
    CProyectoCompleja cProyectoCompleja = new CProyectoCompleja();
    CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
    #endregion

    public static List<EProyectoCompleja> lstProyectos = new List<EProyectoCompleja>();
    public static IEnumerable<EProyectoCompleja> proyectosFiltrados;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LimpiarVariables();
            CargarListaProyectos();
        }
    }

    private void CargarListaProyectos()
    {

        EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;

        lstProyectos = cProyectoCompleja.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(usuarioSesion.CodigoUsuario).ToList();
        grvListaProyectos.DataSource = lstProyectos;
        grvListaProyectos.DataBind();

    }

    protected void FiltrarProyectos()
    {
        char tipoSeleccionado = Convert.ToChar(ddlTipoProyecto.SelectedValue);
        char estadoSeleccionado = Convert.ToChar(ddlEstadoProyecto.SelectedValue);
        string estudiante = txbCodigoUsuario.Text.Trim();

        proyectosFiltrados = lstProyectos
            .Where(w => (tipoSeleccionado == 'X' || w.ModalidadProyecto == tipoSeleccionado) &&
                        (estadoSeleccionado == 'X' || w.EstadoProyecto == estadoSeleccionado) &&
                        (string.IsNullOrEmpty(estudiante) ||
                         (w.NombresEstudiantes.Any(nombre => nombre.ToUpper().Contains(estudiante.ToUpper())) ||
                         w.CodigosEstudiantes.Any(codigo => codigo.ToUpper().Contains(estudiante.ToUpper()))
                        )))
            .ToList();

        grvListaProyectos.DataSource = proyectosFiltrados;
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
                    List<string> valores = new List<string>();
                    if (proyectosFiltrados == null || grvListaProyectos.Rows.Count == lstProyectos.Count())
                        valores = lstProyectos.ElementAt(rowIndex).NombresEstudiantes.ToList(); // Suponiendo que los valores están en la posición correspondiente al índice de la fila
                    else
                        valores = proyectosFiltrados.ElementAt(rowIndex).NombresEstudiantes.ToList(); // Suponiendo que los valores están en la posición correspondiente al índice de la fila

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
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Close()", true);
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
                Session["PaginaAnterior"] = HttpContext.Current.Request.Url.PathAndQuery;
                Response.Redirect("~/WebForm/Informacion/PInformacionUsuario.aspx");
            }
            else
            {
                // Manejo si no se encuentra el proyecto para el estudiante seleccionado
                // Por ejemplo, mostrar un mensaje de error o manejar la situación de otra manera.
            }
        }


    }
    private bool ConfirmarParticipacionDocente(string codigoProyecto)
    {
        if (Session["UsuarioSesion"] != null)
        {
            EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;

            // Si el usuario no es tutor, devuelve true directamente
            if (!usuarioSesion.Roles.Any(rol => rol == SDatosGlobales.ROL_TUTOR))
                return true;

            
            List<EGUsuarioProyecto> eGUsuarioProyecto = cUsuarioProyecto
                .Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto)
                .Where(w => w.CodigoRol == SDatosGlobales.ROL_TUTOR)
                .ToList();

            // Devuelve true si el tutor tiene participación activa en el proyecto, de lo contrario, false
            return eGUsuarioProyecto.Any() ? eGUsuarioProyecto.First().EstadoUsuarioProyecto == SDatosGlobales.ESTADO_ACTIVO : false;
        }

        return false;
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
        if (ConfirmarParticipacionDocente(CodigoProyecto))
        {
            if (e.CommandName == "btnObservaciones")
            {
                Session["CodigoProyecto"] = CodigoProyecto;
                Session["CorrespondeRevision"] = true;
                Response.Redirect("~/WebForm/Observaciones/PListaObservacion.aspx");
            }
            if (e.CommandName == "btnInfo")
            {
                Session["CodigoProyecto"] = CodigoProyecto;
                Response.Redirect("~/WebForm/Informacion/PGraficasAvance.aspx");
            }
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
    private void LimpiarVariables()
    {
        Session["CorrespondeRevision"] = null;
        Session["PaginaAnterior"] = null;
        Session["CodigoProyecto"] = null;
    }
}