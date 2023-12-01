using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Descripción breve de CSubEtapa
/// </summary>
public class CSubEtapa
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

    public CSubEtapa()
    {
        lNServicio = new LNServicio();
    }

    #endregion

    #region Metodos Publicos

    #region GSubEtapa
    public void Insertar_GSubEtapa_I(int codigoSubEtapa, int codigoEtapa, string codigoUsuarioFirmaSubEtapa, string codigoRolDesignadoSubEtapa, byte numeroSubEtapa, DateTime fechaInicioSubEtapa, DateTime fechaDefinidaSubEtapa, DateTime fechaFinSubEtapa, char estadoSubEtapa)
    {
        try
        {
            lNServicio.Insertar_GSubEtapa_I(codigoSubEtapa, codigoEtapa, codigoUsuarioFirmaSubEtapa, codigoRolDesignadoSubEtapa, numeroSubEtapa, fechaInicioSubEtapa, fechaDefinidaSubEtapa, fechaFinSubEtapa, estadoSubEtapa);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public int Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa()
    {
        try
        {
            return lNServicio.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public List<EGSubEtapa> Obtener_GSubEtapa_O_CodigoEtapa(int codigoEtapa)
    {
        List<EGSubEtapa> lstEGSubEtapa = new List<EGSubEtapa>();
        try
        {
            lstEGSubEtapa = lNServicio.Obtener_GSubEtapa_O_CodigoEtapa(codigoEtapa);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return lstEGSubEtapa;
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(int codigoEtapa, char estadoSubEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        try
        {
            eGSubEtapa = lNServicio.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(codigoEtapa, estadoSubEtapa);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return eGSubEtapa;
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int codigoEtapa, byte numeroSubEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        try
        {
            eGSubEtapa = lNServicio.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(codigoEtapa, numeroSubEtapa);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return eGSubEtapa;
    }
    public void Actualizar_GSubEtapa_A_EstadoSubEtapa(int codigoSubEtapa, char estadoSubEtapa)
    {
        try
        {
            lNServicio.Actualizar_GSubEtapa_A_EstadoSubEtapa(codigoSubEtapa, estadoSubEtapa);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    #endregion

    #endregion
}