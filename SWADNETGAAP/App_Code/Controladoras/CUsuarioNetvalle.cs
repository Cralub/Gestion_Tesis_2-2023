/// <summary>
/// Descripción breve de CUsuarioNetvalle
/// </summary>
public class CUsuarioNetvalle
{
    #region Atributos
    private ADUsuarioNetvalle adUsuarioNetvalle;
    #endregion

    #region Constructor
    public CUsuarioNetvalle()
    {
        adUsuarioNetvalle = new ADUsuarioNetvalle();
    }
    #endregion

    #region Métodos públicos
    public EUsuarioNetvalle Obtener_UsuarioNetvalle_O_CodigoUsuario(string CodigoUsuario)
    {
        EUsuarioNetvalle eUsuarioNetvalle = new EUsuarioNetvalle();
        DTOGUsuarioNetvalle dtoUsuarioNetvalle = adUsuarioNetvalle.Obtener_UsuarioNetvalle_O_CodigoUsuario(CodigoUsuario);
        foreach (DTOGUsuarioNetvalle.UsuarioNetvalleRow dgUsuarioNetvalle in dtoUsuarioNetvalle.UsuarioNetvalle.Rows)
        {
            eUsuarioNetvalle = new EUsuarioNetvalle();
            eUsuarioNetvalle.CodigoUsuarioNetvalle = dgUsuarioNetvalle.CodigoUsuarioNetvalle.TrimEnd();
            eUsuarioNetvalle.NombresUsuarioNetvalle = dgUsuarioNetvalle.NombresUsuarioNetvalle.TrimEnd();
            eUsuarioNetvalle.ApellidosUsuarioNetvalle = dgUsuarioNetvalle.ApellidosUsuarioNetvalle.TrimEnd();
            eUsuarioNetvalle.RolUsuarioNetvalle = dgUsuarioNetvalle.RolUsuarioNetvalle.TrimEnd();
            eUsuarioNetvalle.CarreraUsuarioNetvalle = dgUsuarioNetvalle.CarreraUsuarioNetvalle.TrimEnd();
            eUsuarioNetvalle.FacultadUsuarioNetvalle = dgUsuarioNetvalle.FacultadUsuarioNetvalle.TrimEnd();
            eUsuarioNetvalle.SedeUsuarioNetvalle = dgUsuarioNetvalle.SedeUsuarioNetvalle.TrimEnd();
            eUsuarioNetvalle.DireccionUsuarioNetvalle = dgUsuarioNetvalle.DireccionUsuarioNetvalle.TrimEnd();
            eUsuarioNetvalle.DireccionTrabajoUsuarioNetvalle = dgUsuarioNetvalle.DireccionTrabajoUsuarioNetvalle.TrimEnd();
            eUsuarioNetvalle.CelularUsuarioNetvalle = dgUsuarioNetvalle.CelularUsuarioNetvalle.TrimEnd();
        }
        return eUsuarioNetvalle;
    }
    #endregion
}