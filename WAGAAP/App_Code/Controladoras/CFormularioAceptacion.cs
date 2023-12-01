using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Descripción breve de CFormularioAceptacion
/// </summary>
public class CFormularioAceptacion
{
    #region Atributos

    private LNServicio lNServicio;

    #endregion

    #region Propiedades

    public string NombreClase
    {
        get { return GetType().Name; }
    }

    #endregion

    #region Constructor

    public CFormularioAceptacion()
    {
        lNServicio = new LNServicio();
    }

    #endregion

    #region Metodos Publicos

    #region GFormularioAceptacion
    public void Insertar_GFormularioAceptacion_I(int codigoFormularioAceptacion, string codigoProyecto, string codigoEstudiante, string codigoTribunal, char preguntaFormatoYForma1, char preguntaFormatoYForma2, char preguntaFormatoYForma3, char preguntaFormatoYForma4, char preguntaFormatoYForma5, char preguntaFormatoYForma6, char preguntaFormatoYForma7, char preguntaFormatoYForma8, char preguntaFormatoYForma9, char preguntaFormatoYForma10, char preguntaFondo1, char preguntaFondo2, char preguntaFondo3, char preguntaFondo4, char preguntaFondo5, char preguntaFondo6, char preguntaFondo7, char preguntaFondo8, char preguntaFondo9, char preguntaFondo10)
    {
        EGFormularioAceptacion eGFormularioAceptacion = new EGFormularioAceptacion();
        try
        {
            eGFormularioAceptacion.CodigoFormularioAceptacion = codigoFormularioAceptacion;
            eGFormularioAceptacion.CodigoProyecto = codigoProyecto;
            eGFormularioAceptacion.CodigoEstudiante = codigoEstudiante;
            eGFormularioAceptacion.CodigoTribunal = codigoTribunal;
            eGFormularioAceptacion.PreguntaFormatoYForma1 = preguntaFormatoYForma1;
            eGFormularioAceptacion.PreguntaFormatoYForma2 = preguntaFormatoYForma2;
            eGFormularioAceptacion.PreguntaFormatoYForma3 = preguntaFormatoYForma3;
            eGFormularioAceptacion.PreguntaFormatoYForma4 = preguntaFormatoYForma4;
            eGFormularioAceptacion.PreguntaFormatoYForma5 = preguntaFormatoYForma5;
            eGFormularioAceptacion.PreguntaFormatoYForma6 = preguntaFormatoYForma6;
            eGFormularioAceptacion.PreguntaFormatoYForma7 = preguntaFormatoYForma7;
            eGFormularioAceptacion.PreguntaFormatoYForma8 = preguntaFormatoYForma8;
            eGFormularioAceptacion.PreguntaFormatoYForma8 = preguntaFormatoYForma9;
            eGFormularioAceptacion.PreguntaFormatoYForma10 = preguntaFormatoYForma10;
            eGFormularioAceptacion.PreguntaFondo1 = preguntaFondo1;
            eGFormularioAceptacion.PreguntaFondo2 = preguntaFondo2;
            eGFormularioAceptacion.PreguntaFondo3 = preguntaFondo3;
            eGFormularioAceptacion.PreguntaFondo4 = preguntaFondo4;
            eGFormularioAceptacion.PreguntaFondo5 = preguntaFondo5;
            eGFormularioAceptacion.PreguntaFondo6 = preguntaFondo6;
            eGFormularioAceptacion.PreguntaFondo7 = preguntaFondo7;
            eGFormularioAceptacion.PreguntaFondo8 = preguntaFondo8;
            eGFormularioAceptacion.PreguntaFondo9 = preguntaFondo9;
            eGFormularioAceptacion.PreguntaFondo10 = preguntaFondo10;

            lNServicio.Insertar_GFormularioAceptacion_I(eGFormularioAceptacion);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public void Actualizar_GFormularioAceptacion_A(int codigoFormularioAceptacion, string codigoProyecto, string codigoEstudiante, string codigoTribunal, char preguntaFormatoYForma1, char preguntaFormatoYForma2, char preguntaFormatoYForma3, char preguntaFormatoYForma4, char preguntaFormatoYForma5, char preguntaFormatoYForma6, char preguntaFormatoYForma7, char preguntaFormatoYForma8, char preguntaFormatoYForma9, char preguntaFormatoYForma10, char preguntaFondo1, char preguntaFondo2, char preguntaFondo3, char preguntaFondo4, char preguntaFondo5, char preguntaFondo6, char preguntaFondo7, char preguntaFondo8, char preguntaFondo9, char preguntaFondo10, char estadoFormularioAceptacion)
    {
        EGFormularioAceptacion eGFormularioAceptacion = new EGFormularioAceptacion();
        try
        {
            eGFormularioAceptacion.CodigoFormularioAceptacion = codigoFormularioAceptacion;
            eGFormularioAceptacion.CodigoProyecto = codigoProyecto;
            eGFormularioAceptacion.CodigoEstudiante = codigoEstudiante;
            eGFormularioAceptacion.CodigoTribunal = codigoTribunal;
            eGFormularioAceptacion.PreguntaFormatoYForma1 = preguntaFormatoYForma1;
            eGFormularioAceptacion.PreguntaFormatoYForma2 = preguntaFormatoYForma2;
            eGFormularioAceptacion.PreguntaFormatoYForma3 = preguntaFormatoYForma3;
            eGFormularioAceptacion.PreguntaFormatoYForma4 = preguntaFormatoYForma4;
            eGFormularioAceptacion.PreguntaFormatoYForma5 = preguntaFormatoYForma5;
            eGFormularioAceptacion.PreguntaFormatoYForma6 = preguntaFormatoYForma6;
            eGFormularioAceptacion.PreguntaFormatoYForma7 = preguntaFormatoYForma7;
            eGFormularioAceptacion.PreguntaFormatoYForma8 = preguntaFormatoYForma8;
            eGFormularioAceptacion.PreguntaFormatoYForma8 = preguntaFormatoYForma9;
            eGFormularioAceptacion.PreguntaFormatoYForma10 = preguntaFormatoYForma10;
            eGFormularioAceptacion.PreguntaFondo1 = preguntaFondo1;
            eGFormularioAceptacion.PreguntaFondo2 = preguntaFondo2;
            eGFormularioAceptacion.PreguntaFondo3 = preguntaFondo3;
            eGFormularioAceptacion.PreguntaFondo4 = preguntaFondo4;
            eGFormularioAceptacion.PreguntaFondo5 = preguntaFondo5;
            eGFormularioAceptacion.PreguntaFondo6 = preguntaFondo6;
            eGFormularioAceptacion.PreguntaFondo7 = preguntaFondo7;
            eGFormularioAceptacion.PreguntaFondo8 = preguntaFondo8;
            eGFormularioAceptacion.PreguntaFondo9 = preguntaFondo9;
            eGFormularioAceptacion.PreguntaFondo10 = preguntaFondo10;
            eGFormularioAceptacion.EstadoFormularioAceptacion = estadoFormularioAceptacion;
            lNServicio.Actualizar_GFormularioAceptacion_A(eGFormularioAceptacion);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public List<EGFormularioAceptacion> Obtener_GFormularioAceptacion_O_CodigoProyecto(string codigoProyecto)
    {
        List<EGFormularioAceptacion> lstFormularioAceptacion = new List<EGFormularioAceptacion>();
        try
        {
            lstFormularioAceptacion = lNServicio.Obtener_GFormularioAceptacion_O_CodigoProyecto(codigoProyecto);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return lstFormularioAceptacion;
    }
    public int Obtener_GFormularioAceptacion_O_SiguienteCodigoFormularioAceptacion()
    {
        try
        {
            return lNServicio.Obtener_GFormularioAceptacion_O_SiguienteCodigoFormularioAceptacion();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    #endregion

    #endregion
}