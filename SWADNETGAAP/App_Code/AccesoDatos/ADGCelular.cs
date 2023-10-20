using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data.Common;
using System.Data;

/// <summary>
/// Descripción resumida de ADGCelular
/// </summary>
public class ADGCelular
{
    #region Métodos públicos
    public Object Obtener_GCelular_O_UltimoCodigoCelular()
    {
        Object res = null;
        try
        {
            Database bdNETGAAP = SBaseDatos.BDNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GCelular_O_UltimoCodigoCelular");
            res = bdNETGAAP.ExecuteScalar(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
        return res;
    }
    public void Insertar_GCelular_I(EGCelular celular)
    {
        try
        {
            Database bdNETGAAP = SBaseDatos.BDNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GCelular_I");
            bdNETGAAP.AddInParameter(comandoBD, "CodigoCelular", DbType.Int32, celular.CodigoCelular);
            bdNETGAAP.AddInParameter(comandoBD, "CodigoUsuario", DbType.String, celular.CodigoUsuario);
            bdNETGAAP.AddInParameter(comandoBD, "CodigoAreaCelular", DbType.String, celular.CodigoAreaCelular);
            bdNETGAAP.AddInParameter(comandoBD, "NumeroCelular", DbType.Int32, celular.NumeroCelular);
            bdNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            bdNETGAAP.AddInParameter(comandoBD, "FechaRegistro", DbType.DateTime, SDatosPA.Auditoria_FechaRegistro);
            bdNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            bdNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public DTOGCelular Obtener_GCelular_O(int codigoCelular)
    {
        DTOGCelular dtoGCelular = new DTOGCelular();
        try
        {
            Database bdNETGAAP = SBaseDatos.BDNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GCelular_O");
            bdNETGAAP.AddInParameter(comandoBD, "CodigoCelular", DbType.String, codigoCelular);
            bdNETGAAP.LoadDataSet(comandoBD, dtoGCelular, "GCelular");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoGCelular;
    }
    public void Actualizar_GCelular_A(EGCelular celular)
    {
        try
        {
            Database bdNETGAAP = SBaseDatos.BDNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GCelular_A");
            bdNETGAAP.AddInParameter(comandoBD, "CodigoCelular", DbType.Int32, celular.CodigoCelular);
            bdNETGAAP.AddInParameter(comandoBD, "CodigoUsuario", DbType.String, celular.CodigoUsuario);
            bdNETGAAP.AddInParameter(comandoBD, "CodigoAreaCelular", DbType.String, celular.CodigoAreaCelular);
            bdNETGAAP.AddInParameter(comandoBD, "NumeroCelular", DbType.String, celular.NumeroCelular);
            bdNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            bdNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Eliminar_GCelular_E(int codigoCelular)
    {
        try
        {
            Database bdNETGAAP = SBaseDatos.BDNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GCelular_E");
            bdNETGAAP.AddInParameter(comandoBD, "CodigoCelular", DbType.Int32, codigoCelular);
            bdNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}