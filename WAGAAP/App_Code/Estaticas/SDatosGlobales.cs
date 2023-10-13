using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de SDatosGlobales
/// </summary>
public static class SDatosGlobales
{
    
    #region Roles
    public const string ROL_ESTUDIANTE = "ES";
    public const string ROL_TUTOR = "TU";
    public const string ROL_DIRECTOR = "DI";
    public const string ROL_AYUDANTE_DIR = "AD";
    public const string ROL_TRIBUNAL_1 = "T1";
    public const string ROL_TRIBUNAL_2 = "T2";
    public const string ROL_DAAP = "DP";
    public const string ROL_GESTOR = "GT";
    #endregion
    #region Estados Especificos 
    public const char Activo = 'A';
    public const char Pausado = 'P';
    public const char Rechazado = 'R';
    public const char Finalizado = 'F';
    #endregion
    #region Estados Auditoria Base de Datos
    public const string Auditoria_Activo = "AC";
    public const string Auditoria_Inactivo = "IN";
    #endregion
    #region Manejo de Fechas
    public const int DuracionEtapa = 90;
    public const int DuracionSubEtapaEtapa = 15;
    #endregion
    #region Roles Netvalle
    public const string NETVALLE_ESTUDIANTE = "ESTUDIANTE";
    #endregion
    #region Modalidades Titulacion
    public const char Trabajo_Dirigido = 'D';
    public const char Tesis = 'T';
    public const char Proyecto_Grado = 'P';
    #endregion

}