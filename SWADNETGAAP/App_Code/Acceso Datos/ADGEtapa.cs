using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

/// <summary>
/// Descripción breve de ADGEtapa
/// </summary>
public class ADGEtapa
{
    #region Metodos públicos
    public void Insertar_GEtapa_I(EGEtapa etapa)
    {
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GEtapa_I");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoEtapa", DbType.Int32, etapa.CodigoEtapa);
            BDSWADNETGAAP.AddInParameter(dbCommand, "NumeroEtapa", DbType.Byte, etapa.NumeroEtapa);
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaInicioEtapa", DbType.DateTime, etapa.FechaInicioEtapa);
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaDefinidaEtapa", DbType.DateTime, etapa.FechaDefinidaEtapa);
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaFinEtapa", DbType.DateTime, etapa.FechaFinEtapa);
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, etapa.CodigoProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "EstadoEtapa", DbType.StringFixedLength, etapa.EstadoEtapa);
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
    public object Obtener_GEtapa_O_SiguienteCodigoEtapa()
    {
        object ultimoCodigo;
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand(SDatosPA.PROC_OBTENER_ULTIMO_CODIGO);
            bdNETGAAP.AddInParameter(comandoBD, "NombreTabla", DbType.String, "GEtapa");
            ultimoCodigo = bdNETGAAP.ExecuteScalar(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
        return ultimoCodigo;
    }
    public DTOGEtapa Obtener_GEtapa_O_CodigoProyecto(string CodigoProyecto)
    {
        DTOGEtapa dTOGEtapa = new DTOGEtapa();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GEtapa_O_CodigoProyecto");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoProyecto", DbType.String, CodigoProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGEtapa, "GEtapa");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGEtapa;
    }
    public DTOGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(string CodigoProyecto,char EstadoEtapa)
    {
        DTOGEtapa dTOGEtapa = new DTOGEtapa();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GEtapa_O_CodigoProyecto_EstadoEtapaActivo");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, CodigoProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "EstadoEtapa", DbType.StringFixedLength, EstadoEtapa);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGEtapa, "GEtapa");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGEtapa;
    }
    public DTOGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string CodigoProyecto, byte NumeroEtapa)
    {
        DTOGEtapa dTOGEtapa = new DTOGEtapa();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GEtapa_O_CodigoProyecto_NumeroEtapa");
            BDSWADNETGAAP.AddInParameter(dbCommand, "NumeroEtapa", DbType.Byte, NumeroEtapa);
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, CodigoProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGEtapa, "GEtapa");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGEtapa;
    }
    public DTOGEtapa Actualizar_GEtapa_A_EstadoEtapa(int CodigoEtapa, char EstadoEtapa)
    {
        DTOGEtapa dTOGEtapa = new DTOGEtapa();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GEtapa_A_EstadoEtapa");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoEtapa", DbType.Int32, CodigoEtapa);
            BDSWADNETGAAP.AddInParameter(dbCommand, "EstadoEtapa", DbType.StringFixedLength, EstadoEtapa);
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGEtapa, "GEtapa");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGEtapa;
    }
    
    #endregion
}