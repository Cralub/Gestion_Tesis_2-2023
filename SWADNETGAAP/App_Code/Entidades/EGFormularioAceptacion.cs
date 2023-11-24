using System;
using System.Runtime.Serialization;
using System.Security.Cryptography;

/// <summary>
/// Descripción breve de EGEtapa
/// </summary>
[DataContract]
public class EGFormularioAceptacion
{
    #region Propiedades
    [DataMember]
    public int CodigoFormularioAceptacion { get; set; }
    [DataMember]
    public string CodigoProyecto { get; set; }
    [DataMember]
    public string CodigoEstudiante { get; set; }
    [DataMember]
    public string CodigoTribunal { get; set; }
    [DataMember]
    public char PreguntaFormatoYForma1 { get; set; }
    [DataMember]
    public char PreguntaFormatoYForma2 { get; set; }
    [DataMember]
    public char PreguntaFormatoYForma3 { get; set; }
    [DataMember]
    public char PreguntaFormatoYForma4 { get; set; }
    [DataMember]
    public char PreguntaFormatoYForma5 { get; set; }
    [DataMember]
    public char PreguntaFormatoYForma6 { get; set; }
    [DataMember]
    public char PreguntaFormatoYForma7 { get; set; }
    [DataMember]
    public char PreguntaFormatoYForma8 { get; set; }
    [DataMember]
    public char PreguntaFormatoYForma9 { get; set; }
    [DataMember]
    public char PreguntaFormatoYForma10 { get; set; }
    [DataMember]
    public char PreguntaFondo1 { get; set; }
    [DataMember]
    public char PreguntaFondo2 { get; set; }
    [DataMember]
    public char PreguntaFondo3 { get; set; }
    [DataMember]
    public char PreguntaFondo4 { get; set; }
    [DataMember]
    public char PreguntaFondo5 { get; set; }
    [DataMember]
    public char PreguntaFondo6 { get; set; }
    [DataMember]
    public char PreguntaFondo7 { get; set; }
    [DataMember]
    public char PreguntaFondo8 { get; set; }
    [DataMember]
    public char PreguntaFondo9 { get; set; }
    [DataMember]
    public char PreguntaFondo10 { get; set; }
    [DataMember]
    public char EstadoFormularioAceptacion { get; set; }

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
    public EGFormularioAceptacion()
    {
        CodigoFormularioAceptacion = int.MinValue;
        CodigoProyecto = string.Empty;
        CodigoEstudiante = string.Empty;
        CodigoTribunal = string.Empty;
        PreguntaFormatoYForma1 = char.MinValue;
        PreguntaFormatoYForma2 = char.MinValue;
        PreguntaFormatoYForma3 = char.MinValue;
        PreguntaFormatoYForma4 = char.MinValue;
        PreguntaFormatoYForma5 = char.MinValue;
        PreguntaFormatoYForma6 = char.MinValue;
        PreguntaFormatoYForma7 = char.MinValue;
        PreguntaFormatoYForma8 = char.MinValue;
        PreguntaFormatoYForma9 = char.MinValue;
        PreguntaFormatoYForma10 = char.MinValue;
        PreguntaFondo1 = char.MinValue;
        PreguntaFondo2 = char.MinValue;
        PreguntaFondo3 = char.MinValue;
        PreguntaFondo4 = char.MinValue;
        PreguntaFondo5 = char.MinValue;
        PreguntaFondo6 = char.MinValue;
        PreguntaFondo7 = char.MinValue;
        PreguntaFondo8 = char.MinValue;
        PreguntaFondo9 = char.MinValue;
        PreguntaFondo10 = char.MinValue;
        EstadoFormularioAceptacion = char.MinValue;
        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
    }
    #endregion
}