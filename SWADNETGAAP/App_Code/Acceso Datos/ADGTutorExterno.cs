using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

/// <summary>
/// Summary description for ADGTutorExterno
/// </summary>
public class ADGTutorExterno
{
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
			bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
			bdSWADNETGAAP.AddInParameter(comandoBD, "FechaRegistro", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_REGISTRO);
			bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
			bdSWADNETGAAP.ExecuteNonQuery(comandoBD);

		}
		catch ( Exception ex)
		{

			throw ex;
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
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
			bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGTutorExterno, "GTutorExterno");


        }
        catch (Exception ex)
		{
            throw ex;
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
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGTutorExterno, "GTutorExterno");
        }
        catch (Exception ex)
		{
            throw ex;
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
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (Exception ex)
		{
            throw ex;
		}

	}

	public void Eliminar_GTutorExterno_E(int codigoTutorExterno)
	{
		try
		{
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GTutorExterno_E");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoTutorExterno", DbType.Int32, codigoTutorExterno);
			bdSWADNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            bdSWADNETGAAP.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_INACTIVO);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (Exception ex)
		{
            throw ex;
        }
    }
  
    #endregion

}