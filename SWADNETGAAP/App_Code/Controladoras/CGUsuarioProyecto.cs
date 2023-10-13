using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;

/// <summary>
/// Descripción breve de CGUsuarioProyecto
/// </summary>
public class CGUsuarioProyecto
{
    #region Atributos
    private ADGUsuarioProyecto adGUsuarioProyecto;
    #endregion
    #region Constructor
    public CGUsuarioProyecto()
    {
        adGUsuarioProyecto = new ADGUsuarioProyecto();
    }
    #endregion
    #region Métodos públicos
    public void Insertar_GUsuarioProyecto_I(EGUsuarioProyecto eGUsuarioProyecto)
    {
        adGUsuarioProyecto.Insertar_GUsuarioProyecto_I(eGUsuarioProyecto);
    }
    public int Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto()
    {
        Object res = adGUsuarioProyecto.Obtener_GUsuarioProyecto_O_UltimoCodigoUsuarioProyecto();
        if (res.ToString().IsNullOrEmpty())
            return 1;
        else
            return (int)res + 1;
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoProyecto(string CodigoProyecto)
    {
        

        EGUsuarioProyecto eGUsuarioProyecto;
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        DTOGUsuarioProyecto dTOGUsuarioProyecto = adGUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoProyecto(CodigoProyecto);
        foreach (DTOGUsuarioProyecto.GUsuarioProyectoRow drEGUsuarioProyecto in dTOGUsuarioProyecto.GUsuarioProyecto.Rows)
        {
            eGUsuarioProyecto = new EGUsuarioProyecto();
            eGUsuarioProyecto.CodigoUsuarioProyecto = drEGUsuarioProyecto.CodigoUsuarioProyecto;
            eGUsuarioProyecto.CodigoUsuario = drEGUsuarioProyecto.CodigoUsuario;
            eGUsuarioProyecto.CodigoProyecto = drEGUsuarioProyecto.CodigoProyecto;
            eGUsuarioProyecto.CodigoRol = drEGUsuarioProyecto.CodigoRol;
            eGUsuarioProyecto.EstadoUsuarioProyecto = char.Parse(drEGUsuarioProyecto.EstadoUsuarioProyecto);
            lstEGUsuarioProyecto.Add(eGUsuarioProyecto);
        }
        return lstEGUsuarioProyecto;
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoUsuario(string CodigoUsuario)
    {
        EGUsuarioProyecto eGUsuarioProyecto;
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        DTOGUsuarioProyecto dTOGUsuarioProyecto = adGUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoUsuario(CodigoUsuario);
        foreach (DTOGUsuarioProyecto.GUsuarioProyectoRow drEGUsuarioProyecto in dTOGUsuarioProyecto.GUsuarioProyecto.Rows)
        {
            eGUsuarioProyecto = new EGUsuarioProyecto();
            eGUsuarioProyecto.CodigoUsuarioProyecto = drEGUsuarioProyecto.CodigoUsuarioProyecto;
            eGUsuarioProyecto.CodigoUsuario = drEGUsuarioProyecto.CodigoUsuario;
            eGUsuarioProyecto.CodigoProyecto = drEGUsuarioProyecto.CodigoProyecto;
            eGUsuarioProyecto.CodigoRol = drEGUsuarioProyecto.CodigoRol;
            eGUsuarioProyecto.EstadoUsuarioProyecto = char.Parse(drEGUsuarioProyecto.EstadoUsuarioProyecto);
            lstEGUsuarioProyecto.Add(eGUsuarioProyecto);
        }
        return lstEGUsuarioProyecto;
    }
    public EGUsuarioProyecto Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(string CodigoUsuario, string CodigoProyecto)
    {
        EGUsuarioProyecto eGUsuarioProyecto = new EGUsuarioProyecto();
        DTOGUsuarioProyecto dtoGUsuarioProyecto = adGUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(CodigoUsuario, CodigoProyecto);
        foreach (DTOGUsuarioProyecto.GUsuarioProyectoRow dgGUsuarioProyecto in dtoGUsuarioProyecto.GUsuarioProyecto.Rows)
        {
            eGUsuarioProyecto = new EGUsuarioProyecto();
            eGUsuarioProyecto.CodigoUsuarioProyecto = dgGUsuarioProyecto.CodigoUsuarioProyecto;
            eGUsuarioProyecto.CodigoUsuario = dgGUsuarioProyecto.CodigoUsuario;
            eGUsuarioProyecto.CodigoProyecto = dgGUsuarioProyecto.CodigoProyecto;
            eGUsuarioProyecto.CodigoRol = dgGUsuarioProyecto.CodigoRol;
            eGUsuarioProyecto.EstadoUsuarioProyecto = char.Parse(dgGUsuarioProyecto.EstadoUsuarioProyecto);
        }
        return eGUsuarioProyecto;
    }
     public void Actualizar_GUsuarioProyecto_A(EGUsuarioProyecto eGUsuarioProyecto)
    {
        adGUsuarioProyecto.Actualizar_GUsuarioProyecto_A(eGUsuarioProyecto);
    }


    #endregion
}