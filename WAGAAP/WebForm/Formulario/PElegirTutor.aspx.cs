using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

public partial class WebForm_Formulario_PElegirTutor : System.Web.UI.Page
{
    #region Controladores
    CUsuarioRol cUsuarioRol = new CUsuarioRol();
    CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
    CUsuario cUsuario = new CUsuario();

    #endregion
    public static List<EGUsuario> lstTutoresValidos = new List<EGUsuario>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LimpiarVariables();
            BuscarTutores();
        }
    }
    private void BuscarTutores()
    {
        List<EGUsuarioRol> eGUsuarioRols = new List<EGUsuarioRol>();
        eGUsuarioRols = cUsuarioRol.Obtener_GUsuarioRol_O_CodigoRol(SDatosGlobales.ROL_TUTOR).ToList();
        //Filtrar Tutores con mas de X proyectos
        if(eGUsuarioRols.Count > 0)
        {
            List<EGUsuarioRol> lstEGUsuarioRolValidos = new List<EGUsuarioRol>();
            foreach (var tutor in eGUsuarioRols)
            {
                var numeroProyectos = cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoUsuario(tutor.CodigoUsuario).Count();
                if (numeroProyectos <= SDatosGlobales.N_MAXIMO_PROYECTOS_POR_TUTOR)
                {
                    lstEGUsuarioRolValidos.Add(tutor);
                }
            }

            grvTutores.DataSource = null;
            lstTutoresValidos = lstEGUsuarioRolValidos.Select(w => cUsuario.Obtener_GUsuario_O_CodigoUsuario(w.CodigoUsuario)).ToList();
            grvTutores.DataSource = lstTutoresValidos.ToList();
            grvTutores.DataBind();
        }
        else
            grvTutores.DataSource = null;
    }
   
    public void ElegirTutor(string codigoTutor)
    {
        if (Session["ProyectoComplejo"] != null)
        {
            EProyectoCompleja proyecto = Session["ProyectoComplejo"] as EProyectoCompleja;
            //Listamos los Usuarios del Proyecto
            List<EGUsuarioProyecto> usuariosDelProyecto = cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoProyecto(proyecto.CodigoProyecto).ToList();
            //Buscamos si tiene tutor
            EGUsuarioProyecto tutorEnProyecto = usuariosDelProyecto.FirstOrDefault(w => w.CodigoRol == SDatosGlobales.ROL_TUTOR);

            //Existe Tutor asignado a este proyecto
            if (tutorEnProyecto != null)
            {
                //El tutor no ha aceptado la invitacion al proyecto
                if (tutorEnProyecto.EstadoUsuarioProyecto != SDatosGlobales.ESTADO_ACTIVO)
                {
                    //El tutor elejido es distinto del actual
                    if (tutorEnProyecto.CodigoUsuario != codigoTutor)
                    {
                        //Modificamos al tutor y ponemos el estado E -> En espera que el tutor confirme que participara en el proyecto
                        cUsuarioProyecto.Actualizar_GUsuarioProyecto_A(tutorEnProyecto.CodigoUsuarioProyecto, tutorEnProyecto.CodigoProyecto, codigoTutor, tutorEnProyecto.CodigoRol, SDatosGlobales.ESTADO_PAUSADO);
                    }
                }
                else
                {
                    lblMensajeElegirTutor.Text = string.Format("El Proyecto {0} como tutor asignado", SUtil.ObtenerNombrePorCodigo(tutorEnProyecto.CodigoUsuario));
                }
            }
            else //Si el Proyecto no tiene tutor lo agregamos
            {                
                //2 -> Rol Tutor ,E -> En espera que el tutor confirme que participara en el proyecto 
                cUsuarioProyecto.Insertar_GUsuarioProyecto_I(cUsuarioProyecto.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto(), proyecto.CodigoProyecto, codigoTutor, SDatosGlobales.ROL_TUTOR, SDatosGlobales.ESTADO_PAUSADO);
            }
            Response.Redirect("~/WebForm/Formulario/PFormularioEstudiante.aspx");
        }
    }

  

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/WebForm/Formulario/PFormularioEstudiante.aspx");
    }

    protected void grvTutores_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        string codigoUsuario = grvTutores.DataKeys[index].Value.ToString();
        if (e.CommandName == "btnVer")
        {
            Session["CodigoUsuario"] = codigoUsuario;
            Session["PaginaAnterior"] = HttpContext.Current.Request.Url.PathAndQuery;
            Response.Redirect("~/WebForm/Informacion/PInformacionUsuario.aspx");
        }
        if (e.CommandName == "btnElegirTutor")
        {
            Session["CodigoUsuario"] = codigoUsuario;
            ElegirTutor(codigoUsuario);
        }
    }
    protected void txbBuscarTutor_TextChanged(object sender, EventArgs e)
    {
        List<EGUsuario> lstTutoresFiltrados = new List<EGUsuario>();
        if (string.IsNullOrEmpty(txbBuscarTutor.Text) || lstTutoresValidos.Count == 0)
        {
            grvTutores.DataSource = lstTutoresValidos;
        }
        else
        {
            string tutor = txbBuscarTutor.Text.ToUpper().Trim();
            lstTutoresFiltrados = lstTutoresValidos
                .Where(w => w.NombreCompletoUsuario.ToUpper().Contains(tutor)
                         || w.CodigoUsuario.ToUpper().Contains(tutor))
                .ToList();
            grvTutores.DataSource = lstTutoresFiltrados;
        }

        grvTutores.DataBind();
    }
    private void LimpiarVariables()
    {
        Session["PaginaAnterior"] = null;
    }
}