using System.Collections.Generic;

/// <summary>
/// Descripción breve de CGRol
/// </summary>
public class CGRol
{
    #region Atributos
    private ADGRol aDGRol;
    #endregion

    #region Constructor
    public CGRol()
    {
        aDGRol = new ADGRol();
    }
    #endregion

    #region Métodos públicos
    public List<EGRol> Obtener_GRol_O()
    {
        EGRol eGRol;
        List<EGRol> lstEGRol = new List<EGRol>();
        DTOGRol dTOGRol = aDGRol.Obtener_GRol_O();
        foreach (DTOGRol.GRolRow dRGRol in dTOGRol.GRol.Rows)
        {
            eGRol = new EGRol();
            eGRol.CodigoRol = dRGRol.CodigoRol;
            eGRol.DescripcionRol = dRGRol.DescripcionRol;
            lstEGRol.Add(eGRol);
        }
        return lstEGRol;
    }
    public EGRol Obtener_GRol_O_CodigoRol(string codigoRol)
    {
        EGRol eGRol = new EGRol();
        DTOGRol dTOGRol = aDGRol.Obtener_GRol_O_CodigoRol(codigoRol);
        foreach (DTOGRol.GRolRow dRGRol in dTOGRol.GRol.Rows)
        {
            eGRol = new EGRol();
            eGRol.CodigoRol = dRGRol.CodigoRol;
            eGRol.DescripcionRol = dRGRol.DescripcionRol;
        }
        return eGRol;
    }
    #endregion
}