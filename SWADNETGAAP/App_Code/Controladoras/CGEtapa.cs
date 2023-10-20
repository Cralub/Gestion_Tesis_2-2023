using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
/// <summary>
/// Descripción breve de CGEtapa
/// </summary>
public class CGEtapa
{
    #region Atributos
    private ADGEtapa adGEtapa;
    #endregion

    #region Constructor
    public CGEtapa()
    {
        adGEtapa = new ADGEtapa();
    }
    #endregion

    #region Métodos públicos
    //public void Insertar_GEtapa_I(EGEtapa etapa)
    //{
    //    adGEtapa.Insertar_GEtapa_I(etapa);
    //}
    //public List<EGEtapa> Obtener_GEtapa_O_CodigoProyecto(string CodigoProyecto)
    //{
    //    EGEtapa eGEtapa;
    //    List<EGEtapa> lstEGEtapa = new List<EGEtapa>();
    //    DTOGEtapa dtoGEtapa = adGEtapa.Obtener_GEtapa_O_CodigoProyecto(CodigoProyecto);
    //    foreach (DTOGEtapa.GEtapaRow dgGEtapa in dtoGEtapa.GEtapa.Rows)
    //    {
    //        eGEtapa = new EGEtapa();
    //        eGEtapa.CodigoEtapa = dgGEtapa.CodigoEtapa;
    //        eGEtapa.CodigoProyecto = dgGEtapa.CodigoProyecto;
    //        eGEtapa.NumeroEtapa = dgGEtapa.NumeroEtapa;
    //        eGEtapa.FechaInicioEtapa = dgGEtapa.FechaInicioEtapa;
    //        eGEtapa.FechaDefinidaEtapa = dgGEtapa.FechaDefinidaEtapa;
    //        eGEtapa.FechaFinEtapa = dgGEtapa.FechaFinEtapa;
    //        eGEtapa.EstadoEtapa = char.Parse(dgGEtapa.EstadoEtapa);
    //        lstEGEtapa.Add(eGEtapa);
    //    }
    //    return lstEGEtapa;
    //}
    //public EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(string CodigoProyecto)
    //{
    //    EGEtapa eGEtapa = new EGEtapa();
    //    DTOGEtapa dTOGEtapa = adGEtapa.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(CodigoProyecto);
    //    foreach (DTOGEtapa.GEtapaRow dgGEtapa in dTOGEtapa.GEtapa.Rows)
    //    {
    //        eGEtapa = new EGEtapa();
    //        eGEtapa.CodigoEtapa = dgGEtapa.CodigoEtapa;
    //        eGEtapa.CodigoProyecto = dgGEtapa.CodigoProyecto;
    //        eGEtapa.NumeroEtapa = dgGEtapa.NumeroEtapa;
    //        eGEtapa.FechaInicioEtapa = dgGEtapa.FechaInicioEtapa;
    //        eGEtapa.FechaDefinidaEtapa = dgGEtapa.FechaDefinidaEtapa;
    //        eGEtapa.FechaFinEtapa = dgGEtapa.FechaFinEtapa;
    //        eGEtapa.EstadoEtapa = char.Parse(dgGEtapa.EstadoEtapa);
    //    }
    //    return eGEtapa;
    //}
    //public EGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string CodigoProyecto, byte NumeroEtapa)
    //{
    //    EGEtapa eGEtapa = new EGEtapa();
    //    DTOGEtapa dTOGEtapa = adGEtapa.Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(CodigoProyecto, NumeroEtapa);
    //    foreach (DTOGEtapa.GEtapaRow dgGEtapa in dTOGEtapa.GEtapa.Rows)
    //    {
    //        eGEtapa = new EGEtapa();
    //        eGEtapa.CodigoEtapa = dgGEtapa.CodigoEtapa;
    //        eGEtapa.CodigoProyecto = dgGEtapa.CodigoProyecto;
    //        eGEtapa.NumeroEtapa = dgGEtapa.NumeroEtapa;
    //        eGEtapa.FechaInicioEtapa = dgGEtapa.FechaInicioEtapa;
    //        eGEtapa.FechaDefinidaEtapa = dgGEtapa.FechaDefinidaEtapa;
    //        eGEtapa.FechaFinEtapa = dgGEtapa.FechaFinEtapa;
    //        eGEtapa.EstadoEtapa = char.Parse(dgGEtapa.EstadoEtapa);
    //    }
    //    return eGEtapa;
    //}
    //public void Actualizar_GEtapa_A_EstadoEtapa(int CodigoEtapa, char EstadoEtapa)
    //{
    //    adGEtapa.Actualizar_GEtapa_A_EstadoEtapa(CodigoEtapa, EstadoEtapa);
    //}
    //public int Obtener_GEtapa_O_SiguienteCodigoEtapa()
    //{
    //    Object res = adGEtapa.Obtener_GEtapa_O_UltimoCodigoEtapa();
    //    if (res.ToString().IsNullOrEmpty())        
    //        return 1;        
    //    else        
    //        return (int)res + 1;        
    //}
    #endregion
}