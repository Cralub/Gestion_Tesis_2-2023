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
    public static bool CorrespondeRevision(string codigoProyecto, string codigoUsuario)
    {
        CEtapa cEtapa = new CEtapa();
        CSubEtapa cSubEtapa = new CSubEtapa();
        CProyectoCompleja cProyectoCompleja = new CProyectoCompleja();
        CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
        
        EGEtapa eGEtapa = cEtapa.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto, SDatosGlobales.ESTADO_ACTIVO);
        EGSubEtapa eGSubEtapa = cSubEtapa.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(eGEtapa.CodigoEtapa, SDatosGlobales.ESTADO_ACTIVO);
        EGUsuarioProyecto eGUsuarioProyecto = cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(codigoUsuario, codigoProyecto);
        return cProyectoCompleja.Verificar_GProyecto_CorrespondeRevision(eGUsuarioProyecto.CodigoRol, eGSubEtapa);
    }
    public static string ObtenerNombreModalidad(char charModalidad)
    {
        if (charModalidad == SDatosGlobales.CHAR_MODALIDAD_PROYECTO_DE_GRADO)
            return SDatosGlobales.STRING_MODALIDAD_PROYECTO_DE_GRADO;
        if (charModalidad == SDatosGlobales.CHAR_MODALIDAD_TESIS)
            return SDatosGlobales.STRING_MODALIDAD_TESIS;
        if (charModalidad == SDatosGlobales.CHAR_MODALIDAD_TRABAJO_DIRIGIDO)
            return SDatosGlobales.STRING_MODALIDAD_TRABAJO_DIRIGIDO;
        return string.Empty;
    }
    public static string ObtenerNombreEstado(char estado)
    {
        
        switch (estado)
        {
            case SDatosGlobales.ESTADO_ACTIVO:return "Activo";               
            case SDatosGlobales.ESTADO_PAUSADO:return "Pausado";
            case SDatosGlobales.ESTADO_RECHAZADO:return "Rechazado";
            case SDatosGlobales.ESTADO_FINALIZADO:return "Finalizado";
            case SDatosGlobales.ESTADO_CORREGIDO:return "Corregido";
            case SDatosGlobales.ESTADO_REVISADO:return "Revisado";
            case SDatosGlobales.ESTADO_IGNORADO:return "Ignorado";
            default: return string.Empty;
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
    public static bool ConfirmarParticipacionDocente(string codigoProyecto, EUsuarioSesionGAAP usuarioSesion)
    {
        CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
        // Si el usuario no es tutor, devuelve true directamente
        if (!usuarioSesion.Roles.Any(rol => rol == SDatosGlobales.ROL_TUTOR))
            return true;

        List<EGUsuarioProyecto> eGUsuarioProyecto = cUsuarioProyecto
            .Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto)
            .Where(w => w.CodigoRol == SDatosGlobales.ROL_TUTOR)
            .ToList();

        // Devuelve true si el tutor cofirmo su participación en el proyecto, de lo contrario, false
        return eGUsuarioProyecto.Any() ? eGUsuarioProyecto.First().EstadoUsuarioProyecto == SDatosGlobales.ESTADO_ACTIVO : false;
    }
    #region Validaciones
    public static bool ValidarSoloTextoYEspacio(string cadena, int longitudMinima)
    {
        if (string.IsNullOrEmpty(cadena) || cadena.Length < longitudMinima)
        {
            return false;
        }
        return Regex.IsMatch(cadena,SDatosGlobales.REGEX_TEXTO_Y_ESPACIOS);
    }
    public static bool ValidarSoloTexto(string cadena, int longitudMinima)
    {
        if (string.IsNullOrEmpty(cadena) || cadena.Length < longitudMinima)
        {
            return false;
        }
        return Regex.IsMatch(cadena, SDatosGlobales.REGEX_SOLO_TEXTO);
    }
    public static bool ValidarSoloNumero(string cadena, int longitudMinima)
    {
        if (string.IsNullOrEmpty(cadena) || cadena.Length < longitudMinima)
        {
            return false;
        }
        return Regex.IsMatch(cadena, SDatosGlobales.REGEX_SOLO_NUMEROS);
    }
    #endregion
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