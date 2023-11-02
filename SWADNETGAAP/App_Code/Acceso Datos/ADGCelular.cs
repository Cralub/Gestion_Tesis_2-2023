using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data.Common;
using System.Data;

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
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand(SDatosPA.PROC_OBTENER_ULTIMO_CODIGO);
            bdSWADNETGAAP.AddInParameter(comandoBD, "NombreTabla", DbType.String, "GCelular");
            ultimoCodigo = bdSWADNETGAAP.ExecuteScalar(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
        return ultimoCodigo;
    }
    public void Insertar_GCelular_I(EGCelular eGCelular)
    {
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GCelular_I");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoCelular", DbType.Int32, eGCelular.CodigoCelular);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuario", DbType.String, eGCelular.CodigoUsuario);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoAreaCelular", DbType.String, eGCelular.CodigoAreaCelular);
            bdSWADNETGAAP.AddInParameter(comandoBD, "NumeroCelular", DbType.Int32, eGCelular.NumeroCelular);
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
    public DTOGCelular Obtener_GCelular_O_CodigoUsuario(string codigoUsuario)
    {
        DTOGCelular dtoGCelular = new DTOGCelular();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GCelular_O_CodigoUsuario");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuario", DbType.String, codigoUsuario);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dtoGCelular, "GCelular");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoGCelular;
    }
    public void Actualizar_GCelular_A(EGCelular eGCelular)
    {
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GCelular_A");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoCelular", DbType.Int32, eGCelular.CodigoCelular);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuario", DbType.String, eGCelular.CodigoUsuario);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoAreaCelular", DbType.String, eGCelular.CodigoAreaCelular);
            bdSWADNETGAAP.AddInParameter(comandoBD, "NumeroCelular", DbType.String, eGCelular.NumeroCelular);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
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
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GCelular_E");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoCelular", DbType.Int32, codigoCelular);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}