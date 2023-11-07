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
    public const string AUDITORIA_ACTIVO = "AC";
    public const string AUDITORIA_INACTIVO = "IN";
    #region Fechas Auditoria Base de Datos
    public static readonly DateTime AUDITORIA_FECHA_MODIFICACION = DateTime.Now;
    public static readonly DateTime AUDITORIA_FECHA_REGISTRO = DateTime.Now;
    #endregion
    #endregion    
    #region Procedimientos Almacenados
    
    #endregion
    
}