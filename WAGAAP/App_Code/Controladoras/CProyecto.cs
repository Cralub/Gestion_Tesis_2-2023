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
    private LNServicio lnServicio;
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
        lnServicio = new LNServicio();
    }
    #endregion

    #region Métodos públicos
    public EGProyecto Obtener_GProyecto_O(string codigoProyecto)
    {
        try
        {
            return lnServicio.Obtener_GProyecto_O(codigoProyecto.ToUpper());
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
            lnServicio.Actualizar_GProyecto_A(codigoProyecto.ToUpper(), modalidadProyecto, tituloProyecto, objetivoGeneralProyecto, objetivosEspecificosProyecto, alcanceProyecto, enlaceDocumentoProyecto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

}