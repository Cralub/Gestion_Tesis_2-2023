using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CGFormularioAceptacion
/// </summary>
public class CGFormularioAceptacion
{
    #region Atributos
    private ADGFormularioAceptacion adGFormularioAceptacion;
    #endregion

    #region Constructor
    public CGFormularioAceptacion()
    {
        adGFormularioAceptacion = new ADGFormularioAceptacion();
    }
    #endregion
    #region Métodos públicos
    public void Insertar_GFormularioAceptacion_I(EGFormularioAceptacion formularioAceptacion)
    {
        adGFormularioAceptacion.Insertar_GFormularioAceptacion_I(formularioAceptacion);
    }
    public List<EGFormularioAceptacion> Obtener_GFormularioAceptacion_O_CodigoProyecto(string CodigoProyecto)
    {
        EGFormularioAceptacion eGFormularioAceptacion;
        List<EGFormularioAceptacion> lstEGFormularioAceptacion = new List<EGFormularioAceptacion>();
        DTOGFormularioAceptacion dtoGFormularioAceptacion = adGFormularioAceptacion.Obtener_GFormularioAceptacion_O_CodigoProyecto(CodigoProyecto);
        foreach (DTOGFormularioAceptacion.GFormularioAceptacionRow dgFormularioAceptacion in dtoGFormularioAceptacion.GFormularioAceptacion.Rows)
        {
            eGFormularioAceptacion = new EGFormularioAceptacion();
            eGFormularioAceptacion.CodigoFormularioAceptacion = dgFormularioAceptacion.CodigoFormularioAceptacion;
            eGFormularioAceptacion.CodigoProyecto = dgFormularioAceptacion.CodigoProyecto;
            eGFormularioAceptacion.CodigoEstudiante = dgFormularioAceptacion.CodigoEstudiante;
            eGFormularioAceptacion.CodigoTribunal = dgFormularioAceptacion.CodigoTribunal;
            eGFormularioAceptacion.PreguntaFormatoYForma1 = char.Parse(dgFormularioAceptacion.PreguntaFormatoYForma1);
            eGFormularioAceptacion.PreguntaFormatoYForma2 = char.Parse(dgFormularioAceptacion.PreguntaFormatoYForma2);
            eGFormularioAceptacion.PreguntaFormatoYForma3 = char.Parse(dgFormularioAceptacion.PreguntaFormatoYForma3);
            eGFormularioAceptacion.PreguntaFormatoYForma4 = char.Parse(dgFormularioAceptacion.PreguntaFormatoYForma4);
            eGFormularioAceptacion.PreguntaFormatoYForma5 = char.Parse(dgFormularioAceptacion.PreguntaFormatoYForma5);
            eGFormularioAceptacion.PreguntaFormatoYForma6 = char.Parse(dgFormularioAceptacion.PreguntaFormatoYForma6);
            eGFormularioAceptacion.PreguntaFormatoYForma7 = char.Parse(dgFormularioAceptacion.PreguntaFormatoYForma7);
            eGFormularioAceptacion.PreguntaFormatoYForma8 = char.Parse(dgFormularioAceptacion.PreguntaFormatoYForma8);
            eGFormularioAceptacion.PreguntaFormatoYForma9 = char.Parse(dgFormularioAceptacion.PreguntaFormatoYForma9);
            eGFormularioAceptacion.PreguntaFormatoYForma10 = char.Parse(dgFormularioAceptacion.PreguntaFormatoYForma10);
            eGFormularioAceptacion.PreguntaFondo1 = char.Parse(dgFormularioAceptacion.PreguntaFondo1);
            eGFormularioAceptacion.PreguntaFondo2 = char.Parse(dgFormularioAceptacion.PreguntaFondo2);
            eGFormularioAceptacion.PreguntaFondo3 = char.Parse(dgFormularioAceptacion.PreguntaFondo3);
            eGFormularioAceptacion.PreguntaFondo4 = char.Parse(dgFormularioAceptacion.PreguntaFondo4);
            eGFormularioAceptacion.PreguntaFondo5 = char.Parse(dgFormularioAceptacion.PreguntaFondo5);
            eGFormularioAceptacion.PreguntaFondo6 = char.Parse(dgFormularioAceptacion.PreguntaFondo6);
            eGFormularioAceptacion.PreguntaFondo7 = char.Parse(dgFormularioAceptacion.PreguntaFondo7);
            eGFormularioAceptacion.PreguntaFondo8 = char.Parse(dgFormularioAceptacion.PreguntaFondo8);
            eGFormularioAceptacion.PreguntaFondo9 = char.Parse(dgFormularioAceptacion.PreguntaFondo9);
            eGFormularioAceptacion.PreguntaFondo10 = char.Parse(dgFormularioAceptacion.PreguntaFondo10);
            lstEGFormularioAceptacion.Add(eGFormularioAceptacion);
        }
        return lstEGFormularioAceptacion;
    }
    #endregion
}