using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
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

    #region Métodos públicos

    #region GUsuarioProyecto
    public void Insertar_GUsuarioProyecto_I(int CodigoUsuarioProyecto, string CodigoProyecto, string CodigoUsuario, string CodigoRol, char EstadoUsuarioProyecto)
    {
        try
        {
            lNServicio.Insertar_GUsuarioProyecto_I(CodigoUsuarioProyecto, CodigoProyecto, CodigoUsuario, CodigoRol, EstadoUsuarioProyecto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto()
    {
        try
        {
            return lNServicio.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoProyecto(string CodigoProyecto)
    {
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        try
        {
            lstEGUsuarioProyecto = lNServicio.Obtener_GUsuarioProyecto_O_CodigoProyecto(CodigoProyecto).ToList();
        }
        catch (Exception)
        {
            throw;
        }
        return lstEGUsuarioProyecto;
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoUsuario(string CodigoUsuario)
    {
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        try
        {
            lstEGUsuarioProyecto = lNServicio.Obtener_GUsuarioProyecto_O_CodigoUsuario(CodigoUsuario).ToList();
        }
        catch (Exception)
        {
            throw;
        }
        return lstEGUsuarioProyecto;
    }
    public void Actualizar_GUsuarioProyecto_A(int CodigoUsuarioProyecto, string CodigoProyecto, string CodigoUsuario, string CodigoRol, char EstadoUsuarioProyecto)
    {
        try
        {
            lNServicio.Actualizar_GUsuarioProyecto_A(CodigoUsuarioProyecto, CodigoProyecto, CodigoUsuario, CodigoRol, EstadoUsuarioProyecto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #endregion
}