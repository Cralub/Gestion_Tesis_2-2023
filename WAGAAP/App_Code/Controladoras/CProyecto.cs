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

    #region Metodos Públicos

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
    public EGProyecto Obtener_GProyecto_O_CodigoProyecto(string CodigoProyecto)
    {
        EGProyecto eGProyecto = new EGProyecto();
        try
        {
            eGProyecto = lNServicio.Obtener_GProyecto_O_CodigoProyecto(CodigoProyecto.ToUpper());
        }
        catch (Exception)
        {
            throw;
        }
        return eGProyecto;
    }
    public void Actualizar_GProyecto_A(string CodigoProyecto, char ModalidadProyecto, string TituloProyecto, string ObjetivoGeneralProyecto, string EnlaceDocumentoProyecto)
    {
        try
        {
            lNServicio.Actualizar_GProyecto_A(CodigoProyecto, ModalidadProyecto, TituloProyecto, ObjetivoGeneralProyecto, EnlaceDocumentoProyecto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #endregion

}