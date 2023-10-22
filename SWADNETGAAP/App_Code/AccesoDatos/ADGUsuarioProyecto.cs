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
    public Object Obtener_GUsuarioProyecto_O_UltimoCodigoUsuarioProyecto()
    {
        Object res = null;
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GUsuarioProyecto_O_UltimoCodigoUsuarioProyecto");
            res = bdNETGAAP.ExecuteScalar(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
        return res;
    }
    public void Insertar_GUsuarioProyecto_I(EGUsuarioProyecto usuarioProyecto)
    {
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GUsuarioProyecto_I");
            bdNETGAAP.AddInParameter(comandoBD, "CodigoUsuarioProyecto", DbType.Int32, usuarioProyecto.CodigoUsuarioProyecto);
            bdNETGAAP.AddInParameter(comandoBD, "CodigoUsuario", DbType.StringFixedLength, usuarioProyecto.CodigoUsuario);
            bdNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.StringFixedLength, usuarioProyecto.CodigoProyecto);
            bdNETGAAP.AddInParameter(comandoBD, "CodigoRol", DbType.StringFixedLength, usuarioProyecto.CodigoRol);
            bdNETGAAP.AddInParameter(comandoBD, "EstadoUsuarioProyecto", DbType.StringFixedLength, SDatosPA.Activo);
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
    public void Actualizar_GUsuarioProyecto_A(EGUsuarioProyecto usuarioProyecto)
    {
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GUsuarioProyecto_A");
            bdNETGAAP.AddInParameter(comandoBD, "CodigoUsuarioProyecto", DbType.Int32, usuarioProyecto.CodigoUsuarioProyecto);
            bdNETGAAP.AddInParameter(comandoBD, "CodigoUsuario", DbType.StringFixedLength, usuarioProyecto.CodigoUsuario);
            bdNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.StringFixedLength, usuarioProyecto.CodigoProyecto);
            bdNETGAAP.AddInParameter(comandoBD, "CodigoRol", DbType.StringFixedLength, usuarioProyecto.CodigoRol);
            bdNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            bdNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {

            throw;
        }
    }
    public DTOGUsuarioProyecto Obtener_GUsuarioProyecto_O_CodigoProyecto(string CodigoProyecto)
    {
        DTOGUsuarioProyecto DTOGUsuarioProyecto = new DTOGUsuarioProyecto();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GUsuarioProyecto_O_CodigoProyecto");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, CodigoProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
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
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
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
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGUsuarioProyecto, "GUsuarioProyecto");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGUsuarioProyecto;
    }
    #endregion
}