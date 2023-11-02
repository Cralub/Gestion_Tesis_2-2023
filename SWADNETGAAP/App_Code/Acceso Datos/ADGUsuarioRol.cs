using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Data.Common;

/// <summary>
/// Descripción breve de ADGUsuarioRol
/// </summary>
public class ADGUsuarioRol
{
    #region Metodos publicos
    public void Insertar_GUsuarioRol_I(EGUsuarioRol eGUsuarioRol)
    {
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GUsuarioRol_I");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuarioRol", DbType.Int32, eGUsuarioRol.CodigoUsuarioRol);
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuario", DbType.StringFixedLength, eGUsuarioRol.CodigoUsuario);
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoRol", DbType.StringFixedLength, eGUsuarioRol.CodigoRol);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaRegistro", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_REGISTRO);
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            BDSWADNETGAAP.ExecuteNonQuery(dbCommand);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public DTOGUsuarioRol Obtener_GUsuarioRol_O_CodigoRol(string CodigoRol)
    {
        DTOGUsuarioRol dTOGUsuarioRol = new DTOGUsuarioRol();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GUsuarioRol_O_CodigoRol");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoRol", DbType.StringFixedLength, CodigoRol);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGUsuarioRol, "GUsuarioRol");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOGUsuarioRol;
    }
    public DTOGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario(string CodigoUsuario)
    {
        DTOGUsuarioRol dTOGUsuarioRol = new DTOGUsuarioRol();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GUsuarioRol_O_CodigoUsuario");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuario", DbType.StringFixedLength, CodigoUsuario);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGUsuarioRol, "GUsuarioRol");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGUsuarioRol;
    }
    public DTOGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string CodigoUsuario, string CodigoRol)
    {
        DTOGUsuarioRol dTOGUsuarioRol = new DTOGUsuarioRol();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GUsuarioRol_O_CodigoUsuario_CodigoRol");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuario", DbType.StringFixedLength, CodigoUsuario);
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoRol", DbType.StringFixedLength, CodigoRol);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGUsuarioRol, "GUsuarioRol");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGUsuarioRol;
    }
    public object Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol()
    {
        object ultimoCodigo;
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand(SDatosPA.PROC_OBTENER_ULTIMO_CODIGO);
            bdNETGAAP.AddInParameter(comandoBD, "NombreTabla", DbType.String, "GUsuarioRol");
            ultimoCodigo = bdNETGAAP.ExecuteScalar(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
        return ultimoCodigo;
    }
    public DTOGUsuarioRol Actualizar_GUsuarioRol_A(EGUsuarioRol eGUsuarioRol)
    {
        DTOGUsuarioRol dtoGUsuarioRol = new DTOGUsuarioRol();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GUsuarioRol_A");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuarioRol", DbType.Int32, eGUsuarioRol.CodigoUsuarioRol);
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoRol", DbType.StringFixedLength, eGUsuarioRol.CodigoRol);
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuario", DbType.StringFixedLength, eGUsuarioRol.CodigoUsuario);
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dtoGUsuarioRol, "GUsuarioRol");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoGUsuarioRol;
    }
    public void Eliminar_GusuarioRol_E(int CodigoUsuarioRol)
    {
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GUsuarioRol_E");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuarioRol", DbType.Int32, CodigoUsuarioRol);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_INACTIVO);
            BDSWADNETGAAP.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }

    }
    #endregion

}