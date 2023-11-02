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
    public void Insertar_GTutorExterno_I(EGTutorExterno tutorExterno)
    {
		try
		{
			Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
			DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GTutorExterno_I");
			BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoTutorExterno", DbType.Int32, tutorExterno.CodigoTutorExterno);
			BDSWADNETGAAP.AddInParameter(dbCommand, "NombresTutorExterno", DbType.String, tutorExterno.NombresTutorExterno);
			BDSWADNETGAAP.AddInParameter(dbCommand, "ApellidosTutorExterno", DbType.String, tutorExterno.ApellidosTutorExterno);
			BDSWADNETGAAP.AddInParameter(dbCommand, "CarreraTutorExterno", DbType.String, tutorExterno.CarreraTutorExterno);
			BDSWADNETGAAP.AddInParameter(dbCommand, "DireccionTrabajoTutorExterno", DbType.String, tutorExterno.DireccionTrabajoTutorExterno);
			BDSWADNETGAAP.AddInParameter(dbCommand, "DescripcionTutorExterno", DbType.String, tutorExterno.DescripcionTutorExterno);
			BDSWADNETGAAP.AddInParameter(dbCommand, "SedeTutorExterno", DbType.String, tutorExterno.SedeTutorExterno);
			BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
			BDSWADNETGAAP.AddInParameter(dbCommand, "FechaRegistro", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_REGISTRO);
			BDSWADNETGAAP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
			BDSWADNETGAAP.ExecuteNonQuery(dbCommand);

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
			Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
			DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GTutorExterno_O_CodigoTutorExterno");
			BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoTutorExterno", DbType.Int32, codigoTutorExterno);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
			BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGTutorExterno, "GTutorExterno");


        }
        catch (Exception ex)
		{
            throw ex;
		}

		return dTOGTutorExterno;
	}

	public DTOGTutorExterno Obtener_GTutorExterno_O_Todo()
	{
		
		DTOGTutorExterno dTOGTutorExterno = new DTOGTutorExterno();
        try
		{
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GTutorExterno_O_Todo");
            BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGTutorExterno, "GTutorExterno");
        }
        catch (Exception ex)
		{
            throw ex;
        }
        return dTOGTutorExterno;
	}

	public void Actualizar_GTutorExterno_A(EGTutorExterno tutorExterno)
	{
		try
		{
			Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GTutorExterno_A");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoTutorExterno", DbType.Int32, tutorExterno.CodigoTutorExterno);
            BDSWADNETGAAP.AddInParameter(dbCommand, "NombresTutorExterno", DbType.String, tutorExterno.NombresTutorExterno);
            BDSWADNETGAAP.AddInParameter(dbCommand, "ApellidosTutorExterno", DbType.String, tutorExterno.ApellidosTutorExterno);
            BDSWADNETGAAP.AddInParameter(dbCommand, "CarreraTutorExterno", DbType.String, tutorExterno.CarreraTutorExterno);
            BDSWADNETGAAP.AddInParameter(dbCommand, "DireccionTrabajoTutorExterno", DbType.String, tutorExterno.DireccionTrabajoTutorExterno);
            BDSWADNETGAAP.AddInParameter(dbCommand, "DescripcionTutorExterno", DbType.String, tutorExterno.DescripcionTutorExterno);
            BDSWADNETGAAP.AddInParameter(dbCommand, "SedeTutorExterno", DbType.String, tutorExterno.SedeTutorExterno);
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            BDSWADNETGAAP.ExecuteNonQuery(dbCommand);
        }
        catch (Exception ex)
		{
            throw ex;
		}

	}

	public void Actualizar_GTutorExterno_A_Estado(int codigoTutorExterno, string estado)
	{
		try
		{
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GTutorExterno_A_Estado");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoTutorExterno", DbType.Int32, codigoTutorExterno);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, estado);
			BDSWADNETGAAP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_MODIFICACION);
            BDSWADNETGAAP.ExecuteNonQuery(dbCommand);
        }
        catch (Exception ex)
		{
            throw ex;
        }
    }
  
    #endregion

}