using System.Collections.Generic;

/// <summary>
/// Summary description for CGTutorExterno
/// </summary>
public class CGTutorExterno
{
    #region Atributos
    private ADGTutorExterno aDGTutorExterno;
    #endregion

    #region Constructor
    public CGTutorExterno()
    {
        aDGTutorExterno = new ADGTutorExterno();
    }
    #endregion

    #region Métodos públicos
    public void Insertar_GTutorExterno_I(EGTutorExterno eGTutorExterno)
    {
        aDGTutorExterno.Insertar_GTutorExterno_I(eGTutorExterno);
    }

    public void Actualizar_GTutorExterno_A(EGTutorExterno eGTutorExterno)
    {
        aDGTutorExterno.Actualizar_GTutorExterno_A(eGTutorExterno);
    }

    public void Eliminar_GTutorExterno_E(string codigoTutorExterno)
    {
        aDGTutorExterno.Eliminar_GTutorExterno_E(codigoTutorExterno);
    }

    public List<EGTutorExterno> Obtener_GTutorExterno_O()
    {
        EGTutorExterno eGTutorExterno;
        List<EGTutorExterno> lstEGTutorExterno = new List<EGTutorExterno>();
        DTOGTutorExterno dTOGTutorExterno = aDGTutorExterno.Obtener_GTutorExterno_O();
        foreach (DTOGTutorExterno.GTutorExternoRow dRGTutorExterno in dTOGTutorExterno.GTutorExterno.Rows)
        {
            eGTutorExterno = new EGTutorExterno();
            eGTutorExterno.CodigoTutorExterno = dRGTutorExterno.CodigoTutorExterno;
            eGTutorExterno.NombreCompletoTutorExterno = dRGTutorExterno.NombreCompletoTutorExterno;
            eGTutorExterno.CarreraTutorExterno = dRGTutorExterno.CarreraTutorExterno;
            eGTutorExterno.DescripcionTutorExterno = dRGTutorExterno.DescripcionTutorExterno;
            eGTutorExterno.DireccionTrabajoTutorExterno = dRGTutorExterno.DireccionTrabajoTutorExterno;
            eGTutorExterno.SedeTutorExterno= dRGTutorExterno.SedeTutorExterno;
            eGTutorExterno.Estado = dRGTutorExterno.Estado;
            eGTutorExterno.FechaModificacion = dRGTutorExterno.FechaModificacion;
            eGTutorExterno.FechaRegistro= dRGTutorExterno.FechaRegistro;
            lstEGTutorExterno.Add(eGTutorExterno);
        }

        return lstEGTutorExterno;

    }

    public EGTutorExterno Obtener_GTutorExterno_O_CodigoTutorExterno(string codigoTutorExterno)
    {
        EGTutorExterno eGTutorExterno = new EGTutorExterno();
        DTOGTutorExterno dTOGTutorExterno = aDGTutorExterno.Obtener_GTutorExterno_O_CodigoTutorExterno(codigoTutorExterno);
        foreach (DTOGTutorExterno.GTutorExternoRow dRGTutorExterno in dTOGTutorExterno.GTutorExterno.Rows)
        {
            eGTutorExterno.CodigoTutorExterno = dRGTutorExterno.CodigoTutorExterno;
            eGTutorExterno.NombreCompletoTutorExterno = dRGTutorExterno.NombreCompletoTutorExterno;
            eGTutorExterno.CarreraTutorExterno = dRGTutorExterno.CarreraTutorExterno;
            eGTutorExterno.DescripcionTutorExterno = dRGTutorExterno.DescripcionTutorExterno;
            eGTutorExterno.DireccionTrabajoTutorExterno = dRGTutorExterno.DireccionTrabajoTutorExterno;
            eGTutorExterno.SedeTutorExterno = dRGTutorExterno.SedeTutorExterno;
            eGTutorExterno.Estado = dRGTutorExterno.Estado;
            eGTutorExterno.FechaModificacion = dRGTutorExterno.FechaModificacion;
            eGTutorExterno.FechaRegistro = dRGTutorExterno.FechaRegistro;
        }
        return eGTutorExterno;
    }

    #endregion


}