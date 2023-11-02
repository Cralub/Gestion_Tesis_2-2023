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
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GUsuario_I");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuario", DbType.StringFixedLength, eGUsuario.CodigoUsuario);
            BDSWADNETGAAP.AddInParameter(dbCommand, "SedeUsuario", DbType.StringFixedLength, eGUsuario.SedeUsuario);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaRegistro", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_REGISTRO);
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            BDSWADNETGAAP.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public DTOGUsuario Obtener_GUsuario_O_CodigoUsuario(string CodigoUsuario)
    {
        DTOGUsuario dtoGUsuario = new DTOGUsuario();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GUsuario_O_CodigoUsuario");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuario", DbType.StringFixedLength, CodigoUsuario);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dtoGUsuario, "GUsuario");
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
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GUsuario_A");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuario", DbType.String, eGUsuario.CodigoUsuario);
            BDSWADNETGAAP.AddInParameter(dbCommand, "SedeUsuario", DbType.String, eGUsuario.SedeUsuario);
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            BDSWADNETGAAP.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}