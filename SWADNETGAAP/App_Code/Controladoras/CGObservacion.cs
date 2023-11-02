﻿using System.Collections.Generic;

/// <summary>
/// Descripción breve de CGObservacion
/// </summary>
public class CGObservacion
{
    #region Metodos Privados
    private ADGObservacion adGObservacion;
    #endregion
    #region Constructor
    public CGObservacion()
    {
        adGObservacion = new ADGObservacion();
    }
    #endregion
    #region Metodos Publicos

    public List<EGObservacion> Obtener_GObservacion_O_CodigoProyecto(string CodigoProyecto)
    {
        EGObservacion eGObservacion = new EGObservacion();
        List<EGObservacion> lstEGObservaciones = new List<EGObservacion>();
        DTOGObservacion dtoGObservacion = adGObservacion.Obtener_GObservacion_O_CodigoProyecto(CodigoProyecto);
        foreach (DTOGObservacion.GObservacionRow gObservacionRow in dtoGObservacion.GObservacion.Rows)
        {
            eGObservacion = new EGObservacion();
            eGObservacion.CodigoObservacion = gObservacionRow.CodigoObservacion;
            eGObservacion.CodigoProyecto = gObservacionRow.CodigoProyecto;
            eGObservacion.CodigoSubEtapa = gObservacionRow.CodigoSubEtapa;
            eGObservacion.CodigoUsuarioObservacion = gObservacionRow.CodigoUsuarioObservacion;
            eGObservacion.ComentarioObservacion = gObservacionRow.ComentarioObservacion;
            eGObservacion.TipoObservacion = char.Parse(gObservacionRow.TipoObservacion);
            eGObservacion.EstadoObservacion = char.Parse(gObservacionRow.EstadoObservacion);
            lstEGObservaciones.Add(eGObservacion);
        }
        return lstEGObservaciones;
    }

    public List<EGObservacion> Obtener_GObservacion_O_TipoObservacion(char TipoObservacion)
    {
        EGObservacion eGObservacion;
        List<EGObservacion> lstEGObservaciones = new List<EGObservacion>();
        DTOGObservacion dtoGObservacion = adGObservacion.Obtener_GObservacion_O_TipoObservacion(TipoObservacion);
        foreach (DTOGObservacion.GObservacionRow dgObservacionRow in dtoGObservacion.GObservacion.Rows)
        {
            eGObservacion = new EGObservacion();
            eGObservacion.CodigoObservacion = dgObservacionRow.CodigoObservacion;
            eGObservacion.CodigoProyecto = dgObservacionRow.CodigoProyecto;
            eGObservacion.CodigoSubEtapa = dgObservacionRow.CodigoSubEtapa;
            eGObservacion.CodigoUsuarioObservacion = dgObservacionRow.CodigoUsuarioObservacion;
            eGObservacion.ComentarioObservacion = dgObservacionRow.ComentarioObservacion;
            eGObservacion.TipoObservacion = char.Parse(dgObservacionRow.TipoObservacion);
            eGObservacion.EstadoObservacion = char.Parse(dgObservacionRow.EstadoObservacion);
            lstEGObservaciones.Add(eGObservacion);
        }
        return lstEGObservaciones;
    }
    public EGObservacion Obtener_GObservacion_O_CodigoObservacion(int CodigoObservacion)
    {
        EGObservacion eGObservacion = new EGObservacion();
        DTOGObservacion dtoGObservacion = adGObservacion.Obtener_GObservacion_O_CodigoObservacion(CodigoObservacion);
        foreach (DTOGObservacion.GObservacionRow drObservacionRow in dtoGObservacion.GObservacion.Rows)
        {
            eGObservacion.CodigoObservacion = drObservacionRow.CodigoObservacion;
            eGObservacion.CodigoProyecto = drObservacionRow.CodigoProyecto;
            eGObservacion.CodigoSubEtapa = drObservacionRow.CodigoSubEtapa;
            eGObservacion.CodigoUsuarioObservacion = drObservacionRow.CodigoUsuarioObservacion;
            eGObservacion.ComentarioObservacion = drObservacionRow.ComentarioObservacion;
            eGObservacion.TipoObservacion = char.Parse(drObservacionRow.TipoObservacion);
            eGObservacion.EstadoObservacion = char.Parse(drObservacionRow.EstadoObservacion);
            eGObservacion.FechaRegistro = drObservacionRow.FechaRegistro;
        }
        return eGObservacion;

    }
    public void Insertar_GObservacion_I(EGObservacion eGObservacion)
    {
        adGObservacion.Insertar_GObservacion_I(eGObservacion);
    }
    public void Actualizar_GObservacion_A(EGObservacion eGObservacion)
    {
        adGObservacion.Actualizar_GObservacion_A(eGObservacion);
    }

    public void Actualizar_GObservacion_A_EstadoObservacion(int CodigoObservacion, char EstadoObservacion)
    {
        adGObservacion.Actualizar_GObservacion_A_EstadoObservacion(CodigoObservacion, EstadoObservacion);
    }
    public int Obtener_GObsevacion_O_SiguienteCodigoObservacion()
    {
        object res = adGObservacion.Obtener_GObsevacion_O_SiguienteCodigoObservacion();
        return (int)res + 1;
    }
    #endregion
}