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
    public const string ESTADO_ACTIVO_AUDITORIA = "AC";
    public const string ESTADO_INACTIVO_AUDITORIA = "IN";
    #region Fechas Auditoria Base de Datos
    public static readonly DateTime FECHA_MODIFICACION_AUDITORIA = DateTime.Now;
    public static readonly DateTime FECHA_REGISTRO_AUDITORIA = DateTime.Now;
    #endregion
    #endregion    
    #region Procedimientos Almacenados
    public const char ESTADO_ACTIVO_GAAP = 'A';
    #endregion

}