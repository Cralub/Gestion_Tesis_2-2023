using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CCelular
/// </summary>
public class CCelular
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
    public CCelular()
    {
        lnServicio = new LNServicio();
    }
    #endregion

    #region Métodos públicos
    public void Insertar_GCelular_I(string codigoUsuario, string codigoAreaCelular, int numeroCelular)
    {
        try
        {
            lnServicio.Insertar_GCelular_I(codigoUsuario, codigoAreaCelular, numeroCelular);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGCelular Obtener_GCelular_O(int codigoCelular)
    {
        try
        {
            return lnServicio.Obtener_GCelular_O(codigoCelular);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GCelular_A(int codigoCelular, string codigoUsuario, string codigoAreaCelular, int numeroCelular)
    {
        try
        {
            lnServicio.Actualizar_GCelular_A(codigoCelular, codigoUsuario, codigoAreaCelular, numeroCelular);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Eliminar_GCelular_E(int codigoCelular)
    {
        try
        {
            lnServicio.Eliminar_GCelular_E(codigoCelular);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}