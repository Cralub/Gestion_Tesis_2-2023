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
    public DTOGUsuarioNetvalle Obtener_UsuarioNetvalle_O_CodigoUsuario(string CodigoUsuario)
    {
        DTOGUsuarioNetvalle dTOGUsuarioNetvalle = new DTOGUsuarioNetvalle();
        try
        {
            Database BDSWADNETUSR = SBaseDatos.DBSWADNETUSR;
            DbCommand dbCommand = BDSWADNETUSR.GetStoredProcCommand("UsuarioNetvalle_O_CodigoUsuario");
            BDSWADNETUSR.AddInParameter(dbCommand, "CodigoUsuarioNetvalle", DbType.String, CodigoUsuario);
            BDSWADNETUSR.AddInParameter(dbCommand, "EstadoUsuarioNetvalle", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            BDSWADNETUSR.LoadDataSet(dbCommand, dTOGUsuarioNetvalle, "UsuarioNetvalle");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOGUsuarioNetvalle;
    }
    #endregion
}