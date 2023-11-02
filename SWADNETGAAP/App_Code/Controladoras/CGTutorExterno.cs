using System.Collections.Generic;

/// <summary>
/// Summary description for CGTutorExterno
/// </summary>
public class CGTutorExterno
{
    #region Atributos
    private ADGTutorExterno adGTutorExterno;
    #endregion

    #region Constructor
    public CGTutorExterno()
    {
        adGTutorExterno = new ADGTutorExterno();
    }
    #endregion

    #region Métodos públicos
    public void Insertar_GTutorExterno_I(EGTutorExterno eGTutorExterno)
    {
        adGTutorExterno.Insertar_GTutorExterno_I(eGTutorExterno);
    }

    public void Actualizar_GTutorExterno_A(EGTutorExterno eGTutorExterno)
    {
        adGTutorExterno.Actualizar_GTutorExterno_A(eGTutorExterno);
    }

    public void Actualizar_GTutorExterno_A_Estado(int codigoTutorExterno, string estado)
    {
        adGTutorExterno.Actualizar_GTutorExterno_A_Estado(codigoTutorExterno, estado);
    }

    public List<EGTutorExterno> Obtener_GTutorExterno_O_Todo()
    {
        EGTutorExterno eGTutorExterno;
        List<EGTutorExterno> lstEGTutorExterno = new List<EGTutorExterno>();
        DTOGTutorExterno dtoGTutorExterno = (DTOGTutorExterno)adGTutorExterno.Obtener_GTutorExterno_O_Todo();
        foreach (DTOGTutorExterno.GTutorExternoRow drGTutorExterno in dtoGTutorExterno.GTutorExterno.Rows)
        {
            eGTutorExterno = new EGTutorExterno();
            eGTutorExterno.CodigoTutorExterno = int.Parse(drGTutorExterno.CodigoTutorExterno);
            eGTutorExterno.NombresTutorExterno = drGTutorExterno.NombresTutorExterno;
            eGTutorExterno.ApellidosTutorExterno = drGTutorExterno.ApellidosTutorExterno;
            eGTutorExterno.CarreraTutorExterno = drGTutorExterno.CarreraTutorExterno;
            eGTutorExterno.DescripcionTutorExterno = drGTutorExterno.DescripcionTutorExterno;
            eGTutorExterno.DireccionTrabajoTutorExterno = drGTutorExterno.DireccionTrabajoTutorExterno;
            eGTutorExterno.SedeTutorExterno= drGTutorExterno.SedeTutorExterno;
            eGTutorExterno.Estado = drGTutorExterno.Estado;
            eGTutorExterno.FechaModificacion = drGTutorExterno.FechaModificacion;
            eGTutorExterno.FechaRegistro= drGTutorExterno.FechaRegistro;

            lstEGTutorExterno.Add(eGTutorExterno);
        }

        return lstEGTutorExterno;

    }

    public EGTutorExterno Obtener_GTutorExterno_O_CodigoTutorExterno(int codigoTutorExterno)
    {
        EGTutorExterno eGTutorExterno = new EGTutorExterno();
        DTOGTutorExterno dtoGTutorExterno = (DTOGTutorExterno)adGTutorExterno.Obtener_GTutorExterno_O_CodigoTutorExterno(codigoTutorExterno);
        if (dtoGTutorExterno.GTutorExterno.Rows.Count > 0)
        {
            DTOGTutorExterno.GTutorExternoRow drGTutorExterno = dtoGTutorExterno.GTutorExterno[0];
            eGTutorExterno.CodigoTutorExterno = int.Parse(drGTutorExterno.CodigoTutorExterno);
            eGTutorExterno.NombresTutorExterno = drGTutorExterno.NombresTutorExterno;
            eGTutorExterno.ApellidosTutorExterno = drGTutorExterno.ApellidosTutorExterno;
            eGTutorExterno.CarreraTutorExterno = drGTutorExterno.CarreraTutorExterno;
            eGTutorExterno.DescripcionTutorExterno = drGTutorExterno.DescripcionTutorExterno;
            eGTutorExterno.DireccionTrabajoTutorExterno = drGTutorExterno.DireccionTrabajoTutorExterno;
            eGTutorExterno.SedeTutorExterno = drGTutorExterno.SedeTutorExterno;
            eGTutorExterno.Estado = drGTutorExterno.Estado;
            eGTutorExterno.FechaModificacion = drGTutorExterno.FechaModificacion;
            eGTutorExterno.FechaRegistro = drGTutorExterno.FechaRegistro;
        }
        else
        {
            eGTutorExterno = null;
        }
        return eGTutorExterno;
    }

    #endregion


}