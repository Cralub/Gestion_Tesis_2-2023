﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EProyectoCompleja
/// </summary>

[DataContract]
public class EProyectoCompleja
{
    #region Atributos
    [DataMember]
    public string CodigoUsuario { get; set; }
    [DataMember]
    public string CodigoRol { get; set; }
    [DataMember]
    public string Rol { get; set; }
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
    public byte NumeroRevisionesProyecto { get; set; }
    [DataMember]
    public string EnlaceDocumentoProyecto { get; set; }
    [DataMember]
    public List<string> CodigosEstudiantes { get; set; }
    [DataMember]
    public List<string> NombresEstudiantes { get; set; }
    [DataMember]
    public char EstadoProyecto { get; set; }
    [DataMember]
    public string CodigoTutor { get; set; }
    [DataMember]
    public string NombreTutor { get; set; }

    #endregion

    public EProyectoCompleja()
    {
        CodigoUsuario = string.Empty;
        CodigoRol = string.Empty;
        Rol = string.Empty;
        CodigoProyecto = string.Empty;
        ModalidadProyecto = char.MinValue;
        TituloProyecto = string.Empty;
        ObjetivoGeneralProyecto = string.Empty;
        EnlaceDocumentoProyecto = string.Empty;
        NombresEstudiantes = new List<string>();
        CodigosEstudiantes = new List<string>();
        EstadoProyecto = char.MinValue;
        CodigoTutor = string.Empty;
        NombreTutor = string.Empty;
    }
}