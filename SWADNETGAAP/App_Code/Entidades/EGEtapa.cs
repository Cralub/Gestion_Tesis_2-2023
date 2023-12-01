using System;
using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de EGEtapa
/// </summary>
[DataContract]
public class EGEtapa
{
    #region Propiedades
    [DataMember]
    public int CodigoEtapa { get; set; }
    [DataMember]
    public string CodigoProyecto { get; set; }
    [DataMember]
    public byte NumeroEtapa { get; set; }
    [DataMember]
    public DateTime FechaInicioEtapa { get; set; }
    [DataMember]
    public DateTime FechaDefinidaEtapa { get; set; }
    [DataMember]
    public DateTime FechaFinEtapa { get; set; }
    [DataMember]
    public char EstadoEtapa { get; set; }

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


    public EGEtapa()
    {
        CodigoEtapa = int.MinValue;
        CodigoProyecto = string.Empty;
        NumeroEtapa = byte.MinValue;
        FechaInicioEtapa = DateTime.MinValue;
        FechaDefinidaEtapa = DateTime.MinValue;
        FechaFinEtapa = DateTime.MinValue;
        EstadoEtapa = char.MinValue;
        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
    }
    #endregion
}