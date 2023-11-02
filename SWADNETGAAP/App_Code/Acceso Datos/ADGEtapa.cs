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
    public DTOGEtapa Obtener_GEtapa_O_CodigoProyecto(string codigoProyecto)
    {
        DTOGEtapa dTOGEtapa = new DTOGEtapa();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GEtapa_O_CodigoProyecto");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.String, codigoProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGEtapa, "GEtapa");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGEtapa;
    }
    public DTOGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(string codigoProyecto,char estadoEtapa)
    {
        DTOGEtapa dTOGEtapa = new DTOGEtapa();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GEtapa_O_CodigoProyecto_EstadoEtapaActivo");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.StringFixedLength, codigoProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "EstadoEtapa", DbType.StringFixedLength, estadoEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGEtapa, "GEtapa");
        }
        catch (Exception)
        {
            throw;
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
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGEtapa, "GEtapa");
        }
        catch (Exception)
        {
            throw;
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
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGEtapa, "GEtapa");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGEtapa;
    }
    
    #endregion
}