using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
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

    #region Métodos públicos

    #region GObservacion
    public void Insertar_GObservacion_I(int CodigoObservacion, string CodigoProyecto, int CodigoSubEtapa, string CodigoUsuarioObservacion, string ComentarioObservacion, char TipoObservacion, char EstadoObservacion)
    {
        try
        {
            lNServicio.Insertar_GObservacion_I(CodigoObservacion, CodigoProyecto, CodigoSubEtapa, CodigoUsuarioObservacion, ComentarioObservacion, TipoObservacion, EstadoObservacion);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GObsevacion_O_SiguienteCodigoObservacion()
    {
        try
        {
            return lNServicio.Obtener_GObsevacion_O_SiguienteCodigoObservacion();

        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGObservacion> Obtener_GObservacion_O_CodigoProyecto(string CodigoProyecto)
    {
        List<EGObservacion> lstObservacion = new List<EGObservacion>();
        try
        {
            lstObservacion = lNServicio.Obtener_GObservacion_O_CodigoProyecto(CodigoProyecto).ToList();
        }
        catch (Exception)
        {
            throw;
        }
        return lstObservacion;
    }
    public EGObservacion Obtener_GObservacion_O_CodigoObservacion(int CodigoObservacion)
    {
        EGObservacion eGObservacion = new EGObservacion();
        try
        {
            eGObservacion = lNServicio.Obtener_GObservacion_O_CodigoObservacion(CodigoObservacion);
        }
        catch (Exception)
        {
            throw;
        }
        return eGObservacion;
    }
    public void Actualizar_GObservacion_A(int CodigoObservacion, string CodigoProyecto, int CodigoSubEtapa, string CodigoUsuarioObservacion, string ComentarioObservacion, char TipoObservacion, char EstadoObservacion)
    {
        try
        {
            lNServicio.Actualizar_GObservacion_A(CodigoObservacion, CodigoProyecto, CodigoSubEtapa, CodigoUsuarioObservacion, ComentarioObservacion, TipoObservacion, EstadoObservacion);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GObservacion_A_EstadoObservacion(int codigoObservacion, char estadoObservacion)
    {
        try
        {
            lNServicio.Actualizar_GObservacion_A_EstadoObservacion(codigoObservacion, estadoObservacion);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #endregion
}