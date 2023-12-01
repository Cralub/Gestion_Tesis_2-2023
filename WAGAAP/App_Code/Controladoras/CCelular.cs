using SWLNGAAP;
using System.ServiceModel;

/// <summary>
/// Summary description for CCelular
/// </summary>
public class CCelular
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
    public CCelular()
    {
        lNServicio = new LNServicio();
    }
    #endregion

    #region Métodos públicos
    public void Insertar_GCelular_I(string codigoUsuario, string codigoAreaCelular, int numeroCelular)
    {
        try
        {
            lNServicio.Insertar_GCelular_I(codigoUsuario, codigoAreaCelular, numeroCelular);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public EGCelular Obtener_GCelular_O_CodigoUsuario(string codigoUsuario)
    {
        try
        {
            return lNServicio.Obtener_GCelular_O_CodigoUsuario(codigoUsuario);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public void Actualizar_GCelular_A(int codigoCelular, string codigoUsuario, string codigoAreaCelular, int numeroCelular)
    {
        try
        {
            lNServicio.Actualizar_GCelular_A(codigoCelular, codigoUsuario, codigoAreaCelular, numeroCelular);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public void Eliminar_GCelular_E(int codigoCelular)
    {
        try
        {
            lNServicio.Eliminar_GCelular_E(codigoCelular);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    #endregion
}