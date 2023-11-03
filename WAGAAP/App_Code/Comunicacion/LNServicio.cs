using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
    private EDefecto ConstruirDefecto(TTipoDefecto tipoDefecto, string metodo, string excepcion, string mensaje, string stackTrace)
    {
        EDefecto eDefecto = new EDefecto
        {
            TipoDefecto = tipoDefecto,
            Servicio = SDatosGlobales.NOMBRE_APLICACION,
            Clase = NombreClase,
            Metodo = metodo,
            Mensaje = mensaje,
            Excepcion = excepcion,
        };

        return eDefecto;
    }

    private EDefecto ConstruirDefecto(TTipoDefecto tipoDefecto, string metodo, string excepcion, string mensaje)
    {
        EDefecto eDefecto = new EDefecto
        {
            TipoDefecto = tipoDefecto,
            Servicio = SDatosGlobales.NOMBRE_APLICACION,
            Clase = NombreClase,
            Metodo = metodo,
            Mensaje = mensaje,
            Excepcion = excepcion
        };

        return eDefecto;
    }

    private EDefecto ConstruirDefecto(FaultException<EDefecto> ex)
    {
        EDefecto eDefecto = new EDefecto
        {
            TipoDefecto = ex.Detail.TipoDefecto,
            Servicio = ex.Detail.Servicio,
            Clase = ex.Detail.Clase,
            Metodo = ex.Detail.Metodo,
            Excepcion = ex.Detail.Excepcion,
            Mensaje = ex.Detail.Mensaje,
        };
        return eDefecto;
    }
    #endregion

    #region Metodos Publicos

    #region GUsuarioRol
    public void Insertar_GUsuarioRol_I(int codigoUsuarioRol, string codigoRol, string codigoUsuario)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient()) 
            {
                clienteSWLNGAAP.Insertar_GUsuarioRol_I(codigoUsuarioRol, codigoRol, codigoUsuario);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol()
    {
        int siguienteCodigo = 0;
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                siguienteCodigo = clienteSWLNGAAP.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return siguienteCodigo;
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoRol(string codigoRol)
    {
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGUsuarioRol = clienteSWLNGAAP.Obtener_GUsuarioRol_O_CodigoRol(codigoRol).ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEGUsuarioRol;
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoUsuario(string codigoUsuario)
    {
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGUsuarioRol = clienteSWLNGAAP.Obtener_GUsuarioRol_O_CodigoUsuario(codigoUsuario).ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEGUsuarioRol;
    }
    public EGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string codigoUsuario, string codigoRol)
    {
        EGUsuarioRol eGUsuarioRol = new EGUsuarioRol();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGUsuarioRol = clienteSWLNGAAP.Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(codigoUsuario, codigoRol);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eGUsuarioRol;
    }
    public void Actualizar_GUsuarioRol_A(string codigoUsuario, string codigoRol, int codigoUsuarioRol)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GUsuarioRol_A(codigoUsuario, codigoRol, codigoUsuarioRol);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Eliminar_GUsuarioRol_E(int codigoUsuarioRol)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Eliminar_GUsuarioRol_E(codigoUsuarioRol);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region GUsuarioProyecto
    public void Insertar_GUsuarioProyecto_I(int codigoUsuarioProyecto, string codigoProyecto, string codigoUsuario, string codigoRol, char estadoUsuarioProyecto)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GUsuarioProyecto_I(codigoUsuarioProyecto, codigoProyecto, codigoUsuario, codigoRol, estadoUsuarioProyecto);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto()
    {
        int siguienteCodigo = 0;
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                siguienteCodigo = clienteSWLNGAAP.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return siguienteCodigo;
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoProyecto(string codigoProyecto)
    {
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGUsuarioProyecto = clienteSWLNGAAP.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto).ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEGUsuarioProyecto;
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoUsuario(string codigoUsuario)
    {
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGUsuarioProyecto = clienteSWLNGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario(codigoUsuario).ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEGUsuarioProyecto;
    }
    public void Actualizar_GUsuarioProyecto_A(int codigoUsuarioProyecto, string codigoProyecto, string codigoUsuario, string codigoRol, char estadoUsuarioProyecto)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GUsuarioProyecto_A(codigoUsuarioProyecto, codigoProyecto, codigoUsuario, codigoRol, estadoUsuarioProyecto);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Eliminar_GUsuarioProyecto_E(int codigoUsuarioProyecto)
    {
        using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
        {
            clienteSWLNGAAP.Eliminar_GUsuarioProyecto_E(codigoUsuarioProyecto);
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
    public void Insertar_GProyecto_I(string codigoProyecto, char modalidadProyecto, string tituloProyecto, string objetivoGeneralProyecto, string enlaceDocumentoProyecto, char estadoProyecto)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GProyecto_I(codigoProyecto, modalidadProyecto, tituloProyecto, objetivoGeneralProyecto, enlaceDocumentoProyecto, estadoProyecto);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGProyecto> Obtener_GProyecto_O(DateTime fechaInicio, DateTime fechaFin)
    {
        List<EGProyecto> lstEGProyecto = new List<EGProyecto>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGProyecto = clienteSWLNGAAP.Obtener_GProyecto_O(fechaInicio, fechaFin).ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEGProyecto;
    }
    public EGProyecto Obtener_GProyecto_O_CodigoProyecto(string codigoProyecto)
    {
        EGProyecto eGProyecto = new EGProyecto();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGProyecto = clienteSWLNGAAP.Obtener_GProyecto_O_CodigoProyecto(codigoProyecto.ToUpper());
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eGProyecto;
    }
    public void Actualizar_GProyecto_A(string codigoProyecto, char modalidadProyecto, string tituloProyecto, string objetivoGeneralProyecto, string enlaceDocumentoProyecto)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GProyecto_A(codigoProyecto, modalidadProyecto, tituloProyecto, objetivoGeneralProyecto, enlaceDocumentoProyecto);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region GEtapa
    public void Insertar_GEtapa_I(int codigoEtapa, byte numeroEtapa, DateTime fechaInicioEtapa, DateTime fechaDefinidaEtapa, DateTime fechaFinEtapa, string codigoProyecto, char estadoEtapa)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GEtapa_I(codigoEtapa, numeroEtapa, fechaInicioEtapa, fechaDefinidaEtapa, fechaFinEtapa, codigoProyecto, estadoEtapa);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GEtapa_O_SiguienteCodigoEtapa()
    {
        int siguienteCodigo = 0;
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                siguienteCodigo = clienteSWLNGAAP.Obtener_GEtapa_O_SiguienteCodigoEtapa();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return siguienteCodigo;
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(string CodigoProyecto, char estadoEtapa)
    {
        EGEtapa eGEtapa = new EGEtapa();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGEtapa = clienteSWLNGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(CodigoProyecto.ToUpper(), estadoEtapa);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eGEtapa;
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string codigoProyecto, byte numeroSubEtapa)
    {
        EGEtapa eGEtapa = new EGEtapa();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGEtapa = clienteSWLNGAAP.Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(codigoProyecto.ToUpper(), numeroSubEtapa);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eGEtapa;
    }

    public void Actualizar_GEtapa_A_EstadoEtapa(int codigoEtapa, char estadoEtapa)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GEtapa_A_EstadoEtapa(codigoEtapa, estadoEtapa);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region GSubEtapa
    public void Insertar_GSubEtapa_I(int codigoSubEtapa, byte numeroSubEtapa, DateTime fechaInicioSubEtapa, DateTime fechaDefinidaSubEtapa, DateTime fechaFinSubEtapa, string codigoUsuarioFirma, int codigoEtapa, char estadoSubEtapa)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GSubEtapa_I(codigoSubEtapa, numeroSubEtapa, fechaInicioSubEtapa, fechaDefinidaSubEtapa, fechaFinSubEtapa, codigoUsuarioFirma, codigoEtapa, estadoSubEtapa);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa()
    {
        int siguienteCodigo = 0;
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                siguienteCodigo = clienteSWLNGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return siguienteCodigo;
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(int codigoEtapa, char estadoSubEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGSubEtapa = clienteSWLNGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(codigoEtapa, estadoSubEtapa);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eGSubEtapa;
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int codigoEtapa, byte numeroSubEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGSubEtapa = clienteSWLNGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(codigoEtapa, numeroSubEtapa);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eGSubEtapa;
    }
    public void Actualizar_GSubEtapa_A_EstadoSubEtapa(int codigoSubEtapa, char estadoSubEtapa)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(codigoSubEtapa, estadoSubEtapa);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region GFormularioAceptacion
    public void Insertar_GFormularioAceptacion_I(EGFormularioAceptacion eGFormularioAceptacion)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GFormularioAceptacion_I(eGFormularioAceptacion);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGFormularioAceptacion> Obtener_GFormularioAceptacion_O_CodigoProyecto(string codigoProyecto)
    {
        List<EGFormularioAceptacion> lstFormularioAceptacion = new List<EGFormularioAceptacion>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstFormularioAceptacion = clienteSWLNGAAP.Obtener_GFormularioAceptacion_O_CodigoProyecto(codigoProyecto).ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstFormularioAceptacion;
    }
    #endregion
    #region GObservacion
    public void Insertar_GObservacion_I(int codigoObservacion, string codigoProyecto, int codigoSubEtapa, string codigoUsuarioObservacion, string comentarioObservacion, char tipoObservacion, char estadoObservacion)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GObservacion_I(codigoObservacion, codigoProyecto, codigoSubEtapa, codigoUsuarioObservacion, comentarioObservacion, tipoObservacion, estadoObservacion);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GObsevacion_O_SiguienteCodigoObservacion()
    {
        int siguienteCodigo = 0;
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                siguienteCodigo = clienteSWLNGAAP.Obtener_GObsevacion_O_SiguienteCodigoObservacion();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return siguienteCodigo;
    }
    public List<EGObservacion> Obtener_GObservacion_O_CodigoProyecto(string codigoProyecto)
    {
        List<EGObservacion> lstObservacion = new List<EGObservacion>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstObservacion = clienteSWLNGAAP.Obtener_GObservacion_O_CodigoProyecto(codigoProyecto).ToList();
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
    public void Actualizar_GObservacion_A(int codigoObservacion, string codigoProyecto, int codigoSubEtapa, string codigoUsuarioObservacion, string comentarioObservacion, char tipoObservacion, char estadoObservacion)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GObservacion_A(codigoObservacion, codigoProyecto, codigoSubEtapa, codigoUsuarioObservacion, comentarioObservacion, tipoObservacion, estadoObservacion);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GObservacion_A_EstadoObservacion(int codigoObservacion, char estadoObservacion)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GObservacion_A_EstadoObservacion(codigoObservacion, estadoObservacion);
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
    #endregion
    #region GUsuario
    public void Insertar_GUsuario_I(string CodigoUsuario,string nombreCompletoUsuario, string SedeUsuario)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GUsuario_I(CodigoUsuario, nombreCompletoUsuario, SedeUsuario);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGUsuario Obtener_GUsuario_O_CodigoUsuario(string codigoUsuario)
    {
        EGUsuario eGUsuario = new EGUsuario();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGUsuario = clienteSWLNGAAP.Obtener_GUsuario_O_CodigoUsuario(codigoUsuario);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eGUsuario;
    }
    public void Actualizar_GUsuario_A(string codigoUsuario, string nombreCompletoUsuario, string sedeUsuario)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GUsuario_A(codigoUsuario, nombreCompletoUsuario, sedeUsuario);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGUsuario> Obtener_GUsuarios_O_CodigoProyecto(string codigoProyecto)
    {
        List<EGUsuario> lstEGUsuarios = new List<EGUsuario>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGUsuarios = clienteSWLNGAAP.Obtener_GUsuarios_O_CodigoProyecto(codigoProyecto).ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEGUsuarios;
    }
    #endregion
    #region GRol
    public List<EGRol> Obtener_GRol_O()
    {
        List<EGRol> lstEGRol = new List<EGRol>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGRol = clienteSWLNGAAP.Obtener_GRol_O().ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEGRol;
    }
    public EGRol Obtener_GRol_O_CodigoRol(string codigoRol)
    {
        EGRol eGRol =new EGRol();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGRol = clienteSWLNGAAP.Obtener_GRol_O_CodigoRol(codigoRol);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eGRol;
    }
    #endregion
    #region UsuarioNetvalle
    public EUsuarioNetvalle Obtener_UsuarioNetvalle_O_CodigoUsuario(string codigoUsuario)
    {
        EUsuarioNetvalle eUsuarioNetvalle = new EUsuarioNetvalle();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eUsuarioNetvalle = clienteSWLNGAAP.Obtener_UsuarioNetvalle_O_CodigoUsuario(codigoUsuario);
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
    public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(string codigoUsuario)
    {
        List<EProyectoCompleja> lstEGProyectos = new List<EProyectoCompleja>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGProyectos = clienteSWLNGAAP.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(codigoUsuario).ToList();
            }
        }
        catch (Exception)
        {

            throw;
        }
        return lstEGProyectos;
    }
    public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(string codigoUsuario)
    {
        List<EProyectoCompleja> lstEGProyectos = new List<EProyectoCompleja>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGProyectos = clienteSWLNGAAP.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(codigoUsuario).ToList();
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
    public List<EProgresoEtapaSubEtapa> Obtener_EProgresoEtapaSubEtapa_O(string codigoProyecto)
    {
        List<EProgresoEtapaSubEtapa> lstEProgresoEtapaSubEtapa = new List<EProgresoEtapaSubEtapa>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEProgresoEtapaSubEtapa = clienteSWLNGAAP.Obtener_EProgresoEtapaSubEtapa_O(codigoProyecto).ToList();
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
    public EUsuarioCompleto Obtener_EUsuarioCompleto_O(string codigoUsuario, string codigoProyecto)
    {
        EUsuarioCompleto eEUsuarioCompleto = new EUsuarioCompleto();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eEUsuarioCompleto = clienteSWLNGAAP.Obtener_EUsuarioCompleto_O(codigoUsuario, codigoProyecto);
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
    public List<EProyectoTiempoEntrega> Obtener_EProyectoTiempoEntrega_O(string codigoUsuario)
    {
        List<EProyectoTiempoEntrega> lstEProyectoTiempoEntrega = new List<EProyectoTiempoEntrega>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEProyectoTiempoEntrega = clienteSWLNGAAP.Obtener_EProyectoTiempoEntrega_O(codigoUsuario).ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEProyectoTiempoEntrega;
    }
     public bool Verificar_GProyecto_CorrespondeRevision(string codigoRol, byte numeroEtapa, byte numeroSubEtapa)
    {
        bool res;
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                res = clienteSWLNGAAP.Verificar_GProyecto_CorrespondeRevision(codigoRol, numeroEtapa, numeroSubEtapa);
            }
        }
        catch (Exception)
        {

            throw;
        }
        return res;
    }
    public void Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(string codigoProyecto)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(codigoProyecto);
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
    public void Insertar_ProyectoCompleto(string codigoProyecto, string codigoUsuario, string codigoDirector, int diasEtapa, int diasSubEtapa)
    {
        using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
        {
            clienteSWLNGAAP.Insertar_ProyectoCompleto(codigoProyecto, codigoUsuario, codigoDirector, diasEtapa, diasSubEtapa);
        }
    }
    #endregion
    #endregion

    #region Cifrado y descifrado
    public string Descifrar_Cadena(string Texto, string Tipo)
    {
        string textoDescifrado = string.Empty;
        try
        {
            using (SWLNGAAPClient sWLNGAAPClient = new SWLNGAAPClient())
            {
                textoDescifrado = sWLNGAAPClient.Descifrado(Texto, Tipo);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Descifrar_Cadena", ex.Source, ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient sWLNServicioClient = new SWLNGAAPClient())
                {
                    textoDescifrado = sWLNServicioClient.Descifrado(Texto, Tipo);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Descifrar_Cadena", communicationException.ToString(), communicationException.Message, communicationException.StackTrace);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Descifrar_Cadena", ex.Source, ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return textoDescifrado;
    }

    public string Cifrar_Cadena(string TextoACifrar)
    {
        string textoCifrado = string.Empty;

        try
        {
            using (SWLNGAAPClient sWLNGAAPClient = new SWLNGAAPClient())
            {
                textoCifrado = sWLNGAAPClient.Cifrar_Cadena(TextoACifrar);
                //textoCifrado = sWLNServicioClient.Adicionar_VSolicitud()
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Cifrar_Cadena", ex.Source, ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient sWLNGAAPClient = new SWLNGAAPClient())
                {
                    textoCifrado = sWLNGAAPClient.Cifrar_Cadena(TextoACifrar);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Cifrar_Cadena", communicationException.ToString(), communicationException.Message, communicationException.StackTrace);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Cifrar_Cadena", ex.Source, ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return textoCifrado;
    }
    #endregion

    #region EEmpleado
    public Tuple<EEmpleado, EMensajeError> Obtener_Empleado_Id_Emp_SedeAcademica(string Id_Emp, string SedeAcademica)
    {
        Tuple<EEmpleado, EMensajeError> result;
        try
        {
            using (SWLNGAAPClient sWLNGAAPClient = new SWLNGAAPClient())
            {
                result = sWLNGAAPClient.Obtener_Empleado_Id_Emp_SedeAcademica(Id_Emp, SedeAcademica);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_Empleado_Id_Emp_SedeAcademica", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient sWLNGAAPClient = new SWLNGAAPClient())
                {
                    result = sWLNGAAPClient.Obtener_Empleado_Id_Emp_SedeAcademica(Id_Emp, SedeAcademica);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_Empleado_Id_Emp_SedeAcademica", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_Empleado_Id_Emp_SedeAcademica", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_Empleado_Id_Emp_SedeAcademica", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return result;
    }

    public Tuple<byte[], EMensajeError> Obtener_EmpleadoFotografia(string Id_Emp, string SedeAcademica)
    {
        Tuple<byte[], EMensajeError> result;
        try
        {
            using (SWLNGAAPClient sWLNGAAPClient = new SWLNGAAPClient())
            {
                result = sWLNGAAPClient.Obtener_EmpleadoFotografia(Id_Emp, SedeAcademica);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_EmpleadoFotografia", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient sWLNGAAPClient = new SWLNGAAPClient())
                {
                    result = sWLNGAAPClient.Obtener_EmpleadoFotografia(Id_Emp, SedeAcademica);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_EmpleadoFotografia", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_EmpleadoFotografia", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_EmpleadoFotografia", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return result;
    }

    #endregion

    #region GCelular
    public void Insertar_GCelular_I(string codigoUsuario, string codigoAreaCelular, int numeroCelular)
    {
        try
        {
            using (SWLNGAAPClient swlnGAAP = new SWLNGAAPClient())
            {
                swlnGAAP.Insertar_GCelular_I(codigoUsuario, codigoAreaCelular, numeroCelular);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGCelular Obtener_GCelular_O(string codigoUsuario)
    {
        EGCelular celular = new EGCelular();
        try
        {
            using (SWLNGAAPClient swlnGAAP = new SWLNGAAPClient())
            {
                celular = swlnGAAP.Obtener_GCelular_O(codigoUsuario);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return celular;
    }
    public void Actualizar_GCelular_A(int codigoCelular, string codigoUsuario, string codigoAreaCelular, int numeroCelular)
    {
        try
        {
            using (SWLNGAAPClient swlnGAAP = new SWLNGAAPClient())
            {
                swlnGAAP.Actualizar_GCelular_A(codigoCelular, codigoUsuario, codigoAreaCelular, numeroCelular);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Eliminar_GCelular_E(int codigoCelular)
    {
        try
        {
            using (SWLNGAAPClient swlnGAAP = new SWLNGAAPClient())
            {
                swlnGAAP.Eliminar_GCelular_E(codigoCelular);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region GTutorExterno

    public List<EGTutorExterno> Obtener_GTutorExterno_O()
    {
        List<EGTutorExterno> lstEGTutorExterno = new List<EGTutorExterno>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGTutorExterno = clienteSWLNGAAP.Obtener_GTutorExterno_O().ToList();
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

    public void Eliminar_GTutorExterno_E(int codigoTutorExterno)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Eliminar_GTutorExterno_E(codigoTutorExterno);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion




    #endregion
}