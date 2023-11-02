using System;
using System.Collections.Generic;
/// <summary>
/// Descripción breve de CGProyecto
/// </summary>
public class CGProyecto
{
    #region Atributos
    private ADGProyecto aDGProyecto;
    #endregion

    #region Constructor
    public CGProyecto()
    {
        aDGProyecto = new ADGProyecto();
    }
    #endregion

    #region Métodos públicos
    public void Insertar_GProyecto_I(EGProyecto eGProyecto)
    {
        aDGProyecto.Insertar_GProyecto_I(eGProyecto);
    }
    public List<EGProyecto> Obtener_GProyecto_O(DateTime fechaInicio, DateTime fechaFin)
    {
        EGProyecto eGProyecto;
        List<EGProyecto> lstEGProyecto = new List<EGProyecto>();
        DTOGProyecto dTOGProyecto = aDGProyecto.Obtener_GProyecto_O(fechaInicio, fechaFin);
        foreach (DTOGProyecto.GProyectoRow dRGProyecto in dTOGProyecto.GProyecto.Rows)
        {
            eGProyecto = new EGProyecto();
            eGProyecto.CodigoProyecto = dRGProyecto.CodigoProyecto;
            eGProyecto.ModalidadProyecto = char.Parse(dRGProyecto.ModalidadProyecto);
            eGProyecto.TituloProyecto = dRGProyecto.TituloProyecto;
            eGProyecto.ObjetivoGeneralProyecto = dRGProyecto.ObjetivoGeneralProyecto;
            eGProyecto.EnlaceDocumentoProyecto = dRGProyecto.EnlaceDocumentoProyecto;
            eGProyecto.EstadoProyecto = char.Parse(dRGProyecto.EstadoProyecto);            
            lstEGProyecto.Add(eGProyecto);
        }

        return lstEGProyecto;
    }
    public EGProyecto Obtener_GProyecto_O_CodigoProyecto(string codigoProyecto)
    {
        EGProyecto eGProyecto = new EGProyecto();
        DTOGProyecto dTOGProyecto = aDGProyecto.Obtener_GProyecto_O_CodigoProyecto(codigoProyecto);
        foreach (DTOGProyecto.GProyectoRow dRGProyecto in dTOGProyecto.GProyecto.Rows)
        {
            eGProyecto = new EGProyecto();
            eGProyecto.CodigoProyecto = dRGProyecto.CodigoProyecto;
            eGProyecto.ModalidadProyecto = char.Parse(dRGProyecto.ModalidadProyecto);
            eGProyecto.TituloProyecto = dRGProyecto.TituloProyecto;
            eGProyecto.ObjetivoGeneralProyecto = dRGProyecto.ObjetivoGeneralProyecto;
            eGProyecto.ObjetivosEspecificosProyecto = dRGProyecto.ObjetivosEspecificosProyecto;
            eGProyecto.AlcanceProyecto = dRGProyecto.AlcanceProyecto;
            eGProyecto.EnlaceDocumentoProyecto = dRGProyecto.EnlaceDocumentoProyecto;
            eGProyecto.EstadoProyecto = char.Parse(dRGProyecto.EstadoProyecto);
            eGProyecto.NumeroRevisiones = dRGProyecto.NumeroRevisiones;
            eGProyecto.Estado = dRGProyecto.Estado;
            eGProyecto.FechaRegistro = dRGProyecto.FechaRegistro;
            eGProyecto.FechaModificacion = dRGProyecto.FechaModificacion;
        }
        return eGProyecto;
    }
    public void Actualizar_GProyecto_A(EGProyecto eGProyecto)
    {
        aDGProyecto.Actualizar_GProyecto_A(eGProyecto);
    }
    #endregion
}