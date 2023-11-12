using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.SessionState;
using SWLNGAAP;

/// <summary>
/// Descripción breve de SUtil
/// </summary>
public static class SUtil
{
    #region Metodos publicos
    public static string ObtenerNombreCompleto(EEmpleado eEmpleado)
    {
        if (eEmpleado != null)
        {
            List<string> datos = new List<string> {
                    eEmpleado.PrimerNombre.ToLower(),
                    eEmpleado.SegundoNombre.ToLower(),
                    eEmpleado.PrimerApellido.ToLower(),
                    eEmpleado.SegundoApellido.ToLower(),
                };
            List<string> datosNombre = new List<string>();
            foreach (string palabras in datos)
            {
                foreach (string palabra in palabras.Split(' '))
                {
                    if (palabra.Length > 1)
                    {
                        datosNombre.Add(palabra[0].ToString().ToUpper() + palabra.Substring(1));
                    }
                    else
                    {
                        datosNombre.Add(palabra.ToUpper());
                    }
                }
            }

            return string.Join(" ", datosNombre.FindAll(c => !string.IsNullOrEmpty(c)));
        }
        else
        {
            throw new ArgumentNullException();
        }
    }

    public static string ObtenerNombrePorCodigo(string codigoUsuario)
    {
        CUsuario cUsuario = new CUsuario();        
        return cUsuario.Obtener_GUsuario_O_CodigoUsuario(codigoUsuario).NombreCompletoUsuario;
    }
    public static string ObtenerNombreRolPorCodigo(string codigoRol)
    {
        CRol cRol = new CRol();        
        return cRol.Obtener_GRol_O_CodigoRol(codigoRol).DescripcionRol;
    }
    public static object ListarUsuariosRolesPorProyecto(string codigoProyecto)
    {
        CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
        var lstEGUsuarioProyecto = cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto).ToList();
        return lstEGUsuarioProyecto.Select(s => new
        {
            s.CodigoUsuario,
            CodigoRol = ObtenerNombreRolPorCodigo(s.CodigoRol),
            Nombre = ObtenerNombrePorCodigo(s.CodigoUsuario)
        }).ToList();
    }
    public static bool ValidarSoloTextoYEspacios(string cadena,int longitudMinima)
    {
        if (string.IsNullOrEmpty(cadena) || cadena.Length < longitudMinima)
        {
            return false;
        }
        return Regex.IsMatch(cadena,SDatosGlobales.REGEX_TEXTO_Y_ESPACIOS);
    }
    public static bool ValidarSoloNumeros(string cadena, int longitudMinima)
    {
        if (string.IsNullOrEmpty(cadena) || cadena.Length < longitudMinima)
        {
            return false;
        }
        return Regex.IsMatch(cadena, SDatosGlobales.REGEX_SOLO_NUMEROS);
    }
    #endregion

    #region Métodos de Sesión
    public static void BorrarSesiones(HttpSessionState Session)
    {
        Session["UsuarioSesion"] = null;
        Session.Remove("UsuarioSesion");
        Session["Verificar"] = null;
        Session.Remove("Verificar");
        Session["CAutenticar"] = null;
        Session.Remove("CAutenticar");
        Session["CSolicitud"] = null;
        Session.Remove("CSolicitud");
        Session["CListaSolicitud"] = null;
        Session.Remove("CListaSolicitud");
        Session["CArchivo"] = null;
        Session.Remove("CArchivo");
        Session["CInicio"] = null;
        Session.Remove("CInicio");
        Session["ErrorPerfil"] = null;
        Session.Remove("ErrorPerfil");
        Session["ArchivoSolicitud"] = null;
        Session.Remove("ArchivoSolicitud");
        Session["CArchivo"] = null;
        Session.Remove("CArchivo");

        Session.RemoveAll();
        Session.Clear();
    }
    #endregion
}