using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.ServiceModel;

/// <summary>
/// Descripción breve de ADGUsuarioProyecto
/// </summary>
public class ADGUsuarioProyecto
{
    #region Metodos Privados
    /// <summary>
    /// Contruir el Error del servicio > metodo
    /// </summary>
    /// <param name="tipoError"></param>
    /// <param name="metodo"></param>
    /// <param name="excepcion"></param>
    /// <param name="mensaje"></param>
    /// <returns></returns>
    private EDefectoAD ConstruirErrorServicio(TTipoError tipoError, string metodo, string excepcion, string mensaje)
    {
        EDefectoAD eDefectoAD = new EDefectoAD();
        eDefectoAD.TipoError = tipoError;
        eDefectoAD.Servicio = "SWADNETGAAP";
        eDefectoAD.Clase = "ADGUsuarioProyecto";
        eDefectoAD.Metodo = metodo;
        eDefectoAD.Excepcion = excepcion;
        eDefectoAD.Mensaje = mensaje;
        return eDefectoAD;
    }
    #endregion
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
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Insertar_GUsuarioProyecto_I", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
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
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
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
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_GUsuarioProyecto_O_CodigoProyecto", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
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
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_GUsuarioProyecto_O_CodigoUsuario", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
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
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
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
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Actualizar_GUsuarioProyecto_A", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
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
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Eliminar_UsuarioProyecto_E", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
    }
    #endregion
}