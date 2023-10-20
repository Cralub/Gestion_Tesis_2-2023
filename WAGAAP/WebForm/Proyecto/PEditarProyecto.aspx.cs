using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Proyecto_PEditarProyecto : System.Web.UI.Page
{
    private CProyecto cProyecto = new CProyecto();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnObtener_Click(object sender, EventArgs e)
    {
        EGProyecto proyecto = new EGProyecto();
        proyecto = cProyecto.Obtener_GProyecto_O(txbCodigoProyecto.Text);
        txbModalidad.Text = proyecto.ModalidadProyecto.ToString();
        txbTitulo.Text = proyecto.TituloProyecto;
        txbObjetivoGeneral.Text = proyecto.ObjetivoGeneralProyecto;
        txbObjetivoEspecifico.Text = proyecto.ObjetivosEspecificosProyecto;
        txbAlcance.Text = proyecto.AlcanceProyecto;
        txbEnlace.Text = proyecto.EnlaceDocumentoProyecto;
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        cProyecto.Actualizar_GProyecto_A(txbCodigoProyecto.Text, char.Parse(txbModalidad.Text), txbTitulo.Text, txbObjetivoGeneral.Text, txbObjetivoEspecifico.Text, txbAlcance.Text, txbEnlace.Text);
        lblSms.Text = "Actualizado correctamente";
    }
}