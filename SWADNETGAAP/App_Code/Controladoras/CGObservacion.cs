using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;

/// <summary>
/// Descripción breve de CGObservacion
/// </summary>
public class CGObservacion
{
    #region Atributos
    private ADGObservacion adGObservacion;
    #endregion

    #region Constructor
    public CGObservacion()
    {
        adGObservacion = new ADGObservacion();
    }
    #endregion

    #region Métodos públicos
    public void Actualizar_GObservacion_A_EstadoObservacion(int codigoObservacion, char estadoObservacion)
    {
        adGObservacion.Actualizar_GObservacion_A_EstadoObservacion(codigoObservacion, estadoObservacion);
    }
    #endregion
}