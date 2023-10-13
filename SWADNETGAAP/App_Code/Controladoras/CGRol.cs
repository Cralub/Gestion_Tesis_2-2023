using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CGRol
/// </summary>
public class CGRol
{
    #region Atributos
    private ADGRol adGRol;
    #endregion

    #region Constructor
    public CGRol()
    {
        adGRol = new ADGRol();
    }
    #endregion

    #region Métodos públicos
    public List<EGRol> Obtener_GRol_O_Todo()
    {
        EGRol eGRol;
        List<EGRol> lstEGRol = new List<EGRol>();
        DTOGRol dTOGRol = adGRol.Obtener_GRol_O_Todo();
        foreach (DTOGRol.GRolRow drtoGRol in dTOGRol.GRol.Rows)
        {
            eGRol = new EGRol();
            eGRol.CodigoRol = drtoGRol.CodigoRol;
            eGRol.DescripcionRol = drtoGRol.DescripcionRol;
            lstEGRol.Add(eGRol);
        }
        return lstEGRol;
    }
    public EGRol Obtener_GRol_O_CodigoRol(string CodigoRol)
    {
        EGRol eGRol = new EGRol();
        DTOGRol dTOGRol = adGRol.Obtener_GRol_O_CodigoRol(CodigoRol);
        foreach (DTOGRol.GRolRow drtoGRol in dTOGRol.GRol.Rows)
        {
            eGRol = new EGRol();
            eGRol.CodigoRol = drtoGRol.CodigoRol;
            eGRol.DescripcionRol = drtoGRol.DescripcionRol;
        }
        return eGRol;
    }
    #endregion
}