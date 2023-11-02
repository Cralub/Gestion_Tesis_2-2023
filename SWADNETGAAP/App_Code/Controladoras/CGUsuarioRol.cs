using System.Collections.Generic;

/// <summary>
/// Descripción breve de CGUsuarioRol
/// </summary>
public class CGUsuarioRol
{
    #region Metodos privados
    private ADGUsuarioRol aDGUsuarioRol;
    #endregion
    #region Constructor
    public CGUsuarioRol()
    {
        aDGUsuarioRol = new ADGUsuarioRol();
    }
    #endregion
    #region Metodos publicos
    public void Insertar_GUsuarioRol_I(EGUsuarioRol eGUsuarioRol)
    {
        aDGUsuarioRol.Insertar_GUsuarioRol_I(eGUsuarioRol);
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoRol(string CodigoRol)
    {
        EGUsuarioRol eGUsuarioRol = new EGUsuarioRol();
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        DTOGUsuarioRol dtoGUsuarioRol = aDGUsuarioRol.Obtener_GUsuarioRol_O_CodigoRol(CodigoRol);
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
        DTOGUsuarioRol dtoGUsuarioRol = aDGUsuarioRol.Obtener_GUsuarioRol_O_CodigoUsuario(CodigoUsuario);
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
        DTOGUsuarioRol dtoGUsuarioRol = aDGUsuarioRol.Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(CodigoUsuario, CodigoRol);
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
        object res = aDGUsuarioRol.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
        return (int)res + 1;
    }
    public void Actualizar_GUsuarioRol_A(EGUsuarioRol eGUsuarioRol)
    {
        aDGUsuarioRol.Actualizar_GUsuarioRol_A(eGUsuarioRol);
    }
    public void Eliminar_GUsuarioRol_E(int codigoUsuarioRol)
    {
        aDGUsuarioRol.Eliminar_GusuarioRol_E(codigoUsuarioRol);
    }
    #endregion

}