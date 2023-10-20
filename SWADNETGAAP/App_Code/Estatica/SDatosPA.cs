using System;

/// <summary>
/// Datos estáticos para Procedimientos Almacenados
/// </summary>
public static class SDatosPA
{
    #region Estados de auditoria básica
    public const string Auditoria_Activo = "AC";
    public const string Auditoria_Inactivo = "IN";
    #endregion
    #region Fechas de auditoria básica
    public static readonly DateTime Auditoria_FechaModificacion = DateTime.Now;
    public static readonly DateTime Auditoria_FechaRegistro = DateTime.Now;
    #endregion

    #region Estados específicos de la tabla 
    public const char Activo = 'A';
    public const char En_Espera = 'E';
    public const char Pausa = 'P';
    public const char Rechazado = 'R';
    public const char Finalizado = 'F';
    public const char Corregido = 'C';
    public const char Revisado = 'R';
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