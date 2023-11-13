using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EObservacionDetalle
/// </summary>
public class EObservacionDetalle
{
   

    public int CodigoObservacion { get; set; }
    public string CodigoProyecto { get; set; }
    public int CodigoSubEtapa { get; set; }
    public string CodigoUsuarioObservacion { get; set; }
    public string NombreUsuarioObservacion { get; set; }
    public string ComentarioObservacion { get; set; }
    public char TipoObservacion { get; set; }
    public char EstadoObservacion { get; set; }

    public EObservacionDetalle(int codigoObservacion, string codigoProyecto, int codigoSubEtapa, string codigoUsuarioObservacion, string nombreUsuarioObservacion, string comentarioObservacion, char tipoObservacion, char estadoObservacion)
    {
        CodigoObservacion = codigoObservacion;
        CodigoProyecto = codigoProyecto;
        CodigoSubEtapa = codigoSubEtapa;
        CodigoUsuarioObservacion = codigoUsuarioObservacion;
        NombreUsuarioObservacion = nombreUsuarioObservacion;
        ComentarioObservacion = comentarioObservacion;
        TipoObservacion = tipoObservacion;
        EstadoObservacion = estadoObservacion;
    }
}