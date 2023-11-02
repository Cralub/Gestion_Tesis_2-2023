﻿using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data.Common;
using System.Data;

/// <summary>
/// Descripción breve de ADGFormularioAceptacion
/// </summary>
public class ADGFormularioAceptacion
{
    #region Metodos públicos
    public void Insertar_GFormularioAceptacion_I(EGFormularioAceptacion eGFormularioAceptacion)
    {
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GFormularioAceptacion_I");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoFormularioAceptacion", DbType.Int32, eGFormularioAceptacion.CodigoFormularioAceptacion);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.StringFixedLength, eGFormularioAceptacion.CodigoProyecto);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoEstudiante", DbType.StringFixedLength, eGFormularioAceptacion.CodigoEstudiante);
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoTribunal", DbType.StringFixedLength, eGFormularioAceptacion.CodigoTribunal);
            bdSWADNETGAAP.AddInParameter(comandoBD, "PreguntaFormatoYForma1", DbType.StringFixedLength, eGFormularioAceptacion.PreguntaFormatoYForma1);
            bdSWADNETGAAP.AddInParameter(comandoBD, "PreguntaFormatoYForma2", DbType.StringFixedLength, eGFormularioAceptacion.PreguntaFormatoYForma2);
            bdSWADNETGAAP.AddInParameter(comandoBD, "PreguntaFormatoYForma3", DbType.StringFixedLength, eGFormularioAceptacion.PreguntaFormatoYForma3);
            bdSWADNETGAAP.AddInParameter(comandoBD, "PreguntaFormatoYForma4", DbType.StringFixedLength, eGFormularioAceptacion.PreguntaFormatoYForma4);
            bdSWADNETGAAP.AddInParameter(comandoBD, "PreguntaFormatoYForma5", DbType.StringFixedLength, eGFormularioAceptacion.PreguntaFormatoYForma5);
            bdSWADNETGAAP.AddInParameter(comandoBD, "PreguntaFormatoYForma6", DbType.StringFixedLength, eGFormularioAceptacion.PreguntaFormatoYForma6);
            bdSWADNETGAAP.AddInParameter(comandoBD, "PreguntaFormatoYForma7", DbType.StringFixedLength, eGFormularioAceptacion.PreguntaFormatoYForma7);
            bdSWADNETGAAP.AddInParameter(comandoBD, "PreguntaFormatoYForma8", DbType.StringFixedLength, eGFormularioAceptacion.PreguntaFormatoYForma8);
            bdSWADNETGAAP.AddInParameter(comandoBD, "PreguntaFormatoYForma9", DbType.StringFixedLength, eGFormularioAceptacion.PreguntaFormatoYForma9);
            bdSWADNETGAAP.AddInParameter(comandoBD, "PreguntaFormatoYForma10", DbType.StringFixedLength, eGFormularioAceptacion.PreguntaFormatoYForma10);
            bdSWADNETGAAP.AddInParameter(comandoBD, "PreguntaFondo1", DbType.StringFixedLength, eGFormularioAceptacion.PreguntaFondo1);
            bdSWADNETGAAP.AddInParameter(comandoBD, "PreguntaFondo2", DbType.StringFixedLength, eGFormularioAceptacion.PreguntaFondo2);
            bdSWADNETGAAP.AddInParameter(comandoBD, "PreguntaFondo3", DbType.StringFixedLength, eGFormularioAceptacion.PreguntaFondo3);
            bdSWADNETGAAP.AddInParameter(comandoBD, "PreguntaFondo4", DbType.StringFixedLength, eGFormularioAceptacion.PreguntaFondo4);
            bdSWADNETGAAP.AddInParameter(comandoBD, "PreguntaFondo5", DbType.StringFixedLength, eGFormularioAceptacion.PreguntaFondo5);
            bdSWADNETGAAP.AddInParameter(comandoBD, "PreguntaFondo6", DbType.StringFixedLength, eGFormularioAceptacion.PreguntaFondo6);
            bdSWADNETGAAP.AddInParameter(comandoBD, "PreguntaFondo7", DbType.StringFixedLength, eGFormularioAceptacion.PreguntaFondo7);
            bdSWADNETGAAP.AddInParameter(comandoBD, "PreguntaFondo8", DbType.StringFixedLength, eGFormularioAceptacion.PreguntaFondo8);
            bdSWADNETGAAP.AddInParameter(comandoBD, "PreguntaFondo9", DbType.StringFixedLength, eGFormularioAceptacion.PreguntaFondo9);
            bdSWADNETGAAP.AddInParameter(comandoBD, "PreguntaFondo10", DbType.StringFixedLength, eGFormularioAceptacion.PreguntaFondo10);
            bdSWADNETGAAP.AddInParameter(comandoBD, "FechaRegistro", DbType.DateTime, SDatosPA.AUDITORIA_FECHA_REGISTRO);
            bdSWADNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public object Obtener_GFormularioAceptacion_O_SiguienteCodigoFormularioAceptacion()
    {
        object ultimoCodigo;
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand(SDatosPA.PROC_OBTENER_ULTIMO_CODIGO);
            bdNETGAAP.AddInParameter(comandoBD, "NombreTabla", DbType.String, "GFormularioAceptacion");
            ultimoCodigo = bdNETGAAP.ExecuteScalar(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
        return ultimoCodigo;
    }
    public DTOGFormularioAceptacion Obtener_GFormularioAceptacion_O_CodigoProyecto(string codigoProyecto)
    {
        DTOGFormularioAceptacion dTOGFormularioAceptacion = new DTOGFormularioAceptacion();
        try
        {
            Database bdSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdSWADNETGAAP.GetStoredProcCommand("GFormularioAceptacion_O_CodigoProyecto");
            bdSWADNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.String, codigoProyecto);
            bdSWADNETGAAP.LoadDataSet(comandoBD, dTOGFormularioAceptacion, "GFormularioAceptacion");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGFormularioAceptacion;
        #endregion
    }
}