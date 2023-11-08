using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Descripción breve de CEtapa
/// </summary>
public class CEtapa
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

    public CEtapa()
    {
        lNServicio = new LNServicio();
    }

    #endregion

    #region Metodos Publicos

    #region GEtapa
    public void Insertar_GEtapa_I(int codigoEtapa, byte numeroEtapa, DateTime fechaInicioEtapa, DateTime fechaDefinidaEtapa, DateTime fechaFinEtapa, string codigoProyecto, char estadoEtapa)
    {
        try
        {
            lNServicio.Insertar_GEtapa_I(codigoEtapa, numeroEtapa, fechaInicioEtapa, fechaDefinidaEtapa, fechaFinEtapa, codigoProyecto, estadoEtapa);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public int Obtener_GEtapa_O_SiguienteCodigoEtapa()
    {
        try
        {
            return lNServicio.Obtener_GEtapa_O_SiguienteCodigoEtapa();

        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(string codigoProyecto, char estadoEtapa)
    {
        EGEtapa eGEtapa = new EGEtapa();
        try
        {
            eGEtapa = lNServicio.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto.ToUpper(),estadoEtapa);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return eGEtapa;
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string codigoProyecto, byte numeroSubEtapa)
    {
        EGEtapa eGEtapa = new EGEtapa();
        try
        {
            eGEtapa = lNServicio.Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(codigoProyecto.ToUpper(), numeroSubEtapa);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return eGEtapa;
    }

    public void Actualizar_GEtapa_A_EstadoEtapa(int codigoEtapa, char estadoEtapa)
    {
        try
        {
            lNServicio.Actualizar_GEtapa_A_EstadoEtapa(codigoEtapa, estadoEtapa);

        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    #endregion

    #endregion
}