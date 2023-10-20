using System;
using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de EGRol
/// </summary>
[DataContract]
public class EGRol
{
    #region Propiedades
    [DataMember]
    public string CodigoRol { get; set; }
    [DataMember]
    public string DescripcionRol { get; set; }

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
    public EGRol()
    {
        CodigoRol = string.Empty;
        DescripcionRol = string.Empty;

        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
    }
    #endregion
}