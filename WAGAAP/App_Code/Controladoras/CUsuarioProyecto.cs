using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Descripción breve de CUsuarioProyecto
/// </summary>
public class CUsuarioProyecto
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

    public CUsuarioProyecto()
    {
        lNServicio = new LNServicio();
    }

    #endregion

    #region Metodos Publicos

    #region GUsuarioProyecto
    public void Insertar_GUsuarioProyecto_I(int codigoUsuarioProyecto, string codigoProyecto, string codigoUsuario, string codigoRol, char estadoUsuarioProyecto)
    {
        try
        {
            lNServicio.Insertar_GUsuarioProyecto_I(codigoUsuarioProyecto, codigoProyecto, codigoUsuario, codigoRol, estadoUsuarioProyecto);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public int Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto()
    {
        try
        {
            return lNServicio.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoProyecto(string codigoProyecto)
    {
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        try
        {
            lstEGUsuarioProyecto = lNServicio.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return lstEGUsuarioProyecto;
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoUsuario(string codigoUsuario)
    {
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        try
        {
            lstEGUsuarioProyecto = lNServicio.Obtener_GUsuarioProyecto_O_CodigoUsuario(codigoUsuario).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return lstEGUsuarioProyecto;
    }
    public void Actualizar_GUsuarioProyecto_A(int codigoUsuarioProyecto, string codigoProyecto, string codigoUsuario, string codigoRol, char estadoUsuarioProyecto)
    {
        try
        {
            lNServicio.Actualizar_GUsuarioProyecto_A(codigoUsuarioProyecto, codigoProyecto, codigoUsuario, codigoRol, estadoUsuarioProyecto);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public void Eliminar_GUsuarioProyecto_E(int codigoUsuarioProyecto)
    {
        try
        {
            lNServicio.Eliminar_GUsuarioProyecto_E(codigoUsuarioProyecto);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    #endregion

    #endregion
}