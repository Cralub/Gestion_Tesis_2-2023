﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for EGTutorExterno
/// </summary>
public class EGTutorExterno
{

    #region Propiedades
    [DataMember]
    public string CodigoTutorExterno { get; set; }
    [DataMember]
    public string NombreCompletoTutorExterno { get; set; }    
    [DataMember]
    public string CarreraTutorExterno { get; set; }
    [DataMember]
    public string DireccionTrabajoTutorExterno { get; set; }
    [DataMember]
    public string DescripcionTutorExterno { get; set; }
    [DataMember]
    public string SedeTutorExterno { get; set; }
    
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
    public EGTutorExterno()
    {
        CodigoTutorExterno = string.Empty;
        NombreCompletoTutorExterno = string.Empty;        
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