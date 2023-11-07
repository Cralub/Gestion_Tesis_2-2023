﻿using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Data.Common;

/// <summary>
/// Descripción breve de ADGSubEtapa
/// </summary>
public class ADGSubEtapa
{
    #region Metodos públicos
    public void Insertar_GSubEtapa_I(EGSubEtapa eGSubEtapa)
    {
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GSubEtapa_I");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoSubEtapa", DbType.Int32, eGSubEtapa.CodigoSubEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoEtapa", DbType.Int32, eGSubEtapa.CodigoEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuarioFirma", DbType.StringFixedLength, eGSubEtapa.CodigoUsuarioFirma);
            bdSWADNETGAAP.AddInParameter(comandoBD, "NumeroSubEtapa", DbType.Byte, eGSubEtapa.NumeroSubEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaInicioSubEtapa", DbType.DateTime, eGSubEtapa.FechaInicioSubEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaDefinidaSubEtapa", DbType.DateTime, eGSubEtapa.FechaDefinidaSubEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaFinSubEtapa", DbType.DateTime, eGSubEtapa.FechaFinSubEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "EstadoSubEtapa", DbType.StringFixedLength, eGSubEtapa.EstadoSubEtapa);
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
    public DTOGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa(int codigoEtapa)
    {
        DTOGSubEtapa dTOGSubEtapa = new DTOGSubEtapa();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GSubEtapa_O_CodigoEtapa");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoEtapa", DbType.Int32, codigoEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGSubEtapa, "GSubEtapa");
        }
        catch (Exception)
        {
            throw;
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
        catch (Exception)
        {
            throw;
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
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGSubEtapa, "GSubEtapa");
        }
        catch (Exception)
        {

            throw;
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
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGSubEtapa, "GSubEtapa");
        }
        catch (Exception)
        {

            throw;
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
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGSubEtapa, "GSubEtapa");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOGSubEtapa;
    }
    #endregion
}