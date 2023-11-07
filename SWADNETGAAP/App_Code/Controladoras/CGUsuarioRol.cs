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
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoRol(string codigoRol)
    {
        EGUsuarioRol eGUsuarioRol = new EGUsuarioRol();
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        DTOGUsuarioRol dTOGUsuarioRol = aDGUsuarioRol.Obtener_GUsuarioRol_O_CodigoRol(codigoRol);
        foreach (DTOGUsuarioRol.GUsuarioRolRow dRGUsuarioRow in dTOGUsuarioRol.GUsuarioRol.Rows)
        {
            eGUsuarioRol = new EGUsuarioRol();
            eGUsuarioRol.CodigoUsuarioRol = dRGUsuarioRow.CodigoUsuarioRol;
            eGUsuarioRol.CodigoUsuario = dRGUsuarioRow.CodigoUsuario;
            eGUsuarioRol.CodigoRol = dRGUsuarioRow.CodigoRol;
            lstEGUsuarioRol.Add(eGUsuarioRol);
        }
        return lstEGUsuarioRol;
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoUsuario(string codigoUsuario)
    {
        EGUsuarioRol eGUsuarioRol = new EGUsuarioRol();
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        DTOGUsuarioRol dTOGUsuarioRol = aDGUsuarioRol.Obtener_GUsuarioRol_O_CodigoUsuario(codigoUsuario);
        foreach (DTOGUsuarioRol.GUsuarioRolRow dRGUsuarioRow in dTOGUsuarioRol.GUsuarioRol.Rows)
        {
            eGUsuarioRol = new EGUsuarioRol();
            eGUsuarioRol.CodigoUsuarioRol = dRGUsuarioRow.CodigoUsuarioRol;
            eGUsuarioRol.CodigoUsuario = dRGUsuarioRow.CodigoUsuario;
            eGUsuarioRol.CodigoRol = dRGUsuarioRow.CodigoRol;
            lstEGUsuarioRol.Add(eGUsuarioRol);
        }
        return lstEGUsuarioRol;
    }
    public EGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string codigoUsuario, string codigoRol)
    {
        EGUsuarioRol eGUsuarioRol = new EGUsuarioRol();
        DTOGUsuarioRol dTOGUsuarioRol = aDGUsuarioRol.Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(codigoUsuario, codigoRol);
        foreach (DTOGUsuarioRol.GUsuarioRolRow dRGUsuarioRow in dTOGUsuarioRol.GUsuarioRol.Rows)
        {
            eGUsuarioRol = new EGUsuarioRol();
            eGUsuarioRol.CodigoUsuarioRol = dRGUsuarioRow.CodigoUsuarioRol;
            eGUsuarioRol.CodigoUsuario = dRGUsuarioRow.CodigoUsuario;
            eGUsuarioRol.CodigoRol = dRGUsuarioRow.CodigoRol;
        }
        return eGUsuarioRol;
    }
    public int Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol()
    {
        object ultimoCodigo = aDGUsuarioRol.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
        return int.Parse(ultimoCodigo.ToString()) + 1;
    }
    public void Actualizar_GUsuarioRol_A(EGUsuarioRol eGUsuarioRol)
    {
        aDGUsuarioRol.Actualizar_GUsuarioRol_A(eGUsuarioRol);
    }
    public void Eliminar_GUsuarioRol_E(int codigoUsuarioRol)
    {
        aDGUsuarioRol.Eliminar_GUsuarioRol_E(codigoUsuarioRol);
    }
    #endregion

}