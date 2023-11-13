using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.ServiceModel;

/// <summary>
/// Descripción breve de ADGProyecto
/// </summary>
public class ADGProyecto
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
        eDefectoAD.Clase = "ADGProyecto";
        eDefectoAD.Metodo = metodo;
        eDefectoAD.Excepcion = excepcion;
        eDefectoAD.Mensaje = mensaje;
        return eDefectoAD;
    }
    #endregion
    #region Métodos públicos
    public void Insertar_GProyecto_I(EGProyecto eGProyecto)
    {
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GProyecto_I");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.StringFixedLength, eGProyecto.CodigoProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "ModalidadProyecto", DbType.StringFixedLength, eGProyecto.ModalidadProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "TituloProyecto", DbType.String, eGProyecto.TituloProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "ObjetivoGeneralProyecto", DbType.String, eGProyecto.ObjetivoGeneralProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "ObjetivosEspecificosProyecto", DbType.String, eGProyecto.ObjetivosEspecificosProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "AlcanceProyecto", DbType.String, eGProyecto.AlcanceProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "EnlaceDocumentoProyecto", DbType.String, eGProyecto.EnlaceDocumentoProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "EstadoProyecto", DbType.StringFixedLength, SDatosPA.ESTADO_ACTIVO_GAAP);
            bdSWADNETGAAP.AddInParameter(comandoBD, "NumeroRevisiones", DbType.Int32, eGProyecto.NumeroRevisiones);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.ESTADO_ACTIVO_AUDITORIA);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaRegistro", DbType.DateTime, SDatosPA.FECHA_REGISTRO_AUDITORIA);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.FECHA_MODIFICACION_AUDITORIA);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Insertar_GProyecto_I", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
    }
    public DTOGProyecto Obtener_GProyecto_O(DateTime fechaInicio, DateTime fechaFin)
    {
        DTOGProyecto dtoGProyecto = new DTOGProyecto();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GProyecto_O");
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaInicio", DbType.DateTime, fechaInicio);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaFin", DbType.DateTime, fechaFin);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.ESTADO_ACTIVO_AUDITORIA);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dtoGProyecto, "GProyecto");
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_GProyecto_O", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoGProyecto;
    }
    public DTOGProyecto Obtener_GProyecto_O_CodigoProyecto(string codigoProyecto)
    {
        DTOGProyecto dTOGProyecto = new DTOGProyecto();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GProyecto_O_CodigoProyecto");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.StringFixedLength, codigoProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.ESTADO_ACTIVO_AUDITORIA);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGProyecto, "GProyecto");
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_GProyecto_O_CodigoProyecto", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dTOGProyecto;
    }
    public void Actualizar_GProyecto_A(EGProyecto eGProyecto)
    {
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GProyecto_A");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.StringFixedLength, eGProyecto.CodigoProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "ModalidadProyecto", DbType.StringFixedLength, eGProyecto.ModalidadProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "TituloProyecto", DbType.String, eGProyecto.TituloProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "ObjetivoGeneralProyecto", DbType.String, eGProyecto.ObjetivoGeneralProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "ObjetivosEspecificosProyecto", DbType.String, eGProyecto.ObjetivosEspecificosProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "AlcanceProyecto", DbType.String, eGProyecto.AlcanceProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "EnlaceDocumentoProyecto", DbType.String, eGProyecto.EnlaceDocumentoProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "NumeroRevisiones", DbType.Byte, eGProyecto.NumeroRevisiones);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.FECHA_MODIFICACION_AUDITORIA);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Actualizar_GProyecto_A", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
    }
    #endregion    
}