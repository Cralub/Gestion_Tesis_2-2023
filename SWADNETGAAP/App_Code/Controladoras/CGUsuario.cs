/// <summary>
/// Descripción breve de CGUsuario
/// </summary>
public class CGUsuario
{
    #region Atributos
    private ADGUsuario aDGUsuario;
    #endregion
    #region Constructor
    public CGUsuario()
    {
        aDGUsuario = new ADGUsuario();
    }
    #endregion
    #region Métodos públicos
    public void Insertar_GUsuario_I(EGUsuario eGUsuario)
    {
        aDGUsuario.Insertar_GUsuario_I(eGUsuario);
    }
   
    public EGUsuario Obtener_GUsuario_O_CodigoUsuario(string codigoUsuario)
    {
        EGUsuario eGUsuario = new EGUsuario();
        DTOGUsuario dTOGUsuario = aDGUsuario.Obtener_GUsuario_O_CodigoUsuario(codigoUsuario);
        foreach (DTOGUsuario.GUsuarioRow dRGUsuario in dTOGUsuario.GUsuario.Rows)
        {

            eGUsuario.CodigoUsuario = dRGUsuario.CodigoUsuario;
            eGUsuario.NombreCompletoUsuario = dRGUsuario.NombreCompletoUsuario;
            eGUsuario.SedeUsuario = dRGUsuario.SedeUsuario;
        }
        return eGUsuario;
    }
    public void Actualizar_GUsuario_A(EGUsuario eGUsuario)
    {
        aDGUsuario.Actualizar_GUsuario_A(eGUsuario);
    }
    #endregion
}