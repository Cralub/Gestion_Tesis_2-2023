using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Summary description for ADGTutorExterno
/// </summary>
public class ADGTutorExterno
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
        eDefectoAD.Clase = "ADGTutorExterno";
        eDefectoAD.Metodo = metodo;
        eDefectoAD.Excepcion = excepcion;
        eDefectoAD.Mensaje = mensaje;
        return eDefectoAD;
    }
    #endregion
    #region Metodos públicos
    public void Insertar_GTutorExterno_I(EGTutorExterno eGTutorExterno)
    {
		try
		{
			Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
			DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GTutorExterno_I");
			bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoTutorExterno", DbType.Int32, eGTutorExterno.CodigoTutorExterno);
			bdSWADNETGAAP.AddInParameter(comandoBD, "NombresTutorExterno", DbType.String, eGTutorExterno.NombresTutorExterno);
			bdSWADNETGAAP.AddInParameter(comandoBD, "ApellidosTutorExterno", DbType.String, eGTutorExterno.ApellidosTutorExterno);
			bdSWADNETGAAP.AddInParameter(comandoBD, "CarreraTutorExterno", DbType.String, eGTutorExterno.CarreraTutorExterno);
			bdSWADNETGAAP.AddInParameter(comandoBD, "DireccionTrabajoTutorExterno", DbType.String, eGTutorExterno.DireccionTrabajoTutorExterno);
			bdSWADNETGAAP.AddInParameter(comandoBD, "DescripcionTutorExterno", DbType.String, eGTutorExterno.DescripcionTutorExterno);
			bdSWADNETGAAP.AddInParameter(comandoBD, "SedeTutorExterno", DbType.String, eGTutorExterno.SedeTutorExterno);
			bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.ESTADO_ACTIVO_AUDITORIA);
			bdSWADNETGAAP.AddInParameter(comandoBD, "FechaRegistro", DbType.DateTime, SDatosPA.FECHA_REGISTRO_AUDITORIA);
			bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.FECHA_MODIFICACION_AUDITORIA);
			bdSWADNETGAAP.ExecuteNonQuery(comandoBD);

		}
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Insertar_GTutorExterno_I", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
    }

	public DTOGTutorExterno Obtener_GTutorExterno_O_CodigoTutorExterno(int codigoTutorExterno)
	{
		DTOGTutorExterno dTOGTutorExterno = new DTOGTutorExterno();
		try
		{
			Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
			DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GTutorExterno_O_CodigoTutorExterno");
			bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoTutorExterno", DbType.Int32, codigoTutorExterno);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.ESTADO_ACTIVO_AUDITORIA);
			bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGTutorExterno, "GTutorExterno");


        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_GTutorExterno_O_CodigoTutorExterno", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dTOGTutorExterno;
	}

	public DTOGTutorExterno Obtener_GTutorExterno_O()
	{
		
		DTOGTutorExterno dTOGTutorExterno = new DTOGTutorExterno();
        try
		{
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GTutorExterno_O");
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.ESTADO_ACTIVO_AUDITORIA);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGTutorExterno, "GTutorExterno");
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_GTutorExterno_O", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dTOGTutorExterno;
	}

	public void Actualizar_GTutorExterno_A(EGTutorExterno eGTutorExterno)
	{
		try
		{
			Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GTutorExterno_A");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoTutorExterno", DbType.Int32, eGTutorExterno.CodigoTutorExterno);
            bdSWADNETGAAP.AddInParameter(comandoBD, "NombresTutorExterno", DbType.String, eGTutorExterno.NombresTutorExterno);
            bdSWADNETGAAP.AddInParameter(comandoBD, "ApellidosTutorExterno", DbType.String, eGTutorExterno.ApellidosTutorExterno);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CarreraTutorExterno", DbType.String, eGTutorExterno.CarreraTutorExterno);
            bdSWADNETGAAP.AddInParameter(comandoBD, "DireccionTrabajoTutorExterno", DbType.String, eGTutorExterno.DireccionTrabajoTutorExterno);
            bdSWADNETGAAP.AddInParameter(comandoBD, "DescripcionTutorExterno", DbType.String, eGTutorExterno.DescripcionTutorExterno);
            bdSWADNETGAAP.AddInParameter(comandoBD, "SedeTutorExterno", DbType.String, eGTutorExterno.SedeTutorExterno);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.FECHA_MODIFICACION_AUDITORIA);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Actualizar_GTutorExterno_A", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
    }

	public void Eliminar_GTutorExterno_E(int codigoTutorExterno)
	{
		try
		{
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GTutorExterno_E");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoTutorExterno", DbType.Int32, codigoTutorExterno);
			bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.FECHA_MODIFICACION_AUDITORIA);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.ESTADO_INACTIVO_AUDITORIA);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Eliminar_GTutorExterno_E", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
    }
  
    #endregion

}