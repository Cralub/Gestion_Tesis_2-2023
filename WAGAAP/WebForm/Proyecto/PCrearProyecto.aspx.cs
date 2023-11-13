﻿using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Web.UI;

public partial class WebForm_Proyecto_PCrearProyecto : System.Web.UI.Page
{
    #region Controladoras
    CUsuario cUsuario = new CUsuario();
    CUsuarioNetvalle cUsuarioNetvalle = new CUsuarioNetvalle();
    CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
    CProyectoCompleja cProyectoCompleja = new CProyectoCompleja();
    CProyecto cProyecto = new CProyecto();
    CUsuarioRol cUsuarioRol = new CUsuarioRol();
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            //Inhabilita la posibilidad de crear un nuevo Proyecto hasta validar 
            btnCrearProyecto.Enabled = false;
            txbCodigoProyecto.Enabled = false;
            lblMensajeBuscarUsuarioCreacionProyecto.Text = "";
            lblMensajeCrearProyecto.Text = "";
        }
    }

    protected void btnBuscarUsuario_Click(object sender, EventArgs e)
    {
        //Si el codigoUsuario ingresado es correcto 
        if (txbCodigoUsuario.Text.Trim().Length > 9)
        {
            string CodigoUsuario = txbCodigoUsuario.Text.Trim();
            //Buscamos a un ESTUDIANTE en la base de Netvalle con el CodigoUsuario 
            EUsuarioNetvalle estudianteNetvalle = cUsuarioNetvalle.Obtener_UsuarioNetvalle_O_CodigoUsuario(CodigoUsuario);
            if (estudianteNetvalle != null && estudianteNetvalle.RolUsuarioNetvalle.ToUpper() == SDatosGlobales.NETVALLE_ESTUDIANTE)
            {
                //Si no existe algun proyecto con este usuario habilitamos las opciones para crear uno y guardamos la informacion
                List<EGUsuarioProyecto> lstEGUsuarioProyecto = cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoUsuario(CodigoUsuario);
                if (lstEGUsuarioProyecto.Count == 0)
                {
                    btnCrearProyecto.Enabled = true;
                    txbCodigoProyecto.Enabled = true;
                    Session["EstudianteNetvalle"] = estudianteNetvalle;
                    lblMensajeBuscarUsuarioCreacionProyecto.Text = string.Format("Creacion posible para el estudiante: {0}", estudianteNetvalle.NombreCompletoUsuarioNetvalle);
                }
                else
                    lblMensajeBuscarUsuarioCreacionProyecto.Text = string.Format("Proyecto existente con el estudiante: {0}", estudianteNetvalle.NombreCompletoUsuarioNetvalle);
            }
            else
                lblMensajeBuscarUsuarioCreacionProyecto.Text = "Codigo no encontrado o no pertenece a un Estudiante ";
        }
    }

    protected void btnCrearProyecto_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Open()", true);        
    }
    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        string codigoProyectoNuevo = txbCodigoProyecto.Text.Trim();
        //Validamos Codigo Proyecto correcto
        if (codigoProyectoNuevo.Length <= 4)
        {
            lblMensajeCrearProyecto.Text = "Codigo no valido";
            return;
        }
        EGProyecto eGProyecto = cProyecto.Obtener_GProyecto_O_CodigoProyecto(codigoProyectoNuevo);
        if (!string.IsNullOrEmpty(eGProyecto.CodigoProyecto))
        {
            lblMensajeCrearProyecto.Text = "Codigo existente";
            return;
        }
        
        //Recuperamos la informacion de Sesion del Director 
        if (Session["UsuarioSesion"] == null)
        {
            lblMensajeCrearProyecto.Text = "Codigo director no encontrado";
            return;
        }
        EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;

        if (Session["EstudianteNetvalle"] != null)
        {
            //Recuperamos la informacion del Estudiante
            EUsuarioNetvalle estudianteNetvalle = Session["EstudianteNetvalle"] as EUsuarioNetvalle;
            //En caso de no tener al estudiante en nuestra base lo creamos asi como le asignamos su rol de estudiante
            EGUsuario eGUsuario = cUsuario.Obtener_GUsuario_O_CodigoUsuario(estudianteNetvalle.CodigoUsuarioNetvalle);
            if (string.IsNullOrEmpty(eGUsuario.CodigoUsuario))
            {
                cUsuario.Insertar_GUsuario_I(estudianteNetvalle.CodigoUsuarioNetvalle, estudianteNetvalle.NombreCompletoUsuarioNetvalle, estudianteNetvalle.SedeUsuarioNetvalle);
                cUsuarioRol.Insertar_GUsuarioRol_I(cUsuarioRol.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol(), SDatosGlobales.ROL_ESTUDIANTE, estudianteNetvalle.CodigoUsuarioNetvalle);
            }
            //Creamos un nuevo Proyecto y quitamos las opciones por seguridad
            cProyectoCompleja.Insertar_ProyectoCompleto(codigoProyectoNuevo, estudianteNetvalle.CodigoUsuarioNetvalle, usuarioSesion.CodigoUsuario, SDatosGlobales.DURACION_ETAPA, SDatosGlobales.DURACION_SUB_ETAPA);
            Session["EstudianteNetvalle"] = null;
            btnCrearProyecto.Enabled = false;
            txbCodigoProyecto.Enabled = false;
        }
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Close()", true);
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Close()", true);
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/PaginaMaestra/Default.aspx");
    }    
}