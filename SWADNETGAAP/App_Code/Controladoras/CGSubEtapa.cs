using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
/// <summary>
/// Descripción breve de CGSubEtapa
/// </summary>
public class CGSubEtapa
{
    #region Atributos
    private ADGSubEtapa adGSubEtapa;
    #endregion

    #region Constructor
    public CGSubEtapa()
    {
        adGSubEtapa = new ADGSubEtapa();
    }
    #endregion

    #region Métodos públicos
    public void Insertar_GSubEtapa_I(EGSubEtapa eGSubEtapa)
    {
        adGSubEtapa.Insertar_GSubEtapa_I(eGSubEtapa);
    }
    public List<EGSubEtapa> Obtener_GSubEtapa_O_CodigoEtapa(int CodigoEtapa)
    {
        EGSubEtapa eGSubEtapa;
        List<EGSubEtapa> lstEGSubEtapa = new List<EGSubEtapa>();
        DTOGSubEtapa dtoGSubEtapa = adGSubEtapa.Obtener_GSubEtapa_O_CodigoEtapa(CodigoEtapa);
        foreach (DTOGSubEtapa.GSubEtapaRow dgGSubEtapa in dtoGSubEtapa.GSubEtapa.Rows)
        {
            eGSubEtapa = new EGSubEtapa();
            eGSubEtapa.CodigoSubEtapa = dgGSubEtapa.CodigoSubEtapa;
            eGSubEtapa.CodigoEtapa = dgGSubEtapa.CodigoEtapa;
            eGSubEtapa.NumeroSubEtapa = dgGSubEtapa.NumeroSubEtapa;
            eGSubEtapa.FechaInicioSubEtapa = dgGSubEtapa.FechaInicioSubEtapa;
            eGSubEtapa.FechaDefinidaSubEtapa = dgGSubEtapa.FechaDefinidaSubEtapa;
            eGSubEtapa.FechaFinSubEtapa = dgGSubEtapa.FechaFinSubEtapa;
            eGSubEtapa.EstadoSubEtapa = char.Parse(dgGSubEtapa.EstadoSubEtapa);
            lstEGSubEtapa.Add(eGSubEtapa);
        }
        return lstEGSubEtapa;
    }
    public int Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa()
    {
        Object res = adGSubEtapa.Obtener_GSubEtapa_O_UltimoCodigoSubEtapa();
        if (res.ToString().IsNullOrEmpty())
            return 1;
        else
            return (int)res + 1;
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(int CodigoSubEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        DTOGSubEtapa dTOGSubEtapa = adGSubEtapa.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(CodigoSubEtapa);
        foreach (DTOGSubEtapa.GSubEtapaRow dgGSubEtapa in dTOGSubEtapa.GSubEtapa.Rows)
        {
            eGSubEtapa = new EGSubEtapa();
            eGSubEtapa.CodigoSubEtapa = dgGSubEtapa.CodigoSubEtapa;
            eGSubEtapa.CodigoEtapa = dgGSubEtapa.CodigoEtapa;
            eGSubEtapa.CodigoUsuarioFirma = dgGSubEtapa.CodigoUsuarioFirma;
            eGSubEtapa.NumeroSubEtapa = dgGSubEtapa.NumeroSubEtapa;
            eGSubEtapa.FechaInicioSubEtapa = dgGSubEtapa.FechaInicioSubEtapa;
            eGSubEtapa.FechaDefinidaSubEtapa = dgGSubEtapa.FechaDefinidaSubEtapa;
            eGSubEtapa.FechaFinSubEtapa = dgGSubEtapa.FechaFinSubEtapa;
            eGSubEtapa.EstadoSubEtapa = char.Parse(dgGSubEtapa.EstadoSubEtapa);
        }
        return eGSubEtapa;
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int CodigoEtapa, byte NumeroSubEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        DTOGSubEtapa dTOGSubEtapa = adGSubEtapa.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(CodigoEtapa, NumeroSubEtapa);
        foreach (DTOGSubEtapa.GSubEtapaRow dgGSubEtapa in dTOGSubEtapa.GSubEtapa.Rows)
        {
            eGSubEtapa = new EGSubEtapa();
            eGSubEtapa.CodigoSubEtapa = dgGSubEtapa.CodigoSubEtapa;
            eGSubEtapa.CodigoEtapa = dgGSubEtapa.CodigoEtapa;
            eGSubEtapa.CodigoUsuarioFirma = dgGSubEtapa.CodigoUsuarioFirma;
            eGSubEtapa.NumeroSubEtapa = dgGSubEtapa.NumeroSubEtapa;
            eGSubEtapa.FechaInicioSubEtapa = dgGSubEtapa.FechaInicioSubEtapa;
            eGSubEtapa.FechaDefinidaSubEtapa = dgGSubEtapa.FechaDefinidaSubEtapa;
            eGSubEtapa.FechaFinSubEtapa = dgGSubEtapa.FechaFinSubEtapa;
            eGSubEtapa.EstadoSubEtapa = char.Parse(dgGSubEtapa.EstadoSubEtapa);
        }
        return eGSubEtapa;
    }
    public void Actualizar_GSubEtapa_A_EstadoSubEtapa(int CodigoSubEtapa, char EstadoSubEtapa)
    {
        adGSubEtapa.Actualizar_GSubEtapa_A_EstadoSubEtapa(CodigoSubEtapa, EstadoSubEtapa);
    }
    #endregion
}