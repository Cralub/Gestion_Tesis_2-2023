using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Data.Common;

/// <summary>
/// Descripción breve de ADGUsuarioRol
/// </summary>
public class ADGUsuarioRol
{
    #region Metodos publicos
    //public void Insertar_GUsuarioRol_I(EGUsuarioRol eGUsuarioRol)
    //{
    //    try
    //    {
    //        Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
    //        DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GUsuarioRol_I");
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuarioRol", DbType.Int32, eGUsuarioRol.CodigoUsuarioRol);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuario", DbType.StringFixedLength, eGUsuarioRol.CodigoUsuario);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoRol", DbType.StringFixedLength, eGUsuarioRol.CodigoRol);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "FechaRegistro", DbType.DateTime, SDatosPA.Auditoria_FechaRegistro);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
    //        BDSWADNETGAAP.ExecuteNonQuery(dbCommand);
    //    }
    //    catch (Exception ex)
    //    {
    //        throw ex;
    //    }
    //}
    //public DTOGUsuarioRol Obtener_GUsuarioRol_O_CodigoRol(string CodigoRol)
    //{
    //    DTOGUsuarioRol dTOGUsuarioRol = new DTOGUsuarioRol();
    //    try
    //    {
    //        Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
    //        DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GUsuarioRol_O_CodigoRol");
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoRol", DbType.StringFixedLength, CodigoRol);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
    //        BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGUsuarioRol, "GUsuarioRol");
    //    }
    //    catch (Exception)
    //    {

    //        throw;
    //    }
    //    return dTOGUsuarioRol;
    //}
    //public DTOGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario(string CodigoUsuario)
    //{
    //    DTOGUsuarioRol dTOGUsuarioRol = new DTOGUsuarioRol();
    //    try
    //    {
    //        Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
    //        DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GUsuarioRol_O_CodigoUsuario");
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuario", DbType.StringFixedLength, CodigoUsuario);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
    //        BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGUsuarioRol, "GUsuarioRol");
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //    return dTOGUsuarioRol;
    //}
    //public DTOGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string CodigoUsuario, string CodigoRol)
    //{
    //    DTOGUsuarioRol dTOGUsuarioRol = new DTOGUsuarioRol();
    //    try
    //    {
    //        Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
    //        DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GUsuarioRol_O_CodigoUsuario_CodigoRol");
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuario", DbType.StringFixedLength, CodigoUsuario);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoRol", DbType.StringFixedLength, CodigoRol);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
    //        BDSWADNETGAAP.LoadDataSet(dbCommand, dTOGUsuarioRol, "GUsuarioRol");
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //    return dTOGUsuarioRol;
    //}
    //public Object Obtener_GUsuarioRol_O_UltimoCodigoUsuarioRol()
    //{
    //    Object res = null;
    //    try
    //    {
    //        Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
    //        DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GUsuarioRol_O_UltimoCodigoUsuarioRol");
    //        res = BDSWADNETGAAP.ExecuteScalar(dbCommand);
    //    }
    //    catch (Exception ex)
    //    {
    //        throw ex;
    //    }
    //    return res;
    //}
    //public DTOGUsuarioRol Actualizar_GUsuarioRol_A(EGUsuarioRol eGUsuarioRol)
    //{
    //    DTOGUsuarioRol dtoGUsuarioRol = new DTOGUsuarioRol();
    //    try
    //    {
    //        Database BDSWADNETGAAP = SBaseDatos.BDSWADNETGAAP;
    //        DbCommand dbCommand = BDSWADNETGAAP.GetStoredProcCommand("GUsuarioRol_A");
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuarioRol", DbType.Int32, eGUsuarioRol.CodigoUsuarioRol);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoRol", DbType.StringFixedLength, eGUsuarioRol.CodigoRol);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "CodigoUsuario", DbType.StringFixedLength, eGUsuarioRol.CodigoUsuario);
    //        BDSWADNETGAAP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
    //        BDSWADNETGAAP.LoadDataSet(dbCommand, dtoGUsuarioRol, "GUsuarioRol");
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //    return dtoGUsuarioRol;
    //}
    #endregion

}