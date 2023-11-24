using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
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
    static List<EGUsuarioRol> usuariosDAAP = new List<EGUsuarioRol>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            FiltrarInterfazUsuario();
            CargarDatosUsuariosDAAP();
        }
    }

    private void CargarDatosUsuariosDAAP()
    {
        usuariosDAAP = cUsuarioRol.Obtener_GUsuarioRol_O_CodigoRol(SDatosGlobales.ROL_DAAP).ToList();
        var nombresUsuariosDAAP = usuariosDAAP.Select(s => SUtil.ObtenerNombrePorCodigo(s.CodigoUsuario)).ToList();
        ddlUsuarioDAAP.DataSource = nombresUsuariosDAAP; 
        ddlUsuarioDAAP.DataBind();

    }

    protected void btnBuscarUsuario_Click(object sender, EventArgs e)
    {
        FiltrarInterfazUsuario();
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
                    lblMensajeBuscarUsuarioCreacionProyecto.Text = string.Format("Proyecto existente con el estudiante: {0}", estudianteNetvalle.NombreCompletoUsuarioNetvalle);}
            else
                lblMensajeBuscarUsuarioCreacionProyecto.Text = "Codigo no encontrado o no pertenece a un Estudiante ";
            
               
        }
    }

    protected void btnCrearProyecto_Click(object sender, EventArgs e)
    {
        //lblModal.Text = "¿Esta seguro que quiero crear este proyecto?";
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Open()", true);        
    }
    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        string codigoProyectoNuevo = txbCodigoProyecto.Text.Trim();

        if (!ValidarCodigoProyecto(codigoProyectoNuevo))
            return;

        EGProyecto eGProyecto = cProyecto.Obtener_GProyecto_O_CodigoProyecto(codigoProyectoNuevo);

        if (!ProyectoNoExiste(eGProyecto))
            return;

        if (!UsuarioSesionValido())
            return;

        if (Session["EstudianteNetvalle"] != null)
        {
            if (!SeleccionarUsuarioDAAP())
            {
                lblMensajeCrearProyecto.Text = "Escoja un representante de DAAP";
                return;
            }

            EUsuarioNetvalle estudianteNetvalle = Session["EstudianteNetvalle"] as EUsuarioNetvalle;
            CrearOActualizarUsuario(estudianteNetvalle);

            EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            CrearNuevoProyecto(codigoProyectoNuevo, estudianteNetvalle.CodigoUsuarioNetvalle, usuarioSesion.CodigoUsuario);

            Session["EstudianteNetvalle"] = null;
            FiltrarInterfazUsuario();
            lblMensajeCrearProyecto.Text = "Proyecto Creado con éxito";
        }

        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Close()", true);
    }

    
    private bool ValidarCodigoProyecto(string codigoProyecto)
    {
        if (codigoProyecto.Length <= 4)
        {
            lblMensajeCrearProyecto.Text = "Codigo no válido";
            FiltrarInterfazUsuario();
            return false;
        }
        return true;
    }

    private bool ProyectoNoExiste(EGProyecto eGProyecto)
    {
        if (!string.IsNullOrEmpty(eGProyecto.CodigoProyecto))
        {
            lblMensajeCrearProyecto.Text = "Codigo existente";
            FiltrarInterfazUsuario();
            return false;
        }
        return true;
    }

    private bool UsuarioSesionValido()
    {
        if (Session["UsuarioSesion"] == null)
        {
            lblMensajeCrearProyecto.Text = "Codigo director no encontrado";
            FiltrarInterfazUsuario();
            return false;
        }
        return true;
    }

    private bool SeleccionarUsuarioDAAP()
    {
        return ddlUsuarioDAAP.SelectedIndex >= 0;
    }

    private void CrearOActualizarUsuario(EUsuarioNetvalle estudianteNetvalle)
    {
        EGUsuario eGUsuario = cUsuario.Obtener_GUsuario_O_CodigoUsuario(estudianteNetvalle.CodigoUsuarioNetvalle);
        if (string.IsNullOrEmpty(eGUsuario.CodigoUsuario))
        {
            cUsuario.Insertar_GUsuario_I(estudianteNetvalle.CodigoUsuarioNetvalle, estudianteNetvalle.NombreCompletoUsuarioNetvalle, estudianteNetvalle.SedeUsuarioNetvalle);
            cUsuarioRol.Insertar_GUsuarioRol_I(cUsuarioRol.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol(), SDatosGlobales.ROL_ESTUDIANTE, estudianteNetvalle.CodigoUsuarioNetvalle);
        }
    }

    private void CrearNuevoProyecto(string codigoProyectoNuevo, string codigoUsuarioEstudiante, string codigoUsuarioDirector)
    {
        cProyectoCompleja.Insertar_ProyectoCompleto(codigoProyectoNuevo, codigoUsuarioEstudiante, codigoUsuarioDirector, usuariosDAAP[ddlUsuarioDAAP.SelectedIndex - 1].CodigoUsuario, SDatosGlobales.DURACION_ETAPA, SDatosGlobales.DURACION_SUB_ETAPA);
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Close()", true);
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/PaginaMaestra/Default.aspx");
    }    
    void FiltrarInterfazUsuario()
    {
        
        btnCrearProyecto.Enabled = false;
        txbCodigoProyecto.Enabled = false;
        lblMensajeBuscarUsuarioCreacionProyecto.Text = "";
        lblMensajeCrearProyecto.Text = "";
    }
}