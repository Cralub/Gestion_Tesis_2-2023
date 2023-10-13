using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNGAAP;

public partial class WebForm_TutorExterno_Default : System.Web.UI.Page
{
    #region Controladoras
    CTutorExterno cTutorExterno = new CTutorExterno();
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
        //    //Inhabilita la posibilidad de crear un nuevo Tutor Externo hasta validar 

        //    txtCodigo.Enabled= false;
        //    txtNombres.Enabled = false;
        //    txtApellidos.Enabled= false;
        //    txtCarrera.Enabled = false;
        //    txtDireccionTrabajo.Enabled = false;
        //    txtDescripcion.Enabled = false;
        //    txtSede.Enabled = false;
        //    btnGuardar.Enabled = false;
        //}
    }

    protected void btnCrear_Click(object sender, EventArgs e)
    {
        try
        {
            cTutorExterno.Insertar_GTutorExterno_I(int.Parse(txtCodigo.Text), txtNombres.Text, txtApellidos.Text, txtCarrera.Text, txtDireccionTrabajo.Text, txtDescripcion.Text, txtSede.Text);

        }
        catch (Exception)
        {

            throw;
        }
    }
}