using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

public partial class WebForm_Proyecto_PListarProyectos : System.Web.UI.Page
{
    #region Controladores
    CProyectoCompleja cProyectoCompleja = new CProyectoCompleja();
    CUsuario cUsuario = new CUsuario();
    CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
    CEtapa cCEtapa = new CEtapa();
    #endregion

    public static List<EProyectoCompleja> lstProyectos = new List<EProyectoCompleja>();
    public static IEnumerable<EProyectoCompleja> proyectosFiltrados;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack && Session["UsuarioSesion"] != null)
        {
            LimpiarVariables();
            CargarListaProyectos();
            FiltrarInterfazUI();
        }
    }

    private void FiltrarInterfazUI()
    {
        
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
        string numeroEtapa = ddlEtapaProyecto.SelectedValue;
        string estudiante = txbCodigoUsuario.Text.Trim();

        proyectosFiltrados = lstProyectos
            .Where(w => (tipoSeleccionado == 'X' || w.ModalidadProyecto == tipoSeleccionado) &&
                        (estadoSeleccionado == 'X' || w.EstadoProyecto == estadoSeleccionado) &&
                        (string.IsNullOrEmpty(estudiante) ||
                         (w.NombresEstudiantes.Any(nombre => nombre.ToUpper().Contains(estudiante.ToUpper())) ||
                         w.CodigosEstudiantes.Any(codigo => codigo.ToUpper().Contains(estudiante.ToUpper())))
                        ))
            .ToList();

        if (numeroEtapa != "X")
        {
            proyectosFiltrados = proyectosFiltrados
                .Where(proyecto =>
                {
                    byte etapaProyecto = cCEtapa.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(proyecto.CodigoProyecto, SDatosGlobales.ESTADO_ACTIVO).NumeroEtapa;
                    return etapaProyecto == byte.Parse(numeroEtapa);
                })
                .ToList();
        }

        grvListaProyectos.DataSource = proyectosFiltrados;
        grvListaProyectos.DataBind();
    }


    protected void gvListaProyectos_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        #region Boton Editar solo Director
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Button btnEditar = e.Row.FindControl("btnEditar") as Button;

            EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            bool esDirector = usuarioSesion.Roles.Any(rol => rol == SDatosGlobales.ROL_DIRECTOR);
            btnEditar.Visible = esDirector;
        }
        #endregion
        #region Modificar Visualmente Roles
        // Encuentra el índice de la columna que deseas modificar
        int codigoRolColumnIndex = grvListaProyectos.Columns.IndexOf(grvListaProyectos.Columns
            .Cast<DataControlField>()
            .FirstOrDefault(field => field.HeaderText == "Rol En Proyecto"));

        if (codigoRolColumnIndex >= 0)
        {
            try
            {
                // Modifica el contenido de la celda en esa columna para cada fila
                string rol = e.Row.Cells[codigoRolColumnIndex].Text;
                if (rol != "Rol En Proyecto")
                    e.Row.Cells[codigoRolColumnIndex].Text = SUtil.ObtenerNombreRolPorCodigo(rol); // Puedes cambiar "Nuevo valor" por el valor que quieras mostrar
                
            }
            catch (Exception) { }

        }
        #endregion

        #region Modificar Visualmente Modalidad
        // Encuentra el índice de la columna que deseas modificar
        int modalidadRolColumnIndex = grvListaProyectos.Columns.IndexOf(grvListaProyectos.Columns
            .Cast<DataControlField>()
            .FirstOrDefault(field => field.HeaderText == "Modalidad"));

        if (modalidadRolColumnIndex >= 0)
        {
            try
            {
                // Modifica el contenido de la celda en esa columna para cada fila
                e.Row.Cells[modalidadRolColumnIndex].Text = SUtil.ObtenerNombreModalidad(char.Parse(e.Row.Cells[modalidadRolColumnIndex].Text)); // Puedes cambiar "Nuevo valor" por el valor que quieras mostrar
            }
            catch (Exception) { }

        }
        #endregion

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
    protected void gvListaProyectos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "btnVer" || e.CommandName == "btnObservaciones" || e.CommandName == "btnInfo" || e.CommandName == "btnFormularioAceptacion" || e.CommandName == "btnEditar")
        {
            var index = int.Parse(e.CommandArgument.ToString());
            if (index >= 0)
            {
                string codigoProyecto = grvListaProyectos.DataKeys[index].Value.ToString();

                string redirectUrl = string.Empty;
                Session["PaginaAnterior"] = HttpContext.Current.Request.Url.PathAndQuery;
                switch (e.CommandName)
                {
                    case "btnVer":
                        redirectUrl = "PVerProyecto.aspx";
                        break;
                    case "btnObservaciones":
                        redirectUrl = "~/WebForm/Observaciones/PListaObservacion.aspx";
                        break;
                    case "btnInfo":
                        redirectUrl = "~/WebForm/Informacion/PGraficasAvance.aspx";
                        break;
                    case "btnFormularioAceptacion":
                        redirectUrl = "~/WebForm/FormularioAceptacion/PListaFormularioAceptacion.aspx";
                        break;
                    case "btnEditar":
                        redirectUrl = "~/WebForm/Proyecto/PEditarProyecto.aspx";
                        break;
                }

                Session["CodigoProyecto"] = codigoProyecto;
                if (!string.IsNullOrEmpty(redirectUrl))
                {
                    Response.Redirect(redirectUrl);
                }
            }
        }
    }


    //protected void btnVolver_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("~/PaginaMaestra/Default.aspx");
    //}
    private void LimpiarVariables()
    {
        Session["CorrespondeRevision"] = null;
        Session["PaginaAnterior"] = null;
        Session["CodigoProyecto"] = null;
        lstProyectos = new List<EProyectoCompleja>();
        proyectosFiltrados = null;

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
    protected void ddlEtapaProyecto_SelectedIndexChanged(object sender, EventArgs e)
    {
        FiltrarProyectos();
    }
}