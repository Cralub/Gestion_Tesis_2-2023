/// <summary>
/// Summary description for CGCelular
/// </summary>
public class CGCelular
{
    #region Atributo
    private ADGCelular aDGCelular;
    #endregion

    #region Constructor
    public CGCelular()
    {
        aDGCelular = new ADGCelular();
    }
    #endregion

    #region Métodos públicos
    public int Obtener_GCelular_O_SiguienteCodigoCelular()
    {
        object ultimoCodigo = aDGCelular.Obtener_GCelular_O_SiguienteCodigoCelular();
        return (int)ultimoCodigo + 1;
    }
    public void Insertar_GCelular_I(EGCelular eGCelular)
    {
        aDGCelular.Insertar_GCelular_I(eGCelular);
    }
    public EGCelular Obtener_GCelular_O_CodigoUsuario(string codigoUsuario)
    {
        EGCelular eGCelular = null;
        DTOGCelular dTOGCelular = aDGCelular.Obtener_GCelular_O_CodigoUsuario(codigoUsuario);
        foreach (DTOGCelular.GCelularRow dRGCelular in dTOGCelular.GCelular.Rows)
        {
            eGCelular = new EGCelular();
            eGCelular.CodigoCelular = dRGCelular.CodigoCelular;
            eGCelular.CodigoUsuario = dRGCelular.CodigoUsuario;
            eGCelular.NumeroCelular = dRGCelular.NumeroCelular;
            eGCelular.CodigoAreaCelular = dRGCelular.CodigoAreaCelular;
            eGCelular.Estado = dRGCelular.Estado;
            eGCelular.FechaRegistro = dRGCelular.FechaRegistro;
            eGCelular.FechaModificacion = dRGCelular.FechaModificacion;
        }
        return eGCelular;
    }
    public void Actualizar_GCelular_A(EGCelular eGCelular)
    {
        aDGCelular.Actualizar_GCelular_A(eGCelular);
    }
    public void Eliminar_GCelular_E(int codigoCelular)
    {
        aDGCelular.Eliminar_GCelular_E(codigoCelular);
    }
    #endregion
}