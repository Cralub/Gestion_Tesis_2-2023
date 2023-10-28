using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;

/// <summary>
/// Descripción breve de CGProyecto
/// </summary>
public class CGProyecto
{
    #region Atributo
    private ADGProyecto adGProyecto;
    #endregion

    #region Constructor
    public CGProyecto()
    {
        adGProyecto = new ADGProyecto();
    }
    #endregion

    #region Métodos públicos
    public string Obtener_GProyecto_O_ExisteCodigoProyecto(string codigoProyecto)
    {
        Object res = adGProyecto.Obtener_GProyecto_O_CodigoProyecto(codigoProyecto);
        if (res.ToString().IsNullOrEmpty())
            return "OK";
        else
            return (string)res;
    }
    public void Insertar_GProyecto_I(EGProyecto proyecto)
    {
        adGProyecto.Insertar_GProyecto_I(proyecto);
    }
    public List<EGProyecto> Obtener_GProyecto_O_Todo()
    {
        EGProyecto eGProyecto;
        List<EGProyecto> lstEGProyecto = new List<EGProyecto>();
        DTOGProyecto dtoGProyecto = adGProyecto.Obtener_GProyecto_O_Todo();
        foreach (DTOGProyecto.GProyectoRow drGProyecto in dtoGProyecto.GProyecto.Rows)
        {
            eGProyecto = new EGProyecto();
            eGProyecto.CodigoProyecto = drGProyecto.CodigoProyecto;
            eGProyecto.ModalidadProyecto = char.Parse(drGProyecto.ModalidadProyecto);
            eGProyecto.TituloProyecto = drGProyecto.TituloProyecto;
            eGProyecto.ObjetivoGeneralProyecto = drGProyecto.ObjetivoGeneralProyecto;
            eGProyecto.EnlaceDocumentoProyecto = drGProyecto.EnlaceDocumentoProyecto;
            eGProyecto.EstadoProyecto = char.Parse(drGProyecto.EstadoProyecto);            
            lstEGProyecto.Add(eGProyecto);
        }

        return lstEGProyecto;
    }
    public EGProyecto Obtener_GProyecto_O(string codigoProyecto)
    {
        EGProyecto proyecto = null;
        DTOGProyecto dtoGProyecto = adGProyecto.Obtener_GProyecto_O(codigoProyecto);
        foreach (DTOGProyecto.GProyectoRow gProyecto in dtoGProyecto.GProyecto.Rows)
        {
            proyecto = new EGProyecto();
            proyecto.CodigoProyecto = gProyecto.CodigoProyecto;
            proyecto.ModalidadProyecto = char.Parse(gProyecto.ModalidadProyecto);
            proyecto.TituloProyecto = gProyecto.TituloProyecto;
            proyecto.ObjetivoGeneralProyecto = gProyecto.ObjetivoGeneralProyecto;
            proyecto.ObjetivosEspecificosProyecto = gProyecto.ObjetivosEspecificosProyecto;
            proyecto.AlcanceProyecto = gProyecto.AlcanceProyecto;
            proyecto.EnlaceDocumentoProyecto = gProyecto.EnlaceDocumentoProyecto;
            proyecto.EstadoProyecto = char.Parse(gProyecto.EstadoProyecto);
            proyecto.NumeroRevisiones = gProyecto.NumeroRevisiones;
            proyecto.Estado = gProyecto.Estado;
            proyecto.FechaRegistro = gProyecto.FechaRegistro;
            proyecto.FechaModificacion = gProyecto.FechaModificacion;
        }
        return proyecto;
    }
    public void Actualizar_GProyecto_A(EGProyecto proyecto)
    {
        adGProyecto.Actualizar_GProyecto_A(proyecto);
    }
    #endregion
}