using SWLNGAAP;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_PGraficasAvance : System.Web.UI.Page
{
    SWLNGAAPClient client = new SWLNGAAPClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
            if (Session["CodigoProyecto"] != null)
            {
                EUsuarioNetvalle eUsuarioNetvalle = Session["UsuarioSesion"] as EUsuarioNetvalle;
                var progresoEtapas = client.Obtener_EProgresoEtapaSubEtapa_O(Session["CodigoProyecto"] as string).ToList();
                CargarDatos(progresoEtapas);
            }
           
        }
      
    }

    public void CargarDatos(List<EProgresoEtapaSubEtapa> lstProgresoEtapas)
    {
        int[] etapas = new int[4];

        for (int i = 0; i < 4; i++)
        {
            etapas[i] = (int)((double)lstProgresoEtapas[i].CantidadSubEtapaFinalizada / lstProgresoEtapas[i].CantidadSubEtapaTotal * 100);
        }

        int subEtapasTotal = 0, subEtapasFinalizadas = 0;

        for (int j = 0; j < lstProgresoEtapas.Count; j++)
        {
            subEtapasTotal += lstProgresoEtapas[j].CantidadSubEtapaTotal;
            subEtapasFinalizadas += lstProgresoEtapas[j].CantidadSubEtapaFinalizada;
        }

        var progresoTotal = ((double)subEtapasFinalizadas / (double)subEtapasTotal) * 100;

        if (lstProgresoEtapas[0].EstadoEtapa == 'A')
        {
            lblEtapaActiva.Text = "ETAPA 1";
            lblProgresoEtapaActiva.Text = "Total Avance - " + etapas[0] + "%";
            lblValorActivo.Text = etapas[0].ToString() + "%";
            tribunalParticipaActual.Visible = false;
            graficaEtapaActiva.Attributes.Add("style", "background: conic-gradient(#F87178 " + (etapas[0] * 3.6) + "deg, #f0f0f0 0deg);");
            if (lstProgresoEtapas[0].CantidadSubEtapaFinalizada >= 1)
            {
                chkEstudianteActual.Checked = true;
            }
            if (lstProgresoEtapas[0].CantidadSubEtapaFinalizada >= 2)
            {
                chkTutorActual.Checked = true;
            }
            if (lstProgresoEtapas[0].CantidadSubEtapaFinalizada >= 3)
            {
                chkDirectorActual.Checked = true;
            }
            if (lstProgresoEtapas[0].CantidadSubEtapaFinalizada >= 4)
            {
                chkDAAPActual.Checked = true;
            }

            lblEtapa.Text = "ETAPA 2";
            lblProgresoEtapa.Text = "Total Avance - " + etapas[1] + "%";
            lblValor.Text = etapas[1].ToString() + "%";
            tribunalParticipa.Visible = true;
            graficaEtapa.Attributes.Add("style", "background: conic-gradient(#F87178 " + (etapas[1] * 3.6) + "deg, #f0f0f0 0deg);");
            if (lstProgresoEtapas[1].CantidadSubEtapaFinalizada >= 1)
            {
               chkEstudiante.Checked = true;
            }
            if (lstProgresoEtapas[1].CantidadSubEtapaFinalizada >= 8)
            {
                chkTutor.Checked = true;
            }
            if (lstProgresoEtapas[1].CantidadSubEtapaFinalizada >= 9)
            {
                chkTribunales.Checked = true;
            }
            if (lstProgresoEtapas[1].CantidadSubEtapaFinalizada >= 6)
            {
                chkDirector.Checked = true;
            }
            if (lstProgresoEtapas[1].CantidadSubEtapaFinalizada >= 13)
            {
                chkDAAP.Checked = true;
            }
        }
        if (lstProgresoEtapas[1].EstadoEtapa == 'A')
        {
            lblEtapaActiva.Text = "ETAPA 2";
            lblProgresoEtapaActiva.Text = "Total Avance - " + etapas[1] + "%";
            lblValorActivo.Text = etapas[1].ToString() + "%";
            tribunalParticipaActual.Visible = true;
            graficaEtapaActiva.Attributes.Add("style", "background: conic-gradient(#F87178 " + (etapas[1] * 3.6) + "deg, #f0f0f0 0deg);");
            if (lstProgresoEtapas[0].CantidadSubEtapaFinalizada >= 1)
            {
                chkEstudiante.Checked = true;
            }
            if (lstProgresoEtapas[0].CantidadSubEtapaFinalizada >= 2)
            {
                chkTutor.Checked = true;
            }
            if (lstProgresoEtapas[0].CantidadSubEtapaFinalizada >= 3)
            {
                chkDirector.Checked = true;
            }
            if (lstProgresoEtapas[0].CantidadSubEtapaFinalizada >= 4)
            {
                chkDAAP.Checked = true;
            }

            lblEtapa.Text = "ETAPA 1";
            lblProgresoEtapa.Text = "Total Avance - " + etapas[0] + "%";
            lblValor.Text = etapas[0].ToString() + "%";
            tribunalParticipa.Visible = false;
            graficaEtapa.Attributes.Add("style", "background: conic-gradient(#F87178 " + (etapas[0] * 3.6) + "deg, #f0f0f0 0deg);");
            if (lstProgresoEtapas[1].CantidadSubEtapaFinalizada >= 1)
            {
                chkEstudianteActual.Checked = true;
            }
            if (lstProgresoEtapas[1].CantidadSubEtapaFinalizada >= 8)
            {
                chkTutorActual.Checked = true;
            }
            if (lstProgresoEtapas[1].CantidadSubEtapaFinalizada >= 9)
            {
                chkTribunalesActual.Checked = true;
            }
            if (lstProgresoEtapas[1].CantidadSubEtapaFinalizada >= 6)
            {
                chkDirectorActual.Checked = true;
            }
            if (lstProgresoEtapas[1].CantidadSubEtapaFinalizada >= 13)
            {
                chkDAAPActual.Checked = true;
            }
        }

        lblProgresoTotal.Text = Math.Round(progresoTotal).ToString() + "%";
        barraProgreso.Attributes.Add("style", "width: " + Math.Round(progresoTotal) + "%;");
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Session["CodigoProyecto"] = null;
        Response.Redirect("~/PaginaMaestra/Default.aspx");
    }
}