using System.Collections.Generic;
/// <summary>
/// Descripción breve de CGEtapa
/// </summary>
public class CGEtapa
{
    #region Atributos
    private ADGEtapa aDGEtapa;
    #endregion

    #region Constructor
    public CGEtapa()
    {
        aDGEtapa = new ADGEtapa();
    }
    #endregion
    #region Métodos públicos
    public void Insertar_GEtapa_I(EGEtapa eGEtapa)
    {
        aDGEtapa.Insertar_GEtapa_I(eGEtapa);
    }
    public List<EGEtapa> Obtener_GEtapa_O_CodigoProyecto(string codigoProyecto)
    {
        EGEtapa eGEtapa;
        List<EGEtapa> lstEGEtapa = new List<EGEtapa>();
        DTOGEtapa dTOGEtapa = aDGEtapa.Obtener_GEtapa_O_CodigoProyecto(codigoProyecto);
        foreach (DTOGEtapa.GEtapaRow dRGEtapa in dTOGEtapa.GEtapa.Rows)
        {
            eGEtapa = new EGEtapa();
            eGEtapa.CodigoEtapa = dRGEtapa.CodigoEtapa;
            eGEtapa.CodigoProyecto = dRGEtapa.CodigoProyecto;
            eGEtapa.NumeroEtapa = dRGEtapa.NumeroEtapa;
            eGEtapa.FechaInicioEtapa = dRGEtapa.FechaInicioEtapa;
            eGEtapa.FechaDefinidaEtapa = dRGEtapa.FechaDefinidaEtapa;
            eGEtapa.FechaFinEtapa = dRGEtapa.FechaFinEtapa;
            eGEtapa.EstadoEtapa = char.Parse(dRGEtapa.EstadoEtapa);
            lstEGEtapa.Add(eGEtapa);
        }
        return lstEGEtapa;
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(string codigoProyecto, char estadoEtapa)
    {
        EGEtapa eGEtapa = new EGEtapa();
        DTOGEtapa dTOGEtapa = aDGEtapa.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto, estadoEtapa);
        foreach (DTOGEtapa.GEtapaRow dRGEtapa in dTOGEtapa.GEtapa.Rows)
        {
            eGEtapa = new EGEtapa();
            eGEtapa.CodigoEtapa = dRGEtapa.CodigoEtapa;
            eGEtapa.CodigoProyecto = dRGEtapa.CodigoProyecto;
            eGEtapa.NumeroEtapa = dRGEtapa.NumeroEtapa;
            eGEtapa.FechaInicioEtapa = dRGEtapa.FechaInicioEtapa;
            eGEtapa.FechaDefinidaEtapa = dRGEtapa.FechaDefinidaEtapa;
            eGEtapa.FechaFinEtapa = dRGEtapa.FechaFinEtapa;
            eGEtapa.EstadoEtapa = char.Parse(dRGEtapa.EstadoEtapa);
        }
        return eGEtapa;
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string codigoProyecto, byte numeroEtapa)
    {
        EGEtapa eGEtapa = new EGEtapa();
        DTOGEtapa dTOGEtapa = aDGEtapa.Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(codigoProyecto, numeroEtapa);
        foreach (DTOGEtapa.GEtapaRow dRGEtapa in dTOGEtapa.GEtapa.Rows)
        {
            eGEtapa = new EGEtapa();
            eGEtapa.CodigoEtapa = dRGEtapa.CodigoEtapa;
            eGEtapa.CodigoProyecto = dRGEtapa.CodigoProyecto;
            eGEtapa.NumeroEtapa = dRGEtapa.NumeroEtapa;
            eGEtapa.FechaInicioEtapa = dRGEtapa.FechaInicioEtapa;
            eGEtapa.FechaDefinidaEtapa = dRGEtapa.FechaDefinidaEtapa;
            eGEtapa.FechaFinEtapa = dRGEtapa.FechaFinEtapa;
            eGEtapa.EstadoEtapa = char.Parse(dRGEtapa.EstadoEtapa);
        }
        return eGEtapa;
    }
    public void Actualizar_GEtapa_A_EstadoEtapa(int codigoEtapa, char estadoEtapa)
    {
        aDGEtapa.Actualizar_GEtapa_A_EstadoEtapa(codigoEtapa, estadoEtapa);
    }
    public int Obtener_GEtapa_O_SiguienteCodigoEtapa()
    {
        object ultimoCodigo = aDGEtapa.Obtener_GEtapa_O_SiguienteCodigoEtapa();
        return (int)ultimoCodigo + 1;        
    }
    #endregion
}