using SWLNGAAP;
using System;

using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Informacion_PVerInformacionAvance : Page
{
    #region Controladores
    CEtapa cEtapa = new CEtapa();
    CSubEtapa cSubEtapa = new CSubEtapa();
    #endregion
    static string codigoProyecto;
    static int avanceTotal = -1;
    static int numeroSubEtapa = -1;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LimpiarVariables();
            CargarInformacion();
            CargarBarraProgreso();
            MostrarLabels(1);
        }
        
    }

    private void LimpiarVariables()
    {
        avanceTotal = -1;
        numeroSubEtapa = -1;
        codigoProyecto = null;
    }

    private void MostrarLabels(int etapa)
    {
        CargarBarraProgreso();
        pnlEtapa1.Visible = (etapa == 1);
        pnlEtapa2.Visible = (etapa == 2);
        pnlEtapa3.Visible = (etapa == 3);
        pnlEtapa4.Visible = (etapa == 4);
        

    }

    private void CalcularColorBotones()
    {
        EGEtapa etapaActiva = cEtapa.Obtener_GEtapa_O_CodigoProyecto(codigoProyecto).Find(e => e.EstadoEtapa == SDatosGlobales.ESTADO_ACTIVO);
        AsignarColorBotones(btnTema, 1, etapaActiva.NumeroEtapa);
        AsignarColorBotones(btnPerfil, 2, etapaActiva.NumeroEtapa);
        AsignarColorBotones(btnPrivada, 3, etapaActiva.NumeroEtapa);
        AsignarColorBotones(btnPublica, 4, etapaActiva.NumeroEtapa);

    }

    private void AsignarColorBotones(Button boton, int numeroBoton,int etapa)
    {

        if (etapa < 0)
            CalcularNumeroSubEtapa();
        if (numeroBoton == etapa)
            boton.CssClass = "Botones amarillo";
        else if (numeroBoton < etapa)
            boton.CssClass = "Botones verde";
        else
            boton.CssClass = "Botones plomo";
    }

    private void AsignarColorLabel(Label label, int numeroLabel)
    {
       
        if (numeroSubEtapa <= 0)
            CalcularNumeroSubEtapa();
        if (numeroLabel == numeroSubEtapa )
            label.CssClass = "Estilo-SubEtapas amarillo";
        else if (numeroLabel < numeroSubEtapa )
            label.CssClass = "Estilo-SubEtapas verde";
        else
            label.CssClass = "Estilo-SubEtapas plomo";
    }

    private void CalcularNumeroSubEtapa()
    {
        if (Session["CodigoProyecto"] != null || !string.IsNullOrEmpty(codigoProyecto))
        {
            EGEtapa etapaActiva = cEtapa.Obtener_GEtapa_O_CodigoProyecto(codigoProyecto).Find(e => e.EstadoEtapa == SDatosGlobales.ESTADO_ACTIVO);
            EGSubEtapa subEtapaActiva = cSubEtapa.Obtener_GSubEtapa_O_CodigoEtapa(etapaActiva.CodigoEtapa).Find(e => e.EstadoSubEtapa == SDatosGlobales.ESTADO_ACTIVO);
            numeroSubEtapa = subEtapaActiva.NumeroSubEtapa;
            if (etapaActiva.NumeroEtapa > 1)
            {
                numeroSubEtapa += SDatosGlobales.N_SUB_ETAPAS_ETAPA_1;
            }
            if (etapaActiva.NumeroEtapa > 2)
            {
                numeroSubEtapa += SDatosGlobales.N_SUB_ETAPAS_ETAPA_2;
            }
            if (etapaActiva.NumeroEtapa > 3)
            {
                numeroSubEtapa += SDatosGlobales.N_SUB_ETAPAS_ETAPA_3;
            }
        }
            
        
    }

    void CargarBarraProgreso()
    {
        int avance = avanceTotal;
        if (Session["AvanceTotal"] != null)
        {
            avance = int.Parse(Session["AvanceTotal"].ToString());
            avanceTotal = avance;
        }

        ScriptManager.RegisterStartupScript(this, this.GetType(), "ActualizarProgreso", string.Format("actualizarBarraProgreso({0});", avance), true);
        lblPorcentajeTotal.Text = avance + " %";
    }
    private void CargarInformacion()
    {
        if (Session["UsuarioSesion"] == null ||  Session["CodigoProyecto"] == null  || Session["AvanceTotal"] == null)
        {
            return;
        }
        codigoProyecto = Session["CodigoProyecto"].ToString();
        CargarColoresEtapas();
        CalcularColorBotones();
    }


    protected void btnVolver_Click(object sender, EventArgs e)
    {

        if (Session["UsuarioSesion"] != null)
        {
            EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            Session["CodigoProyecto"] = null;
            if (usuarioSesion.esEstudiante)
                Response.Redirect("~/WebForm/Informacion/PGraficasAvance.aspx");
            else
                Response.Redirect("~/WebForm/Proyecto/PListarProyectosRevision.aspx");

        }
    }

    protected void btnTema_Click(object sender, EventArgs e)
    {
        MostrarLabels(1);
    }

    protected void btnPerfil_Click(object sender, EventArgs e)
    {
        MostrarLabels(2);
    }

    protected void btnPrivada_Click(object sender, EventArgs e)
    {
        MostrarLabels(3);
    }

    protected void btnPublica_Click(object sender, EventArgs e)
    {
        MostrarLabels(4);
    }
    private void CargarColoresEtapas()
    {
        AsignarColorLabel(lblE1S1, 1);
        AsignarColorLabel(lblE1S2, 2);
        AsignarColorLabel(lblE1S3, 3);
        AsignarColorLabel(lblE1S4, 4);

        AsignarColorLabel(lblE2S1, 5);
        AsignarColorLabel(lblE2S2, 6);
        AsignarColorLabel(lblE2S3, 7);
        AsignarColorLabel(lblE2S4, 8);
        AsignarColorLabel(lblE2S5, 9);
        AsignarColorLabel(lblE2S6, 10);
        AsignarColorLabel(lblE2S7, 11);

        AsignarColorLabel(lblE3S1, 12);
        AsignarColorLabel(lblE3S2, 13);
        AsignarColorLabel(lblE3S3, 14);
        AsignarColorLabel(lblE3S4, 15);
        AsignarColorLabel(lblE3S5, 16);
        AsignarColorLabel(lblE3S6, 17);
        AsignarColorLabel(lblE3S7, 18);

        AsignarColorLabel(lblE4S1, 19);
        AsignarColorLabel(lblE4S2, 20);
        AsignarColorLabel(lblE4S3, 21);
        AsignarColorLabel(lblE4S4, 22);
        AsignarColorLabel(lblE4S5, 23);
        AsignarColorLabel(lblE4S6, 24);
        AsignarColorLabel(lblE4S7, 25);
    }

}