using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
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
    public void Insertar_GEtapa_I(int CodigoEtapa, byte NumeroEtapa, DateTime FechaInicioEtapa, DateTime FechaDefinidaEtapa, DateTime FechaFinEtapa, string CodigoProyecto, char EstadoEtapa)
    {
        try
        {
            lNServicio.Insertar_GEtapa_I(CodigoEtapa, NumeroEtapa, FechaInicioEtapa, FechaDefinidaEtapa, FechaFinEtapa, CodigoProyecto, EstadoEtapa);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GEtapa_O_SiguienteCodigoEtapa()
    {
        try
        {
            return lNServicio.Obtener_GEtapa_O_SiguienteCodigoEtapa();

        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(string codigoProyecto, char estadoEtapa)
    {
        EGEtapa eGEtapa = new EGEtapa();
        try
        {
            eGEtapa = lNServicio.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto.ToUpper(),estadoEtapa);
        }
        catch (Exception)
        {
            throw;
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
        catch (Exception)
        {
            throw;
        }
        return eGEtapa;
    }

    public void Actualizar_GEtapa_A_EstadoEtapa(int codigoEtapa, char estadoEtapa)
    {
        try
        {
            lNServicio.Actualizar_GEtapa_A_EstadoEtapa(codigoEtapa, estadoEtapa);

        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #endregion
}