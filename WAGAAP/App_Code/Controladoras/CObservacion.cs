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
    private LNServicio lnServicio;
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
        lnServicio = new LNServicio();
    }
    #endregion

    #region Métodos públicos
    public void Actualizar_GObservacion_A_EstadoObservacion(int codigoObservacion, char estadoObservacion)
    {
        try
        {
            lnServicio.Actualizar_GObservacion_A_EstadoObservacion(codigoObservacion, estadoObservacion);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}