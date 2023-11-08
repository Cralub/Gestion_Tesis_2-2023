using System;
using SWLNGAAP;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Observaciones_PCrearFormularioAceptacion : System.Web.UI.Page
{
    #region Controladores
    CFormularioAceptacion cFormularioAceptacion = new CFormularioAceptacion();
    CProyecto cProyecto = new CProyecto();
    #endregion
    #region Metodos privados
    private bool ValidarEntradas(EGFormularioAceptacion eGFormularioAceptacion)
    {
        bool res = true;
        //No validados

        //
        return res;
    }
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
        EProyectoCompleja eProyecto = Session["proyectoCompleja"] as EProyectoCompleja;


        // List<EGUsuarioProyecto> eGProyectoUsuario = new List<EGUsuarioProyecto>();



        //FIN DATOS DE MUESTRA


        ////List<EGUsuarioProyecto> Estudiantes = cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoProyecto(eProyecto.CodigoProyecto).Where(s => s.CodigoRol == SDatosGlobales.ROL_ESTUDIANTE).ToList();
        //rbPreguntaFormatoYForma1.Text = 'S';
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
        EGFormularioAceptacion eGFormularioAceptacion = new EGFormularioAceptacion()
        {
            CodigoProyecto = "w",
            CodigoEstudiante = "w",
            CodigoTribunal = "w",
            PreguntaFormatoYForma1 = char.Parse(rbPreguntaFormatoYForma1.SelectedValue.ToString()),
            PreguntaFormatoYForma2 = char.Parse(rbPreguntaFormatoYForma2.SelectedValue.ToString()),
            PreguntaFormatoYForma3 = char.Parse(rbPreguntaFormatoYForma3.SelectedValue.ToString()),
            PreguntaFormatoYForma4 = char.Parse(rbPreguntaFormatoYForma4.SelectedValue.ToString()),
            PreguntaFormatoYForma5 = char.Parse(rbPreguntaFormatoYForma5.SelectedValue.ToString()),
            PreguntaFormatoYForma6 = char.Parse(rbPreguntaFormatoYForma6.SelectedValue.ToString()),
            PreguntaFormatoYForma7 = char.Parse(rbPreguntaFormatoYForma7.SelectedValue.ToString()),
            PreguntaFormatoYForma8 = char.Parse(rbPreguntaFormatoYForma8.SelectedValue.ToString()),
            PreguntaFormatoYForma9 = char.Parse(rbPreguntaFormatoYForma9.SelectedValue.ToString()),
            PreguntaFormatoYForma10 = char.Parse(rbPreguntaFormatoYForma10.SelectedValue.ToString()),
            PreguntaFondo1 = char.Parse(rbPreguntaFondo1.SelectedValue.ToString()),
            PreguntaFondo2 = char.Parse(rbPreguntaFondo2.SelectedValue.ToString()),
            PreguntaFondo3 = char.Parse(rbPreguntaFondo3.SelectedValue.ToString()),
            PreguntaFondo4 = char.Parse(rbPreguntaFondo4.SelectedValue.ToString()),
            PreguntaFondo5 = char.Parse(rbPreguntaFondo5.SelectedValue.ToString()),
            PreguntaFondo6 = char.Parse(rbPreguntaFondo6.SelectedValue.ToString()),
            PreguntaFondo7 = char.Parse(rbPreguntaFondo7.SelectedValue.ToString()),
            PreguntaFondo8 = char.Parse(rbPreguntaFondo8.SelectedValue.ToString()),
            PreguntaFondo9 = char.Parse(rbPreguntaFondo9.SelectedValue.ToString()),
            PreguntaFondo10 = char.Parse(rbPreguntaFondo10.SelectedValue.ToString()),
        };

        cFormularioAceptacion.Insertar_GFormularioAceptacion_I(4, eGFormularioAceptacion.CodigoProyecto,
            eGFormularioAceptacion.CodigoEstudiante, 
            eGFormularioAceptacion.CodigoTribunal, 
            eGFormularioAceptacion.PreguntaFormatoYForma1, 
            eGFormularioAceptacion.PreguntaFormatoYForma2, 
            eGFormularioAceptacion.PreguntaFormatoYForma3, 
            eGFormularioAceptacion.PreguntaFormatoYForma4, 
            eGFormularioAceptacion.PreguntaFormatoYForma5, 
            eGFormularioAceptacion.PreguntaFormatoYForma6, 
            eGFormularioAceptacion.PreguntaFormatoYForma7, 
            eGFormularioAceptacion.PreguntaFormatoYForma8, 
            eGFormularioAceptacion.PreguntaFormatoYForma9, 
            eGFormularioAceptacion.PreguntaFormatoYForma10, 
            eGFormularioAceptacion.PreguntaFondo1, 
            eGFormularioAceptacion.PreguntaFondo2, 
            eGFormularioAceptacion.PreguntaFondo3, 
            eGFormularioAceptacion.PreguntaFondo4, 
            eGFormularioAceptacion.PreguntaFondo5, 
            eGFormularioAceptacion.PreguntaFondo6, 
            eGFormularioAceptacion.PreguntaFondo7, 
            eGFormularioAceptacion.PreguntaFondo8, 
            eGFormularioAceptacion.PreguntaFondo9, 
            eGFormularioAceptacion.PreguntaFondo10);
    }

}