using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Data.Common;

/// <summary>
/// Descripción breve de ADGProyecto
/// </summary>
public class ADGProyecto
{
    #region Métodos públicos
    public Object Obtener_GProyecto_O_CodigoProyecto(string codigoProyecto)
    {
        Object res = null;
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GProyecto_O_CodigoProyecto");
            bdNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.String, codigoProyecto);
            res = bdNETGAAP.ExecuteScalar(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
        return res;
    }
    public void Insertar_GProyecto_I(EGProyecto proyecto)
    {
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GProyecto_I");
            bdNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.String, proyecto.CodigoProyecto);
            bdNETGAAP.AddInParameter(comandoBD, "ModalidadProyecto", DbType.StringFixedLength, proyecto.ModalidadProyecto);
            bdNETGAAP.AddInParameter(comandoBD, "TituloProyecto", DbType.String, proyecto.TituloProyecto);
            bdNETGAAP.AddInParameter(comandoBD, "ObjetivoGeneralProyecto", DbType.String, proyecto.ObjetivoGeneralProyecto);
            bdNETGAAP.AddInParameter(comandoBD, "ObjetivosEspecificosProyecto", DbType.String, proyecto.ObjetivosEspecificosProyecto);
            bdNETGAAP.AddInParameter(comandoBD, "AlcanceProyecto", DbType.String, proyecto.AlcanceProyecto);
            bdNETGAAP.AddInParameter(comandoBD, "EnlaceDocumentoProyecto", DbType.String, proyecto.EnlaceDocumentoProyecto);
            bdNETGAAP.AddInParameter(comandoBD, "EstadoProyecto", DbType.StringFixedLength, proyecto.EstadoProyecto);
            bdNETGAAP.AddInParameter(comandoBD, "NumeroRevisiones", DbType.Int32, proyecto.NumeroRevisiones);
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
    public DTOGProyecto Obtener_GProyecto_O_Todo()
    {
        DTOGProyecto dtoGProyecto = new DTOGProyecto();
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GProyecto_O_Todo");
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGAAP.LoadDataSet(dbCommand, dtoGProyecto, "GProyecto");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dtoGProyecto;
    }
    public DTOGProyecto Obtener_GProyecto_O(string codigoProyecto)
    {
        DTOGProyecto dtoGProyecto = new DTOGProyecto();
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GProyecto_O");
            bdNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.StringFixedLength, codigoProyecto);
            bdNETGAAP.LoadDataSet(comandoBD, dtoGProyecto, "GProyecto");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoGProyecto;
    }
    public void Actualizar_GProyecto_A(EGProyecto proyecto)
    {
        try
        {
            Database bdNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GProyecto_A");
            bdNETGAAP.AddInParameter(comandoBD, "CodigoProyecto", DbType.StringFixedLength, proyecto.CodigoProyecto);
            bdNETGAAP.AddInParameter(comandoBD, "ModalidadProyecto", DbType.StringFixedLength, proyecto.ModalidadProyecto);
            bdNETGAAP.AddInParameter(comandoBD, "TituloProyecto", DbType.String, proyecto.TituloProyecto);
            bdNETGAAP.AddInParameter(comandoBD, "ObjetivoGeneralProyecto", DbType.String, proyecto.ObjetivoGeneralProyecto);
            bdNETGAAP.AddInParameter(comandoBD, "ObjetivosEspecificosProyecto", DbType.String, proyecto.ObjetivosEspecificosProyecto);
            bdNETGAAP.AddInParameter(comandoBD, "AlcanceProyecto", DbType.String, proyecto.AlcanceProyecto);
            bdNETGAAP.AddInParameter(comandoBD, "EnlaceDocumentoProyecto", DbType.String, proyecto.EnlaceDocumentoProyecto);
            bdNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            bdNETGAAP.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion    
}