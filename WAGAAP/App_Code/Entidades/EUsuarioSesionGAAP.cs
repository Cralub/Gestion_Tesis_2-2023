using SWLNGAAP;
using System.Collections.Generic;

/// <summary>
/// Summary description for EUsuarioSesionGAAP
/// </summary>
public class EUsuarioSesionGAAP
{
    public string CodigoUsuario { get; set; }
    public string NombreCompleto { get; set; }
    public string SedeAcademica { get; set; }
    public List<string> Roles { get; set; }
    public bool esEstudiante {  get; set; }
    public EUsuarioSesionGAAP(EGUsuario eGUsuario, List<string> rolesEnSistema, bool esEstudiante)
    {
        CodigoUsuario = eGUsuario.CodigoUsuario;
        NombreCompleto = eGUsuario.NombreCompletoUsuario;
        SedeAcademica = eGUsuario.NombreCompletoUsuario;
        Roles = rolesEnSistema;
        this.esEstudiante = esEstudiante;
    }

    
}