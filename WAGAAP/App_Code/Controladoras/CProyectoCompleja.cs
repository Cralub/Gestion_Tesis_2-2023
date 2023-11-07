using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
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
        catch (Exception)
        {

            throw;
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
        catch (Exception)
        {

            throw;
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
        catch (Exception)
        {

            throw;
        }
        return esValido;
    }
    public void Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(string codigoProyecto)
    {
        try
        {
            lNServicio.Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(codigoProyecto);
        }
        catch (Exception)
        {

            throw;
        }
    }
    public void Insertar_ProyectoCompleto(string codigoProyecto, string codigoUsuario, string codigoDirector, int diasEtapa, int diasSubEtapa)
    {
        try
        {
            lNServicio.Insertar_ProyectoCompleto(codigoProyecto, codigoUsuario, codigoDirector, diasEtapa, diasSubEtapa);
        }
        catch (Exception)
        {

            throw;
        }
    }
    #endregion

    #endregion
}