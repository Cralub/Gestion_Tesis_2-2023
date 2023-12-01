using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Descripción breve de CProyecto
/// </summary>
public class CProyecto
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

    public CProyecto()
    {
        lNServicio = new LNServicio();
    }

    #endregion

    #region Metodos Públicos

    #region GProyecto
    public void Insertar_GProyecto_I(string codigoProyecto, char modalidadProyecto, string tituloProyecto, string objetivoGeneralProyecto, string objetivosEspecificosProyecto, string alcanceProyecto, string enlaceDocumentoProyecto, char estadoProyecto)
    {
        try
        {
            lNServicio.Insertar_GProyecto_I(codigoProyecto, modalidadProyecto, tituloProyecto, objetivoGeneralProyecto, objetivosEspecificosProyecto, alcanceProyecto, enlaceDocumentoProyecto, estadoProyecto);

        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
 
    public EGProyecto Obtener_GProyecto_O_CodigoProyecto(string codigoProyecto)
    {
        EGProyecto eGProyecto = new EGProyecto();
        try
        {
            eGProyecto = lNServicio.Obtener_GProyecto_O_CodigoProyecto(codigoProyecto.ToUpper());
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return eGProyecto;
    }
    public void Actualizar_GProyecto_A(string codigoProyecto, char modalidadProyecto, string tituloProyecto, string objetivoGeneralProyecto, string objetivosEspecificosProyecto, string alcanceProyecto, byte numeroRevisionesProyecto, string enlaceDocumentoProyecto)
    {
        EGProyecto eGProyecto = new EGProyecto();
        try
        {
            eGProyecto.CodigoProyecto = codigoProyecto;
            eGProyecto.TituloProyecto = tituloProyecto;
            eGProyecto.ModalidadProyecto = modalidadProyecto;
            eGProyecto.ObjetivoGeneralProyecto = objetivoGeneralProyecto;
            eGProyecto.ObjetivosEspecificosProyecto = objetivosEspecificosProyecto;
            eGProyecto.AlcanceProyecto = alcanceProyecto;
            eGProyecto.NumeroRevisionesProyecto = numeroRevisionesProyecto;
            eGProyecto.EnlaceDocumentoProyecto = enlaceDocumentoProyecto;
            lNServicio.Actualizar_GProyecto_A(eGProyecto);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    #endregion

    #endregion

}