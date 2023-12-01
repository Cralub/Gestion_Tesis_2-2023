using System;
using System.Runtime.Serialization;
/// <summary>
/// Descripción breve de EGProyecto
/// </summary>
[DataContract]
public class EGProyecto
{

    #region Propiedades
    [DataMember]
    public string CodigoProyecto { get; set; }
    [DataMember]
    public char ModalidadProyecto { get; set; }
    [DataMember]
    public string TituloProyecto { get; set; }
    [DataMember]
    public string ObjetivoGeneralProyecto { get; set; }
    [DataMember]
    public string ObjetivosEspecificosProyecto { get; set; }
    [DataMember]
    public string AlcanceProyecto { get; set; }
    [DataMember]
    public string EnlaceDocumentoProyecto { get; set; }
    [DataMember]
    public char EstadoProyecto { get; set; }
    [DataMember]
    public byte NumeroRevisionesProyecto { get; set; }

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
    public EGProyecto()
    {
        CodigoProyecto = string.Empty;
        ModalidadProyecto = char.MinValue;
        TituloProyecto = string.Empty;
        ObjetivoGeneralProyecto = string.Empty;
        ObjetivosEspecificosProyecto = string.Empty;
        AlcanceProyecto = string.Empty;
        EnlaceDocumentoProyecto = string.Empty;
        EstadoProyecto = char.MinValue;
        NumeroRevisionesProyecto = byte.MinValue;
        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
    }
    #endregion
}