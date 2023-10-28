using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Data.Common;

/// <summary>
/// Descripción breve de ADGSubEtapa
/// </summary>
public class ADGSubEtapa
{
    #region Métodos públicos
    public void Insertar_GSubEtapa_I(EGSubEtapa subEtapa)
    {
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GSubEtapa_I");
            bdNETGAAP.AddInParameter(comandoBD, "CodigoSubEtapa", DbType.Int32, subEtapa.CodigoSubEtapa);
            bdNETGAAP.AddInParameter(comandoBD, "CodigoEtapa", DbType.Int32, subEtapa.CodigoEtapa);
            bdNETGAAP.AddInParameter(comandoBD, "CodigoUsuarioFirma", DbType.String, SDatosPA.FirmaPorDefecto);
            bdNETGAAP.AddInParameter(comandoBD, "NumeroSubEtapa", DbType.Byte, subEtapa.NumeroSubEtapa);
            bdNETGAAP.AddInParameter(comandoBD, "FechaInicioSubEtapa", DbType.DateTime, subEtapa.FechaInicioSubEtapa);
            bdNETGAAP.AddInParameter(comandoBD, "FechaDefinidaSubEtapa", DbType.DateTime, subEtapa.FechaDefinidaSubEtapa);
            bdNETGAAP.AddInParameter(comandoBD, "FechaFinSubEtapa", DbType.DateTime, subEtapa.FechaFinSubEtapa);
            bdNETGAAP.AddInParameter(comandoBD, "EstadoSubEtapa", DbType.StringFixedLength, subEtapa.EstadoSubEtapa);
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
    public DTOGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa(int CodigoEtapa)
    {
        DTOGSubEtapa dTOGSubEtapa = new DTOGSubEtapa();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GSubEtapa_O_CodigoEtapa");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoEtapa", DbType.Int32, CodigoEtapa);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGSubEtapa, "GSubEtapa");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGSubEtapa;
    }
    public Object Obtener_GSubEtapa_O_UltimoCodigoSubEtapa()
    {
        Object res = null;
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GSubEtapa_O_UltimoCodigoSubEtapa");
            res = bdNETGAAP.ExecuteScalar(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
        return res;
    }
    public DTOGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(int CodigoEtapa)
    {
        DTOGSubEtapa dTOGSubEtapa = new DTOGSubEtapa();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoEtapa", DbType.Int32, CodigoEtapa);
            BDSWADNETGAAP.AddInParameter(dbCommand, "EstadoSubEtapa", DbType.StringFixedLength, SDatosPA.Activo);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGSubEtapa, "GSubEtapa");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOGSubEtapa;
    }
    public DTOGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int CodigoEtapa, byte NumeroSubEtapa)
    {
        DTOGSubEtapa dTOGSubEtapa = new DTOGSubEtapa();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GSubEtapa_O_CodigoEtapa_NumeroSubEtapa");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoEtapa", DbType.Int32, CodigoEtapa);
            BDSWADNETGAAP.AddInParameter(dbCommand, "NumeroSubEtapa", DbType.Byte, NumeroSubEtapa);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGSubEtapa, "GSubEtapa");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOGSubEtapa;
    }
    public DTOGSubEtapa Actualizar_GSubEtapa_A_EstadoSubEtapa(int CodigoSubEtapa, char EstadoSubEtapa)
    {
        DTOGSubEtapa dTOGSubEtapa = new DTOGSubEtapa();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GSubEtapa_A_EstadoSubEtapa");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoSubEtapa", DbType.Int32, CodigoSubEtapa);
            BDSWADNETGAAP.AddInParameter(dbCommand, "EstadoSubEtapa", DbType.StringFixedLength, EstadoSubEtapa);
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGSubEtapa, "GSubEtapa");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOGSubEtapa;
    }
    #endregion
}