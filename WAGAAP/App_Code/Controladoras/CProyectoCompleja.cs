﻿using SWLNGAAP;
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

    #region Métodos públicos

    #region GProyectoCompleja
    public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(string CodigoUsuario)
    {
        List<EProyectoCompleja> lstEGProyectos = new List<EProyectoCompleja>();
        try
        {
            lstEGProyectos = lNServicio.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(CodigoUsuario).ToList();
        }
        catch (Exception)
        {

            throw;
        }
        return lstEGProyectos;
    }
    public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(string CodigoUsuario)
    {
        List<EProyectoCompleja> lstEGProyectos = new List<EProyectoCompleja>();
        try
        {
            lstEGProyectos = lNServicio.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(CodigoUsuario).ToList();
        }
        catch (Exception)
        {

            throw;
        }
        return lstEGProyectos;
    }
    #endregion
    #region Opciones
    public bool Verificar_GProyecto_CorrespondeRevision(string CodigoRol, byte NumeroEtapa, byte NumeroSubEtapa)
    {
        bool res = false;
        try
        {
            res = lNServicio.Verificar_GProyecto_CorrespondeRevision(CodigoRol, NumeroEtapa, NumeroSubEtapa);
        }
        catch (Exception)
        {

            throw;
        }
        return res;
    }
    public void Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(string CodigoProyecto)
    {
        try
        {
            lNServicio.Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(CodigoProyecto);
        }
        catch (Exception)
        {

            throw;
        }
    }
    public void Insertar_ProyectoCompleto(string codigoProyecto, int diasEtapa, int diasSubEtapa, string codigoUsuario, string codigoDirector)
    {
        try
        {
            lNServicio.Insertar_ProyectoCompleto(codigoProyecto, diasEtapa, diasSubEtapa, codigoUsuario, codigoDirector);
        }
        catch (Exception)
        {

            throw;
        }
    }
    #endregion

    #endregion
}