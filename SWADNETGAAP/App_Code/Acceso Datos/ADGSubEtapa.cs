using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.ServiceModel;

/// <summary>
/// Descripción breve de ADGSubEtapa
/// </summary>
public class ADGSubEtapa
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
        eDefectoAD.Clase = "ADGSubEtapa";
        eDefectoAD.Metodo = metodo;
        eDefectoAD.Excepcion = excepcion;
        eDefectoAD.Mensaje = mensaje;
        return eDefectoAD;
    }
    #endregion
    #region Metodos públicos
    public void Insertar_GSubEtapa_I(EGSubEtapa eGSubEtapa)
    {
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GSubEtapa_I");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoSubEtapa", DbType.Int32, eGSubEtapa.CodigoSubEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoEtapa", DbType.Int32, eGSubEtapa.CodigoEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuarioFirmaSubEtapa", DbType.StringFixedLength, eGSubEtapa.CodigoUsuarioFirmaSubEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoRolDesignadoSubEtapa", DbType.StringFixedLength, eGSubEtapa.CodigoRolDesignadoSubEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "NumeroSubEtapa", DbType.Byte, eGSubEtapa.NumeroSubEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaInicioSubEtapa", DbType.DateTime, eGSubEtapa.FechaInicioSubEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaDefinidaSubEtapa", DbType.DateTime, eGSubEtapa.FechaDefinidaSubEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaFinSubEtapa", DbType.DateTime, eGSubEtapa.FechaFinSubEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "EstadoSubEtapa", DbType.StringFixedLength, eGSubEtapa.EstadoSubEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.ESTADO_ACTIVO_AUDITORIA);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaRegistro", DbType.DateTime, SDatosPA.FECHA_REGISTRO_AUDITORIA);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.FECHA_MODIFICACION_AUDITORIA);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Insertar_GSubEtapa_I", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
    }
    public DTOGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa(int codigoEtapa)
    {
        DTOGSubEtapa dTOGSubEtapa = new DTOGSubEtapa();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GSubEtapa_O_CodigoEtapa");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoEtapa", DbType.Int32, codigoEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.ESTADO_ACTIVO_AUDITORIA);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGSubEtapa, "GSubEtapa");
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_GSubEtapa_O_CodigoEtapa", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dTOGSubEtapa;
    }
    public object Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa()
    {
        object ultimoCodigo;
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GSubEtapa_O_UltimoCodigoSubEtapa");
            ultimoCodigo = bdNETGAAP.ExecuteScalar(comandoBD);
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return ultimoCodigo;
    }
    public DTOGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(int codigoEtapa, char estadoSubEtapa)
    {
        DTOGSubEtapa dTOGSubEtapa = new DTOGSubEtapa();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GSubEtapa_O_CodigoEtapa_EstadoSubEtapa");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoEtapa", DbType.Int32, codigoEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "EstadoSubEtapa", DbType.StringFixedLength, estadoSubEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.ESTADO_ACTIVO_AUDITORIA);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGSubEtapa, "GSubEtapa");
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dTOGSubEtapa;
    }
    public DTOGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int codigoEtapa, byte numeroSubEtapa)
    {
        DTOGSubEtapa dTOGSubEtapa = new DTOGSubEtapa();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GSubEtapa_O_CodigoEtapa_NumeroSubEtapa");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoEtapa", DbType.Int32, codigoEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "NumeroSubEtapa", DbType.Byte, numeroSubEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.ESTADO_ACTIVO_AUDITORIA);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGSubEtapa, "GSubEtapa");
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dTOGSubEtapa;
    }
    public DTOGSubEtapa Actualizar_GSubEtapa_A_CodigoUsuarioFirmaSubEtapa_EstadoSubEtapa(string codigoUsuarioFirmaSubEtapa,int codigoSubEtapa, char estadoSubEtapa)
    {
        DTOGSubEtapa dTOGSubEtapa = new DTOGSubEtapa();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GSubEtapa_A_CodigoUsuarioFirmaSubEtapa_EstadoSubEtapa");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuarioFirmaSubEtapa", DbType.String, codigoUsuarioFirmaSubEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoSubEtapa", DbType.Int32, codigoSubEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "EstadoSubEtapa", DbType.StringFixedLength, estadoSubEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.FECHA_MODIFICACION_AUDITORIA);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGSubEtapa, "GSubEtapa");
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "GSubEtapa_A_CodigoUsuarioFirmaSubEtapa_EstadoSubEtapa", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dTOGSubEtapa;
    }
    public DTOGSubEtapa Actualizar_GSubEtapa_A_EstadoSubEtapa(int codigoSubEtapa, char estadoSubEtapa)
    {
        DTOGSubEtapa dTOGSubEtapa = new DTOGSubEtapa();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GSubEtapa_A_EstadoSubEtapa");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoSubEtapa", DbType.Int32, codigoSubEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "EstadoSubEtapa", DbType.StringFixedLength, estadoSubEtapa);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGSubEtapa, "GSubEtapa");
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Actualizar_GSubEtapa_A_EstadoSubEtapa", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dTOGSubEtapa;
    }
    #endregion
}