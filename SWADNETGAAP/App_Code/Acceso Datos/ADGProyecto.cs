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
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GProyecto_I");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, eGProyecto.CodigoProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "ModalidadProyecto", DbType.StringFixedLength, eGProyecto.ModalidadProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "TituloProyecto", DbType.String, eGProyecto.TituloProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "ObjetivoGeneralProyecto", DbType.String, eGProyecto.ObjetivoGeneralProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "ObjetivosEspecificosProyecto", DbType.String, eGProyecto.ObjetivosEspecificosProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "AlcanceProyecto", DbType.String, eGProyecto.AlcanceProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "EnlaceDocumentoProyecto", DbType.String, eGProyecto.EnlaceDocumentoProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "EstadoProyecto", DbType.StringFixedLength, eGProyecto.EstadoProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "NumeroRevisiones", DbType.Int32, eGProyecto.NumeroRevisiones);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaRegistro", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_REGISTRO);
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            BDSWADNETGAAP.ExecuteNonQuery(dbCommand);
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
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GProyecto_O");
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaInicio", DbType.DateTime, fechaInicio);
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaFin", DbType.DateTime, fechaFin);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dtoGProyecto, "GProyecto");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dtoGProyecto;
    }
    public DTOGProyecto Obtener_GProyecto_O_CodigoProyecto(string CodigoProyecto)
    {
        DTOGProyecto dTOGProyecto = new DTOGProyecto();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GProyecto_O_CodigoProyecto");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, CodigoProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGProyecto, "GProyecto");
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
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GProyecto_A");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, eGProyecto.CodigoProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "ModalidadProyecto", DbType.StringFixedLength, eGProyecto.ModalidadProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "TituloProyecto", DbType.String, eGProyecto.TituloProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "ObjetivoGeneralProyecto", DbType.String, eGProyecto.ObjetivoGeneralProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "ObjetivosEspecificosProyecto", DbType.String, eGProyecto.ObjetivosEspecificosProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "AlcanceProyecto", DbType.String, eGProyecto.AlcanceProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "EnlaceDocumentoProyecto", DbType.String, eGProyecto.EnlaceDocumentoProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            BDSWADNETGAAP.ExecuteNonQuery(dbCommand);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    #endregion    
}