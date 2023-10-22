using System;
using System.Runtime.Serialization;

/// <summary>
/// Summary description for EGTutorExterno
/// </summary>
[DataContract]
public class EGTutorExterno
{
    #region Propiedades
    [DataMember]
    public int CodigoTutorExterno { get; set; }
    [DataMember]
    public string NombresTutorExterno { get; set; }
    [DataMember]
    public string ApellidosTutorExterno { get; set; }
    [DataMember]
    public string CarreraTutorExterno { get; set; }
    [DataMember]
    public string DireccionTrabajoTutorExterno { get; set; }
    [DataMember]
    public string DescripcionTutorExterno { get; set; }
    [DataMember]
    public string SedeTutorExterno { get; set; }

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
    public EGTutorExterno()
    {
        CodigoTutorExterno = int.MinValue;
        NombresTutorExterno = string.Empty;
        ApellidosTutorExterno = string.Empty;
        CarreraTutorExterno = string.Empty;
        DireccionTrabajoTutorExterno = string.Empty;
        DescripcionTutorExterno = string.Empty;
        SedeTutorExterno = string.Empty;

        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
    }
    #endregion
}