using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción resumida de CGCelular
/// </summary>
public class CGCelular
{
    #region Atributos
    private ADGCelular adGCelular;
    #endregion

    #region Constructor
    public CGCelular()
    {
        adGCelular = new ADGCelular();
    }
    #endregion

    #region Métodos públicos
    public int Obtener_GCelular_O_SiguienteCodigoCelular()
    {
        Object res = adGCelular.Obtener_GCelular_O_UltimoCodigoCelular();
        if (res.ToString().IsNullOrEmpty())
            return 1;
        else
            return (int)res + 1;
    }
    public void Insertar_GCelular_I(EGCelular celular)
    {
        adGCelular.Insertar_GCelular_I(celular);
    }
    public EGCelular Obtener_GCelular_O(int codigoCelular)
    {
        EGCelular celular = null;
        DTOGCelular dtoGCelular = adGCelular.Obtener_GCelular_O(codigoCelular);
        foreach (DTOGCelular.GCelularRow gCelular in dtoGCelular.GCelular.Rows)
        {
            celular = new EGCelular();
            celular.CodigoCelular = gCelular.CodigoCelular;
            celular.CodigoUsuario = gCelular.CodigoUsuario;
            celular.NumeroCelular = gCelular.NumeroCelular;
            celular.CodigoAreaCelular = gCelular.CodigoAreaCelular;
            celular.Estado = gCelular.Estado;
            celular.FechaRegistro = gCelular.FechaRegistro;
            celular.FechaModificacion = gCelular.FechaModificacion;
        }
        return celular;
    }
    public void Actualizar_GCelular_A(EGCelular celular)
    {
        adGCelular.Actualizar_GCelular_A(celular);
    }
    public void Eliminar_GCelular_E(int codigoCelular)
    {
        adGCelular.Eliminar_GCelular_E(codigoCelular);
    }
    #endregion
}