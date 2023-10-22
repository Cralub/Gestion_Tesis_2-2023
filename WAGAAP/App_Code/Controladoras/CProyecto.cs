using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
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

    #region Métodos públicos

    #region GProyecto
    public void Insertar_GProyecto_I(string CodigoProyecto, char ModalidadProyecto, string TituloProyecto, string ObjetivoGeneralProyecto, string EnlaceDocumentoProyecto, char EstadoProyecto)
    {
        try
        {
            lNServicio.Insertar_GProyecto_I(CodigoProyecto, ModalidadProyecto, TituloProyecto, ObjetivoGeneralProyecto, EnlaceDocumentoProyecto, EstadoProyecto);

        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGProyecto> Obtener_GProyecto_O_Todo()
    {
        List<EGProyecto> lstEGProyecto = new List<EGProyecto>();
        try
        {
            lstEGProyecto = lNServicio.Obtener_GProyecto_O_Todo();
        }
        catch (Exception)
        {
            throw;
        }
        return lstEGProyecto;
    }
    public EGProyecto Obtener_GProyecto_O(string codigoProyecto)
    {
        try
        {
            return lNServicio.Obtener_GProyecto_O(codigoProyecto.ToUpper());
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GProyecto_A(string codigoProyecto, char modalidadProyecto, string tituloProyecto, string objetivoGeneralProyecto, string objetivosEspecificosProyecto, string alcanceProyecto, string enlaceDocumentoProyecto)
    {
        try
        {
            lNServicio.Actualizar_GProyecto_A(codigoProyecto.ToUpper(), modalidadProyecto, tituloProyecto, objetivoGeneralProyecto, objetivosEspecificosProyecto, alcanceProyecto, enlaceDocumentoProyecto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #endregion

}