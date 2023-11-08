using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Descripción breve de CUsuarioNetvalle
/// </summary>
public class CUsuarioNetvalle
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

    public CUsuarioNetvalle()
    {
        lNServicio = new LNServicio();
    }

    #endregion

    #region Metodos Publicos

    #region UsuarioNetvalle
    public EUsuarioNetvalle Obtener_UsuarioNetvalle_O_CodigoUsuario(string codigoUsuario)
    {
        EUsuarioNetvalle eUsuarioNetvalle = new EUsuarioNetvalle();
        try
        {
            eUsuarioNetvalle = lNServicio.Obtener_UsuarioNetvalle_O_CodigoUsuario(codigoUsuario);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return eUsuarioNetvalle;
    }
    #endregion

    #endregion
}