using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Data.Common;

/// <summary>
/// Descripción breve de ADGProyecto
/// </summary>
public class ADGProyecto
{
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
            bdSWADNETGAAP.AddInParameter(comandoBD, "EstadoProyecto", DbType.StringFixedLength, eGProyecto.EstadoProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "NumeroRevisiones", DbType.Int32, eGProyecto.NumeroRevisiones);
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
    public DTOGProyecto Obtener_GProyecto_O(DateTime fechaInicio, DateTime fechaFin)
    {
        DTOGProyecto dtoGProyecto = new DTOGProyecto();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GProyecto_O");
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaInicio", DbType.DateTime, fechaInicio);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaFin", DbType.DateTime, fechaFin);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dtoGProyecto, "GProyecto");
        }
        catch (Exception ex)
        {
            throw ex;
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
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGProyecto, "GProyecto");
        }
        catch (Exception ex)
        {
            throw ex;
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
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    #endregion    
}