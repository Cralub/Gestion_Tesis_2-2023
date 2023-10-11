using SWLNGAAP;
using System;

public partial class WebForm_Observaciones_PActualizarObservacion : System.Web.UI.Page
{ 
    #region Controladoras
    CObservacion cObservacion = new CObservacion();
    #endregion
    #region Metodos privados

    private bool ValidarEntradas(EGObservacion eGObservacion)
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
            CargarDatosObservacion();
        }
    }
    //Datos de prueba
    string CodigoProyectoPrueba = "PRGAAP001";
    int CodigoSubEtapaPrueba = 1;
    string CodigoUsuarioObservacionPrueba = "BLC0030298";
    //
   
   

   
    //Metodo de Prueba
    void CargarDatosObservacion()
    {
        //if(Session["CodigoObservacion"] > 0)
        if (txtCodigoObservación.Text != "")
        {
            EGObservacion eGObservacion = cObservacion.Obtener_GObservacion_O_CodigoObservacion(int.Parse(txtCodigoObservación.Text));
            if (eGObservacion.TipoObservacion == 'O') rbObservacionFondo.Checked = true; else rbObservacionForma.Checked = true;
            txtComentario.Text = eGObservacion.ComentarioObservacion;
        }
        else
        {
            EGObservacion eGObservacion = cObservacion.Obtener_GObservacion_O_CodigoObservacion(1);
            if (eGObservacion.TipoObservacion == 'O') rbObservacionFondo.Checked = true; else rbObservacionForma.Checked = true;
            txtComentario.Text = eGObservacion.ComentarioObservacion;
        }
    }
    protected void btnBuscarObservacion_Click(object sender, EventArgs e)
    {
        CargarDatosObservacion();
    }
    //
    protected void btnActualizarObservacion_Click(object sender, EventArgs e)
    {
        EGObservacion eGObservacion = new EGObservacion()
        {
            CodigoObservacion = int.Parse(txtCodigoObservación.Text),
            CodigoProyecto = CodigoProyectoPrueba,
            CodigoSubEtapa = CodigoSubEtapaPrueba,
            CodigoUsuarioObservacion = CodigoUsuarioObservacionPrueba,
            TipoObservacion = rbObservacionFondo.Checked ? 'O' : 'A',
            ComentarioObservacion = txtComentario.Text,
            EstadoObservacion = 'A'
        };
        if (ValidarEntradas(eGObservacion))
        {
            cObservacion.Actualizar_GObservacion_A(
                eGObservacion.CodigoObservacion,
                eGObservacion.CodigoProyecto,
                eGObservacion.CodigoSubEtapa,
                eGObservacion.CodigoUsuarioObservacion,
                eGObservacion.ComentarioObservacion,
                eGObservacion.TipoObservacion,
                eGObservacion.EstadoObservacion);
        }
    }
}