using System;

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

        //    txbCodigo.Enabled= false;
        //    txbNombres.Enabled = false;
        //    txbApellidos.Enabled= false;
        //    txbCarrera.Enabled = false;
        //    txbDireccionTrabajo.Enabled = false;
        //    txbDescripcion.Enabled = false;
        //    txbSede.Enabled = false;
        //    btnGuardar.Enabled = false;
        //}
    }

    protected void btnCrear_Click(object sender, EventArgs e)
    {
        try
        {
            cTutorExterno.Insertar_GTutorExterno_I(txbCodigo.Text, txbNombreCompleto.Text, txbCarrera.Text, txbDireccionTrabajo.Text, txbDescripcion.Text, txbSede.Text);

        }
        catch (Exception)
        {

            throw;
        }
    }
    void ValidarEntradas()
    {
        
    }
}