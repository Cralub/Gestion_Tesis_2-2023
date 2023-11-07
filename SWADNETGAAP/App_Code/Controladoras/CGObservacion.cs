using System.Collections.Generic;

/// <summary>
/// Descripción breve de CGObservacion
/// </summary>
public class CGObservacion
{
    #region Metodos Privados
    private ADGObservacion aDGObservacion;
    #endregion
    #region Constructor
    public CGObservacion()
    {
        aDGObservacion = new ADGObservacion();
    }
    #endregion
    #region Metodos Publicos

    public List<EGObservacion> Obtener_GObservacion_O_CodigoProyecto(string codigoProyecto)
    {
        EGObservacion eGObservacion = new EGObservacion();
        List<EGObservacion> lstEGObservaciones = new List<EGObservacion>();
        DTOGObservacion dTOGObservacion = aDGObservacion.Obtener_GObservacion_O_CodigoProyecto(codigoProyecto);
        foreach (DTOGObservacion.GObservacionRow dRGObservacionRow in dTOGObservacion.GObservacion.Rows)
        {
            eGObservacion = new EGObservacion();
            eGObservacion.CodigoObservacion = dRGObservacionRow.CodigoObservacion;
            eGObservacion.CodigoProyecto = dRGObservacionRow.CodigoProyecto;
            eGObservacion.CodigoSubEtapa = dRGObservacionRow.CodigoSubEtapa;
            eGObservacion.CodigoUsuarioObservacion = dRGObservacionRow.CodigoUsuarioObservacion;
            eGObservacion.ComentarioObservacion = dRGObservacionRow.ComentarioObservacion;
            eGObservacion.TipoObservacion = char.Parse(dRGObservacionRow.TipoObservacion);
            eGObservacion.EstadoObservacion = char.Parse(dRGObservacionRow.EstadoObservacion);
            lstEGObservaciones.Add(eGObservacion);
        }
        return lstEGObservaciones;
    }
    
    public EGObservacion Obtener_GObservacion_O_CodigoObservacion(int codigoObservacion)
    {
        EGObservacion eGObservacion = new EGObservacion();
        DTOGObservacion dTOGObservacion = aDGObservacion.Obtener_GObservacion_O_CodigoObservacion(codigoObservacion);
        foreach (DTOGObservacion.GObservacionRow drGObservacionRow in dTOGObservacion.GObservacion.Rows)
        {
            eGObservacion.CodigoObservacion = drGObservacionRow.CodigoObservacion;
            eGObservacion.CodigoProyecto = drGObservacionRow.CodigoProyecto;
            eGObservacion.CodigoSubEtapa = drGObservacionRow.CodigoSubEtapa;
            eGObservacion.CodigoUsuarioObservacion = drGObservacionRow.CodigoUsuarioObservacion;
            eGObservacion.ComentarioObservacion = drGObservacionRow.ComentarioObservacion;
            eGObservacion.TipoObservacion = char.Parse(drGObservacionRow.TipoObservacion);
            eGObservacion.EstadoObservacion = char.Parse(drGObservacionRow.EstadoObservacion);
            eGObservacion.FechaRegistro = drGObservacionRow.FechaRegistro;
        }
        return eGObservacion;

    }
    public void Insertar_GObservacion_I(EGObservacion eGObservacion)
    {
        aDGObservacion.Insertar_GObservacion_I(eGObservacion);
    }
    public void Actualizar_GObservacion_A(EGObservacion eGObservacion)
    {
        aDGObservacion.Actualizar_GObservacion_A(eGObservacion);
    }

    public void Actualizar_GObservacion_A_EstadoObservacion(int codigoObservacion, char estadoObservacion)
    {
        aDGObservacion.Actualizar_GObservacion_A_EstadoObservacion(codigoObservacion, estadoObservacion);
    }
    public int Obtener_GObsevacion_O_SiguienteCodigoObservacion()
    {
        object ultimoCodigo = aDGObservacion.Obtener_GObsevacion_O_SiguienteCodigoObservacion();
        return int.Parse(ultimoCodigo.ToString()) + 1;
    }
    #endregion
}