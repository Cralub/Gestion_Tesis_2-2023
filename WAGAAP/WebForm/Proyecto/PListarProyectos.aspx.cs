﻿using SWLNGAAP;
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
    //EUsuarioNetvalle eUsuarioNetvalle = new EUsuarioNetvalle();
    public static List<EProyectoCompleja> lstProyectos = new List<EProyectoCompleja>();
    public static List<EGUsuario> lstUsuarios = new List<EGUsuario>();
    public static List<EGUsuarioProyecto> lstUsuarioProyectos = new List<EGUsuarioProyecto>();
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
        lstProyectos = new List<EProyectoCompleja>();
        lstUsuarios = new List<EGUsuario>();
        lstUsuarioProyectos = new List<EGUsuarioProyecto>();
        EUsuarioNetvalle eUsuarioNetvalle = Session["UsuarioSesion"] as EUsuarioNetvalle;        

        lstProyectos = cProyectoCompleja.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(eUsuarioNetvalle.CodigoUsuarioNetvalle).ToList();
        grvListaProyectos.DataSource = lstProyectos;
        grvListaProyectos.DataBind();

        //foreach (EProyectoCompleja proyectoCompleja in lstProyectos)
        //{
        //    if (lstUsuarios.Count == 0)
        //        lstUsuarios = cUsuario.Obtener_GUsuarios_O_CodigoProyecto(proyectoCompleja.CodigoProyecto);
        //    else
        //        lstUsuarios = lstUsuarios.Union(cUsuario.Obtener_GUsuarios_O_CodigoProyecto(proyectoCompleja.CodigoProyecto)).ToList();

        //    if (lstUsuarioProyectos.Count == 0)
        //        lstUsuarioProyectos = cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoProyecto(proyectoCompleja.CodigoProyecto);
        //    else
        //        lstUsuarioProyectos = lstUsuarioProyectos.Union(cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoProyecto(proyectoCompleja.CodigoProyecto)).ToList();
        //}
    }
    
    protected void FiltrarProyectos()
    {
        char tipoSeleccionado = Convert.ToChar(ddlTipoProyecto.SelectedValue);
        char estadoSeleccionado = Convert.ToChar(ddlEstadoProyecto.SelectedValue);
        string nombreUsuario = txbCodigoUsuario.Text;

        //var proyectosFiltrados = (from p in lstProyectos
        //                          join up in lstUsuarioProyectos on p.CodigoProyecto equals up.CodigoProyecto
        //                          join u in lstUsuarios on up.CodigoUsuario equals u.CodigoUsuario
        //                          where (tipoSeleccionado == 'T' || p.ModalidadProyecto == tipoSeleccionado) &&
        //                                (estadoSeleccionado == 'T' || p.EstadoProyecto == estadoSeleccionado) &&
        //                                (string.IsNullOrEmpty(nombreUsuario) || u.NombreCompletoUsuario.ToUpper().Contains(nombreUsuario.ToUpper()))
        //                          select p).Distinct().ToList();

        var proyectosFiltrados = lstProyectos
                                    .Where(w => tipoSeleccionado == 'T' || w.ModalidadProyecto == tipoSeleccionado &&
                                                estadoSeleccionado == 'T' || w.EstadoProyecto == estadoSeleccionado &&
                                                string.IsNullOrEmpty(nombreUsuario) || w.NombresEstudiantes.Where(e => e.ToUpper().Contains(nombreUsuario.ToUpper()));
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
            //Response.Redirect("~/WebForm/Informacion/PInformacionUsuario.aspx");
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