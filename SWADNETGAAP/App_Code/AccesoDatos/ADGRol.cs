using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADGRol
/// </summary>
public class ADGRol
{
    #region Métodos públicos
    public DTOGRol Obtener_GRol_O_Todo()
    {
        DTOGRol dTOGRol = new DTOGRol();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GRol_O_Todo");
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGRol, "GRol");

        }
        catch (Exception)
        {
            throw;
        }
        return dTOGRol;
    }
    public DTOGRol Obtener_GRol_O_CodigoRol(string CodigoRol)
    {
        DTOGRol dTOGRol = new DTOGRol();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GRol_O_CodigoRol");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoRol", DbType.StringFixedLength, CodigoRol);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGRol, "GRol");

        }
        catch (Exception)
        {
            throw;
        }
        return dTOGRol;
    }
    #endregion
}