using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Data.Common;

/// <summary>
/// Descripción breve de ADGUsuarioProyecto
/// </summary>
public class ADGUsuarioProyecto
{
    #region Métodos públicos
    public void Insertar_GUsuarioProyecto_I(EGUsuarioProyecto eGUsuarioProyecto)
    {
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GUsuarioProyecto_I");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuarioProyecto", DbType.Int32, eGUsuarioProyecto.CodigoUsuarioProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuario", DbType.StringFixedLength, eGUsuarioProyecto.CodigoUsuario);
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, eGUsuarioProyecto.CodigoProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoRol", DbType.StringFixedLength, eGUsuarioProyecto.CodigoRol);
            BDSWADNETGAAP.AddInParameter(dbCommand, "EstadoUsuarioProyecto", DbType.StringFixedLength, eGUsuarioProyecto.EstadoUsuarioProyecto);
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
    public object Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto()
    {
        object ultimoCodigo;
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand(SDatosPA.PROC_OBTENER_ULTIMO_CODIGO);
            bdNETGAAP.AddInParameter(comandoBD, "NombreTabla", DbType.String, "GUsuarioProyecto");
            ultimoCodigo = bdNETGAAP.ExecuteScalar(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
        return ultimoCodigo;
    }
    public DTOGUsuarioProyecto Obtener_GUsuarioProyecto_O_CodigoProyecto(string CodigoProyecto)
    {
        DTOGUsuarioProyecto DTOGUsuarioProyecto = new DTOGUsuarioProyecto();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GUsuarioProyecto_O_CodigoProyecto");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, CodigoProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            BDSWADNETGAAP.LoadDataSet(dbCommand, DTOGUsuarioProyecto, "GUsuarioProyecto");
        }
        catch (Exception)
        {
            throw;
        }
        return DTOGUsuarioProyecto;
    }
    public DTOGUsuarioProyecto Obtener_GUsuarioProyecto_O_CodigoUsuario(string CodigoUsuario)
    {
        DTOGUsuarioProyecto DTOGUsuarioProyecto = new DTOGUsuarioProyecto();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GUsuarioProyecto_O_CodigoUsuario");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuario", DbType.StringFixedLength, CodigoUsuario);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            BDSWADNETGAAP.LoadDataSet(dbCommand, DTOGUsuarioProyecto, "GUsuarioProyecto");
        }
        catch (Exception)
        {
            throw;
        }
        return DTOGUsuarioProyecto;
    }
    public DTOGUsuarioProyecto Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(string CodigoUsuario, string CodigoProyecto)
    {
        DTOGUsuarioProyecto dTOGUsuarioProyecto = new DTOGUsuarioProyecto();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuario", DbType.String, CodigoUsuario);
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoProyecto", DbType.String, CodigoProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGUsuarioProyecto, "GUsuarioProyecto");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGUsuarioProyecto;
    }
    public void Actualizar_GUsuarioProyecto_A(EGUsuarioProyecto eGUsuarioProyecto)
    {
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GUsuarioProyecto_A");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuarioProyecto", DbType.Int32, eGUsuarioProyecto.CodigoUsuarioProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuario", DbType.StringFixedLength, eGUsuarioProyecto.CodigoUsuario);
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, eGUsuarioProyecto.CodigoProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoRol", DbType.StringFixedLength, eGUsuarioProyecto.CodigoRol);
            BDSWADNETGAAP.AddInParameter(dbCommand, "EstadoUsuarioProyecto", DbType.StringFixedLength, eGUsuarioProyecto.EstadoUsuarioProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            BDSWADNETGAAP.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {

            throw;
        }
    }
    public void Eliminar_UsuarioProyecto_E(int codigoUsuarioProyecto)
    {
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GUsuarioProyecto_E");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuarioProyecto", DbType.Int32, codigoUsuarioProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_INACTIVO);
            BDSWADNETGAAP.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}