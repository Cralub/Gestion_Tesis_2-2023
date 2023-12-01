using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.ServiceModel;
using Microsoft.Practices.EnterpriseLibrary.Data;

/// <summary>
/// Descripción breve de ADGEtapa
/// </summary>
public class ADGEtapa
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
        eDefectoAD.Clase = "ADGEtapa";
        eDefectoAD.Metodo = metodo;
        eDefectoAD.Excepcion = excepcion;
        eDefectoAD.Mensaje = mensaje;
        return eDefectoAD;
    }
    #endregion
    #region Metodos públicos
    public void Insertar_GEtapa_I(EGEtapa eGEtapa)
    {
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GEtapa_I");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoEtapa", DbType.Int32, eGEtapa.CodigoEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "NumeroEtapa", DbType.Byte, eGEtapa.NumeroEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaInicioEtapa", DbType.DateTime, eGEtapa.FechaInicioEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaDefinidaEtapa", DbType.DateTime, eGEtapa.FechaDefinidaEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaFinEtapa", DbType.DateTime, eGEtapa.FechaFinEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.StringFixedLength, eGEtapa.CodigoProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "EstadoEtapa", DbType.StringFixedLength, eGEtapa.EstadoEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.ESTADO_ACTIVO_AUDITORIA);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaRegistro", DbType.DateTime, SDatosPA.FECHA_REGISTRO_AUDITORIA);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.FECHA_MODIFICACION_AUDITORIA);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Insertar_GEtapa_I", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
    }
    public object Obtener_GEtapa_O_SiguienteCodigoEtapa()
    {
        object ultimoCodigo;
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GEtapa_O_UltimoCodigoEtapa");
            ultimoCodigo = bdNETGAAP.ExecuteScalar(comandoBD);
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_GEtapa_O_SiguienteCodigoEtapa", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return ultimoCodigo;
    }
    public DTOGEtapa Obtener_GEtapa_O_CodigoProyecto(string codigoProyecto)
    {
        DTOGEtapa dTOGEtapa = new DTOGEtapa();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GEtapa_O_CodigoProyecto");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.String, codigoProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.ESTADO_ACTIVO_AUDITORIA);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGEtapa, "GEtapa");
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_GEtapa_O_CodigoProyecto", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dTOGEtapa;
    }
    public DTOGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(string codigoProyecto,char estadoEtapa)
    {
        DTOGEtapa dTOGEtapa = new DTOGEtapa();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GEtapa_O_CodigoProyecto_EstadoEtapa");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.String, codigoProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "EstadoEtapa", DbType.StringFixedLength, estadoEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.ESTADO_ACTIVO_AUDITORIA);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGEtapa, "GEtapa");
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dTOGEtapa;
    }
    public DTOGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string codigoProyecto, byte numeroEtapa)
    {
        DTOGEtapa dTOGEtapa = new DTOGEtapa();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GEtapa_O_CodigoProyecto_NumeroEtapa");
            bdSWADNETGAAP.AddInParameter(comandoBD, "NumeroEtapa", DbType.Byte, numeroEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.StringFixedLength, codigoProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.ESTADO_ACTIVO_AUDITORIA);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGEtapa, "GEtapa");
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dTOGEtapa;
    }
    public DTOGEtapa Actualizar_GEtapa_A_EstadoEtapa(int codigoEtapa, char estadoEtapa)
    {
        DTOGEtapa dTOGEtapa = new DTOGEtapa();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GEtapa_A_EstadoEtapa");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoEtapa", DbType.Int32, codigoEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "EstadoEtapa", DbType.StringFixedLength, estadoEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.FECHA_MODIFICACION_AUDITORIA);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGEtapa, "GEtapa");
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Actualizar_GEtapa_A_EstadoEtapa", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dTOGEtapa;
    }
    
    #endregion
}