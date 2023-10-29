using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

/// <summary>
/// Descripción breve de LNServicio
/// </summary>
public class LNServicio
{
    #region Propiedades
    public string NombreClase
    {
        get { return GetType().Name; }
    }
    #endregion

    #region Constructor
    public LNServicio()
    {
        
    }
    #endregion

    #region Metodos Publicos

    #region GUsuarioRol
    public void Insertar_GUsuarioRol_I(int CodigoUsuarioRol, string CodigoRol, string CodigoUsuario)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient()) 
            {
                clienteSWLNGAAP.Insertar_GUsuarioRol_I(CodigoUsuarioRol, CodigoRol, CodigoUsuario);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol()
    {
        int resultado = 0;
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                resultado = clienteSWLNGAAP.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return resultado;
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoRol(string CodigoRol)
    {
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGUsuarioRol = clienteSWLNGAAP.Obtener_GUsuarioRol_O_CodigoRol(CodigoRol).ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEGUsuarioRol;
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoUsuario(string CodigoUsuario)
    {
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGUsuarioRol = clienteSWLNGAAP.Obtener_GUsuarioRol_O_CodigoUsuario(CodigoUsuario).ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEGUsuarioRol;
    }
    public EGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string CodigoUsuario, string CodigoRol)
    {
        EGUsuarioRol eGUsuarioRol = new EGUsuarioRol();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGUsuarioRol = clienteSWLNGAAP.Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(CodigoUsuario, CodigoRol);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eGUsuarioRol;
    }
    public void Actualizar_GUsuarioRol_A(string CodigoUsuario, string CodigoRol, int CodigoUsuarioRol)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GUsuarioRol_A(CodigoUsuario, CodigoRol, CodigoUsuarioRol);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Eliminar_GUsuarioRol_E(int CodigoUsuarioRol)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Eliminar_GUsuarioRol_E(CodigoUsuarioRol);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region GUsuarioProyecto
    public void Insertar_GUsuarioProyecto_I(int CodigoUsuarioProyecto, string CodigoProyecto, string CodigoUsuario, string CodigoRol, char EstadoUsuarioProyecto)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GUsuarioProyecto_I(CodigoUsuarioProyecto, CodigoProyecto, CodigoUsuario, CodigoRol, EstadoUsuarioProyecto);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto()
    {
        int resultado = 0;
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                resultado = clienteSWLNGAAP.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return resultado;
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoProyecto(string CodigoProyecto)
    {
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGUsuarioProyecto = clienteSWLNGAAP.Obtener_GUsuarioProyecto_O_CodigoProyecto(CodigoProyecto).ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEGUsuarioProyecto;
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoUsuario(string CodigoUsuario)
    {
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGUsuarioProyecto = clienteSWLNGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario(CodigoUsuario).ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEGUsuarioProyecto;
    }
    public void Actualizar_GUsuarioProyecto_A(int CodigoUsuarioProyecto, string CodigoProyecto, string CodigoUsuario, string CodigoRol, char EstadoUsuarioProyecto)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GUsuarioProyecto_A(CodigoUsuarioProyecto, CodigoProyecto, CodigoUsuario, CodigoRol, EstadoUsuarioProyecto);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Eliminar_GUsuarioProyecto_E(int CodigoUsuarioProyecto)
    {
        using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
        {
            clienteSWLNGAAP.Eliminar_GUsuarioProyecto_E(CodigoUsuarioProyecto);
        }
        try
        {
            
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region GProyecto
    public void Insertar_GProyecto_I(string CodigoProyecto, char ModalidadProyecto, string TituloProyecto, string ObjetivoGeneralProyecto, string EnlaceDocumentoProyecto, char EstadoProyecto)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GProyecto_I(CodigoProyecto, ModalidadProyecto, TituloProyecto, ObjetivoGeneralProyecto, EnlaceDocumentoProyecto, EstadoProyecto);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGProyecto> Obtener_GProyecto_O_Todo()
    {
        List<EGProyecto> lstEGProyecto = new List<EGProyecto>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGProyecto = clienteSWLNGAAP.Obtener_GProyecto_O_Todo().ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEGProyecto;
    }
    public EGProyecto Obtener_GProyecto_O_CodigoProyecto(string CodigoProyecto)
    {
        EGProyecto eGProyecto = new EGProyecto();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGProyecto = clienteSWLNGAAP.Obtener_GProyecto_O_CodigoProyecto(CodigoProyecto.ToUpper());
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eGProyecto;
    }
    public void Actualizar_GProyecto_A(string CodigoProyecto, char ModalidadProyecto, string TituloProyecto, string ObjetivoGeneralProyecto, string EnlaceDocumentoProyecto)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GProyecto_A(CodigoProyecto, ModalidadProyecto, TituloProyecto, ObjetivoGeneralProyecto, EnlaceDocumentoProyecto);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region GEtapa
    public void Insertar_GEtapa_I(int CodigoEtapa, byte NumeroEtapa, DateTime FechaInicioEtapa, DateTime FechaDefinidaEtapa, DateTime FechaFinEtapa, string CodigoProyecto, char EstadoEtapa)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GEtapa_I(CodigoEtapa, NumeroEtapa, FechaInicioEtapa, FechaDefinidaEtapa, FechaFinEtapa, CodigoProyecto, EstadoEtapa);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GEtapa_O_SiguienteCodigoEtapa()
    {
        int resultado = 0;
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                resultado = clienteSWLNGAAP.Obtener_GEtapa_O_SiguienteCodigoEtapa();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return resultado;
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(string CodigoProyecto)
    {
        EGEtapa eGEtapa = new EGEtapa();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGEtapa = clienteSWLNGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(CodigoProyecto.ToUpper());
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eGEtapa;
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string CodigoProyecto, byte NumeroSubEtapa)
    {
        EGEtapa eGEtapa = new EGEtapa();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGEtapa = clienteSWLNGAAP.Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(CodigoProyecto.ToUpper(), NumeroSubEtapa);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eGEtapa;
    }

    public void Actualizar_GEtapa_A_EstadoEtapa(int CodigoEtapa, char EstadoEtapa)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GEtapa_A_EstadoEtapa(CodigoEtapa, EstadoEtapa);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region GSubEtapa
    public void Insertar_GSubEtapa_I(int CodigoSubEtapa, byte NumeroSubEtapa, DateTime FechaInicioSubEtapa, DateTime FechaDefinidaSubEtapa, DateTime FechaFinSubEtapa, string CodigoUsuarioFirma, int CodigoEtapa, char EstadoSubEtapa)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GSubEtapa_I(CodigoSubEtapa, NumeroSubEtapa, FechaInicioSubEtapa, FechaDefinidaSubEtapa, FechaFinSubEtapa, CodigoUsuarioFirma, CodigoEtapa, EstadoSubEtapa);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa()
    {
        int resultado = 0;
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                resultado = clienteSWLNGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return resultado;
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(int CodigoEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGSubEtapa = clienteSWLNGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(CodigoEtapa);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eGSubEtapa;
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int CodigoEtapa, byte NumeroSubEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGSubEtapa = clienteSWLNGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(CodigoEtapa, NumeroSubEtapa);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eGSubEtapa;
    }
    public void Actualizar_GSubEtapa_A_EstadoSubEtapa(int CodigoSubEtapa, char EstadoSubEtapa)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(CodigoSubEtapa, EstadoSubEtapa);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region GObservacion
    public void Insertar_GObservacion_I(int CodigoObservacion, string CodigoProyecto, int CodigoSubEtapa, string CodigoUsuarioObservacion, string ComentarioObservacion, char TipoObservacion, char EstadoObservacion)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GObservacion_I(CodigoObservacion, CodigoProyecto, CodigoSubEtapa, CodigoUsuarioObservacion, ComentarioObservacion, TipoObservacion, EstadoObservacion);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GObsevacion_O_SiguienteCodigoObservacion()
    {
        int resultado = 0;
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                resultado = clienteSWLNGAAP.Obtener_GObsevacion_O_SiguienteCodigoObservacion();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return resultado;
    }
    public List<EGObservacion> Obtener_GObservacion_O_CodigoProyecto(string CodigoProyecto)
    {
        List<EGObservacion> lstObservacion = new List<EGObservacion>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstObservacion = clienteSWLNGAAP.Obtener_GObservacion_O_CodigoProyecto(CodigoProyecto).ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstObservacion;
    }
    public EGObservacion Obtener_GObservacion_O_CodigoObservacion(int CodigoObservacion)
    {
        EGObservacion eGObservacion = new EGObservacion();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGObservacion = clienteSWLNGAAP.Obtener_GObservacion_O_CodigoObservacion(CodigoObservacion);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eGObservacion;
    }
    public void Actualizar_GObservacion_A(int CodigoObservacion, string CodigoProyecto, int CodigoSubEtapa, string CodigoUsuarioObservacion, string ComentarioObservacion, char TipoObservacion, char EstadoObservacion)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GObservacion_A(CodigoObservacion, CodigoProyecto, CodigoSubEtapa, CodigoUsuarioObservacion, ComentarioObservacion, TipoObservacion, EstadoObservacion);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GObservacion_A_EstadoObservacion(int CodigoObservacion, char EstadoObservacion)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GObservacion_A_EstadoObservacion(CodigoObservacion, EstadoObservacion);
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
    #endregion
    #region GUsuario
    public void Insertar_GUsuario_I(string CodigoUsuario, string NombreCompletoUsuario, string SedeUsuario)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GUsuario_I(CodigoUsuario, NombreCompletoUsuario, SedeUsuario);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGUsuario Obtener_GUsuario_O_CodigoUsuario(string CodigoUsuario)
    {
        EGUsuario eGUsuario = new EGUsuario();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGUsuario = clienteSWLNGAAP.Obtener_GUsuario_O_CodigoUsuario(CodigoUsuario);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eGUsuario;
    }
    public void Actualizar_GUsuario_A(string CodigoUsuario, string NombreCompletoUsuario, string SedeUsuario)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GUsuario_A(CodigoUsuario, NombreCompletoUsuario, SedeUsuario);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region GRol
    public List<EGRol> Obtener_GRol_O_Todo()
    {
        List<EGRol> lstEGRol = new List<EGRol>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGRol = clienteSWLNGAAP.Obtener_GRol_O_Todo().ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEGRol;
    }
    public EGRol Obtener_GRol_O_CodigoRol(string CodigoRol)
    {
        EGRol rol =new EGRol();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                rol = clienteSWLNGAAP.Obtener_GRol_O_CodigoRol(CodigoRol);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return rol;
    }
    #endregion
    #region GTutorExterno
    
    public List<EGTutorExterno> Obtener_GTutorExterno_O_Todo()
    {
        List<EGTutorExterno> lstEGTutorExterno = new List<EGTutorExterno>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGTutorExterno = clienteSWLNGAAP.Obtener_GTutorExterno_O_Todo().ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEGTutorExterno;
    }

    public EGTutorExterno Obtener_GTutorExterno_O_CodigoTutorExterno(int codigoTutorExterno)
    {
        EGTutorExterno eGTutorExterno = new EGTutorExterno();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGTutorExterno = clienteSWLNGAAP.Obtener_GTutorExterno_O_CodigoTutorExterno(codigoTutorExterno);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eGTutorExterno;
    }

    public void Insertar_GTutorExterno_I(int codigoTutorExterno, string nombresTutorExterno, string apellidosTutorExterno, string carreraTutorExterno, string direccionTrabajoTutorExterno, string descripcionTutorExterno, string sedeTutorExterno)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GTutorExterno_I(codigoTutorExterno, nombresTutorExterno, apellidosTutorExterno, carreraTutorExterno, direccionTrabajoTutorExterno, descripcionTutorExterno, sedeTutorExterno);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Actualizar_GTutorExterno_A(int codigoTutorExterno, string nombresTutorExterno, string apellidosTutorExterno, string carreraTutorExterno, string direccionTrabajoTutorExterno, string descripcionTutorExterno, string sedeTutorExterno)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GTutorExterno_A(codigoTutorExterno, nombresTutorExterno, apellidosTutorExterno, carreraTutorExterno, direccionTrabajoTutorExterno, descripcionTutorExterno, sedeTutorExterno);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Actualizar_GTutorExterno_A_Estado(int codigoTutorExterno, string estado)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GTutorExterno_A_Estado(codigoTutorExterno, estado);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }




    #endregion
    #region UsuarioNetvalle
    public EUsuarioNetvalle Obtener_UsuarioNetvalle_O_CodigoUsuario(string CodigoUsuario)
    {
        EUsuarioNetvalle eUsuarioNetvalle = new EUsuarioNetvalle();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eUsuarioNetvalle = clienteSWLNGAAP.Obtener_UsuarioNetvalle_O_CodigoUsuario(CodigoUsuario);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eUsuarioNetvalle;
    }
    #endregion
    #region Metodos Complejos

    #region GProyectoCompleja
    public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(string CodigoUsuario)
    {
        List<EProyectoCompleja> lstEGProyectos = new List<EProyectoCompleja>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGProyectos = clienteSWLNGAAP.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(CodigoUsuario).ToList();
            }
        }
        catch (Exception)
        {

            throw;
        }
        return lstEGProyectos;
    }
    public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(string CodigoUsuario)
    {
        List<EProyectoCompleja> lstEGProyectos = new List<EProyectoCompleja>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGProyectos = clienteSWLNGAAP.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(CodigoUsuario).ToList();
            }
        }
        catch (Exception)
        {

            throw;
        }
        return lstEGProyectos;
    }
    #endregion
    #region EProgresoEtapaSubEtapa
    public List<EProgresoEtapaSubEtapa> Obtener_EProgresoEtapaSubEtapa_O(string CodigoProyecto)
    {
        List<EProgresoEtapaSubEtapa> lstEProgresoEtapaSubEtapa = new List<EProgresoEtapaSubEtapa>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEProgresoEtapaSubEtapa = clienteSWLNGAAP.Obtener_EProgresoEtapaSubEtapa_O(CodigoProyecto).ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEProgresoEtapaSubEtapa;
    }
    #endregion
    #region EUsuarioCompleto
    public EUsuarioCompleto Obtener_EUsuarioCompleto_O(string CodigoUsuario, string CodigoProyecto)
    {
        EUsuarioCompleto eEUsuarioCompleto = new EUsuarioCompleto();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eEUsuarioCompleto = clienteSWLNGAAP.Obtener_EUsuarioCompleto_O(CodigoUsuario, CodigoProyecto);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eEUsuarioCompleto;
    }
    #endregion
    #region EProyectoTiempoEntrega
    public List<EProyectoTiempoEntrega> Obtener_EProyectoTiempoEntrega_O(string CodigoUsuario)
    {
        List<EProyectoTiempoEntrega> lstEProyectoTiempoEntrega = new List<EProyectoTiempoEntrega>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEProyectoTiempoEntrega = clienteSWLNGAAP.Obtener_EProyectoTiempoEntrega_O(CodigoUsuario).ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEProyectoTiempoEntrega;
    }
     public bool Verificar_GProyecto_CorrespondeRevision(string CodigoRol, byte NumeroEtapa, byte NumeroSubEtapa)
    {
        bool res;
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                res = clienteSWLNGAAP.Verificar_GProyecto_CorrespondeRevision(CodigoRol, NumeroEtapa, NumeroSubEtapa);
            }
        }
        catch (Exception)
        {

            throw;
        }
        return res;
    }
    public void Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(string CodigoProyecto)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(CodigoProyecto);
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
    public void Insertar_ProyectoCompleto(string CodigoProyecto, string CodigoUsuario, string CodigoDirector, int DiasEtapa, int DiasSubEtapa)
    {
        using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
        {
            clienteSWLNGAAP.Insertar_ProyectoCompleto(CodigoProyecto, CodigoUsuario, CodigoDirector, DiasEtapa, DiasSubEtapa);
        }
    }
    #endregion
    #endregion
    #endregion
}