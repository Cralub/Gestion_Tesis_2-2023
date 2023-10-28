using SWLNGAAP;
using System;
using System.Collections.Generic;

public partial class WebForm_Proyecto_PCrearProyecto : System.Web.UI.Page
{
    #region Controladoras
    CUsuario cUsuario = new CUsuario();
    CUsuarioNetvalle cUsuarioNetvalle = new CUsuarioNetvalle();
    CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
    CProyectoCompleja cProyectoCompleja = new CProyectoCompleja();
    CUsuarioRol cUsuarioRol = new CUsuarioRol();
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            //Inhabilita la posibilidad de crear un nuevo Proyecto hasta validar 
            btnCrearProyecto.Enabled = false;
            txbCodigoProyecto.Enabled = false;
        }
    }

    protected void btnBuscarUsuario_Click(object sender, EventArgs e)
    {
        //Si el codigoUsuario ingresado es correcto 
        if (txbCodigoUsuario.Text.Trim().Length == 10)
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
                }
            }
        }
    }

    protected void btnCrearProyecto_Click(object sender, EventArgs e)
    {
        //Validamos Codigo Proyecto correcto
        if(txbCodigoProyecto.Text.Trim().Length == 4)
        {
            string CodigoProyecto = txbCodigoProyecto.Text.Trim();
            //Recuperamos la informacion de Sesion del Director 
            EUsuarioNetvalle usuarioNetvalle = Session["UsuarioSesion"] as EUsuarioNetvalle;
            if (Session["EstudianteNetvalle"] != null)
            {
                //Recuperamos la informacion del Estudiante
                EUsuarioNetvalle estudianteNetvalle = Session["EstudianteNetvalle"] as EUsuarioNetvalle;
                //En caso de no tener al estudiante en nuestra base lo creamos asi como le asignamos su rol de estudiante
                EGUsuario eGUsuario = cUsuario.Obtener_GUsuario_O_CodigoUsuario(estudianteNetvalle.CodigoUsuarioNetvalle);
                if (eGUsuario.CodigoUsuario.Equals(""))
                {
                    cUsuario.Insertar_GUsuario_I(estudianteNetvalle.CodigoUsuarioNetvalle, estudianteNetvalle.SedeUsuarioNetvalle);
                    cUsuarioRol.Insertar_GUsuarioRol_I(cUsuarioRol.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol(), SDatosGlobales.ROL_ESTUDIANTE, estudianteNetvalle.CodigoUsuarioNetvalle);
                }
                //Creamos un nuevo Proyecto y quitamos las opciones por seguridad
                cProyectoCompleja.Insertar_ProyectoCompleto(CodigoProyecto, SDatosGlobales.DuracionEtapa, SDatosGlobales.DuracionSubEtapaEtapa, estudianteNetvalle.CodigoUsuarioNetvalle, usuarioNetvalle.CodigoUsuarioNetvalle);
                Session["EstudianteNetvalle"] = null;
                btnCrearProyecto.Enabled = false;
                txbCodigoProyecto.Enabled = false;
            }
        }
        
        
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/PaginaMaestra/Default.aspx");
    }
}