using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EProyectoTiempoEntrega
/// </summary>
public class EProyectoTiempoEntrega
{
    #region Propiedades
    [DataMember]
    public string Modalidad { get; set; }

    [DataMember]
    public string Titulo { get; set; }

    [DataMember]
    public string Objetivo { get; set; }

    [DataMember]
    public string Documento { get; set; }

    [DataMember]
    public DateTime FechaEntrega { get; set; }
    #endregion

    #region Constructores
    public EProyectoTiempoEntrega()
    {
        Modalidad = string.Empty;
        Titulo = string.Empty;
        Objetivo = string.Empty;
        Documento = string.Empty;
        FechaEntrega = DateTime.MinValue;
    }
    #endregion
}