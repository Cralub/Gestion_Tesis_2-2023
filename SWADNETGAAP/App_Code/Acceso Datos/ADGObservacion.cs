using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Data.Common;

/// <summary>
/// Descripción breve de ADGObservacion
/// </summary>
public class ADGObservacion
{
    #region Metodos publicos
    public void Insertar_GObservacion_I(EGObservacion eGObservacion)
    {
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GObservacion_I");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoObservacion", DbType.Int32, eGObservacion.CodigoObservacion);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.StringFixedLength, eGObservacion.CodigoProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoSubEtapa", DbType.Int32, eGObservacion.CodigoSubEtapa);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuarioObservacion", DbType.StringFixedLength, eGObservacion.CodigoUsuarioObservacion);
            bdSWADNETGAAP.AddInParameter(comandoBD, "ComentarioObservacion", DbType.String, eGObservacion.ComentarioObservacion);
            bdSWADNETGAAP.AddInParameter(comandoBD, "TipoObservacion", DbType.String, eGObservacion.TipoObservacion);
            bdSWADNETGAAP.AddInParameter(comandoBD, "EstadoObservacion", DbType.StringFixedLength, eGObservacion.EstadoObservacion);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaRegistro", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_REGISTRO);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public DTOGObservacion Obtener_GObservacion_O_CodigoProyecto(string codigoProyecto)
    {
        DTOGObservacion dtoGObservacion = new DTOGObservacion();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GObservacion_O_CodigoProyecto");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.String, codigoProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dtoGObservacion, "GObservacion");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoGObservacion;
    }
    public DTOGObservacion Obtener_GObservacion_O_CodigoObservacion(int codigoObservacion)
    {
        DTOGObservacion dtoGObservacion = new DTOGObservacion();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GObservacion_O_CodigoObservacion");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoObservacion", DbType.String, codigoObservacion);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dtoGObservacion, "GObservacion");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoGObservacion;
    }
    public void Actualizar_GObservacion_A(EGObservacion eGObservacion)
    {
        Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
        DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GObservacion_A");
        bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoObservacion", DbType.Int32, eGObservacion.CodigoObservacion);
        bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.StringFixedLength, eGObservacion.CodigoProyecto);
        bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoSubEtapa", DbType.Int32, eGObservacion.CodigoSubEtapa);
        bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuarioObservacion", DbType.StringFixedLength, eGObservacion.CodigoUsuarioObservacion);
        bdSWADNETGAAP.AddInParameter(comandoBD, "ComentarioObservacion", DbType.String, eGObservacion.ComentarioObservacion);
        bdSWADNETGAAP.AddInParameter(comandoBD, "TipoObservacion", DbType.String, eGObservacion.TipoObservacion);
        bdSWADNETGAAP.AddInParameter(comandoBD, "EstadoObservacion", DbType.StringFixedLength, eGObservacion.EstadoObservacion);
        bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
        bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
    }
    public void Actualizar_GObservacion_A_EstadoObservacion(int codigoObservacion, char estadoObservacion)
    {
        Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
        DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GObservacion_A_EstadoObservacion");
        bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoObservacion", DbType.Int32, codigoObservacion);
        bdSWADNETGAAP.AddInParameter(comandoBD, "EstadoObservacion", DbType.StringFixedLength, estadoObservacion);
        bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
        bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
    }
    public object Obtener_GObsevacion_O_SiguienteCodigoObservacion()
    {
        object ultimoCodigo;
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GObsevacion_O_UltimoCodigoObservacion");
            ultimoCodigo = bdNETGAAP.ExecuteScalar(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
        return ultimoCodigo;
    }    
    #endregion

}