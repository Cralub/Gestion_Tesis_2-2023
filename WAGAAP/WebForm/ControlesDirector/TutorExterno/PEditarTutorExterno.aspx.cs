using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNGAAP;

public partial class WebForm_TutorExterno_PEditarTutorExterno : System.Web.UI.Page
{
    #region Controladoras
    CTutorExterno cTutorExterno = new CTutorExterno();
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        txbCodigo.Enabled= false;

        string CodigoTutorExterno = Request.QueryString["CodigoTutorExterno"];
        if (!IsPostBack)
        {
            txbCodigo.Text = CodigoTutorExterno;
            CargarDatosTutorExterno();
        }

    }

    //method to get the data from TutorExterno using the method Obtener_GTutorExterno_O_CodigoTutorExterno
    private void CargarDatosTutorExterno()
    {
        try
        {
            EGTutorExterno eTutorExterno = cTutorExterno.Obtener_GTutorExterno_O_CodigoTutorExterno(int.Parse(txbCodigo.Text));
            txbNombres.Text = eTutorExterno.NombresTutorExterno;
            txbApellidos.Text = eTutorExterno.ApellidosTutorExterno;
            txbCarrera.Text = eTutorExterno.CarreraTutorExterno;
            txbDireccionTrabajo.Text = eTutorExterno.DireccionTrabajoTutorExterno;
            txbDescripcion.Text = eTutorExterno.DescripcionTutorExterno;
            txbSede.Text = eTutorExterno.SedeTutorExterno;
        }
        catch (Exception)
        {
            
            throw;
        }
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            cTutorExterno.Actualizar_GTutorExterno_A(int.Parse(txbCodigo.Text), txbNombres.Text, txbApellidos.Text, txbCarrera.Text, txbDireccionTrabajo.Text, txbDescripcion.Text, txbSede.Text);
            Response.Redirect("PListarTutoresExternos.aspx");
        }
        catch (Exception)
        {
            
            throw;
        }

    }
}