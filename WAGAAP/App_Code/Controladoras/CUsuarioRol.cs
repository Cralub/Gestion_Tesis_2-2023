using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CUsuarioRol
/// </summary>
public class CUsuarioRol
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

    public CUsuarioRol()
    {
        lNServicio = new LNServicio();
    }

    #endregion

    #region Metodos Públicos

    #region GUsuarioRol
    public void Insertar_GUsuarioRol_I(int codigoUsuarioRol, string codigoRol, string codigoUsuario)
    {
        try
        {
            lNServicio.Insertar_GUsuarioRol_I(codigoUsuarioRol, codigoRol, codigoUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol()
    {
        try
        {
            return lNServicio.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();

        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoRol(string codigoRol)
    {
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        try
        {
            lstEGUsuarioRol = lNServicio.Obtener_GUsuarioRol_O_CodigoRol(codigoRol);
        }
        catch (Exception)
        {
            throw;
        }
        return lstEGUsuarioRol;
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoUsuario(string codigoUsuario)
    {
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        try
        {
            lstEGUsuarioRol = lNServicio.Obtener_GUsuarioRol_O_CodigoUsuario(codigoUsuario);
        }
        catch (Exception)
        {
            throw;
        }
        return lstEGUsuarioRol;
    }
    public EGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string codigoUsuario, string codigoRol)
    {
        EGUsuarioRol eGUsuarioRol = new EGUsuarioRol();
        try
        {
            eGUsuarioRol = lNServicio.Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(codigoUsuario, codigoRol);
        }
        catch (Exception)
        {
            throw;
        }
        return eGUsuarioRol;
    }
    public void Actualizar_GUsuarioRol_A(string codigoUsuario, string codigoRol, int codigoUsuarioRol)
    {
        try
        {
            lNServicio.Actualizar_GUsuarioRol_A(codigoUsuario, codigoRol, codigoUsuarioRol);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Eliminar_GUsuarioRol_E(int codigoUsuarioRol)
    {
        try
        {
            lNServicio.Eliminar_GUsuarioRol_E(codigoUsuarioRol);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #endregion
}