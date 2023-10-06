using System;
using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de EGObservacion
/// </summary>
/// 
[DataContract]
public class EGObservacion
{
    #region Propiedades
    [DataMember]
    public int CodigoObservacion { get; set; }
    [DataMember]
    public string CodigoProyecto { get; set; }
    [DataMember]
    public int CodigoSubEtapa { get; set; }
    [DataMember]
    public string CodigoUsuarioObservacion { get; set; }
    [DataMember]
    public string ComentarioObservacion { get; set; }
    [DataMember]
    public char TipoObservacion { get; set; }
    [DataMember]
    public char EstadoObservacion { get; set; }

    #region “Auditoría básica”
    [DataMember]
    public string Estado { get; set; }
    [DataMember]
    public DateTime FechaRegistro { get; set; }
    [DataMember]
    public DateTime FechaModificacion { get; set; }
    #endregion
    #endregion

    #region Constructores
    public EGObservacion()
    {
        CodigoObservacion = int.MinValue;
        CodigoProyecto = string.Empty;
        CodigoSubEtapa = int.MinValue;
        CodigoUsuarioObservacion = string.Empty;
        TipoObservacion = char.MinValue;
        EstadoObservacion = char.MinValue;

        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
    }
    #endregion
}