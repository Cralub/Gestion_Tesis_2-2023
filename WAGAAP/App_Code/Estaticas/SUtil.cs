using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI.WebControls;
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