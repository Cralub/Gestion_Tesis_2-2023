using System;
using System.Runtime.Serialization;

/// <summary>
/// Summary description for EGCelular
/// </summary>
[DataContract]
public class EGCelular
{
    #region Propiedades
    [DataMember]
    public int CodigoCelular { get; set; }
    [DataMember]
    public string CodigoUsuario { get; set; }
    [DataMember]
    public string CodigoAreaCelular { get; set; }
    [DataMember]
    public int NumeroCelular { get; set; }

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
    public EGCelular()
    {
        CodigoCelular = int.MinValue;
        CodigoUsuario = string.Empty;
        CodigoAreaCelular = string.Empty;
        NumeroCelular = int.MinValue;

        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
    }
    #endregion
}