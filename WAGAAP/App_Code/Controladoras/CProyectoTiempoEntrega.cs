using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CProyectoTiempoEntrega
/// </summary>
public class CProyectoTiempoEntrega
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

    public CProyectoTiempoEntrega()
    {
        lNServicio = new LNServicio();
    }

    #endregion

    #region Metodos Publicos

    //#region EProyectoTiempoEntrega
    //public List<EProyectoTiempoEntrega> Obtener_EProyectoTiempoEntrega_O(string CodigoUsuario)
    //{
    //    List<EProyectoTiempoEntrega> lstEProyectoTiempoEntrega = new List<EProyectoTiempoEntrega>();
    //    try
    //    {
    //        lstEProyectoTiempoEntrega = lNServicio.Obtener_EProyectoTiempoEntrega_O(CodigoUsuario);
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //    return lstEProyectoTiempoEntrega;
    //}
    //#endregion

    #endregion
}