using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CUsuario
/// </summary>
public class CUsuario
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

    public CUsuario()
    {
        lNServicio = new LNServicio();
    }

    #endregion

    #region Metodos Publicos

    #region GUsuario
    public void Insertar_GUsuario_I(string CodigoUsuario, string SedeUsuario)
    {
        try
        {
            lNServicio.Insertar_GUsuario_I(CodigoUsuario, SedeUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGUsuario Obtener_GUsuario_O_CodigoUsuario(string CodigoUsuario)
    {
        EGUsuario eGUsuario = new EGUsuario();
        try
        {
            eGUsuario = lNServicio.Obtener_GUsuario_O_CodigoUsuario(CodigoUsuario);
        }
        catch (Exception)
        {
            throw;
        }
        return eGUsuario;
    }
    public void Actualizar_GUsuario_A(string CodigoUsuario, string SedeUsuario)
    {
        try
        {
            lNServicio.Actualizar_GUsuario_A(CodigoUsuario, SedeUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #endregion
}