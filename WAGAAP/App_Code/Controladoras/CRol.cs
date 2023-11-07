using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CRol
/// </summary>
public class CRol
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

    public CRol()
    {
        lNServicio = new LNServicio();
    }

    #endregion

    #region Metodos Publicos

    #region GRol
    public List<EGRol> Obtener_GRol_O()
    {
        List<EGRol> lstEGRol = new List<EGRol>();
        try
        {
            lstEGRol = lNServicio.Obtener_GRol_O().ToList();
        }
        catch (Exception)
        {
            throw;
        }
        return lstEGRol;
    }
    public EGRol Obtener_GRol_O_CodigoRol(string codigoRol)
    {
        EGRol eGRol = new EGRol();
        try
        {
            eGRol = lNServicio.Obtener_GRol_O_CodigoRol(codigoRol);
        }
        catch (Exception)
        {

            throw;
        }
        return eGRol;
    }
    #endregion

    #endregion
}