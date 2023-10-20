using System;
using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de EGUsuarioRol
/// </summary>
[DataContract]
public class EGUsuarioRol
{
    #region Propiedades
    [DataMember]
    public int CodigoUsuarioRol { get; set; }
    [DataMember]
    public string CodigoUsuario { get; set; }
    [DataMember]
    public string CodigoRol { get; set; }

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
    public EGUsuarioRol()
    {
        CodigoUsuarioRol = int.MinValue;
        CodigoUsuario = string.Empty;
        CodigoRol = string.Empty;

        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
    }
    #endregion
}