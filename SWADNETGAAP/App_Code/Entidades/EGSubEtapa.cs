using System;
using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de EGSubEtapa
/// </summary>
[DataContract]
public class EGSubEtapa
{
    #region Propiedades
    [DataMember]
    public int CodigoSubEtapa { get; set; }
    [DataMember]
    public int CodigoEtapa { get; set; }
    [DataMember]
    public string CodigoUsuarioFirmaSubEtapa { get; set; }
    [DataMember]
    public string CodigoRolDesignadoSubEtapa { get; set; }
    [DataMember]
    public byte NumeroSubEtapa { get; set; }
    [DataMember]
    public DateTime FechaInicioSubEtapa { get; set; }
    [DataMember]
    public DateTime FechaDefinidaSubEtapa { get; set; }
    [DataMember]
    public DateTime FechaFinSubEtapa { get; set; }
    [DataMember]
    public char EstadoSubEtapa { get; set; }

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

    public EGSubEtapa()
    {
        CodigoSubEtapa = int.MinValue;
        CodigoEtapa = int.MinValue;
        CodigoUsuarioFirmaSubEtapa = string.Empty;
        CodigoRolDesignadoSubEtapa = string.Empty;
        NumeroSubEtapa = byte.MinValue;
        FechaInicioSubEtapa = DateTime.MinValue;
        FechaDefinidaSubEtapa = DateTime.MinValue;
        FechaFinSubEtapa = DateTime.MinValue;
        EstadoSubEtapa = char.MinValue;
        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
    }
    #endregion
}