using System;
using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de EGUsuarioProyecto
/// </summary>
[DataContract]
public class EGUsuarioProyecto
{
    #region Propiedades
    [DataMember]
    public int CodigoUsuarioProyecto { get; set; }
    [DataMember]
    public string CodigoProyecto { get; set; }
    [DataMember]
    public string CodigoUsuario { get; set; }
    [DataMember]
    public string CodigoRol { get; set; }
    [DataMember]
    public char EstadoUsuarioProyecto { get; set; }

    #region Auditoría básica
    [DataMember]
    public string Estado { get; set; }
    [DataMember]
    public DateTime FechaRegistro { get; set; }
    [DataMember]
    public DateTime FechaModificacion { get; set; }
    #endregion
    #endregion

    #region Constructores
    public EGUsuarioProyecto()
    {
        CodigoUsuarioProyecto = int.MinValue;
        CodigoProyecto = string.Empty;
        CodigoUsuario = string.Empty;
        CodigoRol = string.Empty;
        EstadoUsuarioProyecto = char.MinValue;

        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
    }
    #endregion
}