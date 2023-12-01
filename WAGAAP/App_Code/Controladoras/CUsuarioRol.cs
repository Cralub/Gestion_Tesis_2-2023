using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public int Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol()
    {
        try
        {
            return lNServicio.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();

        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoRol(string codigoRol)
    {
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        try
        {
            lstEGUsuarioRol = lNServicio.Obtener_GUsuarioRol_O_CodigoRol(codigoRol);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
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
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
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
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return eGUsuarioRol;
    }
    public void Actualizar_GUsuarioRol_A(string codigoUsuario, string codigoRol, int codigoUsuarioRol)
    {
        try
        {
            lNServicio.Actualizar_GUsuarioRol_A(codigoUsuario, codigoRol, codigoUsuarioRol);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public void Eliminar_GUsuarioRol_E(int codigoUsuarioRol)
    {
        try
        {
            lNServicio.Eliminar_GUsuarioRol_E(codigoUsuarioRol);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    #endregion

    #endregion
}