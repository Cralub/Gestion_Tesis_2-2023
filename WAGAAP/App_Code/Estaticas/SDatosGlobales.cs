﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de SDatosGlobales
/// </summary>
public static class SDatosGlobales
{
    #region Estados

    /// <summary>
    /// Códigos de estados utilizados dentro del sistema
    /// </summary>
    /// 
    public const string NOMBRE_APLICACION = "GESTION DE APOYO Y ASESORIA A PROYECTOS";

    #endregion
    #region Roles
    public const string ROL_ESTUDIANTE = "ES";
    public const string ROL_TUTOR = "TU";
    public const string ROL_DIRECTOR = "DI";
    public const string ROL_AYUDANTE_DIR = "AD";
    public const string ROL_TRIBUNAL_1 = "T1";
    public const string ROL_TRIBUNAL_2 = "T2";
    public const string ROL_TRIBUNAL = "TR";
    public const string ROL_DAAP = "DP";
    //public const string ROL_GESTOR = "GT";
    #endregion
    #region Estados Especificos 
    public const char ESTADO_ACTIVO = 'A';
    public const char ESTADO_PAUSADO = 'P';
    public const char ESTADO_RECHAZADO = 'R';
    public const char ESTADO_FINALIZADO = 'F';
    public const char ESTADO_CORREGIDO = 'C';
    public const char ESTADO_REVISADO = 'V';
    public const char ESTADO_IGNORADO = 'I';
    #endregion
    #region Estados Auditoria Base de Datos
    public const string AUDITORIA_ACTIVO = "AC";
    public const string AUDITORIA_INACTIVO = "IN";
    #endregion
    
    #region Roles Netvalle
    public const string NETVALLE_ESTUDIANTE = "ESTUDIANTE";

    #endregion
    #region Modalidades Titulacion
    public const char CHAR_MODALIDAD_TRABAJO_DIRIGIDO = 'D';
    public const char CHAR_MODALIDAD_TESIS = 'T';
    public const char CHAR_MODALIDAD_PROYECTO_DE_GRADO = 'P';
    public const char CHAR_SIN_MODALIDAD = '-';
    public const string STRING_MODALIDAD_TRABAJO_DIRIGIDO = "Trabajo Dirigido";
    public const string STRING_MODALIDAD_TESIS = "Tesis";
    public const string STRING_MODALIDAD_PROYECTO_DE_GRADO = "Proyecto de Grado";
    public const string STRING_SIN_MODALIDAD = "Sin Modalidad";
    #endregion
    #region Manejo de Fechas
    public const int DURACION_ETAPA = 90;
    public const int DURACION_SUB_ETAPA = 15;
    #endregion
    public const int N_MAXIMO_PROYECTOS_POR_TUTOR = 10;
    public const string REGEX_TEXTO_Y_ESPACIOS = "^[A-Za-z ]+$";
    public const string REGEX_SOLO_TEXTO = "^[A-Za-z]+$";

    public const string REGEX_SOLO_NUMEROS = "^[0-9]+$";
    #region SubEtapas Por Etapa
    public const int N_SUB_ETAPAS_ETAPA_1 = 4;
    public const int N_SUB_ETAPAS_ETAPA_2 = 7;
    public const int N_SUB_ETAPAS_ETAPA_3 = 7;
    public const int N_SUB_ETAPAS_ETAPA_4 = 7;
    #endregion
}