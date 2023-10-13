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
        txtCodigo.Enabled= false;

        string CodigoTutorExterno = Request.QueryString["CodigoTutorExterno"];
        if (!IsPostBack)
        {
            txtCodigo.Text = CodigoTutorExterno;
            CargarDatosTutorExterno();
        }

    }

    //method to get the data from TutorExterno using the method Obtener_GTutorExterno_O_CodigoTutorExterno
    private void CargarDatosTutorExterno()
    {
        try
        {
            EGTutorExterno eTutorExterno = cTutorExterno.Obtener_GTutorExterno_O_CodigoTutorExterno(int.Parse(txtCodigo.Text));
            txtNombres.Text = eTutorExterno.NombresTutorExterno;
            txtApellidos.Text = eTutorExterno.ApellidosTutorExterno;
            txtCarrera.Text = eTutorExterno.CarreraTutorExterno;
            txtDireccionTrabajo.Text = eTutorExterno.DireccionTrabajoTutorExterno;
            txtDescripcion.Text = eTutorExterno.DescripcionTutorExterno;
            txtSede.Text = eTutorExterno.SedeTutorExterno;
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
            cTutorExterno.Actualizar_GTutorExterno_A(int.Parse(txtCodigo.Text), txtNombres.Text, txtApellidos.Text, txtCarrera.Text, txtDireccionTrabajo.Text, txtDescripcion.Text, txtSede.Text);
            Response.Redirect("PListarTutoresExternos.aspx");
        }
        catch (Exception)
        {
            
            throw;
        }

    }
}