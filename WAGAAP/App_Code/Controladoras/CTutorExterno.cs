using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
    public void Insertar_GTutorExterno_I(string codigoTutorExterno, string nombreCompletoTutorExterno, string carreraTutorExterno, string direccionTrabajoTutorExterno, string descripcionTutorExterno, string sedeTutorExterno)
    {
        try
        {
            lNServicio.Insertar_GTutorExterno_I(codigoTutorExterno, nombreCompletoTutorExterno, carreraTutorExterno, direccionTrabajoTutorExterno, descripcionTutorExterno, sedeTutorExterno);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }

    public void Actualizar_GTutorExterno_A(string codigoTutorExterno, string nombreCompletoTutorExterno, string carreraTutorExterno, string direccionTrabajoTutorExterno, string descripcionTutorExterno, string sedeTutorExterno)
    {
        try
        {
            lNServicio.Actualizar_GTutorExterno_A(codigoTutorExterno, nombreCompletoTutorExterno, carreraTutorExterno, direccionTrabajoTutorExterno, descripcionTutorExterno, sedeTutorExterno);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }

    public void Eliminar_GTutorExterno_E(string codigoTutorExterno)
    {
        try
        {
            lNServicio.Eliminar_GTutorExterno_E(codigoTutorExterno);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }

    public List<SWLNGAAP.EGTutorExterno> Obtener_GTutorExterno_O()
    {
        try
        {
            return lNServicio.Obtener_GTutorExterno_O();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }

    public SWLNGAAP.EGTutorExterno Obtener_GTutorExterno_O_CodigoTutorExterno(string CodigoTutorExterno)
    {
        try
        {
            return lNServicio.Obtener_GTutorExterno_O_CodigoTutorExterno(CodigoTutorExterno);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }

    #endregion

    #endregion
}