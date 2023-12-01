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
        if (!IsPostBack)
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
        if (string.IsNullOrEmpty(codigoProyecto) || codigoProyecto.Length <= 4)
        {
            lblMensajeCrearProyecto.Text = "* Ingrese un Codigo Valido *";
            
            return false;
        }
        return true;
    }

    private bool ProyectoNoExiste(EGProyecto eGProyecto)
    {
        if (!string.IsNullOrEmpty(eGProyecto.CodigoProyecto))
        {
            lblMensajeCrearProyecto.Text = "* El Codigo de Proyecto ingresado ya existe *";
            return false;
        }
        return true;
    }

    private bool UsuarioSesionValido()
    {
        if (Session["UsuarioSesion"] == null)
        {
            lblMensajeCrearProyecto.Text = "* Codigo Director no encontrado *";
            
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
        cProyectoCompleja.Insertar_ProyectoCompleto(codigoProyectoNuevo, codigoUsuarioEstudiante, codigoUsuarioDirector, usuariosDAAP[ddlUsuarioDAAP.SelectedIndex].CodigoUsuario, SDatosGlobales.DURACION_ETAPA, SDatosGlobales.DURACION_SUB_ETAPA);
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Close()", true);
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/WebForm/ControlesDirector/PMenuOpcionesDirector.aspx");
    }
    void FiltrarInterfazUsuario()
    {

        btnCrearProyecto.Enabled = false;
        btnCrearProyecto.Visible = false;
        txbCodigoProyecto.Enabled = false;
        txbCodigoProyecto.Visible = false;
        ddlUsuarioDAAP.Enabled = false;
        ddlUsuarioDAAP.Visible = false;
        lblDAAP.Visible = false;
        lblMensajeBuscarUsuarioCreacionProyecto.Text = "";
        lblMensajeCrearProyecto.Text = "";
    }
    
    protected void txbCodigoUsuario_TextChanged(object sender, EventArgs e)
    {
        FiltrarInterfazUsuario();
        //Si el codigoUsuario ingresado es correcto 
        if (txbCodigoUsuario.Text.Trim().Length > 3)
        {
            string CodigoUsuario = txbCodigoUsuario.Text.Trim();
            //Buscamos a un ESTUDIANTE en la base de Netvalle con el CodigoUsuario 
            EUsuarioNetvalle estudianteNetvalle = cUsuarioNetvalle.Obtener_UsuarioNetvalle_O_CodigoUsuario(CodigoUsuario);
            if (!string.IsNullOrEmpty(estudianteNetvalle.CodigoUsuarioNetvalle))
            {
                if (estudianteNetvalle.RolUsuarioNetvalle.ToUpper() == SDatosGlobales.NETVALLE_ESTUDIANTE)
                {
                    //Si no existe algun proyecto con este usuario habilitamos las opciones para crear uno y guardamos la informacion
                    List<EGUsuarioProyecto> lstEGUsuarioProyecto = cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoUsuario(CodigoUsuario);
                    if (lstEGUsuarioProyecto.Count == 0)
                    {
                        btnCrearProyecto.Enabled = true;
                        btnCrearProyecto.Visible = true;
                        txbCodigoProyecto.Enabled = true;
                        txbCodigoProyecto.Visible = true;
                        ddlUsuarioDAAP.Enabled = true;
                        ddlUsuarioDAAP.Visible = true;
                        lblDAAP.Visible = true;
                        Session["EstudianteNetvalle"] = estudianteNetvalle;
                        lblMensajeBuscarUsuarioCreacionProyecto.Text = string.Format(">> La Creacion es Posible para el Estudiante: {0}", estudianteNetvalle.NombreCompletoUsuarioNetvalle);
                    }
                    else
                        lblMensajeBuscarUsuarioCreacionProyecto.Text = string.Format("* Ya se Encuentra en un Proyecto Activo el Estudiante: {0} *", estudianteNetvalle.NombreCompletoUsuarioNetvalle);
                }
                else
                    lblMensajeBuscarUsuarioCreacionProyecto.Text = "* El Codigo Ingresado No Pertenece a un Estudiante *";
            }
            else
                lblMensajeBuscarUsuarioCreacionProyecto.Text = "* El Codigo Ingresado no fue Encontrado *";
        }
    }
}