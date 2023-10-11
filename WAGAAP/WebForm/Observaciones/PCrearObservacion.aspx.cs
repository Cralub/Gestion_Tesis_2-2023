﻿using SWLNGAAP;
using System;

public partial class WebForm_Observaciones_PCrearObservacion : System.Web.UI.Page
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

        }
    }
    //Datos de prueba
    string CodigoProyectoPrueba = "PRGAAP001";
    int CodigoSubEtapaPrueba = 1;
    string CodigoUsuarioObservacionPrueba = "BLC0030298";
    //
   
    protected void btnCrearObservacion_Click(object sender, EventArgs e)
    {
        EGObservacion eGObservacion = new EGObservacion()
        {
            CodigoObservacion = cObservacion.Obtener_GObsevacion_O_SiguienteCodigoObservacion(),
            CodigoProyecto = CodigoProyectoPrueba,
            CodigoSubEtapa = CodigoSubEtapaPrueba,
            CodigoUsuarioObservacion = CodigoUsuarioObservacionPrueba,
            TipoObservacion = rbObservacionFondo.Checked ? 'O' : 'A',
            ComentarioObservacion = txtComentario.Text,
            EstadoObservacion = 'A'
        };
        if (ValidarEntradas(eGObservacion))
        {
            cObservacion.Insertar_GObservacion_I(
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