using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel;

/// <summary>
/// Summary description for ADGCelular
/// </summary>
public class ADGCelular
{
    #region Metodos Privados
    /// <summary>
    /// Contruir el Error del servicio > metodo
    /// </summary>
    /// <param name="tipoError"></param>
    /// <param name="metodo"></param>
    /// <param name="excepcion"></param>
    /// <param name="mensaje"></param>
    /// <returns></returns>
    private EDefectoAD ConstruirErrorServicio(TTipoError tipoError, string metodo, string excepcion, string mensaje)
    {
        EDefectoAD eDefectoAD = new EDefectoAD();
        eDefectoAD.TipoError = tipoError;
        eDefectoAD.Servicio = "SWADNETGAAP";
        eDefectoAD.Clase = "ADGCelular";
        eDefectoAD.Metodo = metodo;
        eDefectoAD.Excepcion = excepcion;
        eDefectoAD.Mensaje = mensaje;
        return eDefectoAD;
    }
    #endregion
    #region Métodos públicos
    public object Obtener_GCelular_O_SiguienteCodigoCelular()
    {
        object ultimoCodigo;
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GCelular_O_UltimoCodigoCelular");
            ultimoCodigo = bdNETGAAP.ExecuteScalar(comandoBD);
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_GCelular_O_SiguienteCodigoCelular", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
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
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.ESTADO_ACTIVO_AUDITORIA);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaRegistro", DbType.DateTime, SDatosPA.FECHA_REGISTRO_AUDITORIA);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.FECHA_MODIFICACION_AUDITORIA);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Insertar_GCelular_I", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
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
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_GCelular_O_CodigoUsuario", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
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
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.FECHA_MODIFICACION_AUDITORIA);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Actualizar_GCelular_A", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
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
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Eliminar_GCelular_E", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
    }
    #endregion
}