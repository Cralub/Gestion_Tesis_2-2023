using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Descripción breve de CProyecto
/// </summary>
public class CProyecto
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

    public CProyecto()
    {
        lNServicio = new LNServicio();
    }

    #endregion

    #region Metodos Públicos

    #region GProyecto
    public void Insertar_GProyecto_I(string codigoProyecto, char modalidadProyecto, string tituloProyecto, string objetivoGeneralProyecto, string enlaceDocumentoProyecto, char estadoProyecto)
    {
        try
        {
            lNServicio.Insertar_GProyecto_I(codigoProyecto, modalidadProyecto, tituloProyecto, objetivoGeneralProyecto, enlaceDocumentoProyecto, estadoProyecto);

        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public List<EGProyecto> Obtener_GProyecto_O(DateTime fechaInicio, DateTime fechaFin)
    {
        List<EGProyecto> lstEGProyecto = new List<EGProyecto>();
        try
        {
            lstEGProyecto = lNServicio.Obtener_GProyecto_O(fechaInicio, fechaFin);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return lstEGProyecto;
    }
    public EGProyecto Obtener_GProyecto_O_CodigoProyecto(string codigoProyecto)
    {
        EGProyecto eGProyecto = new EGProyecto();
        try
        {
            eGProyecto = lNServicio.Obtener_GProyecto_O_CodigoProyecto(codigoProyecto.ToUpper());
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return eGProyecto;
    }
    public void Actualizar_GProyecto_A(string codigoProyecto, char modalidadProyecto, string tituloProyecto, string objetivoGeneralProyecto, string enlaceDocumentoProyecto)
    {
        try
        {
            lNServicio.Actualizar_GProyecto_A(codigoProyecto, modalidadProyecto, tituloProyecto, objetivoGeneralProyecto, enlaceDocumentoProyecto);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    #endregion

    #endregion

}