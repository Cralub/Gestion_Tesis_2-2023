using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.ServiceModel;

/// <summary>
/// Descripción breve de ADGObservacion
/// </summary>
public class ADGObservacion
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
        eDefectoAD.Clase = "ADGObservacion";
        eDefectoAD.Metodo = metodo;
        eDefectoAD.Excepcion = excepcion;
        eDefectoAD.Mensaje = mensaje;
        return eDefectoAD;
    }
    #endregion
    #region Metodos publicos
    public void Insertar_GObservacion_I(EGObservacion eGObservacion)
    {
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GObservacion_I");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoObservacion", DbType.Int32, eGObservacion.CodigoObservacion);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.StringFixedLength, eGObservacion.CodigoProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoSubEtapa", DbType.Int32, eGObservacion.CodigoSubEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuarioObservacion", DbType.StringFixedLength, eGObservacion.CodigoUsuarioObservacion);
            bdSWADNETGAAP.AddInParameter(comandoBD, "ComentarioObservacion", DbType.String, eGObservacion.ComentarioObservacion);
            bdSWADNETGAAP.AddInParameter(comandoBD, "TipoObservacion", DbType.String, eGObservacion.TipoObservacion);
            bdSWADNETGAAP.AddInParameter(comandoBD, "EstadoObservacion", DbType.StringFixedLength, eGObservacion.EstadoObservacion);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.ESTADO_ACTIVO_AUDITORIA);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaRegistro", DbType.DateTime, SDatosPA.FECHA_REGISTRO_AUDITORIA);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.FECHA_MODIFICACION_AUDITORIA);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Insertar_GObservacion_I", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
    }
    public DTOGObservacion Obtener_GObservacion_O_CodigoProyecto(string codigoProyecto)
    {
        DTOGObservacion dtoGObservacion = new DTOGObservacion();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GObservacion_O_CodigoProyecto");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.StringFixedLength, codigoProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.ESTADO_ACTIVO_AUDITORIA);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dtoGObservacion, "GObservacion");
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_GObservacion_O_CodigoProyecto", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoGObservacion;
    }
    public DTOGObservacion Obtener_GObservacion_O_CodigoObservacion(int codigoObservacion)
    {
        DTOGObservacion dtoGObservacion = new DTOGObservacion();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GObservacion_O_CodigoObservacion");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoObservacion", DbType.Int32, codigoObservacion);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.ESTADO_ACTIVO_AUDITORIA);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dtoGObservacion, "GObservacion");
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_GObservacion_O_CodigoObservacion", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoGObservacion;
    }
    public void Actualizar_GObservacion_A(EGObservacion eGObservacion)
    {
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GObservacion_A");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoObservacion", DbType.Int32, eGObservacion.CodigoObservacion);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.StringFixedLength, eGObservacion.CodigoProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoSubEtapa", DbType.Int32, eGObservacion.CodigoSubEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuarioObservacion", DbType.StringFixedLength, eGObservacion.CodigoUsuarioObservacion);
            bdSWADNETGAAP.AddInParameter(comandoBD, "ComentarioObservacion", DbType.String, eGObservacion.ComentarioObservacion);
            bdSWADNETGAAP.AddInParameter(comandoBD, "TipoObservacion", DbType.String, eGObservacion.TipoObservacion);
            bdSWADNETGAAP.AddInParameter(comandoBD, "EstadoObservacion", DbType.StringFixedLength, eGObservacion.EstadoObservacion);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.FECHA_MODIFICACION_AUDITORIA);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Actualizar_GObservacion_A", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
    }
    public void Actualizar_GObservacion_A_EstadoObservacion(int codigoObservacion, char estadoObservacion)
    {
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GObservacion_A_EstadoObservacion");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoObservacion", DbType.Int32, codigoObservacion);
            bdSWADNETGAAP.AddInParameter(comandoBD, "EstadoObservacion", DbType.StringFixedLength, estadoObservacion);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.FECHA_MODIFICACION_AUDITORIA);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Actualizar_GObservacion_A_EstadoObservacion", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }        
    }
    public object Obtener_GObsevacion_O_SiguienteCodigoObservacion()
    {
        object ultimoCodigo;
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GObsevacion_O_UltimoCodigoObservacion");
            ultimoCodigo = bdNETGAAP.ExecuteScalar(comandoBD);
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_GObsevacion_O_SiguienteCodigoObservacion", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return ultimoCodigo;
    }    
    #endregion
}