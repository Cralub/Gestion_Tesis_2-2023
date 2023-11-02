using System.Collections.Generic;
/// <summary>
/// Descripción breve de CGSubEtapa
/// </summary>
public class CGSubEtapa
{
    #region Atributos
    private ADGSubEtapa aDGSubEtapa;
    #endregion

    #region Constructor
    public CGSubEtapa()
    {
        aDGSubEtapa = new ADGSubEtapa();
    }
    #endregion

    #region Métodos públicos
    public void Insertar_GSubEtapa_I(EGSubEtapa eGSubEtapa)
    {
        aDGSubEtapa.Insertar_GSubEtapa_I(eGSubEtapa);
    }
    public List<EGSubEtapa> Obtener_GSubEtapa_O_CodigoEtapa(int codigoEtapa)
    {
        EGSubEtapa eGSubEtapa;
        List<EGSubEtapa> lstEGSubEtapa = new List<EGSubEtapa>();
        DTOGSubEtapa dTOGSubEtapa = aDGSubEtapa.Obtener_GSubEtapa_O_CodigoEtapa(codigoEtapa);
        foreach (DTOGSubEtapa.GSubEtapaRow dRGSubEtapa in dTOGSubEtapa.GSubEtapa.Rows)
        {
            eGSubEtapa = new EGSubEtapa();
            eGSubEtapa.CodigoSubEtapa = dRGSubEtapa.CodigoSubEtapa;
            eGSubEtapa.CodigoEtapa = dRGSubEtapa.CodigoEtapa;
            eGSubEtapa.NumeroSubEtapa = dRGSubEtapa.NumeroSubEtapa;
            eGSubEtapa.FechaInicioSubEtapa = dRGSubEtapa.FechaInicioSubEtapa;
            eGSubEtapa.FechaDefinidaSubEtapa = dRGSubEtapa.FechaDefinidaSubEtapa;
            eGSubEtapa.FechaFinSubEtapa = dRGSubEtapa.FechaFinSubEtapa;
            eGSubEtapa.EstadoSubEtapa = char.Parse(dRGSubEtapa.EstadoSubEtapa);
            lstEGSubEtapa.Add(eGSubEtapa);
        }
        return lstEGSubEtapa;
    }
    public int Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa()
    {
        object ultimoCodigo = aDGSubEtapa.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
        return (int)ultimoCodigo + 1;
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(int codigoSubEtapa, char estadoSubEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        DTOGSubEtapa dTOGSubEtapa = aDGSubEtapa.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(codigoSubEtapa , estadoSubEtapa);
        foreach (DTOGSubEtapa.GSubEtapaRow dRGSubEtapa in dTOGSubEtapa.GSubEtapa.Rows)
        {
            eGSubEtapa = new EGSubEtapa();
            eGSubEtapa.CodigoSubEtapa = dRGSubEtapa.CodigoSubEtapa;
            eGSubEtapa.CodigoEtapa = dRGSubEtapa.CodigoEtapa;
            eGSubEtapa.CodigoUsuarioFirma = dRGSubEtapa.CodigoUsuarioFirma;
            eGSubEtapa.NumeroSubEtapa = dRGSubEtapa.NumeroSubEtapa;
            eGSubEtapa.FechaInicioSubEtapa = dRGSubEtapa.FechaInicioSubEtapa;
            eGSubEtapa.FechaDefinidaSubEtapa = dRGSubEtapa.FechaDefinidaSubEtapa;
            eGSubEtapa.FechaFinSubEtapa = dRGSubEtapa.FechaFinSubEtapa;
            eGSubEtapa.EstadoSubEtapa = char.Parse(dRGSubEtapa.EstadoSubEtapa);
        }
        return eGSubEtapa;
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int codigoEtapa, byte numeroSubEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        DTOGSubEtapa dTOGSubEtapa = aDGSubEtapa.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(codigoEtapa, numeroSubEtapa);
        foreach (DTOGSubEtapa.GSubEtapaRow dRGSubEtapa in dTOGSubEtapa.GSubEtapa.Rows)
        {
            eGSubEtapa = new EGSubEtapa();
            eGSubEtapa.CodigoSubEtapa = dRGSubEtapa.CodigoSubEtapa;
            eGSubEtapa.CodigoEtapa = dRGSubEtapa.CodigoEtapa;
            eGSubEtapa.CodigoUsuarioFirma = dRGSubEtapa.CodigoUsuarioFirma;
            eGSubEtapa.NumeroSubEtapa = dRGSubEtapa.NumeroSubEtapa;
            eGSubEtapa.FechaInicioSubEtapa = dRGSubEtapa.FechaInicioSubEtapa;
            eGSubEtapa.FechaDefinidaSubEtapa = dRGSubEtapa.FechaDefinidaSubEtapa;
            eGSubEtapa.FechaFinSubEtapa = dRGSubEtapa.FechaFinSubEtapa;
            eGSubEtapa.EstadoSubEtapa = char.Parse(dRGSubEtapa.EstadoSubEtapa);
        }
        return eGSubEtapa;
    }
    public void Actualizar_GSubEtapa_A_EstadoSubEtapa(int codigoSubEtapa, char estadoSubEtapa)
    {
        aDGSubEtapa.Actualizar_GSubEtapa_A_EstadoSubEtapa(codigoSubEtapa, estadoSubEtapa);
    }
    #endregion
}