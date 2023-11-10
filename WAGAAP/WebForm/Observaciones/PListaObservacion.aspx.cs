using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using SWLNGAAP;


public partial class WebForm_PListaObservacion : System.Web.UI.Page
{
    #region Controladores
    CObservacion cObservacion = new CObservacion();
    #endregion
    public static List<EGObservacion> listaObservaciones = new List<EGObservacion>();

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
        listaObservaciones = new List<EGObservacion>();
        if (Session["CodigoProyecto"] != null)
        {
            string codigoProyecto = Session["CodigoProyecto"].ToString();
            listaObservaciones = cObservacion.Obtener_GObservacion_O_CodigoProyecto(codigoProyecto);
            grvListaObservaciones.DataSource = listaObservaciones;
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

        var observacionesFiltradas = listaObservaciones
                                        .Where(w => w.TipoObservacion == tipoSeleccionado || tipoSeleccionado == 'T'
                                        && w.EstadoObservacion == estadoSeleccionado || estadoSeleccionado == 'T');
        grvListaObservaciones.DataSource = observacionesFiltradas;
        grvListaObservaciones.DataBind();
    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Session["CodigoProyecto"] = null;
        Response.Redirect("~/WebForm/Proyecto/PListarProyectos.aspx");
    }



    protected void btnCrearObservacion_Click(object sender, EventArgs e)
    {
        if (Session["CodigoProyecto"] != null)
            Response.Redirect("~/WebForm/Observaciones/PCrearObservacion.aspx");
    }
    void FiltrarInterfazUsuario()
    {
        bool esPosibleAgregar = false;
        if (Session["CorrespondeRevision"] != null)
        {
            esPosibleAgregar = bool.Parse(Session["CorrespondeRevision"].ToString());
        }
        if (esPosibleAgregar)
        {
            if (Session["UsuarioSesion"] != null)
            {
                EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;

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
        //if (Session["UsuarioSession"] != null)
        //{
        //    EUsuarioSesionGAAP eUsuarioSesionGAAP = Session["UsuarioSession"] as EUsuarioSesionGAAP;
        //    if (e.Row.RowType == DataControlRowType.DataRow)
        //    {
        //        ButtonField btnModificar = (ButtonField)grvListaObservaciones.Columns[0]; // Ajusta el índice de la celda según la posición del botón en la fila

        //        if (btnModificar != null)
        //        {
        //            if(listaObservaciones[e.Row.RowIndex].EstadoObservacion == SDatosGlobales.ESTADO_ACTIVO && listaObservaciones[e.Row.RowIndex].CodigoUsuarioObservacion == eUsuarioSesionGAAP.CodigoUsuario)
        //            {
        //                btnModificar.Visible = false;
        //            }
        //            else
        //                btnModificar.Visible =true;

        //        }
        //    }
        //}
    }
}