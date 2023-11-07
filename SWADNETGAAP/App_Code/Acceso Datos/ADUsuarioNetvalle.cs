using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data.Common;
using System.Data;

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
            BDSWADNETUSR.AddInParameter(comandoBD, "CodigoUsuarioNetvalle", DbType.String, codigoUsuario.ToUpper());
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