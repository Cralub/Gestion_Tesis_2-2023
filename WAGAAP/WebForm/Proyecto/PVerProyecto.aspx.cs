using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Proyecto_PVerProyecto : System.Web.UI.Page
{
    #region Contructores
    CProyecto cProyecto = new CProyecto();
    CRol cRol = new CRol();
    CUsuarioProyecto cUsuarioProyecto = new CUsuarioProyecto();
    #endregion
    
   // private string CodigoProyecto;
   //EUsuarioNetvalle usuarioNetvalle = new EUsuarioNetvalle();
    
   // EGProyecto eGProyecto  = new EGProyecto();
   // List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
   // List<EGRol> listaRoles = new List<EGRol>();

    // utilizar los valores como se necesite

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //CodigoProyecto = Session["CodigoProyecto"] as string;
            //usuarioNetvalle = Session["UsuarioSesion"] as EUsuarioNetvalle;
            //CargarDatos();
        }
        
    }
    private void CargarDatos()
    {
        //eGProyecto = cProyecto.Obtener_GProyecto_O_CodigoProyecto(CodigoProyecto.Trim()); 
        //lblCodigoUsuario.Text = usuarioNetvalle.CodigoUsuarioNetvalle;
        
        //switch (eGProyecto.ModalidadProyecto)
        //{
        //    case 'T':
        //        lblModalidad.Text = "Tesis de Grado";
        //        break;
        //    case 'P':
        //        lblModalidad.Text = "Proyecto de Grado";
        //        break;
        //    case 'D':
        //        lblModalidad.Text = "Trabajo Dirigido";
        //        break;
        //    default:
        //        lblModalidad.Text = "Desconocida";
        //        break;
        //}
        //lblTitulo.Text = eGProyecto.TituloProyecto;
        //lblObjetivoGeneral.Text = eGProyecto.ObjetivoGeneralProyecto;
        //lkbEnlaceDocumento.Text = eGProyecto.EnlaceDocumentoProyecto;
        //listaRoles = cRol.Obtener_GRol_O_Todo().ToList();
        //gvListaUsuarios.DataSource = null;
        //lstEGUsuarioProyecto = cUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoProyecto(CodigoProyecto.Trim()).ToList();
        //gvListaUsuarios.DataSource = lstEGUsuarioProyecto;
        //gvListaUsuarios.DataBind();

    }
    //protected string GetRolNombre(string codigoRol)
    //{
    //    //listaRoles = cRol.Obtener_GRol_O_Todo().ToList();
    //    //EGRol rol = listaRoles.FirstOrDefault(r => r.CodigoRol.Trim() == codigoRol);
    //    //if (rol != null)
    //    //{
    //    //    return rol.DescripcionRol;
    //    //}
    //    //else
    //    //{
    //    //    return "Rol Desconocido";
    //    //}
    //}
    


    protected void gvListaUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        string CodigoUsuario = System.Net.WebUtility.HtmlDecode(gvListaUsuarios.Rows[index].Cells[0].Text);
        
        if (e.CommandName == "btnVer")
        {
            Session["CodigoUsuario"] = CodigoUsuario;
            Response.Redirect("~/WebForm/Informacion/PInformacionUsuario.aspx");
        }
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/WebForm/Proyecto/PListarProyectos.aspx");
    }
}
