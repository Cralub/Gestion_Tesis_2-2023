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
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GUsuarioRol_I");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuarioRol", DbType.Int32, eGUsuarioRol.CodigoUsuarioRol);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuario", DbType.StringFixedLength, eGUsuarioRol.CodigoUsuario);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoRol", DbType.StringFixedLength, eGUsuarioRol.CodigoRol);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaRegistro", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_REGISTRO);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public DTOGUsuarioRol Obtener_GUsuarioRol_O_CodigoRol(string codigoRol)
    {
        DTOGUsuarioRol dTOGUsuarioRol = new DTOGUsuarioRol();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GUsuarioRol_O_CodigoRol");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoRol", DbType.StringFixedLength, codigoRol);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGUsuarioRol, "GUsuarioRol");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOGUsuarioRol;
    }
    public DTOGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario(string codigoUsuario)
    {
        DTOGUsuarioRol dTOGUsuarioRol = new DTOGUsuarioRol();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GUsuarioRol_O_CodigoUsuario");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuario", DbType.StringFixedLength, codigoUsuario);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGUsuarioRol, "GUsuarioRol");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGUsuarioRol;
    }
    public DTOGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string codigoUsuario, string codigoRol)
    {
        DTOGUsuarioRol dTOGUsuarioRol = new DTOGUsuarioRol();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GUsuarioRol_O_CodigoUsuario_CodigoRol");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuario", DbType.StringFixedLength, codigoUsuario);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoRol", DbType.StringFixedLength, codigoRol);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGUsuarioRol, "GUsuarioRol");
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
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GUsuarioRol_A");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuarioRol", DbType.Int32, eGUsuarioRol.CodigoUsuarioRol);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoRol", DbType.StringFixedLength, eGUsuarioRol.CodigoRol);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuario", DbType.StringFixedLength, eGUsuarioRol.CodigoUsuario);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dtoGUsuarioRol, "GUsuarioRol");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoGUsuarioRol;
    }
    public void Eliminar_GUsuarioRol_E(int codigoUsuarioRol)
    {
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GUsuarioRol_E");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuarioRol", DbType.Int32, codigoUsuarioRol);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_INACTIVO);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }

    }
    #endregion

}