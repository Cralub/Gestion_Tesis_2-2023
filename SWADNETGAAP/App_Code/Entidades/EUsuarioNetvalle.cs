using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de EGUsuarioNetvalle
/// </summary>
[DataContract]
public class EUsuarioNetvalle
{
    #region Propiedades
    [DataMember]
    public string CodigoUsuarioNetvalle { get; set; }
    [DataMember]
    public string NombresUsuarioNetvalle { get; set; }
    [DataMember]
    public string ApellidosUsuarioNetvalle { get; set; }
    [DataMember]
    public string RolUsuarioNetvalle { get; set; }
    [DataMember]
    public string CarreraUsuarioNetvalle { get; set; }
    [DataMember]
    public string FacultadUsuarioNetvalle { get; set; }
    [DataMember]
    public string SedeUsuarioNetvalle { get; set; }
    [DataMember]
    public string DireccionUsuarioNetvalle { get; set; }
    [DataMember]
    public string DireccionTrabajoUsuarioNetvalle { get; set; }
    [DataMember]
    public string CelularUsuarioNetvalle { get; set; }
    [DataMember]
    public string EstadoUsuarioNetvalle { get; set; }
    #endregion


    #region Constructores
    public EUsuarioNetvalle()
    {
        CodigoUsuarioNetvalle = string.Empty;

        NombresUsuarioNetvalle = string.Empty;
        ApellidosUsuarioNetvalle = string.Empty;
        RolUsuarioNetvalle = string.Empty;

        
        CarreraUsuarioNetvalle = string.Empty;
        FacultadUsuarioNetvalle = string.Empty;
        SedeUsuarioNetvalle = string.Empty;
        DireccionUsuarioNetvalle = string.Empty;
        CelularUsuarioNetvalle = string.Empty;

        DireccionTrabajoUsuarioNetvalle = string.Empty;

        EstadoUsuarioNetvalle = string.Empty;
    }
    #endregion
}