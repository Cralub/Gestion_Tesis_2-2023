using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;

/// <summary>
/// Descripción breve de CGUsuarioRol
/// </summary>
public class CGUsuarioRol
{
    #region Atributo
    private ADGUsuarioRol adGUsuarioRol;
    #endregion

    #region Constructor
    public CGUsuarioRol()
    {
        adGUsuarioRol = new ADGUsuarioRol();
    }
    #endregion

    #region Métodos públicos
    public void Insertar_GUsuarioRol_I(EGUsuarioRol eGUsuarioRol)
    {
        adGUsuarioRol.Insertar_GUsuarioRol_I(eGUsuarioRol);
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoRol(string CodigoRol)
    {
        EGUsuarioRol eGUsuarioRol = new EGUsuarioRol();
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        DTOGUsuarioRol dtoGUsuarioRol = adGUsuarioRol.Obtener_GUsuarioRol_O_CodigoRol(CodigoRol);
        foreach (DTOGUsuarioRol.GUsuarioRolRow gUsuarioRow in dtoGUsuarioRol.GUsuarioRol.Rows)
        {
            eGUsuarioRol = new EGUsuarioRol();
            eGUsuarioRol.CodigoUsuarioRol = gUsuarioRow.CodigoUsuarioRol;
            eGUsuarioRol.CodigoUsuario = gUsuarioRow.CodigoUsuario;
            eGUsuarioRol.CodigoRol = gUsuarioRow.CodigoRol;
            lstEGUsuarioRol.Add(eGUsuarioRol);
        }
        return lstEGUsuarioRol;
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoUsuario(string CodigoUsuario)
    {
        EGUsuarioRol eGUsuarioRol = new EGUsuarioRol();
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        DTOGUsuarioRol dtoGUsuarioRol = adGUsuarioRol.Obtener_GUsuarioRol_O_CodigoUsuario(CodigoUsuario);
        foreach (DTOGUsuarioRol.GUsuarioRolRow gUsuarioRow in dtoGUsuarioRol.GUsuarioRol.Rows)
        {
            eGUsuarioRol = new EGUsuarioRol();
            eGUsuarioRol.CodigoUsuarioRol = gUsuarioRow.CodigoUsuarioRol;
            eGUsuarioRol.CodigoUsuario = gUsuarioRow.CodigoUsuario;
            eGUsuarioRol.CodigoRol = gUsuarioRow.CodigoRol;
            lstEGUsuarioRol.Add(eGUsuarioRol);
        }
        return lstEGUsuarioRol;
    }
    public EGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string CodigoUsuario, string CodigoRol)
    {
        EGUsuarioRol eGUsuarioRol = new EGUsuarioRol();
        DTOGUsuarioRol dtoGUsuarioRol = adGUsuarioRol.Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(CodigoUsuario, CodigoRol);
        foreach (DTOGUsuarioRol.GUsuarioRolRow gUsuarioRow in dtoGUsuarioRol.GUsuarioRol.Rows)
        {
            eGUsuarioRol = new EGUsuarioRol();
            eGUsuarioRol.CodigoUsuarioRol = gUsuarioRow.CodigoUsuarioRol;
            eGUsuarioRol.CodigoUsuario = gUsuarioRow.CodigoUsuario;
            eGUsuarioRol.CodigoRol = gUsuarioRow.CodigoRol;
        }
        return eGUsuarioRol;
    }
    public int Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol()
    {
        Object res = adGUsuarioRol.Obtener_GUsuarioRol_O_UltimoCodigoUsuarioRol();
        if (res.ToString().IsNullOrEmpty())
            return 1;
        else
            return (int)res + 1;
    }
    public void Actualizar_GUsuarioRol_A(EGUsuarioRol eGUsuarioRol)
    {
        adGUsuarioRol.Actualizar_GUsuarioRol_A(eGUsuarioRol);
    }
    #endregion
}