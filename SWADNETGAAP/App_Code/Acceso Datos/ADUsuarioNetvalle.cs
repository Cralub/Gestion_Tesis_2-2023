using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADGUsuarioNetvalle
/// </summary>
public class ADUsuarioNetvalle
{
    #region Metodos públicos
    public DTOGUsuarioNetvalle Obtener_UsuarioNetvalle_O_CodigoUsuario(string codigoUsuario)
    {
        DTOGUsuarioNetvalle dTOGUsuarioNetvalle = new DTOGUsuarioNetvalle();
        try
        {
            Database BDSWADNETUSR = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = BDSWADNETUSR.GetStoredProcCommand("UsuarioNetvalle_O_CodigoUsuario");
            BDSWADNETUSR.AddInParameter(comandoBD, "CodigoUsuarioNetvalle", DbType.String, codigoUsuario);
            BDSWADNETUSR.AddInParameter(comandoBD, "EstadoUsuarioNetvalle", DbType.StringFixedLength, SDatosPA.AUDITORIA_ACTIVO);
            BDSWADNETUSR.LoadDataSet(comandoBD, dTOGUsuarioNetvalle, "UsuarioNetvalle");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGUsuarioNetvalle;
    }
    #endregion
}