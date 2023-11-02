using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// La clase estatica SDatos sirve para los datos de auditoria, estados, valores por defecto y roles del sistema
/// tambien esta los roles de la institución univalle
/// </summary>
public static class SDatos
{
    #region Auditoria básica
    public const string AUDITORIA_ACTIVO = "AC";
    public const string AUDITORIA_INACTIVO = "IN";
    public static readonly DateTime AUDITORIA_FECHA_REGISTRO = DateTime.Now;
    public static readonly DateTime AUDITORIA_FECHA_MODIFICACION = DateTime.Now;
    #endregion

    #region Roles del sistema GAAPG
    public const string ROL_ESTUDIANTE = "ES";
    public const string ROL_TUTOR = "TU";
    public const string ROL_DIRECTOR_CARRERA = "DI";
    public const string ROL_AYUDANTE_DIR = "AD";
    public const string ROL_TRIBUNAL_1 = "T1";
    public const string ROL_TRIBUNAL_2 = "T2";
    public const string ROL_DAAP = "DP";
    //public const string ROL_GESTOR = "GT";
    #endregion

    #region Roles UNIVALLE
    public const string NETVALLE_ESTUDIANTE = "ESTUDIANTE";
    public const string DOCENTE_ADMINISTRATIVO = "DOCENTE-ADMINISTRATIVO";
    #endregion

    #region Estados específicos de las tablas 
    public const char ESTADO_ACTIVO = 'A';
    public const char ESTADO_EN_ESPERA = 'E';
    public const char ESTADO_PAUSADO = 'P';
    public const char ESTADO_RECHAZADO = 'R';
    public const char ESTADO_FINALIZADO = 'F';
    public const char ESTADO_CORREGIDO = 'C';
    public const char ESTADO_REVISADO = 'R';
    #endregion

    #region Modalidades de titulación
    public const char TRABAJO_DIRIGIDO = 'D';
    public const char TESIS = 'T';
    public const char PROYECTO_DE_GRADO = 'P';
    public const char SIN_MODALIDAD = '-';
    #endregion

    #region Datos base de un Proyecto
    public const string TITULO_POR_DEFECTO = "Título no definido";
    public const string OBJETIVO_GENERAL_POR_DEFECTO = "Objetivo general no definido";
    public const string OBJETIVOS_ESPECIFICOS_POR_DEFECTO = "Objetivos especificos no definidos";
    public const string ALCANCE_POR_DEFECTO = "Alcance no definido";
    public const string ENLACE_DOCUMENTO_POR_DEFECTO = "Enclace de url no definido";
    public const byte NUMERO_REVISIONES_POR_DEFECTO = 0;
    #endregion
    #region Base SubEtapa
    public const string FIRMA_POR_DEFECTO = "-/-/-/-/-/";
    #endregion
    #region Manejo de Fechas
    public const int DURACION_ETAPA = 90;
    public const int DURACION_SUB_ETAPA = 15;
    #endregion
}