using System.Collections.Generic;

/// <summary>
/// Descripción breve de CGFormularioAceptacion
/// </summary>
public class CGFormularioAceptacion
{
    #region Atributos
    private ADGFormularioAceptacion aDGFormularioAceptacion;
    #endregion

    #region Constructor
    public CGFormularioAceptacion()
    {
        aDGFormularioAceptacion = new ADGFormularioAceptacion();
    }
    #endregion
    #region Métodos públicos
    public void Insertar_GFormularioAceptacion_I(EGFormularioAceptacion eGFormularioAceptacion)
    {
        aDGFormularioAceptacion.Insertar_GFormularioAceptacion_I(eGFormularioAceptacion);
    }
    public void Actualizar_GFormularioAceptacion_A(EGFormularioAceptacion eGFormularioAceptacion)
    {
        aDGFormularioAceptacion.Actualizar_GFormularioAceptacion_A(eGFormularioAceptacion);
    }
    public List<EGFormularioAceptacion> Obtener_GFormularioAceptacion_O_CodigoProyecto(string codigoProyecto)
    {
        EGFormularioAceptacion eGFormularioAceptacion;
        List<EGFormularioAceptacion> lstEGFormularioAceptacion = new List<EGFormularioAceptacion>();
        DTOGFormularioAceptacion dTOGFormularioAceptacion = aDGFormularioAceptacion.Obtener_GFormularioAceptacion_O_CodigoProyecto(codigoProyecto);
        foreach (DTOGFormularioAceptacion.GFormularioAceptacionRow dRGFormularioAceptacion in dTOGFormularioAceptacion.GFormularioAceptacion.Rows)
        {
            eGFormularioAceptacion = new EGFormularioAceptacion();
            eGFormularioAceptacion.CodigoFormularioAceptacion = dRGFormularioAceptacion.CodigoFormularioAceptacion;
            eGFormularioAceptacion.CodigoProyecto = dRGFormularioAceptacion.CodigoProyecto;
            eGFormularioAceptacion.CodigoEstudiante = dRGFormularioAceptacion.CodigoEstudiante;
            eGFormularioAceptacion.CodigoTribunal = dRGFormularioAceptacion.CodigoTribunal;
            eGFormularioAceptacion.PreguntaFormatoYForma1 = char.Parse(dRGFormularioAceptacion.PreguntaFormatoYForma1);
            eGFormularioAceptacion.PreguntaFormatoYForma2 = char.Parse(dRGFormularioAceptacion.PreguntaFormatoYForma2);
            eGFormularioAceptacion.PreguntaFormatoYForma3 = char.Parse(dRGFormularioAceptacion.PreguntaFormatoYForma3);
            eGFormularioAceptacion.PreguntaFormatoYForma4 = char.Parse(dRGFormularioAceptacion.PreguntaFormatoYForma4);
            eGFormularioAceptacion.PreguntaFormatoYForma5 = char.Parse(dRGFormularioAceptacion.PreguntaFormatoYForma5);
            eGFormularioAceptacion.PreguntaFormatoYForma6 = char.Parse(dRGFormularioAceptacion.PreguntaFormatoYForma6);
            eGFormularioAceptacion.PreguntaFormatoYForma7 = char.Parse(dRGFormularioAceptacion.PreguntaFormatoYForma7);
            eGFormularioAceptacion.PreguntaFormatoYForma8 = char.Parse(dRGFormularioAceptacion.PreguntaFormatoYForma8);
            eGFormularioAceptacion.PreguntaFormatoYForma9 = char.Parse(dRGFormularioAceptacion.PreguntaFormatoYForma9);
            eGFormularioAceptacion.PreguntaFormatoYForma10 = char.Parse(dRGFormularioAceptacion.PreguntaFormatoYForma10);
            eGFormularioAceptacion.PreguntaFondo1 = char.Parse(dRGFormularioAceptacion.PreguntaFondo1);
            eGFormularioAceptacion.PreguntaFondo2 = char.Parse(dRGFormularioAceptacion.PreguntaFondo2);
            eGFormularioAceptacion.PreguntaFondo3 = char.Parse(dRGFormularioAceptacion.PreguntaFondo3);
            eGFormularioAceptacion.PreguntaFondo4 = char.Parse(dRGFormularioAceptacion.PreguntaFondo4);
            eGFormularioAceptacion.PreguntaFondo5 = char.Parse(dRGFormularioAceptacion.PreguntaFondo5);
            eGFormularioAceptacion.PreguntaFondo6 = char.Parse(dRGFormularioAceptacion.PreguntaFondo6);
            eGFormularioAceptacion.PreguntaFondo7 = char.Parse(dRGFormularioAceptacion.PreguntaFondo7);
            eGFormularioAceptacion.PreguntaFondo8 = char.Parse(dRGFormularioAceptacion.PreguntaFondo8);
            eGFormularioAceptacion.PreguntaFondo9 = char.Parse(dRGFormularioAceptacion.PreguntaFondo9);
            eGFormularioAceptacion.PreguntaFondo10 = char.Parse(dRGFormularioAceptacion.PreguntaFondo10);
            eGFormularioAceptacion.EstadoFormularioAceptacion = char.Parse(dRGFormularioAceptacion.EstadoFormularioAceptacion);
            eGFormularioAceptacion.Estado = dRGFormularioAceptacion.Estado;
            eGFormularioAceptacion.FechaRegistro = dRGFormularioAceptacion.FechaRegistro;
            eGFormularioAceptacion.FechaModificacion = dRGFormularioAceptacion.FechaModificacion;
            lstEGFormularioAceptacion.Add(eGFormularioAceptacion);
        }
        return lstEGFormularioAceptacion;
    }

    public int Obtener_GFormularioAceptacion_O_SiguienteCodigoFormularioAceptacion()
    {
        object ultimoCodigo = aDGFormularioAceptacion.Obtener_GFormularioAceptacion_O_SiguienteCodigoFormularioAceptacion();
        return int.Parse(ultimoCodigo.ToString()) + 1;
    }
    #endregion
}