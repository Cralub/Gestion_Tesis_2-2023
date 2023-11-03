using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
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
    public void Insertar_GSubEtapa_I(int CodigoSubEtapa, byte NumeroSubEtapa, DateTime FechaInicioSubEtapa, DateTime FechaDefinidaSubEtapa, DateTime FechaFinSubEtapa, string CodigoUsuarioFirma, int CodigoEtapa, char EstadoSubEtapa)
    {
        try
        {
            lNServicio.Insertar_GSubEtapa_I(CodigoSubEtapa, NumeroSubEtapa, FechaInicioSubEtapa, FechaDefinidaSubEtapa, FechaFinSubEtapa, CodigoUsuarioFirma, CodigoEtapa, EstadoSubEtapa);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa()
    {
        try
        {
            return lNServicio.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(int CodigoEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        try
        {
            eGSubEtapa = lNServicio.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(CodigoEtapa);
        }
        catch (Exception)
        {
            throw;
        }
        return eGSubEtapa;
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int CodigoEtapa, byte NumeroSubEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        try
        {
            eGSubEtapa = lNServicio.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(CodigoEtapa, NumeroSubEtapa);
        }
        catch (Exception)
        {
            throw;
        }
        return eGSubEtapa;
    }
    public void Actualizar_GSubEtapa_A_EstadoSubEtapa(int CodigoSubEtapa, char EstadoSubEtapa)
    {
        try
        {
            lNServicio.Actualizar_GSubEtapa_A_EstadoSubEtapa(CodigoSubEtapa, EstadoSubEtapa);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #endregion
}