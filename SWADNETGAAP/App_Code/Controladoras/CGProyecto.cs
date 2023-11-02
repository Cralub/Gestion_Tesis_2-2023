using System;
using System.Collections.Generic;
/// <summary>
/// Descripción breve de CGProyecto
/// </summary>
public class CGProyecto
{
    #region Atributos
    private ADGProyecto adGProyecto;
    #endregion

    #region Constructor
    public CGProyecto()
    {
        adGProyecto = new ADGProyecto();
    }
    #endregion

    #region Métodos públicos
    public void Insertar_GProyecto_I(EGProyecto eGProyecto)
    {
        adGProyecto.Insertar_GProyecto_I(eGProyecto);
    }
    public List<EGProyecto> Obtener_GProyecto_O(DateTime fechaInicio, DateTime fechaFin)
    {
        EGProyecto eGProyecto;
        List<EGProyecto> lstEGProyecto = new List<EGProyecto>();
        DTOGProyecto dtoGProyecto = adGProyecto.Obtener_GProyecto_O(fechaInicio, fechaFin);
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
    public EGProyecto Obtener_GProyecto_O_CodigoProyecto(string CodigoProyecto)
    {
        EGProyecto eGProyecto = new EGProyecto();
        DTOGProyecto dTOGProyecto = adGProyecto.Obtener_GProyecto_O_CodigoProyecto(CodigoProyecto);
        foreach (DTOGProyecto.GProyectoRow drGProyecto in dTOGProyecto.GProyecto.Rows)
        {
            eGProyecto = new EGProyecto();
            eGProyecto.CodigoProyecto = drGProyecto.CodigoProyecto;
            eGProyecto.ModalidadProyecto = char.Parse(drGProyecto.ModalidadProyecto);
            eGProyecto.TituloProyecto = drGProyecto.TituloProyecto;
            eGProyecto.ObjetivoGeneralProyecto = drGProyecto.ObjetivoGeneralProyecto;
            eGProyecto.ObjetivosEspecificosProyecto = drGProyecto.ObjetivosEspecificosProyecto;
            eGProyecto.AlcanceProyecto = drGProyecto.AlcanceProyecto;
            eGProyecto.EnlaceDocumentoProyecto = drGProyecto.EnlaceDocumentoProyecto;
            eGProyecto.EstadoProyecto = char.Parse(drGProyecto.EstadoProyecto);
            eGProyecto.NumeroRevisiones = drGProyecto.NumeroRevisiones;
            eGProyecto.Estado = drGProyecto.Estado;
            eGProyecto.FechaRegistro = drGProyecto.FechaRegistro;
            eGProyecto.FechaModificacion = drGProyecto.FechaModificacion;
        }
        return eGProyecto;
    }
    public void Actualizar_GProyecto_A(EGProyecto eGProyecto)
    {
        adGProyecto.Actualizar_GProyecto_A(eGProyecto);
    }
    #endregion
}