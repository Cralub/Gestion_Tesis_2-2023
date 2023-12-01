using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Descripción breve de CObservacion
/// </summary>
public class CObservacion
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

    public CObservacion()
    {
        lNServicio = new LNServicio();
    }

    #endregion

    #region Metodos Publicos

    #region GObservacion
    public void Insertar_GObservacion_I(int codigoObservacion, string codigoProyecto, int codigoSubEtapa, string codigoUsuarioObservacion, string comentarioObservacion, char tipoObservacion, char estadoObservacion)
    {
        try
        {
            lNServicio.Insertar_GObservacion_I(codigoObservacion, codigoProyecto, codigoSubEtapa, codigoUsuarioObservacion, comentarioObservacion, tipoObservacion, estadoObservacion);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public int Obtener_GObsevacion_O_SiguienteCodigoObservacion()
    {
        try
        {
            return lNServicio.Obtener_GObsevacion_O_SiguienteCodigoObservacion();

        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public List<EGObservacion> Obtener_GObservacion_O_CodigoProyecto(string codigoProyecto)
    {
        List<EGObservacion> lstObservacion = new List<EGObservacion>();
        try
        {
            lstObservacion = lNServicio.Obtener_GObservacion_O_CodigoProyecto(codigoProyecto).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return lstObservacion;
    }
   
    public EGObservacion Obtener_GObservacion_O_CodigoObservacion(int codigoObservacion)
    {
        EGObservacion eGObservacion = new EGObservacion();
        try
        {
            eGObservacion = lNServicio.Obtener_GObservacion_O_CodigoObservacion(codigoObservacion);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return eGObservacion;
    }
    public void Actualizar_GObservacion_A(int codigoObservacion, string codigoProyecto, int codigoSubEtapa, string codigoUsuarioObservacion, string comentarioObservacion, char tipoObservacion, char estadoObservacion)
    {
        try
        {
            lNServicio.Actualizar_GObservacion_A(codigoObservacion, codigoProyecto, codigoSubEtapa, codigoUsuarioObservacion, comentarioObservacion, tipoObservacion, estadoObservacion);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public void Actualizar_GObservacion_A_EstadoObservacion(int codigoObservacion, char estadoObservacion)
    {
        try
        {
            lNServicio.Actualizar_GObservacion_A_EstadoObservacion(codigoObservacion, estadoObservacion);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    #endregion

    #endregion
}