/// <summary>
/// Descripción breve de CUsuarioNetvalle
/// </summary>
public class CUsuarioNetvalle
{
    #region Atributos
    private ADUsuarioNetvalle aDUsuarioNetvalle;
    #endregion

    #region Constructor
    public CUsuarioNetvalle()
    {
        aDUsuarioNetvalle = new ADUsuarioNetvalle();
    }
    #endregion

    #region Métodos públicos
    public EUsuarioNetvalle Obtener_UsuarioNetvalle_O_CodigoUsuario(string codigoUsuario)
    {
        EUsuarioNetvalle eUsuarioNetvalle = new EUsuarioNetvalle();
        DTOGUsuarioNetvalle dTOUsuarioNetvalle = aDUsuarioNetvalle.Obtener_UsuarioNetvalle_O_CodigoUsuario(codigoUsuario);
        foreach (DTOGUsuarioNetvalle.UsuarioNetvalleRow dRUsuarioNetvalle in dTOUsuarioNetvalle.UsuarioNetvalle.Rows)
        {
            eUsuarioNetvalle = new EUsuarioNetvalle();
            eUsuarioNetvalle.CodigoUsuarioNetvalle = dRUsuarioNetvalle.CodigoUsuarioNetvalle.TrimEnd();
            eUsuarioNetvalle.NombreCompletoUsuarioNetvalle = dRUsuarioNetvalle.CodigoUsuarioNetvalle.TrimEnd();
            eUsuarioNetvalle.RolUsuarioNetvalle = dRUsuarioNetvalle.RolUsuarioNetvalle.TrimEnd();
            eUsuarioNetvalle.CarreraUsuarioNetvalle = dRUsuarioNetvalle.CarreraUsuarioNetvalle.TrimEnd();
            eUsuarioNetvalle.FacultadUsuarioNetvalle = dRUsuarioNetvalle.FacultadUsuarioNetvalle.TrimEnd();
            eUsuarioNetvalle.SedeUsuarioNetvalle = dRUsuarioNetvalle.SedeUsuarioNetvalle.TrimEnd();
            eUsuarioNetvalle.DireccionUsuarioNetvalle = dRUsuarioNetvalle.DireccionUsuarioNetvalle.TrimEnd();
            eUsuarioNetvalle.DireccionTrabajoUsuarioNetvalle = dRUsuarioNetvalle.DireccionTrabajoUsuarioNetvalle.TrimEnd();            
        }
        return eUsuarioNetvalle;
    }
    #endregion
}