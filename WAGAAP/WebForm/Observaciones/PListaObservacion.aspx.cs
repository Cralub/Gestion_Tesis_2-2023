using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;


public partial class WebForm_PListaObservacion : System.Web.UI.Page
{
    #region Controladores
    CObservacion cObservacion = new CObservacion();
    #endregion
    public static List<EObservacionDetalle> lstObservaciones = new List<EObservacionDetalle>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CargarObservaciones();
            FiltrarInterfazUsuario();
        }

    }

    private void CargarObservaciones()
    {
        lstObservaciones = new List<EObservacionDetalle>();
        if (Session["CodigoProyecto"] != null)
        {
            string codigoProyecto = Session["CodigoProyecto"].ToString();
            var observaciones = cObservacion.Obtener_GObservacion_O_CodigoProyecto(codigoProyecto);
            lstObservaciones = observaciones.Select(obs => new EObservacionDetalle
            {
                CodigoObservacion = obs.CodigoObservacion,
                CodigoProyecto = obs.CodigoProyecto,
                CodigoSubEtapa = obs.CodigoSubEtapa,
                CodigoUsuarioObservacion = obs.CodigoUsuarioObservacion,
                NombreUsuarioObservacion = SUtil.ObtenerNombrePorCodigo(obs.CodigoUsuarioObservacion),
                ComentarioObservacion = obs.ComentarioObservacion,
                TipoObservacion = obs.TipoObservacion,
                NombreTipoObservacion = obs.TipoObservacion == 'O'? "Fondo":"Forma",
                EstadoObservacion = obs.EstadoObservacion
            }).ToList();
            grvListaObservaciones.DataSource = lstObservaciones;
            grvListaObservaciones.DataBind();
        }
    }
    protected void grvListaObservaciones_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        string CodigoObservacion = grvListaObservaciones.DataKeys[index].Value.ToString();
        if (e.CommandName == "btnVer")
        {
            Session["CodigoObservacion"] = CodigoObservacion;
            Response.Redirect("PObservacionDetalle.aspx");
        }
    }
    protected void FiltrarObservaciones()
    {
        char tipoSeleccionado = Convert.ToChar(ddlTipoObservacion.SelectedValue);
        char estadoSeleccionado = Convert.ToChar(ddlEstadoObservacion.SelectedValue);
        string observador = txbObservador.Text.Trim();

        var observacionesFiltradas = lstObservaciones
                                       .Where(w => (tipoSeleccionado == 'X' || w.TipoObservacion == tipoSeleccionado) &&
                                                   (estadoSeleccionado == 'X' || w.EstadoObservacion == estadoSeleccionado) &&
                                                   (string.IsNullOrEmpty(observador) ||
                                                    (w.CodigoUsuarioObservacion.ToUpper().Contains(observador.ToUpper())) ||
                                                    w.NombreUsuarioObservacion.ToUpper().Contains(observador.ToUpper())));

        grvListaObservaciones.DataSource = observacionesFiltradas;
        grvListaObservaciones.DataBind();
    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Session["CodigoProyecto"] = null;
        if(Session["UsuarioSesion"] != null)
        {
            EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            if(usuarioSesion.esEstudiante)
                Response.Redirect("~/WebForm/Informacion/PGraficasAvance.aspx");
            else
                Response.Redirect("~/WebForm/Proyecto/PListarProyectos.aspx");
        }
        
    }



    protected void btnCrearObservacion_Click(object sender, EventArgs e)
    {
        if (Session["CodigoProyecto"] != null)
            Response.Redirect("~/WebForm/Observaciones/PCrearObservacion.aspx");
    }
    void FiltrarInterfazUsuario()
    {
        if(Session["CodigoProyecto"] != null && Session["UsuarioSesion"] != null)
        {
            EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            if (SUtil.CorrespondeRevision(Session["CodigoProyecto"].ToString(), usuarioSesion.CodigoUsuario))
            {
                btnCrearObservacion.Enabled = !usuarioSesion.esEstudiante;
                btnCrearObservacion.Visible = !usuarioSesion.esEstudiante;
            }
        }
    }
    protected void ddlTipoObservacion_SelectedIndexChanged(object sender, EventArgs e)
    {
        FiltrarObservaciones();
    }

    protected void ddlEstadoObservacion_SelectedIndexChanged(object sender, EventArgs e)
    {
        FiltrarObservaciones();
    }

    protected void grvListaObservaciones_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        #region Modificar Visualmente Roles
        // Encuentra el índice de la columna que deseas modificar
        int estadoColumnIndex = grvListaObservaciones.Columns.IndexOf(grvListaObservaciones.Columns
            .Cast<DataControlField>()
            .FirstOrDefault(field => field.HeaderText == "Estado"));

        if (estadoColumnIndex >= 0)
        {
            try
            {
                // Modifica el contenido de la celda en esa columna para cada fila
                string estado = e.Row.Cells[estadoColumnIndex].Text;
                if (estado != "Estado")
                    e.Row.Cells[estadoColumnIndex].Text = SUtil.ObtenerNombreEstado(char.Parse(estado)); // Puedes cambiar "Nuevo valor" por el valor que quieras mostrar
            }
            catch (Exception) { }

        }
        #endregion
    }

    protected void txbObservador_TextChanged(object sender, EventArgs e)
    {
        FiltrarObservaciones();
    }

}