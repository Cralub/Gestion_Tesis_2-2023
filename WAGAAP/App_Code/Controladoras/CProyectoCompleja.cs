using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Descripción breve de CProyectoCompleja
/// </summary>
public class CProyectoCompleja
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

    public CProyectoCompleja()
    {
        lNServicio = new LNServicio();
    }

    #endregion

    #region Metodos Publicos

    #region GProyectoCompleja
    public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(string codigoUsuario)
    {
        List<EProyectoCompleja> lstEGProyectos = new List<EProyectoCompleja>();
        try
        {
            lstEGProyectos = lNServicio.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(codigoUsuario).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return lstEGProyectos;
    }
    public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(string codigoUsuario)
    {
        List<EProyectoCompleja> lstEGProyectos = new List<EProyectoCompleja>();
        try
        {
            lstEGProyectos = lNServicio.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(codigoUsuario).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return lstEGProyectos;
    }
    #endregion
    #region Opciones
    public bool Verificar_GProyecto_CorrespondeRevision(string codigoRol, byte numeroEtapa, byte numeroSubEtapa)
    {
        bool esValido = false;
        try
        {
            esValido = lNServicio.Verificar_GProyecto_CorrespondeRevision(codigoRol, numeroEtapa, numeroSubEtapa);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return esValido;
    }
    public void Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(string codigoProyecto)
    {
        try
        {
            lNServicio.Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(codigoProyecto);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public void Insertar_ProyectoCompleto(string codigoProyecto, string codigoUsuario, string codigoDirector, int diasEtapa, int diasSubEtapa)
    {
        try
        {
            lNServicio.Insertar_ProyectoCompleto(codigoProyecto, codigoUsuario, codigoDirector, diasEtapa, diasSubEtapa);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    #endregion

    #endregion
}