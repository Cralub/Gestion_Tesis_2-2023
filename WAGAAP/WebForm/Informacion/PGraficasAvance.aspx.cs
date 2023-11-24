using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_PGraficasAvance : Page
{
    #region Controladores
    CEtapa cEtapa = new CEtapa();
    CSubEtapa cSubEtapa = new CSubEtapa();
    #endregion
    static List<EGEtapa> lstEtapas = new List<EGEtapa>();
    static List<int> avancePorEtapa = new List<int>();
    static int avanceTotal = 0;
    
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (Session["CodigoProyecto"] != null && Session["UsuarioSesion"] != null)
            {
                EUsuarioSesionGAAP usuario = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
                CargarInformacionDelProyecto();
                FiltrarInterfazUsuario();
            }

        }
        

    }

    public void CargarInformacionDelProyecto()
    {

        if (Session["CodigoProyecto"] != null)
        {
            string codigoProyecto = Session["CodigoProyecto"].ToString();
            lstEtapas = cEtapa.Obtener_GEtapa_O_CodigoProyecto(codigoProyecto);
            avancePorEtapa = new List<int>();

            foreach (var etapa in lstEtapas)
            {
                var lstSubEtapas = cSubEtapa.Obtener_GSubEtapa_O_CodigoEtapa(etapa.CodigoEtapa);
                var subEtapasTotales = lstSubEtapas.Count(c => c.EstadoSubEtapa != SDatosGlobales.ESTADO_IGNORADO);
                var subEtapasFinalizadas = lstSubEtapas.Count(c => c.EstadoSubEtapa == SDatosGlobales.ESTADO_FINALIZADO);

                int avance = (int)Math.Round((double)subEtapasFinalizadas * 100 / subEtapasTotales);
                avancePorEtapa.Add(avance);
            }
            avanceTotal = (int)Math.Round((double)avancePorEtapa.Sum()/4);
            AsignarValores(1);
        }
    }
    private void AsignarValores(int numeroSubEtapa)
    {
        lblTituloNumeroEtapa.Text = string.Format("• Etapa {0}", numeroSubEtapa.ToString()); 
        if(avancePorEtapa.Count > 0)
        {
            bool tieneTribunales = numeroSubEtapa != 1;
            lblTribunal1.Visible = tieneTribunales;
            lblTribunal2.Visible = tieneTribunales;
            lblPorcentajeTribunal1.Visible = tieneTribunales;
            lblPorcentajeTribunal2.Visible = tieneTribunales;
            lblPorcentajeTotal.Text = string.Format("{0} %",avanceTotal);
            int avanceEtapa = avancePorEtapa.ElementAt(numeroSubEtapa - 1);

            //Combinar los scripts en uno solo antes de registrarlo
            string script = string.Format("actualizarProgreso({0});actualizarBarraProgreso({1}); ", avanceEtapa, avanceTotal);

            ScriptManager.RegisterStartupScript(this, this.GetType(), "ActualizarProgreso", script, true);
            AsignarValoresPorRoles(numeroSubEtapa);
        }
    }
    private void AsignarValoresPorRoles(int numeroSubEtapa)
    {
        if (lstEtapas.Count > 0)
        {
            int codigoEtapaActual = lstEtapas.ElementAt(numeroSubEtapa - 1).CodigoEtapa;
            var lstSubEtapas = cSubEtapa.Obtener_GSubEtapa_O_CodigoEtapa(codigoEtapaActual);

            int porcentajeTutor = ObtenerPorcentajeSubEtapas(lstSubEtapas, SDatosGlobales.ROL_TUTOR);
            int porcentajeDirector = ObtenerPorcentajeSubEtapas(lstSubEtapas, SDatosGlobales.ROL_DIRECTOR);
            int porcentajeDAAP = ObtenerPorcentajeSubEtapas(lstSubEtapas, SDatosGlobales.ROL_DAAP);

            AsignarPorcentaje(lblPorcentajeTutor, porcentajeTutor);
            AsignarPorcentaje(lblPorcentajeDirector, porcentajeDirector);
            AsignarPorcentaje(lblPorcentajeDAAP, porcentajeDAAP);

            if (numeroSubEtapa != 1)
            {
                int porcentajeTribunal1 = ObtenerPorcentajeSubEtapas(lstSubEtapas, SDatosGlobales.ROL_TRIBUNAL_1);
                int porcentajeTribunal2 = ObtenerPorcentajeSubEtapas(lstSubEtapas, SDatosGlobales.ROL_TRIBUNAL_2);

                AsignarPorcentaje(lblPorcentajeTribunal1, porcentajeTribunal1);
                AsignarPorcentaje(lblPorcentajeTribunal2, porcentajeTribunal2);
            }
        }
    }

    private int ObtenerPorcentajeSubEtapas(List<EGSubEtapa> lstSubEtapas, string codigoRol)
    {
        int subEtapasTotales = lstSubEtapas.Count(c => (c.EstadoSubEtapa != SDatosGlobales.ESTADO_FINALIZADO && c.EstadoSubEtapa != SDatosGlobales.ESTADO_IGNORADO) && c.CodigoRolDesignadoSubEtapa == codigoRol);
        int subEtapasCumplidas = lstSubEtapas.Count(c => c.EstadoSubEtapa == SDatosGlobales.ESTADO_FINALIZADO && c.CodigoRolDesignadoSubEtapa == codigoRol);

        return subEtapasTotales > 0 ? (int)Math.Round((double)(subEtapasCumplidas * 100 / subEtapasTotales)) : 0;
    }

    private void AsignarPorcentaje(Label label, int porcentaje)
    {

        label.Text = string.Format("{0} %", porcentaje > 90 ? 100 : porcentaje);

        if (porcentaje > 0)
            label.CssClass = "cuadro amarillo";
        else if (porcentaje > 90)
            label.CssClass = "cuadro verde";
        else 
            label.CssClass = "cuadro plomo";
    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Session["CodigoProyecto"] = null;
        Session["CodigoUsuario"] = null;

        if (Session["PaginaAnterior"] != null)
        {
            string paginaAnterior = Session["PaginaAnterior"].ToString();
            Session["PaginaAnterior"] = null;
            Response.Redirect(paginaAnterior);
        }
        else
        {
            Response.Redirect("~/WebForm/Proyecto/PListarProyectosRevision.aspx");
        }
    }

    void FiltrarInterfazUsuario()
    {
        if (Session["UsuarioSesion"] != null)
        {
            EUsuarioSesionGAAP usuarioSesion = Session["UsuarioSesion"] as EUsuarioSesionGAAP;
            if (usuarioSesion.esEstudiante)
            {
                btnVolver.Enabled = false;
                btnVolver.Visible = false;
            }
        }
    }
    protected void btnTema_Click(object sender, EventArgs e)
    {
        AsignarValores(1);
    }

    protected void btnPerfil_Click(object sender, EventArgs e)
    {
        AsignarValores(2);
    }

    protected void btnPrivada_Click(object sender, EventArgs e)
    {
        AsignarValores(3);
    }

    protected void btnPublica_Click(object sender, EventArgs e)
    {
        AsignarValores(4);
    }
}