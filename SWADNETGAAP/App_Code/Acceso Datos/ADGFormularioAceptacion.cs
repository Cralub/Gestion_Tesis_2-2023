using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Web;
using Azure;

/// <summary>
/// Descripción breve de ADGFormularioAceptacion
/// </summary>
public class ADGFormularioAceptacion
{
    #region Metodos públicos
    public void Insertar_GFormularioAceptacion_I(EGFormularioAceptacion formularioAceptacion)
    {
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GFormularioAceptacion_I");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoFormularioAceptacion", DbType.Int32, formularioAceptacion.CodigoFormularioAceptacion);
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, formularioAceptacion.CodigoProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoEstudiante", DbType.StringFixedLength, formularioAceptacion.CodigoEstudiante);
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoTribunal", DbType.StringFixedLength, formularioAceptacion.CodigoTribunal);
            BDSWADNETGAAP.AddInParameter(dbCommand, "PreguntaFormatoYForma1", DbType.StringFixedLength, formularioAceptacion.PreguntaFormatoYForma1);
            BDSWADNETGAAP.AddInParameter(dbCommand, "PreguntaFormatoYForma2", DbType.StringFixedLength, formularioAceptacion.PreguntaFormatoYForma2);
            BDSWADNETGAAP.AddInParameter(dbCommand, "PreguntaFormatoYForma3", DbType.StringFixedLength, formularioAceptacion.PreguntaFormatoYForma3);
            BDSWADNETGAAP.AddInParameter(dbCommand, "PreguntaFormatoYForma4", DbType.StringFixedLength, formularioAceptacion.PreguntaFormatoYForma4);
            BDSWADNETGAAP.AddInParameter(dbCommand, "PreguntaFormatoYForma5", DbType.StringFixedLength, formularioAceptacion.PreguntaFormatoYForma5);
            BDSWADNETGAAP.AddInParameter(dbCommand, "PreguntaFormatoYForma6", DbType.StringFixedLength, formularioAceptacion.PreguntaFormatoYForma6);
            BDSWADNETGAAP.AddInParameter(dbCommand, "PreguntaFormatoYForma7", DbType.StringFixedLength, formularioAceptacion.PreguntaFormatoYForma7);
            BDSWADNETGAAP.AddInParameter(dbCommand, "PreguntaFormatoYForma8", DbType.StringFixedLength, formularioAceptacion.PreguntaFormatoYForma8);
            BDSWADNETGAAP.AddInParameter(dbCommand, "PreguntaFormatoYForma9", DbType.StringFixedLength, formularioAceptacion.PreguntaFormatoYForma9);
            BDSWADNETGAAP.AddInParameter(dbCommand, "PreguntaFormatoYForma10", DbType.StringFixedLength, formularioAceptacion.PreguntaFormatoYForma10);
            BDSWADNETGAAP.AddInParameter(dbCommand, "PreguntaFondo1", DbType.StringFixedLength, formularioAceptacion.PreguntaFondo1);
            BDSWADNETGAAP.AddInParameter(dbCommand, "PreguntaFondo2", DbType.StringFixedLength, formularioAceptacion.PreguntaFondo2);
            BDSWADNETGAAP.AddInParameter(dbCommand, "PreguntaFondo3", DbType.StringFixedLength, formularioAceptacion.PreguntaFondo3);
            BDSWADNETGAAP.AddInParameter(dbCommand, "PreguntaFondo4", DbType.StringFixedLength, formularioAceptacion.PreguntaFondo4);
            BDSWADNETGAAP.AddInParameter(dbCommand, "PreguntaFondo5", DbType.StringFixedLength, formularioAceptacion.PreguntaFondo5);
            BDSWADNETGAAP.AddInParameter(dbCommand, "PreguntaFondo6", DbType.StringFixedLength, formularioAceptacion.PreguntaFondo6);
            BDSWADNETGAAP.AddInParameter(dbCommand, "PreguntaFondo7", DbType.StringFixedLength, formularioAceptacion.PreguntaFondo7);
            BDSWADNETGAAP.AddInParameter(dbCommand, "PreguntaFondo8", DbType.StringFixedLength, formularioAceptacion.PreguntaFondo8);
            BDSWADNETGAAP.AddInParameter(dbCommand, "PreguntaFondo9", DbType.StringFixedLength, formularioAceptacion.PreguntaFondo9);
            BDSWADNETGAAP.AddInParameter(dbCommand, "PreguntaFondo10", DbType.StringFixedLength, formularioAceptacion.PreguntaFondo10);
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaRegistro", DbType.DateTime, SDatosPA.Auditoria_FechaRegistro);
            BDSWADNETGAAP.ExecuteNonQuery(dbCommand);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public Object Obtener_GFormularioAceptacion_O_UltimoCodigoFormularioAceptacion()
    {
        Object res = null;
        try
        {
            Database database = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = database.GetStoredProcCommand("GFormularioAceptacion_O_UltimoCodigoFormularioAceptacion");
            res = database.ExecuteScalar(dbCommand);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return res;
    }
    public DTOGFormularioAceptacion Obtener_GFormularioAceptacion_O_CodigoProyecto(string CodigoProyect)
    {
        DTOGFormularioAceptacion dTOGFormularioAceptacion = new DTOGFormularioAceptacion();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GFormularioAceptacion_O_CodigoProyecto");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoProyecto", DbType.String, CodigoProyect);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGFormularioAceptacion, "GFormularioAceptacion");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGFormularioAceptacion;
        #endregion
    }
}