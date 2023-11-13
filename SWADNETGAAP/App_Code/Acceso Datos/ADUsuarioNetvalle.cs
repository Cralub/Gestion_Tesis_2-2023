using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel;

/// <summary>
/// Descripción breve de ADGUsuarioNetvalle
/// </summary>
public class ADUsuarioNetvalle
{
    #region Metodos Privados
    /// <summary>
    /// Contruir el Error del servicio > metodo
    /// </summary>
    /// <param name="tipoError"></param>
    /// <param name="metodo"></param>
    /// <param name="excepcion"></param>
    /// <param name="mensaje"></param>
    /// <returns></returns>
    private EDefectoAD ConstruirErrorServicio(TTipoError tipoError, string metodo, string excepcion, string mensaje)
    {
        EDefectoAD eDefectoAD = new EDefectoAD();
        eDefectoAD.TipoError = tipoError;
        eDefectoAD.Servicio = "SWADNETGAAP";
        eDefectoAD.Clase = "ADUsuarioNetvalle";
        eDefectoAD.Metodo = metodo;
        eDefectoAD.Excepcion = excepcion;
        eDefectoAD.Mensaje = mensaje;
        return eDefectoAD;
    }
    #endregion
    #region Metodos públicos
    public DTOGUsuarioNetvalle Obtener_UsuarioNetvalle_O_CodigoUsuario(string codigoUsuario)
    {
        DTOGUsuarioNetvalle dTOGUsuarioNetvalle = new DTOGUsuarioNetvalle();
        try
        {
            Database BDSWADNETUSR = SBaseDatos.BDSWADNETGAAP;
            DbCommand comandoBD = BDSWADNETUSR.GetStoredProcCommand("UsuarioNetvalle_O_CodigoUsuario");
            BDSWADNETUSR.AddInParameter(comandoBD, "CodigoUsuarioNetvalle", DbType.String, codigoUsuario.ToUpper());
            BDSWADNETUSR.AddInParameter(comandoBD, "EstadoUsuarioNetvalle", DbType.StringFixedLength, SDatosPA.ESTADO_ACTIVO_AUDITORIA);
            BDSWADNETUSR.LoadDataSet(comandoBD, dTOGUsuarioNetvalle, "UsuarioNetvalle");
        }
        catch (SqlException SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_UsuarioNetvalle_O_CodigoUsuario", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dTOGUsuarioNetvalle;
    }
    #endregion
}