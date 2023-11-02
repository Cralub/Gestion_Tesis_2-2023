using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ADGCelular
/// </summary>
public class ADGCelular
{
    #region Métodos públicos
    public object Obtener_GCelular_O_SiguienteCodigoCelular()
    {
        object ultimoCodigo;
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand(SDatosPA.PROC_OBTENER_ULTIMO_CODIGO);
            bdNETGAAP.AddInParameter(comandoBD, "NombreTabla", DbType.String, "GCelular");
            ultimoCodigo = bdNETGAAP.ExecuteScalar(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
        return ultimoCodigo;
    }
    public void Insertar_GCelular_I(EGCelular celular)
    {
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GCelular_I");
            bdNETGAAP.AddInParameter(comandoBD, "CodigoCelular", DbType.Int32, celular.CodigoCelular);
            bdNETGAAP.AddInParameter(comandoBD, "CodigoUsuario", DbType.String, celular.CodigoUsuario);
            bdNETGAAP.AddInParameter(comandoBD, "CodigoAreaCelular", DbType.String, celular.CodigoAreaCelular);
            bdNETGAAP.AddInParameter(comandoBD, "NumeroCelular", DbType.Int32, celular.NumeroCelular);
            bdNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdNETGAAP.AddInParameter(comandoBD, "FechaRegistro", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_REGISTRO);
            bdNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
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
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
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
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GCelular_A");
            bdNETGAAP.AddInParameter(comandoBD, "CodigoCelular", DbType.Int32, celular.CodigoCelular);
            bdNETGAAP.AddInParameter(comandoBD, "CodigoUsuario", DbType.String, celular.CodigoUsuario);
            bdNETGAAP.AddInParameter(comandoBD, "CodigoAreaCelular", DbType.String, celular.CodigoAreaCelular);
            bdNETGAAP.AddInParameter(comandoBD, "NumeroCelular", DbType.String, celular.NumeroCelular);
            bdNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
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
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
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