using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

/// <summary>
/// Descripción breve de ADGEtapa
/// </summary>
public class ADGEtapa
{
    #region Métodos públicos
    public void Insertar_GEtapa_I(EGEtapa etapa)
    {
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GEtapa_I");
            bdNETGAAP.AddInParameter(comandoBD, "CodigoEtapa", DbType.Int32, etapa.CodigoEtapa);
            bdNETGAAP.AddInParameter(comandoBD, "NumeroEtapa", DbType.Byte, etapa.NumeroEtapa);
            bdNETGAAP.AddInParameter(comandoBD, "FechaInicioEtapa", DbType.DateTime, etapa.FechaInicioEtapa);
            bdNETGAAP.AddInParameter(comandoBD, "FechaDefinidaEtapa", DbType.DateTime, etapa.FechaDefinidaEtapa);
            bdNETGAAP.AddInParameter(comandoBD, "FechaFinEtapa", DbType.DateTime, etapa.FechaFinEtapa);
            bdNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.StringFixedLength, etapa.CodigoProyecto);
            bdNETGAAP.AddInParameter(comandoBD, "EstadoEtapa", DbType.StringFixedLength, etapa.EstadoEtapa);
            bdNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            bdNETGAAP.AddInParameter(comandoBD, "FechaRegistro", DbType.DateTime, SDatosPA.Auditoria_FechaRegistro);
            bdNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            bdNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public Object Obtener_GEtapa_O_UltimoCodigoEtapa()
    {
        Object res = null;
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GEtapa_O_UltimoCodigoEtapa");
            res = bdNETGAAP.ExecuteScalar(comandoBD);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return res;
    }
    public DTOGEtapa Obtener_GEtapa_O_CodigoProyecto(string CodigoProyecto)
    {
        DTOGEtapa dTOGEtapa = new DTOGEtapa();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GEtapa_O_CodigoProyecto");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoProyecto", DbType.String, CodigoProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGEtapa, "GEtapa");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGEtapa;
    }
    public DTOGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(string CodigoProyecto)
    {
        DTOGEtapa dTOGEtapa = new DTOGEtapa();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GEtapa_O_CodigoProyecto_EstadoEtapaActivo");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, CodigoProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "EstadoEtapa", DbType.StringFixedLength, SDatosPA.Activo);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
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
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
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
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
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