using System.Collections.Generic;

/// <summary>
/// Descripción breve de CGUsuarioProyecto
/// </summary>
public class CGUsuarioProyecto
{
    #region Atributos
    private ADGUsuarioProyecto aDGUsuarioProyecto;
    #endregion
    #region Constructor
    public CGUsuarioProyecto()
    {
        aDGUsuarioProyecto = new ADGUsuarioProyecto();
    }
    #endregion
    #region Métodos públicos
    public void Insertar_GUsuarioProyecto_I(EGUsuarioProyecto eGUsuarioProyecto)
    {
        aDGUsuarioProyecto.Insertar_GUsuarioProyecto_I(eGUsuarioProyecto);
    }
    public int Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto()
    {
        object ultimoCodigo = aDGUsuarioProyecto.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
        return int.Parse(ultimoCodigo.ToString()) + 1;
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoProyecto(string codigoProyecto)
    {


        EGUsuarioProyecto eGUsuarioProyecto;
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        DTOGUsuarioProyecto dTOGUsuarioProyecto = aDGUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto);
        foreach (DTOGUsuarioProyecto.GUsuarioProyectoRow dRGUsuarioProyecto in dTOGUsuarioProyecto.GUsuarioProyecto.Rows)
        {
            eGUsuarioProyecto = new EGUsuarioProyecto();
            eGUsuarioProyecto.CodigoUsuarioProyecto = dRGUsuarioProyecto.CodigoUsuarioProyecto;
            eGUsuarioProyecto.CodigoUsuario = dRGUsuarioProyecto.CodigoUsuario;
            eGUsuarioProyecto.CodigoProyecto = dRGUsuarioProyecto.CodigoProyecto;
            eGUsuarioProyecto.CodigoRol = dRGUsuarioProyecto.CodigoRol;
            eGUsuarioProyecto.EstadoUsuarioProyecto = char.Parse(dRGUsuarioProyecto.EstadoUsuarioProyecto);
            lstEGUsuarioProyecto.Add(eGUsuarioProyecto);
        }
        return lstEGUsuarioProyecto;
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoUsuario(string codigoUsuario)
    {
        EGUsuarioProyecto eGUsuarioProyecto;
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        DTOGUsuarioProyecto dTOGUsuarioProyecto = aDGUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoUsuario(codigoUsuario);
        foreach (DTOGUsuarioProyecto.GUsuarioProyectoRow dRGUsuarioProyecto in dTOGUsuarioProyecto.GUsuarioProyecto.Rows)
        {
            eGUsuarioProyecto = new EGUsuarioProyecto();
            eGUsuarioProyecto.CodigoUsuarioProyecto = dRGUsuarioProyecto.CodigoUsuarioProyecto;
            eGUsuarioProyecto.CodigoUsuario = dRGUsuarioProyecto.CodigoUsuario;
            eGUsuarioProyecto.CodigoProyecto = dRGUsuarioProyecto.CodigoProyecto;
            eGUsuarioProyecto.CodigoRol = dRGUsuarioProyecto.CodigoRol;
            eGUsuarioProyecto.EstadoUsuarioProyecto = char.Parse(dRGUsuarioProyecto.EstadoUsuarioProyecto);
            lstEGUsuarioProyecto.Add(eGUsuarioProyecto);
        }
        return lstEGUsuarioProyecto;
    }
    public EGUsuarioProyecto Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(string CodigoUsuario, string CodigoProyecto)
    {
        EGUsuarioProyecto eGUsuarioProyecto = new EGUsuarioProyecto();
        DTOGUsuarioProyecto dTOGUsuarioProyecto = aDGUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(CodigoUsuario, CodigoProyecto);
        foreach (DTOGUsuarioProyecto.GUsuarioProyectoRow dRGUsuarioProyecto in dTOGUsuarioProyecto.GUsuarioProyecto.Rows)
        {
            eGUsuarioProyecto = new EGUsuarioProyecto();
            eGUsuarioProyecto.CodigoUsuarioProyecto = dRGUsuarioProyecto.CodigoUsuarioProyecto;
            eGUsuarioProyecto.CodigoUsuario = dRGUsuarioProyecto.CodigoUsuario;
            eGUsuarioProyecto.CodigoProyecto = dRGUsuarioProyecto.CodigoProyecto;
            eGUsuarioProyecto.CodigoRol = dRGUsuarioProyecto.CodigoRol;
            eGUsuarioProyecto.EstadoUsuarioProyecto = char.Parse(dRGUsuarioProyecto.EstadoUsuarioProyecto);
        }
        return eGUsuarioProyecto;
    }
    public void Actualizar_GUsuarioProyecto_A(EGUsuarioProyecto eGUsuarioProyecto)
    {
        aDGUsuarioProyecto.Actualizar_GUsuarioProyecto_A(eGUsuarioProyecto);
    }
    public void Eliminar_GUsuarioProyecto_E(int codigoUsuarioProyecto)
    {
        aDGUsuarioProyecto.Eliminar_UsuarioProyecto_E(codigoUsuarioProyecto);
    }

    #endregion
}