using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Datos Estaticos para los Procedimentos Almacenados
/// </summary>
public static class SDatosPA
{
    #region Estados Auditoria Base de Datos
    public const string Auditoria_Activo = "AC";
    public const string Auditoria_Inactivo = "IN";
    #region Fechas Auditoria Base de Datos
    public static readonly DateTime Auditoria_FechaModificacion = DateTime.Now;
    public static readonly DateTime Auditoria_FechaRegistro = DateTime.Now;
    #endregion
    #endregion

    #region Estados Especificos 
    public const char Activo = 'A';
    public const char En_Espera = 'E';
    public const char Rechazado = 'R';
    public const char Finalizado = 'F';
    #endregion

    #region Base Proyecto
    public const string TituloPorDefecto = "Titulo no definido";
    public const char ModalidadPorDefecto = '-';
    public const string ObjetivoPorDefecto = "Objetivo no definido";
    public const string EnlacePorDefecto = "Enlace no definido";
    #endregion
    #region Base SubEtapa
    public const string FirmaPorDefecto = "-/-/-/-/-/";
    #endregion
}