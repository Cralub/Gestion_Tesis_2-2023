using SWLNGAAP;
using System;

public partial class WebForm_Usuario_PEditarCelular : System.Web.UI.Page
{
    #region Controladores
    CCelular cCelular = new CCelular();
    #endregion
    static EGCelular eGCelular;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack && Session["UsuarioSesion"] != null)
        {
            eGCelular = cCelular.Obtener_GCelular_O_CodigoUsuario(((EUsuarioSesionGAAP)Session["UsuarioSesion"]).CodigoUsuario);
            txbCodigoArea.Text = eGCelular.CodigoAreaCelular;
            txbNumeroCelular.Text = eGCelular.NumeroCelular.ToString();
        }
    }

    protected void btnEditarCelular_Click(object sender, EventArgs e)
    {
        if (ValidarCamposEntrada() && Session["UsuarioSesion"] != null && !string.IsNullOrEmpty(eGCelular.CodigoUsuario))
        {
            cCelular.Actualizar_GCelular_A(eGCelular.CodigoCelular, eGCelular.CodigoUsuario, txbCodigoArea.Text, int.Parse(txbNumeroCelular.Text));
            Response.Redirect("~/WebForm/Informacion/PInformacionUsuario.aspx");
        }
    }

    protected void btnEliminarCelular_Click(object sender, EventArgs e)
    {
        if(Session["UsuarioSesion"] != null && !string.IsNullOrEmpty(eGCelular.CodigoAreaCelular))
        {
            cCelular.Eliminar_GCelular_E(eGCelular.CodigoCelular);
            Response.Redirect("~/WebForm/Informacion/PInformacionUsuario.aspx");
        }
        
    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/WebForm/Informacion/PInformacionUsuario.aspx");
    }
    private bool ValidarCamposEntrada()
    {
        if (!SUtil.ValidarSoloNumero(txbCodigoArea.Text.Trim(), 3))
            return false;
        if (!SUtil.ValidarSoloNumero(txbNumeroCelular.Text.Trim(), 7))
            return false;
        if (txbNumeroCelular.Text.Trim().Length > 10)
            return false;
        return true;
    }
}