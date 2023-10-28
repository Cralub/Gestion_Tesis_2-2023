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
    public const string Auditoria_Activo = "AC";
    public const string Auditoria_Inactivo = "IN";
    public static readonly DateTime Auditoria_FechaRegistro = DateTime.Now;
    public static readonly DateTime Auditoria_FechaModificacion = DateTime.Now;
    #endregion

    #region Roles del sistema GAAPG
    public const string ROL_ESTUDIANTE = "ES";
    public const string ROL_TUTOR = "TU";
    public const string ROL_DIRECTOR_CARRERA = "DC";
    public const string ROL_AYUDANTE_DIR = "AD";
    public const string ROL_TRIBUNAL_1 = "T1";
    public const string ROL_TRIBUNAL_2 = "T2";
    public const string ROL_DAAP = "DP";
    public const string ROL_GESTOR = "GT";
    #endregion

    #region Roles UNIVALLE
    public const string NETVALLE_ESTUDIANTE = "ESTUDIANTE";
    public const string DOCENTE_ADMINISTRATIVO = "DOCENTE-ADMINISTRATIVO";
    #endregion

    #region Estados específicos de las tablas 
    public const char Activo = 'A';
    public const char En_Espera = 'E';
    public const char Pausa = 'P';
    public const char Rechazado = 'R';
    public const char Finalizado = 'F';
    public const char Corregido = 'C';
    public const char Revisado = 'R';
    #endregion

    #region Modalidades de titulación
    public const char Trabajo_Dirigido = 'D';
    public const char Tesis = 'T';
    public const char Proyecto_Grado = 'P';
    public const char Sin_Modalidad = '-';
    #endregion

    #region Datos base de un Proyecto
    public const string TituloPorDefecto = "Título no definido";
    public const string ObjetivoGeneralPorDefecto = "Objetivo general no definido";
    public const string ObjetivosEspecificosPorDefecto = "Objetivos especificos no definidos";
    public const string AlcancePorDefecto = "Alcance no definido";
    public const string EnlaceDocumentoPorDefecto = "Enclace de url no definido";
    public const byte NumeroRevisionesPorDefecto = 0;
    #endregion
    #region Base SubEtapa
    public const string FirmaPorDefecto = "-/-/-/-/-/";
    #endregion
    #region Manejo de Fechas
    public const int DuracionEtapa = 90;
    public const int DuracionSubEtapaEtapa = 15;
    #endregion
}