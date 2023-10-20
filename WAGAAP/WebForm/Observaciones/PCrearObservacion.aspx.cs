using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Observaciones_PCrearObservacion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCambioEstado_Click(object sender, EventArgs e)
    {
        CObservacion cObservacion = new CObservacion();
        cObservacion.Actualizar_GObservacion_A_EstadoObservacion(1, SDatosGlobales.Corregido);
        lblSms.Text = "Actualizado correctamente";
    }
}