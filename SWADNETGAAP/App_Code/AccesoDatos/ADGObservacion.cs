using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Data.Common;

/// <summary>
/// Descripción breve de ADGObservacion
/// </summary>
public class ADGObservacion
{
    #region Métodos públicos
    public void Actualizar_GObservacion_A_EstadoObservacion(int codigoObservacion, char estadoObservacion)
    {
        Database bdNETGAAP = SBaseDatos.BDNETGAAP;
        DbCommand comandoBD = bdNETGAAP.GetStoredProcCommand("GObservacion_A_EstadoObservacion");
        bdNETGAAP.AddInParameter(comandoBD, "CodigoObservacion", DbType.Int32, codigoObservacion);
        bdNETGAAP.AddInParameter(comandoBD, "EstadoObservacion", DbType.StringFixedLength, estadoObservacion);
        bdNETGAAP.AddInParameter(comandoBD, "FechaModificacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
        bdNETGAAP.ExecuteNonQuery(comandoBD);
    }
    #endregion

}