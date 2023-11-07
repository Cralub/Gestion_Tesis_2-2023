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
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GUsuarioProyecto_I");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuarioProyecto", DbType.Int32, eGUsuarioProyecto.CodigoUsuarioProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuario", DbType.StringFixedLength, eGUsuarioProyecto.CodigoUsuario);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.StringFixedLength, eGUsuarioProyecto.CodigoProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoRol", DbType.StringFixedLength, eGUsuarioProyecto.CodigoRol);
            bdSWADNETGAAP.AddInParameter(comandoBD, "EstadoUsuarioProyecto", DbType.StringFixedLength, eGUsuarioProyecto.EstadoUsuarioProyecto);
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
    public object Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto()
    {
        object ultimoCodigo;
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GUsuarioProyecto_O_UltimoCodigoUsuarioProyecto");
            ultimoCodigo = bdNETGAAP.ExecuteScalar(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
        return ultimoCodigo;
    }
    public DTOGUsuarioProyecto Obtener_GUsuarioProyecto_O_CodigoProyecto(string codigoProyecto)
    {
        DTOGUsuarioProyecto DTOGUsuarioProyecto = new DTOGUsuarioProyecto();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GUsuarioProyecto_O_CodigoProyecto");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.StringFixedLength, codigoProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.LoadDataSet(comandoBD, DTOGUsuarioProyecto, "GUsuarioProyecto");
        }
        catch (Exception)
        {
            throw;
        }
        return DTOGUsuarioProyecto;
    }
    public DTOGUsuarioProyecto Obtener_GUsuarioProyecto_O_CodigoUsuario(string codigoUsuario)
    {
        DTOGUsuarioProyecto DTOGUsuarioProyecto = new DTOGUsuarioProyecto();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GUsuarioProyecto_O_CodigoUsuario");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuario", DbType.StringFixedLength, codigoUsuario);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.LoadDataSet(comandoBD, DTOGUsuarioProyecto, "GUsuarioProyecto");
        }
        catch (Exception)
        {
            throw;
        }
        return DTOGUsuarioProyecto;
    }
    public DTOGUsuarioProyecto Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(string codigoUsuario, string codigoProyecto)
    {
        DTOGUsuarioProyecto dTOGUsuarioProyecto = new DTOGUsuarioProyecto();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuario", DbType.String, codigoUsuario);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.String, codigoProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGUsuarioProyecto, "GUsuarioProyecto");
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
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GUsuarioProyecto_A");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuarioProyecto", DbType.Int32, eGUsuarioProyecto.CodigoUsuarioProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuario", DbType.StringFixedLength, eGUsuarioProyecto.CodigoUsuario);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.StringFixedLength, eGUsuarioProyecto.CodigoProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoRol", DbType.StringFixedLength, eGUsuarioProyecto.CodigoRol);
            bdSWADNETGAAP.AddInParameter(comandoBD, "EstadoUsuarioProyecto", DbType.StringFixedLength, eGUsuarioProyecto.EstadoUsuarioProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
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
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GUsuarioProyecto_E");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoUsuarioProyecto", DbType.Int32, codigoUsuarioProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_INACTIVO);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}