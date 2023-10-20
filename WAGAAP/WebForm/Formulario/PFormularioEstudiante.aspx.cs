using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Formulario_PFormularioEstudiante : System.Web.UI.Page
{
    #region Controladores
    CEtapa cEtapa = new CEtapa();
    CSubEtapa cSubEtapa = new CSubEtapa();
    CProyecto cProyecto = new CProyecto();
    CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
    CProyectoCompleja cProyectoCompleja = new CProyectoCompleja();
    #endregion
    #region Metodos privados

    //private bool ValidarEntradas(EGProyecto eGProyecto)
    //{
    //    bool res = true;
    //    //No validados
        
    //    //
    //    return res;
    //}
    //private bool ValidacionDeEstados(EProyectoCompleja eProyectoC)
    //{
    //    bool res = false;
       

    //    EGEtapa eGEtapa = cEtapa.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(eProyectoC.CodigoProyecto);
    //    EGSubEtapa eGSubEtapa = cSubEtapa.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(eGEtapa.CodigoEtapa);
    //    res = cProyectoCompleja.Verificar_GProyecto_CorrespondeRevision(eProyectoC.CodigoRol, eGEtapa.NumeroEtapa, eGSubEtapa.NumeroSubEtapa);
    //    return res;
    //}
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["proyectoCompleja"] != null)
            {
                CargarInformacionProyecto();
            }
            
        }
    }

    

    private void CargarInformacionProyecto()
    {
        //EProyectoCompleja eProyecto = Session["proyectoCompleja"] as EProyectoCompleja;
        

       //// List<EGUsuarioProyecto> eGProyectoUsuario = new List<EGUsuarioProyecto>();
        
        

        ////FIN DATOS DE MUESTRA

      
        ////List<EGUsuarioProyecto> Estudiantes = cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoProyecto(eProyecto.CodigoProyecto).Where(s => s.CodigoRol == SDatosGlobales.ROL_ESTUDIANTE).ToList();
        //txbCodigoProyecto.Text = eProyecto.CodigoProyecto;
        //txbCodigoProyecto.Visible = false;
        //lkbEnlaceDocumento.Text = eProyecto.EnlaceDocumentoProyecto;
        //ddlEstudiantes.DataSource = eProyecto.CodigosEstudiantes;
        //ddlEstudiantes.DataBind();
        //txbTitulo.Text = eProyecto.TituloProyecto;
        //ddlModalidades.Text = eProyecto.ModalidadProyecto.ToString();
        //txbObjetivoGeneral.Text = eProyecto.ObjetivoGeneralProyecto;
       
        //bool EsModificable = ValidacionDeEstados(eProyecto);
        //if (!EsModificable)
        //{
        //    ddlModalidades.Enabled = false;
        //    txbObjetivoGeneral.Enabled = false;
        //    txbTitulo.Enabled = false;
        //    btnAgregar.Enabled = false;
        //}
    }

    

    public void btnAgregar_Click(object sender, EventArgs e)
    {
        //EGProyecto eGProyecto = new EGProyecto()
        //{
        //     CodigoProyecto = txbCodigoProyecto.Text.Trim(),
        //     ModalidadProyecto = char.Parse(ddlModalidades.SelectedValue.Trim()),
        //     TituloProyecto = txbTitulo.Text.Trim(),
        //     ObjetivoGeneralProyecto = txbObjetivoGeneral.Text.Trim(),
        //     EnlaceDocumentoProyecto = lkbEnlaceDocumento.Text.Trim()
        //};
        //if (ValidarEntradas(eGProyecto))
        //{
        //    cProyecto.Actualizar_GProyecto_A(eGProyecto.CodigoProyecto, eGProyecto.ModalidadProyecto, eGProyecto.TituloProyecto, eGProyecto.ObjetivoGeneralProyecto, eGProyecto.EnlaceDocumentoProyecto);
        //}
    }
    protected void BtnTutor_Click(object sender, EventArgs e)
    {
        Session["CodigoProyecto"] = txbCodigoProyecto.Text;
        Response.Redirect("~/WebForm/Formulario/PElegirTutor.aspx");
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Session["proyectoCompleja"] = null;
        Response.Redirect("~/WebForm/Formulario/PListarProyectosFormulario.aspx");
    }

    protected void ddlEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
    {
        int index = ddlEstudiantes.SelectedIndex;
        if (index != -1)
        {
            string CodigoUsuario = ddlEstudiantes.SelectedValue;
        }
    }

    protected void btnAvanzar_Click(object sender, EventArgs e)
    {

        //cProyectoCompleja.Actualizar_Etapa_SubEtapa_AvanzarEnFlujo((Session["proyectoCompleja"] as EProyectoCompleja).CodigoProyecto);
    }
}