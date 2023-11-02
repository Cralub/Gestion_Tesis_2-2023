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
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GObservacion_I");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoObservacion", DbType.Int32, eGObservacion.CodigoObservacion);
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, eGObservacion.CodigoProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoSubEtapa", DbType.Int32, eGObservacion.CodigoSubEtapa);
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuarioObservacion", DbType.StringFixedLength, eGObservacion.CodigoUsuarioObservacion);
            BDSWADNETGAAP.AddInParameter(dbCommand, "ComentarioObservacion", DbType.String, eGObservacion.ComentarioObservacion);
            BDSWADNETGAAP.AddInParameter(dbCommand, "TipoObservacion", DbType.String, eGObservacion.TipoObservacion);
            BDSWADNETGAAP.AddInParameter(dbCommand, "EstadoObservacion", DbType.StringFixedLength, eGObservacion.EstadoObservacion);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaRegistro", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_REGISTRO);
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            BDSWADNETGAAP.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public DTOGObservacion Obtener_GObservacion_O_CodigoProyecto(string CodigoProyecto)
    {
        DTOGObservacion dtoGObservacion = new DTOGObservacion();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GObservacion_O_CodigoProyecto");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoProyecto", DbType.String, CodigoProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dtoGObservacion, "GObservacion");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoGObservacion;
    }
    public DTOGObservacion Obtener_GObservacion_O_CodigoObservacion(int CodigoObservacion)
    {
        DTOGObservacion dtoGObservacion = new DTOGObservacion();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GObservacion_O_CodigoObservacion");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoObservacion", DbType.String, CodigoObservacion);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dtoGObservacion, "GObservacion");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoGObservacion;
    }
    public void Actualizar_GObservacion_A(EGObservacion eGObservacion)
    {
        Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
        DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GObservacion_A");
        BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoObservacion", DbType.Int32, eGObservacion.CodigoObservacion);
        BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, eGObservacion.CodigoProyecto);
        BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoSubEtapa", DbType.Int32, eGObservacion.CodigoSubEtapa);
        BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuarioObservacion", DbType.StringFixedLength, eGObservacion.CodigoUsuarioObservacion);
        BDSWADNETGAAP.AddInParameter(dbCommand, "ComentarioObservacion", DbType.String, eGObservacion.ComentarioObservacion);
        BDSWADNETGAAP.AddInParameter(dbCommand, "TipoObservacion", DbType.String, eGObservacion.TipoObservacion);
        BDSWADNETGAAP.AddInParameter(dbCommand, "EstadoObservacion", DbType.StringFixedLength, eGObservacion.EstadoObservacion);
        BDSWADNETGAAP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
        BDSWADNETGAAP.ExecuteNonQuery(dbCommand);
    }
    public void Actualizar_GObservacion_A_EstadoObservacion(int CodigoObservacion, char EstadoObservacion)
    {
        Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
        DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GObservacion_A_EstadoObservacion");
        BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoObservacion", DbType.Int32, CodigoObservacion);
        BDSWADNETGAAP.AddInParameter(dbCommand, "EstadoObservacion", DbType.StringFixedLength, EstadoObservacion);
        BDSWADNETGAAP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
        BDSWADNETGAAP.ExecuteNonQuery(dbCommand);
    }
    public object Obtener_GObsevacion_O_SiguienteCodigoObservacion()
    {
        object ultimoCodigo;
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand(SDatosPA.PROC_OBTENER_ULTIMO_CODIGO);
            bdNETGAAP.AddInParameter(comandoBD, "NombreTabla", DbType.String, "GObservacion");
            ultimoCodigo = bdNETGAAP.ExecuteScalar(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
        return ultimoCodigo;
    }

    internal DTOGObservacion Obtener_GObservacion_O_TipoObservacion(char tipoObservacion)
    {
        throw new NotImplementedException();
    }
    #endregion

}