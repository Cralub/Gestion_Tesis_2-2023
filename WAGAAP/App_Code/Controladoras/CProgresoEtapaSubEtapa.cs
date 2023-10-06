using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CProgresoEtapaSubEtapa
/// </summary>
public class CProgresoEtapaSubEtapa
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

    public CProgresoEtapaSubEtapa()
    {
        lNServicio = new LNServicio();
    }

    #endregion

    #region Metodos Publicos

    #region EProgresoEtapaSubEtapa
    public List<EProgresoEtapaSubEtapa> Obtener_EProgresoEtapaSubEtapa_O(string CodigoProyecto)
    {
        List<EProgresoEtapaSubEtapa> lstEProgresoEtapaSubEtapa = new List<EProgresoEtapaSubEtapa>();
        try
        {
            lstEProgresoEtapaSubEtapa = lNServicio.Obtener_EProgresoEtapaSubEtapa_O(CodigoProyecto).ToList();
        }
        catch (Exception)
        {
            throw;
        }
        return lstEProgresoEtapaSubEtapa;
    }
    #endregion

    #endregion
}