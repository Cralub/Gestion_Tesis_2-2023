using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EProgresoEtapaSubEtapa
/// </summary>
[DataContract]
public class EProgresoEtapaSubEtapa
{
    #region Propiedades
    [DataMember]
    public byte NumeroEtapa { get; set; }

    [DataMember]
    public char EstadoEtapa { get; set; }

    [DataMember]
    public int CantidadSubEtapaTotal { get; set; }

    [DataMember]
    public int CantidadSubEtapaFinalizada { get; set; }
    #endregion

    #region Constructores
    public EProgresoEtapaSubEtapa()
    {
        NumeroEtapa = byte.MinValue;
        EstadoEtapa = char.MinValue;
        CantidadSubEtapaTotal = int.MinValue;
        CantidadSubEtapaFinalizada = int.MinValue;
    }
    #endregion
}