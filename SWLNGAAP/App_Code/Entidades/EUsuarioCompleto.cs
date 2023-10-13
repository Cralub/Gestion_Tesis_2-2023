using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EUsuarioCompleto
/// </summary>
[DataContract]
public class EUsuarioCompleto
{
    #region Propiedades
    [DataMember]
    public string NombreCompleto { get; set; }

    [DataMember]
    public string RolNetvalle { get; set; }

    [DataMember]
    public string RolProyecto { get; set; }

    [DataMember]
    public string Carrera { get; set; }

    [DataMember]
    public string Facultad { get; set; }

    [DataMember]
    public string Sede { get; set; }

    [DataMember]
    public string Direccion { get; set; }

    [DataMember]
    public string DireccionTrabajo { get; set; }

    [DataMember]
    public string Celular { get; set; }
    #endregion

    #region Constructores
    public EUsuarioCompleto()
    {
        NombreCompleto = string.Empty;
        RolNetvalle = string.Empty;
        RolProyecto = string.Empty;

        Carrera = string.Empty;
        Facultad = string.Empty;
        Sede = string.Empty;

        Direccion = string.Empty;
        DireccionTrabajo = string.Empty;
        Celular = string.Empty;
    }
    #endregion
}