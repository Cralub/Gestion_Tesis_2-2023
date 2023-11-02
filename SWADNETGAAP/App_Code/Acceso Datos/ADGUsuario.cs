using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data.Common;
using System.Data;

/// <summary>
/// Descripción breve de ADGUsuario
/// </summary>
public class ADGUsuario
{
    #region Metodos publicos
    public void Insertar_GUsuario_I(EGUsuario eGUsuario)
    {
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GUsuario_I");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuario", DbType.StringFixedLength, eGUsuario.CodigoUsuario);
            bdSWADNETGAAP.AddInParameter(comandoBD, "SedeUsuario", DbType.StringFixedLength, eGUsuario.SedeUsuario);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaRegistro", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_REGISTRO);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public DTOGUsuario Obtener_GUsuario_O_CodigoUsuario(string codigoUsuario)
    {
        DTOGUsuario dtoGUsuario = new DTOGUsuario();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GUsuario_O_CodigoUsuario");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuario", DbType.StringFixedLength, codigoUsuario);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dtoGUsuario, "GUsuario");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dtoGUsuario;
    }
    public void Actualizar_GUsuario_A(EGUsuario eGUsuario)
    {
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GUsuario_A");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuario", DbType.String, eGUsuario.CodigoUsuario);
            bdSWADNETGAAP.AddInParameter(comandoBD, "SedeUsuario", DbType.String, eGUsuario.SedeUsuario);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}