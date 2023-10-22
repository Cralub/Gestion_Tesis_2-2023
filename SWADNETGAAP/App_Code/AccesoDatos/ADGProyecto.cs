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
    public void Insertar_GProyecto_I(EGProyecto eGProyecto)
    {
        try
        {
            Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
            DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GProyecto_I");
            BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoProyecto", DbType.StringFixedLength, eGProyecto.CodigoProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "ModalidadProyecto", DbType.StringFixedLength, eGProyecto.ModalidadProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "TituloProyecto", DbType.String, eGProyecto.TituloProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "ObjetivoGeneralProyecto", DbType.String, eGProyecto.ObjetivoGeneralProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "EnlaceDocumentoProyecto", DbType.String, eGProyecto.EnlaceDocumentoProyecto);
            BDSWADNETGAAP.AddInParameter(dbCommand, "EstadoProyecto", DbType.StringFixedLength, SDatosPA.Activo);
            BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaRegistro", DbType.DateTime, SDatosPA.Auditoria_FechaRegistro);
            BDSWADNETGAAP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            BDSWADNETGAAP.ExecuteNonQuery(dbCommand);
        }
        catch (Exception ex)
        {
            throw ex;
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