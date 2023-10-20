using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SSesion
/// </summary>
public static class SSesion
{
    #region Variables de transpaso de datos
    public static string CodigoUsuario = string.Empty;
    public static int CodigoCelular = int.MinValue;
    public static string CodigoProyecto = string.Empty;
    #endregion

    #region Varables de sesión
    public static string NombreCompleto = string.Empty;
    public static string Usuario = string.Empty;
    public static string Clave = string.Empty;
    public static List<string> Roles = new List<string>();
    public static string RolNetValle = string.Empty;
    #endregion
}