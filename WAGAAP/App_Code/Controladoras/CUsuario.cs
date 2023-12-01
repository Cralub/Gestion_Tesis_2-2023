using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
    public void Insertar_GUsuario_I(string codigoUsuario, string nombreCompletoUsuario, string sedeUsuario)
    {
        try
        {
            lNServicio.Insertar_GUsuario_I(codigoUsuario, nombreCompletoUsuario, sedeUsuario);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public EGUsuario Obtener_GUsuario_O_CodigoUsuario(string codigoUsuario)
    {
        EGUsuario eGUsuario = new EGUsuario();
        try
        {
            eGUsuario = lNServicio.Obtener_GUsuario_O_CodigoUsuario(codigoUsuario);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return eGUsuario;
    }
    public List<EGUsuario> Obtener_GUsuarios_O_CodigoProyecto(string codigoProyecto)
    {
        try
        {
            return lNServicio.Obtener_GUsuarios_O_CodigoProyecto(codigoProyecto);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public EGUsuario Obtener_GUsuario_O_NombreCompletoUsuario(string nombreCompletoUsuario)
    {
        EGUsuario eGUsuario = new EGUsuario();
        try
        {
            eGUsuario = lNServicio.Obtener_GUsuario_O_NombreCompletoUsuario(nombreCompletoUsuario);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return eGUsuario;
    }
    public List<EGUsuario> Buscar_GUsuario_B_NombreCompletoUsuario(string nombreCompletoUsuario)
    {
        try
        {
            return lNServicio.Buscar_GUsuario_B_NombreCompletoUsuario(nombreCompletoUsuario);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public void Actualizar_GUsuario_A(string CodigoUsuario, string nombreCompletoUsuario, string SedeUsuario)
    {
        try
        {
            lNServicio.Actualizar_GUsuario_A(CodigoUsuario, nombreCompletoUsuario, SedeUsuario);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
 
    #endregion

    #endregion
}