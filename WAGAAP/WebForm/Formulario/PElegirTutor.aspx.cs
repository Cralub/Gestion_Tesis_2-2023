using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Formulario_PElegirTutor : System.Web.UI.Page
{
    #region Controladores
    CUsuarioRol cUsuarioRol = new CUsuarioRol();
    CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
    
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BuscarTutores();
        }
    }
    private void BuscarTutores()
    {
        //List<EGUsuarioRol> eGUsuarioRols = new List<EGUsuarioRol>();
        //eGUsuarioRols = cUsuarioRol.Obtener_GUsuarioRol_O_CodigoRol(SDatosGlobales.ROL_TUTOR).ToList();
      
        
        //ddlTutores.DataSource = eGUsuarioRols;
        //ddlTutores.DataTextField = "CodigoUsuario";
        //ddlTutores.DataValueField = "CodigoUsuario";
        //ddlTutores.DataBind();

    }
    public void SeleccionarTutor(string codigoTutor)
    {
        //string codigoProyecto = Session["CodigoProyecto"].ToString();
        //if (ddlTutores.SelectedIndex != -1)
        //{
        //    //Listamos los Usuarios del Proyecto
        //    List<EGUsuarioProyecto> usuariosDelProyecto = cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto).ToList();
        //    //Buscamos si tiene tutor
        //    EGUsuarioProyecto tutor = usuariosDelProyecto.Where(w => w.CodigoRol == SDatosGlobales.ROL_TUTOR).FirstOrDefault();
        //    //Si tiene tutor
        //    if (tutor != null)
        //    {
        //        //Si a cambiado de tutor
        //        if (tutor.CodigoUsuario != codigoTutor)
        //        {
        //            //Modificamos al tutor y ponemos el estado E -> En espera que el tutor confirme que participara en el proyecto
        //            cUsuarioProyecto.Actualizar_GUsuarioProyecto_A(tutor.CodigoUsuarioProyecto, tutor.CodigoProyecto, codigoTutor, tutor.CodigoRol,SDatosGlobales.Pausado);
        //        }
        //    }
        //    else //Si el Proyecto no tiene tutor lo creamos
        //    {
        //        //2 -> Rol Tutor ,E -> En espera que el tutor confirme que participara en el proyecto 
        //        cUsuarioProyecto.Insertar_GUsuarioProyecto_I(cUsuarioProyecto.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto(),codigoProyecto, codigoTutor, SDatosGlobales.ROL_TUTOR, SDatosGlobales.Pausado);

        //    }
        //}
    }

    protected void btnElegirTutor_Click(object sender, EventArgs e)
    {
        if(ddlTutores.SelectedIndex != -1)
        {
            SeleccionarTutor(ddlTutores.SelectedValue);
        }
        Response.Redirect("~/WebForm/Formulario/PFormularioEstudiante.aspx");
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Session["CodigoProyecto"] = null;
        Response.Redirect("~/WebForm/Formulario/PFormularioEstudiante.aspx");
    }
}