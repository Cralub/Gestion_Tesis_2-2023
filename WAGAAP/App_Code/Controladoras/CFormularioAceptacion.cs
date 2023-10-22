using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
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
    public void Insertar_GFormularioAceptacion_I(int CodigoFormularioAceptacion, string CodigoProyecto, string CodigoEstudiante, string CodigoTribunal, char PreguntaFormatoYForma1, char PreguntaFormatoYForma2, char PreguntaFormatoYForma3, char PreguntaFormatoYForma4, char PreguntaFormatoYForma5, char PreguntaFormatoYForma6, char PreguntaFormatoYForma7, char PreguntaFormatoYForma8, char PreguntaFormatoYForma9, char PreguntaFormatoYForma10, char PreguntaFondo1, char PreguntaFondo2, char PreguntaFondo3, char PreguntaFondo4, char PreguntaFondo5, char PreguntaFondo6, char PreguntaFondo7, char PreguntaFondo8, char PreguntaFondo9, char PreguntaFondo10)
    {
        EGFormularioAceptacion eGFormularioAceptacion = new EGFormularioAceptacion();
        try
        {
            eGFormularioAceptacion.CodigoFormularioAceptacion = CodigoFormularioAceptacion;
            eGFormularioAceptacion.CodigoProyecto = CodigoProyecto;
            eGFormularioAceptacion.CodigoEstudiante = CodigoEstudiante;
            eGFormularioAceptacion.CodigoTribunal = CodigoTribunal;
            eGFormularioAceptacion.PreguntaFormatoYForma1 = PreguntaFormatoYForma1;
            eGFormularioAceptacion.PreguntaFormatoYForma2 = PreguntaFormatoYForma2;
            eGFormularioAceptacion.PreguntaFormatoYForma3 = PreguntaFormatoYForma3;
            eGFormularioAceptacion.PreguntaFormatoYForma4 = PreguntaFormatoYForma4;
            eGFormularioAceptacion.PreguntaFormatoYForma5 = PreguntaFormatoYForma5;
            eGFormularioAceptacion.PreguntaFormatoYForma6 = PreguntaFormatoYForma6;
            eGFormularioAceptacion.PreguntaFormatoYForma7 = PreguntaFormatoYForma7;
            eGFormularioAceptacion.PreguntaFormatoYForma8 = PreguntaFormatoYForma8;
            eGFormularioAceptacion.PreguntaFormatoYForma8 = PreguntaFormatoYForma9;
            eGFormularioAceptacion.PreguntaFormatoYForma10 = PreguntaFormatoYForma10;
            eGFormularioAceptacion.PreguntaFondo1 = PreguntaFondo1;
            eGFormularioAceptacion.PreguntaFondo2 = PreguntaFondo2;
            eGFormularioAceptacion.PreguntaFondo3 = PreguntaFondo3;
            eGFormularioAceptacion.PreguntaFondo4 = PreguntaFondo4;
            eGFormularioAceptacion.PreguntaFondo5 = PreguntaFondo5;
            eGFormularioAceptacion.PreguntaFondo6 = PreguntaFondo6;
            eGFormularioAceptacion.PreguntaFondo7 = PreguntaFondo7;
            eGFormularioAceptacion.PreguntaFondo8 = PreguntaFondo8;
            eGFormularioAceptacion.PreguntaFondo9 = PreguntaFondo9;
            eGFormularioAceptacion.PreguntaFondo10 = PreguntaFondo10;

            lNServicio.Insertar_GFormularioAceptacion_I(eGFormularioAceptacion);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public List<EGFormularioAceptacion> Obtener_GFormularioAceptacion_O_CodigoProyecto(string CodigoProyecto)
    {
        List<EGFormularioAceptacion> lstFormularioAceptacion = new List<EGFormularioAceptacion>();
        try
        {
            lstFormularioAceptacion = lNServicio.Obtener_GFormularioAceptacion_O_CodigoProyecto(CodigoProyecto);
        }
        catch (Exception)
        {
            throw;  
        }
        return lstFormularioAceptacion;
    }
    #endregion

    #endregion
}