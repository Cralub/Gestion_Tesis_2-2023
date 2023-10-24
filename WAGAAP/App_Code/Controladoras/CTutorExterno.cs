using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CTutorExterno
/// </summary>
public class CTutorExterno
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

    public CTutorExterno()
    {
        lNServicio = new LNServicio();
    }

    #endregion

    #region Metodos Publicos

    #region GTutorExterno
    public void Insertar_GTutorExterno_I(int CodigoTutorExterno, string NombreTutorExterno, string ApellidoTutorExterno, string CorreoTutorExterno, string TelefonoTutorExterno, string CodigoEmpresa, string EstadoTutorExterno)
    {
        try
        {
            lNServicio.Insertar_GTutorExterno_I(CodigoTutorExterno, NombreTutorExterno, ApellidoTutorExterno, CorreoTutorExterno, TelefonoTutorExterno, CodigoEmpresa, EstadoTutorExterno);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Actualizar_GTutorExterno_A(int CodigoTutorExterno, string NombreTutorExterno, string ApellidoTutorExterno, string CorreoTutorExterno, string TelefonoTutorExterno, string CodigoEmpresa, string EstadoTutorExterno)
    {
        try
        {
            lNServicio.Actualizar_GTutorExterno_A(CodigoTutorExterno, NombreTutorExterno, ApellidoTutorExterno, CorreoTutorExterno, TelefonoTutorExterno, CodigoEmpresa, EstadoTutorExterno);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Actualizar_GTutorExterno_A_Estado(int CodigoTutorExterno, string EstadoTutorExterno)
    {
        try
        {
            lNServicio.Actualizar_GTutorExterno_A_Estado(CodigoTutorExterno, EstadoTutorExterno);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public List<SWLNGAAP.EGTutorExterno> Obtener_GTutorExterno_O()
    {
        try
        {
            return lNServicio.Obtener_GTutorExterno_O_Todo();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public SWLNGAAP.EGTutorExterno Obtener_GTutorExterno_O_CodigoTutorExterno(int CodigoTutorExterno)
    {
        try
        {
            return lNServicio.Obtener_GTutorExterno_O_CodigoTutorExterno(CodigoTutorExterno);
        }
        catch (Exception)
        {
            throw;
        }
    }

    #endregion

    #endregion
}