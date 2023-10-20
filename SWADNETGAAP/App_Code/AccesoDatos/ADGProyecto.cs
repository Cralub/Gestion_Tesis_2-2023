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
    public DTOGProyecto Obtener_GProyecto_O(string codigoProyecto)
    {
        DTOGProyecto dtoGProyecto = new DTOGProyecto();
        try
        {
            Database bdNETGAAP = SBaseDatos.BDNETGAAP;
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
            Database bdNETGAAP = SBaseDatos.BDNETGAAP;
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