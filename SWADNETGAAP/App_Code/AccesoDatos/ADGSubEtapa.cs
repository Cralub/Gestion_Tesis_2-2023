using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Data.Common;

/// <summary>
/// Descripción breve de ADGSubEtapa
/// </summary>
public class ADGSubEtapa
{
    #region Metodos públicos
    //public void Insertar_GSubEtapa_I(EGSubEtapa eGSubEtapa)
    //{
    //    try
    //    {
    //        Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
    //        DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GSubEtapa_I");
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoSubEtapa", DbType.Int32, eGSubEtapa.CodigoSubEtapa);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoEtapa", DbType.Int32, eGSubEtapa.CodigoEtapa);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuarioFirma", DbType.StringFixedLength, SDatosPA.FirmaPorDefecto);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "NumeroSubEtapa", DbType.Byte, eGSubEtapa.NumeroSubEtapa);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "FechaInicioSubEtapa", DbType.DateTime, eGSubEtapa.FechaInicioSubEtapa);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "FechaDefinidaSubEtapa", DbType.DateTime, eGSubEtapa.FechaDefinidaSubEtapa);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "FechaFinSubEtapa", DbType.DateTime, eGSubEtapa.FechaFinSubEtapa);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "EstadoSubEtapa", DbType.StringFixedLength, eGSubEtapa.EstadoSubEtapa);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "FechaRegistro", DbType.DateTime, SDatosPA.Auditoria_FechaRegistro);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
    //        BDSWADNETGAAP.ExecuteNonQuery(dbCommand);
    //    }
    //    catch (Exception ex)
    //    {
    //        throw ex;
    //    }
    //}
    //public DTOGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa(int CodigoEtapa)
    //{
    //    DTOGSubEtapa dTOGSubEtapa = new DTOGSubEtapa();
    //    try
    //    {
    //        Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
    //        DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GSubEtapa_O_CodigoEtapa");
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoEtapa", DbType.Int32, CodigoEtapa);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
    //        BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGSubEtapa, "GSubEtapa");
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //    return dTOGSubEtapa;
    //}
    //public Object Obtener_GSubEtapa_O_UltimoCodigoSubEtapa()
    //{
    //    Object res = null;
    //    try
    //    {
    //        Database database = SBaseDatos.BDSWADNETGAAP;
    //        DbCommand dbCommand = database.GetStoredProcCommand("GSubEtapa_O_UltimoCodigoSubEtapa");
    //        res =database.ExecuteScalar(dbCommand);
    //    }
    //    catch (Exception ex)
    //    {
    //        throw ex;
    //    }
    //    return res;
    //}
    //public DTOGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(int CodigoEtapa)
    //{
    //    DTOGSubEtapa dTOGSubEtapa = new DTOGSubEtapa();
    //    try
    //    {
    //        Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
    //        DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo");
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoEtapa", DbType.Int32, CodigoEtapa);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "EstadoSubEtapa", DbType.StringFixedLength, SDatosPA.Activo);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
    //        BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGSubEtapa, "GSubEtapa");
    //    }
    //    catch (Exception)
    //    {

    //        throw;
    //    }
    //    return dTOGSubEtapa;
    //}
    //public DTOGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int CodigoEtapa, byte NumeroSubEtapa)
    //{
    //    DTOGSubEtapa dTOGSubEtapa = new DTOGSubEtapa();
    //    try
    //    {
    //        Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
    //        DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GSubEtapa_O_CodigoEtapa_NumeroSubEtapa");
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoEtapa", DbType.Int32, CodigoEtapa);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "NumeroSubEtapa", DbType.Byte, NumeroSubEtapa);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
    //        BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGSubEtapa, "GSubEtapa");
    //    }
    //    catch (Exception)
    //    {

    //        throw;
    //    }
    //    return dTOGSubEtapa;
    //}
    //public DTOGSubEtapa Actualizar_GSubEtapa_A_EstadoSubEtapa(int CodigoSubEtapa, char EstadoSubEtapa)
    //{
    //    DTOGSubEtapa dTOGSubEtapa = new DTOGSubEtapa();
    //    try
    //    {
    //        Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
    //        DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GSubEtapa_A_EstadoSubEtapa");
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoSubEtapa", DbType.Int32, CodigoSubEtapa);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "EstadoSubEtapa", DbType.StringFixedLength, EstadoSubEtapa);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
    //        BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGSubEtapa, "GSubEtapa");
    //    }
    //    catch (Exception)
    //    {

    //        throw;
    //    }
    //    return dTOGSubEtapa;
    //}
    #endregion
}