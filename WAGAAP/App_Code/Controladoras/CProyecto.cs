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
    public string Obtener_GProyecto_O_ExisteCodigoProyecto(string codigoProyecto)
    {
        try
        {
            return lNServicio.Obtener_GProyecto_O_ExisteCodigoProyecto(codigoProyecto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Insertar_GProyecto_I(string codigoProyecto, char modalidadProyecto, string tituloProyecto, string objetivoGeneralProyecto, string objetivosEspecificosProyecto, string alcanceProyecto, string enlaceDocumentoProyecto, byte numeroRevisiones)
    {
        try
        {
            lNServicio.Insertar_GProyecto_I(codigoProyecto, modalidadProyecto, tituloProyecto, objetivoGeneralProyecto, objetivosEspecificosProyecto, alcanceProyecto, enlaceDocumentoProyecto, numeroRevisiones);

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