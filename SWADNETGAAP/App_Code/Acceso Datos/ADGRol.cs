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
    public DTOGRol Obtener_GRol_O()
    {
        DTOGRol dTOGRol = new DTOGRol();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GRol_O");
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGRol, "GRol");

        }
        catch (Exception)
        {
            throw;
        }
        return dTOGRol;
    }
    public DTOGRol Obtener_GRol_O_CodigoRol(string codigoRol)
    {
        DTOGRol dTOGRol = new DTOGRol();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GRol_O_CodigoRol");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoRol", DbType.StringFixedLength, codigoRol);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGRol, "GRol");

        }
        catch (Exception)
        {
            throw;
        }
        return dTOGRol;
    }
}