using System;

public partial class WebForm_Usuario_PAgregarCelular : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAgregarCelular_Click(object sender, EventArgs e)
    {
        CCelular cCelular = new CCelular();
        if (ValidarCamposEntrada() && Session["UsuarioSesion"] != null)
        {
            cCelular.Insertar_GCelular_I(((EUsuarioSesionGAAP)Session["UsuarioSesion"]).CodigoUsuario, txbCodigoArea.Text, int.Parse(txbNumeroCelular.Text));
            Response.Redirect("~/PaginaMaestra/Default.aspx");
        }
        
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/WebForm/Informacion/PInformacionUsuario.aspx");
    }
    private bool ValidarCamposEntrada()
    {
        if (!SUtil.ValidarSoloNumero(txbCodigoArea.Text.Trim(),3))        
            return false;
        if (!SUtil.ValidarSoloNumero(txbNumeroCelular.Text.Trim(), 7))
            return false;
        if(txbNumeroCelular.Text.Trim().Length > 10)
            return false;
        return true;
    }
}