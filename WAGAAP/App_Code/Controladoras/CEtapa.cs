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

    #region Métodos públicos

    #region GEtapa
    public void Insertar_GEtapa_I(byte numeroEtapa, DateTime fechaInicioEtapa, DateTime fechaDefinidaEtapa, DateTime fechaFinEtapa, string codigoProyecto, char estadoEtapa)
    {
        try
        {
            lNServicio.Insertar_GEtapa_I(numeroEtapa, fechaInicioEtapa, fechaDefinidaEtapa, fechaFinEtapa, codigoProyecto, estadoEtapa);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(string CodigoProyecto)
    {
        EGEtapa eGEtapa = new EGEtapa();
        try
        {
            eGEtapa = lNServicio.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(CodigoProyecto.ToUpper());
        }
        catch (Exception)
        {
            throw;
        }
        return eGEtapa;
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string CodigoProyecto, byte NumeroSubEtapa)
    {
        EGEtapa eGEtapa = new EGEtapa();
        try
        {
            eGEtapa = lNServicio.Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(CodigoProyecto.ToUpper(), NumeroSubEtapa);
        }
        catch (Exception)
        {
            throw;
        }
        return eGEtapa;
    }
    public void Actualizar_GEtapa_A_EstadoEtapa(int CodigoEtapa, char EstadoEtapa)
    {
        try
        {
            lNServicio.Actualizar_GEtapa_A_EstadoEtapa(CodigoEtapa, EstadoEtapa);

        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #endregion
}