using System;
using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de EGUsuario
/// </summary>
[DataContract]
public class EGUsuario
{
    #region Propiedades
    [DataMember]
    public string CodigoUsuario { get; set; }

    [DataMember]
    public string SedeUsuario { get; set; }

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
    public EGUsuario()
    {
        CodigoUsuario = string.Empty;
        SedeUsuario = string.Empty;

        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
    }
    #endregion
}