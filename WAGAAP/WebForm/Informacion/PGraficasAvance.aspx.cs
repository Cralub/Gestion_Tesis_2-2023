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
                Session["AvanceTotal"] = null;
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
            Session["CodigoProyecto"] = codigoProyecto;
            lstEtapas = cEtapa.Obtener_GEtapa_O_CodigoProyecto(codigoProyecto).OrderBy(o => o.NumeroEtapa).ToList();
            avancePorEtapa = new List<int>();
            int numeroEtapaActual = lstEtapas.FirstOrDefault(e => e.EstadoEtapa == SDatosGlobales.ESTADO_ACTIVO).NumeroEtapa;
            //Por cada etapa
            foreach (var etapa in lstEtapas)
            {
                //Listamos las SubEtapas
                var lstSubEtapas = cSubEtapa.Obtener_GSubEtapa_O_CodigoEtapa(etapa.CodigoEtapa).OrderBy(o => o.NumeroSubEtapa);

                int avance = 100;
                if (etapa.NumeroEtapa == numeroEtapaActual)
                {
                    //Cantidad SubEtapas
                    var subEtapasTotales = lstSubEtapas.Count();
                    var ultimaSubEtapaActiva = lstSubEtapas.Last(c => c.EstadoSubEtapa == SDatosGlobales.ESTADO_ACTIVO).NumeroSubEtapa;
                    avance = (int)Math.Round((double)ultimaSubEtapaActiva * 100 / subEtapasTotales);
                }
                if (etapa.NumeroEtapa > numeroEtapaActual)
                    avance = 0;


                avancePorEtapa.Add(avance);
            }
            avanceTotal = (int)Math.Round((double)avancePorEtapa.Sum() / 4);
            AsignarValores(1);
        }
    }
    private void AsignarValores(int numeroSubEtapa)
    {
        lblTituloNumeroEtapa.Text = string.Format("• Etapa {0}", numeroSubEtapa.ToString());
        if (avancePorEtapa.Count > 0)
        {
            bool tieneTribunales = numeroSubEtapa != 1;
            lblTribunal1.Visible = tieneTribunales;
            lblTribunal2.Visible = tieneTribunales;
            lblPorcentajeTribunal1.Visible = tieneTribunales;
            lblPorcentajeTribunal2.Visible = tieneTribunales;
            lblPorcentajeTotal.Text = string.Format("{0} %", avanceTotal);
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
            EGEtapa etapaSeleccionada = lstEtapas.ElementAt(numeroSubEtapa - 1);
            int etapaActiva = lstEtapas.FirstOrDefault(e => e.EstadoEtapa == SDatosGlobales.ESTADO_ACTIVO).NumeroEtapa;

            var lstSubEtapas = cSubEtapa.Obtener_GSubEtapa_O_CodigoEtapa(etapaSeleccionada.CodigoEtapa).OrderBy(o => o.NumeroSubEtapa).ToList();

            int porcentajeTutor = 100;
            int porcentajeDirector = 100;
            int porcentajeDAAP = 100;
            int porcentajeTribunal1 = 100;
            int porcentajeTribunal2 = 100;
            if (etapaSeleccionada.NumeroEtapa == etapaActiva)
            {
                porcentajeTutor = ObtenerPorcentajeSubEtapas(lstSubEtapas, SDatosGlobales.ROL_TUTOR);
                porcentajeDirector = ObtenerPorcentajeSubEtapas(lstSubEtapas, SDatosGlobales.ROL_DIRECTOR);
                porcentajeDAAP = ObtenerPorcentajeSubEtapas(lstSubEtapas, SDatosGlobales.ROL_DAAP);
                if (numeroSubEtapa != 1)
                {
                    porcentajeTribunal1 = ObtenerPorcentajeSubEtapas(lstSubEtapas, SDatosGlobales.ROL_TRIBUNAL_1);
                    porcentajeTribunal2 = ObtenerPorcentajeSubEtapas(lstSubEtapas, SDatosGlobales.ROL_TRIBUNAL_2);
                }
            }
            if (etapaSeleccionada.NumeroEtapa > etapaActiva)
            {
                porcentajeTutor = 0;
                porcentajeDirector = 0;
                porcentajeDAAP = 0;
                porcentajeTribunal1 = 0;
                porcentajeTribunal2 = 0;
            }

            AsignarPorcentajePorRol(lblPorcentajeTutor, porcentajeTutor);
            AsignarPorcentajePorRol(lblPorcentajeDirector, porcentajeDirector);
            AsignarPorcentajePorRol(lblPorcentajeDAAP, porcentajeDAAP);

            if (numeroSubEtapa != 1)
            {
                AsignarPorcentajePorRol(lblPorcentajeTribunal1, porcentajeTribunal1);
                AsignarPorcentajePorRol(lblPorcentajeTribunal2, porcentajeTribunal2);
            }


        }
    }

    private int ObtenerPorcentajeSubEtapas(List<EGSubEtapa> lstSubEtapas, string codigoRol)
    {
        List<byte> numeroSubEtapasPorRol = lstSubEtapas.Where(c => c.CodigoRolDesignadoSubEtapa == codigoRol).Select(s => s.NumeroSubEtapa).ToList();
        EGSubEtapa subEtapaActiva = lstSubEtapas.FirstOrDefault(w => w.EstadoSubEtapa == SDatosGlobales.ESTADO_ACTIVO);
        int etapasCompletas = 0;
        foreach (var numeroSubEtapa in numeroSubEtapasPorRol)
        {
            if (numeroSubEtapa < subEtapaActiva.NumeroSubEtapa)
            {
                etapasCompletas++;
            }
        }
        return etapasCompletas > 0 ? (int)Math.Round((double)(etapasCompletas * 100 / numeroSubEtapasPorRol.Count())) : 0;
    }

    private void AsignarPorcentajePorRol(Label label, int porcentaje)
    {

        label.Text = string.Format("{0} %", porcentaje > 90 ? 100 : porcentaje);

        if (porcentaje < 10)
            label.CssClass = "cuadro plomo";
        else if (porcentaje < 90)
            label.CssClass = "cuadro amarillo";
        else
            label.CssClass = "cuadro verde";
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

    protected void btnDetalle_Click(object sender, EventArgs e)
    {
        if (Session["UsuarioSesion"] != null &&  Session["CodigoProyecto"] != null)
            Session["AvanceTotal"] = avanceTotal;

        Response.Redirect("~/WebForm/Informacion/PVerInformacionAvance.aspx");

    }
}