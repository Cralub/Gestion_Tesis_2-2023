using System;

/// <summary>
/// Descripción breve de CGUsuario
/// </summary>
public class CGUsuario
{
    #region Atributo
    private ADGUsuario adGUsuario;
    #endregion

    #region Constructor
    public CGUsuario()
    {
        adGUsuario = new ADGUsuario();
    }
    #endregion

    #region Métodos públicos
    public void Insertar_GUsuario_I(EGUsuario eGUsuario)
    {
        adGUsuario.Insertar_GUsuario_I(eGUsuario);
    }
    public EGUsuario Obtener_GUsuario_O_CodigoUsuario(string CodigoUsuario)
    {
        EGUsuario eGUsuario = new EGUsuario();
        DTOGUsuario dtoGUsuario = adGUsuario.Obtener_GUsuario_O_CodigoUsuario(CodigoUsuario);
        foreach (DTOGUsuario.GUsuarioRow drGUsuario in dtoGUsuario.GUsuario.Rows)
        {
            eGUsuario.CodigoUsuario = drGUsuario.CodigoUsuario;
            eGUsuario.SedeUsuario = drGUsuario.SedeUsuario;
        }
        return eGUsuario;
    }
    public void Actualizar_GUsuario_A(EGUsuario eGUsuario)
    {
        adGUsuario.Actualizar_GUsuario_A(eGUsuario);
    }
    #endregion
}