using System.Collections.Generic;
/// <summary>
/// Descripción breve de CGProyecto
/// </summary>
public class CGProyecto
{
    #region Atributos
    private ADGProyecto adGProyecto;
    #endregion

    #region Constructor
    public CGProyecto()
    {
        adGProyecto = new ADGProyecto();
    }
    #endregion

    #region Métodos públicos
    public EGProyecto Obtener_GProyecto_O(string codigoProyecto)
    {
        EGProyecto proyecto = null;
        DTOGProyecto dtoGProyecto = adGProyecto.Obtener_GProyecto_O(codigoProyecto);
        foreach (DTOGProyecto.GProyectoRow gProyecto in dtoGProyecto.GProyecto.Rows)
        {
            proyecto = new EGProyecto();
            proyecto.CodigoProyecto = gProyecto.CodigoProyecto;
            proyecto.ModalidadProyecto = char.Parse(gProyecto.ModalidadProyecto);
            proyecto.TituloProyecto = gProyecto.TituloProyecto;
            proyecto.ObjetivoGeneralProyecto = gProyecto.ObjetivoGeneralProyecto;
            proyecto.ObjetivosEspecificosProyecto = gProyecto.ObjetivosEspecificosProyecto;
            proyecto.AlcanceProyecto = gProyecto.AlcanceProyecto;
            proyecto.EnlaceDocumentoProyecto = gProyecto.EnlaceDocumentoProyecto;
            proyecto.EstadoProyecto = char.Parse(gProyecto.EstadoProyecto);
            proyecto.NumeroRevisiones = gProyecto.NumeroRevisiones;
            proyecto.Estado = gProyecto.Estado;
            proyecto.FechaRegistro = gProyecto.FechaRegistro;
            proyecto.FechaModificacion = gProyecto.FechaModificacion;
        }
        return proyecto;
    }
    public void Actualizar_GProyecto_A(EGProyecto proyecto)
    {
        adGProyecto.Actualizar_GProyecto_A(proyecto);
    }
    #endregion
}