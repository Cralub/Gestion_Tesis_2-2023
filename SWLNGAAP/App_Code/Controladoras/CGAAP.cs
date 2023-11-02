using SWADNETGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Descripción breve de CGAAP
/// </summary>
public class CGAAP
{
    #region Atributos
    ASNETGAAP aSNETGAAP;
    #endregion
    #region Constructor
    public CGAAP()
    {
        aSNETGAAP = new ASNETGAAP();
    }
    #endregion
    #region GUsuarioRol
    public void Insertar_GUsuarioRol_I(int codigoUsuarioRol, string codigoRol, string codigoUsuario)
    {
        EGUsuarioRol eGUsuarioRol = new EGUsuarioRol();
        try
        {
            eGUsuarioRol.CodigoUsuarioRol = codigoUsuarioRol;
            eGUsuarioRol.CodigoRol = codigoRol;
            eGUsuarioRol.CodigoUsuario = codigoUsuario;
            aSNETGAAP.Insertar_GUsuarioRol_I(eGUsuarioRol);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol()
    {
        int codigo = 0;
        try
        {
            codigo = aSNETGAAP.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
            return codigo;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoRol(string codigoRol)
    {
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        try
        {
            lstEGUsuarioRol = aSNETGAAP.Obtener_GUsuarioRol_O_CodigoRol(codigoRol);
            return lstEGUsuarioRol;
        }
        catch (Exception)
        {

            throw;
        }
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoUsuario(string codigoUsuario)
    {
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        try
        {
            lstEGUsuarioRol = aSNETGAAP.Obtener_GUsuarioRol_O_CodigoUsuario(codigoUsuario).ToList();
            return lstEGUsuarioRol;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string codigoUsuario, string codigoRol)
    {
        EGUsuarioRol eGUsuarioRol = new EGUsuarioRol();
        try
        {
            eGUsuarioRol = aSNETGAAP.Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(codigoUsuario, codigoRol);
            return eGUsuarioRol;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GUsuarioRol_A(string codigoUsuario, string codigoRol, int codigoUsuarioRol)
    {
        EGUsuarioRol eGUsuarioRol = new EGUsuarioRol();
        try
        {
            eGUsuarioRol.CodigoUsuarioRol = codigoUsuarioRol;
            eGUsuarioRol.CodigoUsuario = codigoUsuario;
            eGUsuarioRol.CodigoRol = codigoRol;
            aSNETGAAP.Actualizar_GUsuarioRol_A(eGUsuarioRol);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Eliminar_GusuarioRol_E(int codigoUsuarioRol)
    {
        try
        {
            aSNETGAAP.Eliminar_GUsuarioRol_E(codigoUsuarioRol);
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
        EGUsuarioProyecto eGUsuarioProyecto = new EGUsuarioProyecto();
        try
        {
            eGUsuarioProyecto.CodigoUsuarioProyecto = codigoUsuarioProyecto;
            eGUsuarioProyecto.CodigoProyecto = codigoProyecto;
            eGUsuarioProyecto.CodigoUsuario = codigoUsuario;
            eGUsuarioProyecto.CodigoRol = codigoRol;
            eGUsuarioProyecto.EstadoUsuarioProyecto = estadoUsuarioProyecto;
            aSNETGAAP.Insertar_GUsuarioProyecto_I(eGUsuarioProyecto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto()
    {
        try
        {
            return aSNETGAAP.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
        }
        catch (Exception)
        {
            throw;
        }

    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoProyecto(string codigoProyecto)
    {
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        try
        {
            lstEGUsuarioProyecto = aSNETGAAP.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto);
            return lstEGUsuarioProyecto;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoUsuario(string codigoUsuario)
    {
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        try
        {
            lstEGUsuarioProyecto = aSNETGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario(codigoUsuario);
            return lstEGUsuarioProyecto;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGUsuarioProyecto Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(string codigoUsuario, string codigoProyecto)
    {
        try
        {
            return aSNETGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(codigoUsuario, codigoProyecto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GUsuarioProyecto_A(int codigoUsuarioProyecto, string codigoProyecto, string codigoUsuario, string codigoRol, char estadoUsuarioProyecto)
    {
        EGUsuarioProyecto eGProyectoUsuario = new EGUsuarioProyecto();
        try
        {
            eGProyectoUsuario.CodigoUsuarioProyecto = codigoUsuarioProyecto;
            eGProyectoUsuario.CodigoProyecto = codigoProyecto;
            eGProyectoUsuario.CodigoUsuario = codigoUsuario;
            eGProyectoUsuario.CodigoRol = codigoRol;
            eGProyectoUsuario.EstadoUsuarioProyecto = estadoUsuarioProyecto;
            aSNETGAAP.Actualizar_GUsuarioProyecto_A(eGProyectoUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Eliminar_GUsuarioProyecto_E(int codigoUsuarioProyecto)
    {
        try
        {
            aSNETGAAP.Eliminar_GUsuarioProyecto_E(codigoUsuarioProyecto);
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
        EGProyecto eGProyecto = new EGProyecto();
        try
        {
            eGProyecto.CodigoProyecto = codigoProyecto;
            eGProyecto.ModalidadProyecto = modalidadProyecto;
            eGProyecto.TituloProyecto = tituloProyecto;
            eGProyecto.ObjetivoGeneralProyecto = objetivoGeneralProyecto;
            eGProyecto.EnlaceDocumentoProyecto = enlaceDocumentoProyecto;
            eGProyecto.EstadoProyecto = estadoProyecto;
            aSNETGAAP.Insertar_GProyecto_I(eGProyecto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGProyecto> Obtener_GProyecto_O(DateTime fechaInicio, DateTime fechaFin)
    {
        try
        {
            return aSNETGAAP.Obtener_GProyecto_O(fechaInicio, fechaFin);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGProyecto Obtener_GProyecto_O_CodigoProyecto(string codigoProyecto)
    {
        EGProyecto eGProyecto = new EGProyecto();
        try
        {
            eGProyecto = aSNETGAAP.Obtener_GProyecto_O_CodigoProyecto(codigoProyecto.ToUpper());
            return eGProyecto;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGProyecto> Obtener_GProyecto_O_CodigoUsuario(string codigoUsuario)
    {
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = Obtener_GUsuarioProyecto_O_CodigoUsuario(codigoUsuario);
        EGProyecto eEGProyecto;
        List<EGProyecto> lstEGProyecto = new List<EGProyecto>();
        try
        {
            foreach (EGUsuarioProyecto proyectos in lstEGUsuarioProyecto)
            {
                eEGProyecto = new EGProyecto();
                eEGProyecto = Obtener_GProyecto_O_CodigoProyecto(proyectos.CodigoProyecto);
                lstEGProyecto.Add(eEGProyecto);
            }
            return lstEGProyecto;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GProyecto_A(string codigoProyecto, char modalidadProyecto, string tituloProyecto, string objetivoGeneralProyecto, string enlaceDocumentoProyecto)
    {
        EGProyecto eGProyecto = new EGProyecto();
        try
        {
            eGProyecto.CodigoProyecto = codigoProyecto;
            eGProyecto.ModalidadProyecto = modalidadProyecto;
            eGProyecto.TituloProyecto = tituloProyecto;
            eGProyecto.ObjetivoGeneralProyecto = objetivoGeneralProyecto;
            eGProyecto.EnlaceDocumentoProyecto = enlaceDocumentoProyecto;
            aSNETGAAP.Actualizar_GProyecto_A(eGProyecto);
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
        EGEtapa eGEtapa = new EGEtapa();
        try
        {
            eGEtapa.CodigoEtapa = codigoEtapa;
            eGEtapa.CodigoProyecto = codigoProyecto;
            eGEtapa.NumeroEtapa = numeroEtapa;
            eGEtapa.FechaInicioEtapa = fechaInicioEtapa;
            eGEtapa.FechaDefinidaEtapa = fechaDefinidaEtapa;
            eGEtapa.FechaFinEtapa = fechaFinEtapa;
            eGEtapa.EstadoEtapa = estadoEtapa;
            aSNETGAAP.Insertar_GEtapa_I(eGEtapa);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGEtapa> Obtener_GEtapa_O_CodigoProyecto(string codigoProyecto)
    {
        try
        {
            return aSNETGAAP.Obtener_GEtapa_O_CodigoProyecto(codigoProyecto).ToList();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GEtapa_O_SiguienteCodigoEtapa()
    {
        try
        {
            return aSNETGAAP.Obtener_GEtapa_O_SiguienteCodigoEtapa();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(string codigoProyecto, char estadoSubEtapa)
    {
        EGEtapa eGEtapa = new EGEtapa();
        try
        {
            eGEtapa = aSNETGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto.ToUpper(), estadoSubEtapa);
            return eGEtapa;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string codigoProyecto, byte numeroSubEtapa)
    {
        EGEtapa eGEtapa = new EGEtapa();
        try
        {
            eGEtapa = aSNETGAAP.Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(codigoProyecto.ToUpper(), numeroSubEtapa);
            return eGEtapa;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Actualizar_GEtapa_A_EstadoEtapa(int codigoEtapa, char estadoEtapa)
    {
        try
        {
            aSNETGAAP.Actualizar_GEtapa_A_EstadoEtapa(codigoEtapa, estadoEtapa);
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

            aSNETGAAP.Insertar_GFormularioAceptacion_I(eGFormularioAceptacion);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGFormularioAceptacion> Obtener_GFormularioAceptacion_O_CodigoProyecto(string codigoProyecto)
    {
        try
        {
            return aSNETGAAP.Obtener_GFormularioAceptacion_O_CodigoProyecto(codigoProyecto).ToList();
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
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        try
        {
            eGSubEtapa.CodigoSubEtapa = codigoSubEtapa;
            eGSubEtapa.CodigoEtapa = codigoEtapa;
            eGSubEtapa.CodigoUsuarioFirma = codigoUsuarioFirma;
            eGSubEtapa.NumeroSubEtapa = numeroSubEtapa;
            eGSubEtapa.FechaInicioSubEtapa = fechaInicioSubEtapa;
            eGSubEtapa.FechaDefinidaSubEtapa = fechaDefinidaSubEtapa;
            eGSubEtapa.FechaFinSubEtapa = fechaFinSubEtapa;
            eGSubEtapa.EstadoSubEtapa = estadoSubEtapa;
            aSNETGAAP.Insertar_GSubEtapa_I(eGSubEtapa);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGSubEtapa> Obtener_GSubEtapa_O_CodigoEtapa(int codigoEtapa)
    {
        try
        {
            return aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa(codigoEtapa).ToList();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa()
    {
        try
        {
            return aSNETGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(int codigoEtapa, char estadoSubEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        try
        {
            eGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(codigoEtapa, estadoSubEtapa);
            return eGSubEtapa;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int codigoEtapa, byte numeroSubEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        try
        {
            eGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(codigoEtapa, numeroSubEtapa);
            return eGSubEtapa;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GSubEtapa_A_EstadoSubEtapa(int codigoSubEtapa, char estadoSubEtapa)
    {
        try
        {
            aSNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(codigoSubEtapa, estadoSubEtapa);
        }
        catch (Exception)
        {

            throw;
        }
    }
    #endregion
    #region GObservacion
    public void Insertar_GObservacion_I(int codigoObservacion, string codigoProyecto, int codigoSubEtapa, string codigoUsuarioObservacion, string comentarioObservacion, char tipoObservacion, char estadoObservacion)
    {
        EGObservacion eGObservacion = new EGObservacion();
        try
        {
            eGObservacion.CodigoObservacion = codigoObservacion;
            eGObservacion.CodigoProyecto = codigoProyecto;
            eGObservacion.CodigoSubEtapa = codigoSubEtapa;
            eGObservacion.CodigoUsuarioObservacion = codigoUsuarioObservacion;
            eGObservacion.ComentarioObservacion = comentarioObservacion;
            eGObservacion.TipoObservacion = tipoObservacion;
            eGObservacion.EstadoObservacion = estadoObservacion;
            aSNETGAAP.Insertar_GObservacion_I(eGObservacion);
        }
        catch (Exception)
        {

            throw;
        }
    }

    public List<EGObservacion> Obtener_GObservacion_O_CodigoProyecto(string codigoProyecto)
    {
        List<EGObservacion> lstObservacion = new List<EGObservacion>();
        try
        {
            lstObservacion = aSNETGAAP.Obtener_GObservacion_O_CodigoProyecto(codigoProyecto).ToList();
            return lstObservacion;

        }
        catch (Exception)
        {
            throw;
        }
    }    
    public EGObservacion Obtener_GObservacion_O_CodigoObservacion(int codigoObservacion)
    {
        EGObservacion eGObservacion = new EGObservacion();
        try
        {
            eGObservacion = aSNETGAAP.Obtener_GObservacion_O_CodigoObservacion(codigoObservacion);
            return eGObservacion;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Actualizar_GObservacion_A(int codigoObservacion, string codigoProyecto, int codigoSubEtapa, string codigoUsuarioObservacion, string comentarioObservacion, char tipoObservacion, char estadoObservacion)
    {
        EGObservacion eGObservacion = new EGObservacion();
        try
        {
            eGObservacion.CodigoObservacion = codigoObservacion;
            eGObservacion.CodigoProyecto = codigoProyecto;
            eGObservacion.CodigoSubEtapa = codigoSubEtapa;
            eGObservacion.CodigoUsuarioObservacion = codigoUsuarioObservacion;
            eGObservacion.ComentarioObservacion = comentarioObservacion;
            eGObservacion.TipoObservacion = tipoObservacion;
            eGObservacion.EstadoObservacion = estadoObservacion;
            aSNETGAAP.Actualizar_GObservacion_A(eGObservacion);
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
            aSNETGAAP.Actualizar_GObservacion_A_EstadoObservacion(codigoObservacion, estadoObservacion);
        }
        catch (Exception)
        {

            throw;
        }
    }
    public int Obtener_GObsevacion_O_SiguienteCodigoObservacion()
    {
        try
        {
            return aSNETGAAP.Obtener_GObsevacion_O_SiguienteCodigoObservacion();
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    
    #region GUsuario
    public void Insertar_GUsuario_I(string codigoUsuario,string nombreCompletoUsuario, string sedeUsuario)
    {
        EGUsuario eGUsuario = new EGUsuario();
        try
        {
            eGUsuario.CodigoUsuario = codigoUsuario;
            eGUsuario.NombreCompletoUsuario = nombreCompletoUsuario;
            eGUsuario.SedeUsuario = sedeUsuario;
            aSNETGAAP.Insertar_GUsuario_I(eGUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGUsuario Obtener_GUsuario_O_CodigoUsuario(string codigoUsuario)
    {
        try
        {
            return aSNETGAAP.Obtener_GUsuario_O_CodigoUsuario(codigoUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GUsuario_A(string codigoUsuario,string nombreCompletoUsuario, string sedeUsuario)
    {
        EGUsuario eGUsuario = new EGUsuario();
        try
        {
            eGUsuario.CodigoUsuario = codigoUsuario;
            eGUsuario.NombreCompletoUsuario = nombreCompletoUsuario;
            eGUsuario.SedeUsuario = sedeUsuario;
            aSNETGAAP.Actualizar_GUsuario_A(eGUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGUsuario> Obtener_GUsuarios_O_CodigoProyecto(string codigoProyecto)
    {
        List<EGUsuario> lstEGUsuarios = new List<EGUsuario>();
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        try
        {
            lstEGUsuarioProyecto = Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto);
            foreach (EGUsuarioProyecto eGUsuarioProyecto in lstEGUsuarioProyecto)
            {
                EGUsuario eGUsuario = Obtener_GUsuario_O_CodigoUsuario(eGUsuarioProyecto.CodigoUsuario);

                lstEGUsuarios.Add(eGUsuario);
            }
            return lstEGUsuarios;
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region GRol
    public List<EGRol> Obtener_GRol_O()
    {
        try
        {
            return aSNETGAAP.Obtener_GRol_O();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGRol Obtener_GRol_O_CodigoRol(string codigoRol)
    {
        try
        {
            return aSNETGAAP.Obtener_GRol_O_CodigoRol(codigoRol);
        }
        catch (Exception)
        {

            throw;
        }
    }
    #endregion
    #region UsuarioNetvalle
    public EUsuarioNetvalle Obtener_UsuarioNetvalle_O_CodigoUsuario(string codigoUsuario)
    {
        try
        {
            return aSNETGAAP.Obtener_UsuarioNetvalle_O_CodigoUsuario(codigoUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region GCelular
    public void Insertar_GCelular_I(string codigoUsuario, string codigoAreaCelular, int numeroCelular)
    {
        EGCelular celular = new EGCelular();
        try
        {
            celular.CodigoCelular = aSNETGAAP.Obtener_GCelular_O_SiguienteCodigoCelular();
            celular.CodigoUsuario = codigoUsuario;
            celular.CodigoAreaCelular = codigoAreaCelular;
            celular.NumeroCelular = numeroCelular;
            aSNETGAAP.Insertar_GCelular_I(celular);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGCelular Obtener_GCelular_O_CodigoUsuario(string codigoUsuario)
    {
        try
        {
            return aSNETGAAP.Obtener_GCelular_O_CodigoUsuario(codigoUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GCelular_A(int codigoCelular, string codigoUsuario, string codigoAreaCelular, int numeroCelular)
    {
        EGCelular celular = new EGCelular();
        try
        {
            celular.CodigoCelular = codigoCelular;
            celular.CodigoUsuario = codigoUsuario;
            celular.CodigoAreaCelular = codigoAreaCelular;
            celular.NumeroCelular = numeroCelular;
            aSNETGAAP.Actualizar_GCelular_A(celular);
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
            aSNETGAAP.Eliminar_GCelular_E(codigoCelular);
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
        try
        {
            return aSNETGAAP.Obtener_GTutorExterno_O();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public EGTutorExterno Obtener_GTutorExterno_O_CodigoTutorExterno(int codigoTutorExterno)
    {
        try
        {
            return aSNETGAAP.Obtener_GTutorExterno_O_CodigoTutorExterno(codigoTutorExterno);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Insertar_GTutorExterno_I(int codigoTutorExterno, string nombresTutorExterno, string apellidosTutorExterno, string carreraTutorExterno, string direccionTrabajoTutorExterno, string descripcionTutorExterno, string sedeTutorExterno)
    {
        EGTutorExterno eGTutorExterno = new EGTutorExterno();
        try
        {
            eGTutorExterno.CodigoTutorExterno = codigoTutorExterno;
            eGTutorExterno.NombresTutorExterno = nombresTutorExterno;
            eGTutorExterno.ApellidosTutorExterno = apellidosTutorExterno;
            eGTutorExterno.CarreraTutorExterno = carreraTutorExterno;
            eGTutorExterno.DireccionTrabajoTutorExterno = direccionTrabajoTutorExterno;
            eGTutorExterno.DescripcionTutorExterno = descripcionTutorExterno;
            eGTutorExterno.SedeTutorExterno = sedeTutorExterno;
            aSNETGAAP.Insertar_GTutorExterno_I(eGTutorExterno);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Actualizar_GTutorExterno_A(int codigoTutorExterno, string nombresTutorExterno, string apellidosTutorExterno, string carreraTutorExterno, string direccionTrabajoTutorExterno, string descripcionTutorExterno, string sedeTutorExterno)
    {
        EGTutorExterno eGTutorExterno = new EGTutorExterno();
        try
        {
            eGTutorExterno.CodigoTutorExterno = codigoTutorExterno;
            eGTutorExterno.NombresTutorExterno = nombresTutorExterno;
            eGTutorExterno.ApellidosTutorExterno = apellidosTutorExterno;
            eGTutorExterno.CarreraTutorExterno = carreraTutorExterno;
            eGTutorExterno.DireccionTrabajoTutorExterno = direccionTrabajoTutorExterno;
            eGTutorExterno.DescripcionTutorExterno = descripcionTutorExterno;
            eGTutorExterno.SedeTutorExterno = sedeTutorExterno;
            aSNETGAAP.Actualizar_GTutorExterno_A(eGTutorExterno);
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
            aSNETGAAP.Eliminar_GTutorExterno_E(codigoTutorExterno);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region Metodos Complejos
    #region GEtapa_SubEtapa
    public void Actualizar_GEtapa_GSubEtapa_A(string codigoProyecto)
    {
        EGEtapa eGEtapa = new EGEtapa();
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        try
        {
            eGEtapa = aSNETGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto, SDatos.ESTADO_ACTIVO);
            eGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(eGSubEtapa.CodigoEtapa, SDatos.ESTADO_ACTIVO);
            byte NumeroSubEtapa = eGSubEtapa.NumeroSubEtapa;


        }
        catch (Exception)
        {

            throw;
        }

    }
    #endregion
    #region EProgresoEtapaSubEtapa
    public List<EProgresoEtapaSubEtapa> Obtener_EProgresoEtapaSubEtapa_O(string codigoProyecto)
    {
        EProgresoEtapaSubEtapa eEProgresoEtapaSubEtapa;
        List<EProgresoEtapaSubEtapa> lstEProgresoEtapaSubEtapa = new List<EProgresoEtapaSubEtapa>();
        try
        {
            foreach (EGEtapa etapas in Obtener_GEtapa_O_CodigoProyecto(codigoProyecto))
            {
                eEProgresoEtapaSubEtapa = new EProgresoEtapaSubEtapa();
                eEProgresoEtapaSubEtapa.NumeroEtapa = etapas.NumeroEtapa;
                eEProgresoEtapaSubEtapa.EstadoEtapa = etapas.EstadoEtapa;
                eEProgresoEtapaSubEtapa.CantidadSubEtapaTotal = Obtener_GSubEtapa_O_CodigoEtapa(etapas.CodigoEtapa).Count();
                eEProgresoEtapaSubEtapa.CantidadSubEtapaFinalizada = Obtener_GSubEtapa_O_CodigoEtapa(etapas.CodigoEtapa).Where(subetapa => subetapa.EstadoSubEtapa == 'F').Count();
                lstEProgresoEtapaSubEtapa.Add(eEProgresoEtapaSubEtapa);
            }
            return lstEProgresoEtapaSubEtapa;
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region EUsuarioCompleto
    public EUsuarioCompleto Obtener_EUsuarioCompleto_O_CodigoUsuario(string codigoUsuario, string codigoProyecto)
    {
        EUsuarioCompleto eEUsuarioCompleto;
        EGUsuario eGUsuario = Obtener_GUsuario_O_CodigoUsuario(codigoUsuario);//Busca usuario en nuestro sistema
        EUsuarioNetvalle eUsuarioNetvalle = Obtener_UsuarioNetvalle_O_CodigoUsuario(eGUsuario.CodigoUsuario);// Busca la informacion del usuario de Netvalle
        EGUsuarioProyecto eGProyectoUsuario = Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(codigoUsuario, codigoProyecto);//Busca el proyecto en el que participa el usuario
        EGUsuarioRol eGUsuarioRol = Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(eGUsuario.CodigoUsuario, eGProyectoUsuario.CodigoRol);// Busca el rol que ocupa en el proyecto
        try
        {
            eEUsuarioCompleto = new EUsuarioCompleto();
            eEUsuarioCompleto.NombreCompleto = eUsuarioNetvalle.NombreCompletoUsuarioNetvalle;
            eEUsuarioCompleto.RolNetvalle = eUsuarioNetvalle.RolUsuarioNetvalle;
            eEUsuarioCompleto.RolProyecto = Obtener_GRol_O().Where(w => w.CodigoRol == eGUsuarioRol.CodigoRol).Select(s => s.DescripcionRol).FirstOrDefault();// Saca la descripcion del rol
            eEUsuarioCompleto.Carrera = eUsuarioNetvalle.CarreraUsuarioNetvalle;
            eEUsuarioCompleto.Facultad = eUsuarioNetvalle.FacultadUsuarioNetvalle;
            eEUsuarioCompleto.Sede = eUsuarioNetvalle.SedeUsuarioNetvalle;
            eEUsuarioCompleto.Direccion = eUsuarioNetvalle.DireccionUsuarioNetvalle;
            eEUsuarioCompleto.DireccionTrabajo = eUsuarioNetvalle.DireccionTrabajoUsuarioNetvalle;
            return eEUsuarioCompleto;
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region EProyectoTiempoEntrega
    public List<EProyectoTiempoEntrega> Obtener_EProyectoTiempoEntrega_O(string codigoUsuario)
    {
        EProyectoTiempoEntrega eEProyectoTiempoEntrega;
        List<EProyectoTiempoEntrega> lstEProyectoTiempoEntrega = new List<EProyectoTiempoEntrega>();
        List<EGProyecto> lstEGProyecto = Obtener_GProyecto_O_CodigoUsuario(codigoUsuario);

        try
        {
            foreach (EGProyecto entrega in lstEGProyecto)
            {
                eEProyectoTiempoEntrega = new EProyectoTiempoEntrega();
                switch (entrega.ModalidadProyecto)
                {
                    case SDatos.CHAR_MODALIDAD_TESIS:
                        eEProyectoTiempoEntrega.Modalidad = SDatos.STRING_MODALIDAD_TESIS;
                        break;
                    case SDatos.CHAR_MODALIDAD_TRABAJO_DIRIGIDO:
                        eEProyectoTiempoEntrega.Modalidad = SDatos.STRING_MODALIDAD_TRABAJO_DIRIGIDO;
                        break;
                    case SDatos.CHAR_MODALIDAD_PROYECTO_DE_GRADO:
                        eEProyectoTiempoEntrega.Modalidad = SDatos.STRING_MODALIDAD_PROYECTO_DE_GRADO;
                        break;
                }
                eEProyectoTiempoEntrega.Titulo = entrega.TituloProyecto;
                eEProyectoTiempoEntrega.Objetivo = entrega.ObjetivoGeneralProyecto;
                eEProyectoTiempoEntrega.Documento = entrega.EnlaceDocumentoProyecto;
                eEProyectoTiempoEntrega.FechaEntrega = Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(
                                                            Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(
                                                                entrega.CodigoProyecto, SDatos.ESTADO_ACTIVO)
                                                                    .CodigoEtapa, SDatos.ESTADO_ACTIVO)
                                                                    .FechaDefinidaSubEtapa;
                lstEProyectoTiempoEntrega.Add(eEProyectoTiempoEntrega);
            }
            return lstEProyectoTiempoEntrega;
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region GProyectoCompleja
    #region Obtener Proyecto Completo
    public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(string codigoUsuario)
    {
        return Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(codigoUsuario, true);

    }
    public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(string codigoUsuario)
    {
        return Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(codigoUsuario, false);

    }
    public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(string codigoUsuario, bool conValidacionDeRevision)
    {
        //Lista de Proyectos Validados para revision por Rol - Etapa - SubEtapa
        List<EProyectoCompleja> lstEGProyectos = new List<EProyectoCompleja>();
        try
        {
            //Lista de GProyetoUsuario -> Todos los GProyecto que participan por Usuario
            List<EGUsuarioProyecto> lstEGProyectosPorUsuario = new List<EGUsuarioProyecto>();
            lstEGProyectosPorUsuario = aSNETGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario(codigoUsuario);

            //Buscamos la Etapa y SubEtapa Activas para saber el progreso/estado de cada proyecto
            foreach (EGUsuarioProyecto eGUsuarioProyecto in lstEGProyectosPorUsuario)
            {
                bool esValido = true; //Es valido por defecto
                if (conValidacionDeRevision)
                {
                    //Verificamos si en ese momento(etapa y subetapa) y con ese rol le corresponde revisar el proyecto(s)
                    EGEtapa eGEtapa = new EGEtapa();
                    EGSubEtapa eGSubEtapa = new EGSubEtapa();
                    eGEtapa = aSNETGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(eGUsuarioProyecto.CodigoProyecto, SDatos.ESTADO_ACTIVO);
                    eGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(eGEtapa.CodigoEtapa, SDatos.ESTADO_ACTIVO);

                    esValido = Verificar_GProyecto_CorrespondeRevision(eGUsuarioProyecto.CodigoRol, eGEtapa.NumeroEtapa, eGSubEtapa.NumeroSubEtapa);
                }
                //Lista de GProyetoUsuario -> Todos los Usuarios que participan por GProyecto
                List<EGUsuarioProyecto> lstUsuariosPorProyecto = new List<EGUsuarioProyecto>();
                EProyectoCompleja eGProyectoComplejo = new EProyectoCompleja();
                //Obtener GProyecto por CodigoProyecto
                EGProyecto eGProyecto = new EGProyecto();
                eGProyecto = aSNETGAAP.Obtener_GProyecto_O_CodigoProyecto(eGUsuarioProyecto.CodigoProyecto);

                lstUsuariosPorProyecto = aSNETGAAP.Obtener_GUsuarioProyecto_O_CodigoProyecto(eGProyecto.CodigoProyecto);

                //Crear eGProyectoFormularioCompleja con la informacion de GProyecto y GProyectoUsuario
                eGProyectoComplejo.CodigoUsuario = eGUsuarioProyecto.CodigoUsuario;
                eGProyectoComplejo.CodigoRol = eGUsuarioProyecto.CodigoRol;

                eGProyectoComplejo.CodigoProyecto = eGUsuarioProyecto.CodigoProyecto;
                eGProyectoComplejo.TituloProyecto = eGProyecto.TituloProyecto;
                eGProyectoComplejo.ModalidadProyecto = eGProyecto.ModalidadProyecto;
                eGProyectoComplejo.ObjetivoGeneralProyecto = eGProyecto.ObjetivoGeneralProyecto;
                eGProyectoComplejo.EnlaceDocumentoProyecto = eGProyecto.EnlaceDocumentoProyecto;
                eGProyectoComplejo.EstadoProyecto = eGProyecto.EstadoProyecto;
                eGProyectoComplejo.CodigosEstudiantes = lstUsuariosPorProyecto.Where(w => w.CodigoRol == SDatos.ROL_ESTUDIANTE).Select(s => s.CodigoUsuario).ToList();
                eGProyectoComplejo.CodigoTutor = lstUsuariosPorProyecto.Where(w => w.CodigoRol == SDatos.ROL_TUTOR).Select(s => s.CodigoUsuario).FirstOrDefault();

                //Si corresponde validar y no es valido, salta al siguiente y no se agrega a la lista
                if (conValidacionDeRevision && !esValido)
                    continue;

                lstEGProyectos.Add(eGProyectoComplejo);

            }
            return lstEGProyectos;
        }
        catch (Exception)
        {
            throw;
        }
    }


    public bool Verificar_GProyecto_CorrespondeRevision(string Rol, byte Etapa, byte SubEtapa)
    {
        bool res = false;
        switch (Rol)
        {
            case "ES"://Estudiante
                switch (Etapa)
                {
                    case 1://Etapa 1
                        res = (SubEtapa == 1) ? true : false;
                        break;

                }
                break;
            case "TU"://Tutor
                switch (Etapa)
                {
                    case 1://Etapa 1
                        res = (SubEtapa == 2) ? true : false;
                        break;

                }
                break;
            case "DI"://Director -> el codigo continua hasta encontrar break(entra en caso 4)
            case "AD"://Ayudante Director
                switch (Etapa)
                {
                    case 1://Etapa 1
                        res = (SubEtapa == 3) ? true : false;
                        break;

                }
                break;
            case "T1"://Tribunal 1
                break;
            case "T2"://Tribunal 2
                break;
            case "DP"://DAAP
                switch (Etapa)
                {
                    case 1://Etapa 1
                        res = (SubEtapa == 4) ? true : false;
                        break;

                }
                break;
            case "GT"://Gestor
                res = true;
                break;

        }
        return res;
    }
    #endregion
    #region Control de Etapas y SubEtapas
    public void Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(string codigoProyecto)
    {
        EGEtapa eGEtapa = aSNETGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto, SDatos.ESTADO_ACTIVO);
        EGSubEtapa eGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(eGEtapa.CodigoEtapa, SDatos.ESTADO_ACTIVO);
        switch (eGEtapa.NumeroEtapa)
        {
            case 1:
                if (eGSubEtapa.NumeroSubEtapa == SDatos.N_SUB_ETAPAS_ETAPA_1)
                    Avanzar_Etapa(eGEtapa, eGSubEtapa);
                else
                    Avanzar_SubEtapa(eGSubEtapa);
                break;
            case 2:
                if (eGSubEtapa.NumeroSubEtapa == SDatos.N_SUB_ETAPAS_ETAPA_2)
                    Avanzar_Etapa(eGEtapa, eGSubEtapa);
                else
                    Avanzar_SubEtapa(eGSubEtapa);
                break;
            case 3:
                if (eGSubEtapa.NumeroSubEtapa == SDatos.N_SUB_ETAPAS_ETAPA_3)
                    Avanzar_Etapa(eGEtapa, eGSubEtapa);
                else
                    Avanzar_SubEtapa(eGSubEtapa);
                break;
            case 4:                                                             //Falta finalizar
                if (eGSubEtapa.NumeroSubEtapa == SDatos.N_SUB_ETAPAS_ETAPA_4)
                    Avanzar_Etapa(eGEtapa, eGSubEtapa);
                else
                    Avanzar_SubEtapa(eGSubEtapa);
                break;
        }
    }
    private void Avanzar_Etapa(EGEtapa eGEtapa, EGSubEtapa eGSubEtapa)
    {
        EGEtapa siguienteEGEtapa = Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(eGEtapa.CodigoProyecto, (byte)((int)eGEtapa.NumeroEtapa + 1));
        aSNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(eGSubEtapa.CodigoSubEtapa, SDatos.ESTADO_FINALIZADO);
        aSNETGAAP.Actualizar_GEtapa_A_EstadoEtapa(eGEtapa.CodigoEtapa, SDatos.ESTADO_FINALIZADO);
        aSNETGAAP.Actualizar_GEtapa_A_EstadoEtapa(siguienteEGEtapa.CodigoEtapa, SDatos.ESTADO_ACTIVO);
        EGSubEtapa siguienteEGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(siguienteEGEtapa.CodigoEtapa, (byte)1);
        aSNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(siguienteEGSubEtapa.CodigoSubEtapa, SDatos.ESTADO_ACTIVO);
    }
    private void Avanzar_SubEtapa(EGSubEtapa eGSubEtapa)
    {
        EGSubEtapa siguienteEGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(eGSubEtapa.CodigoEtapa, (byte)((int)eGSubEtapa.NumeroSubEtapa + 1));
        aSNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(eGSubEtapa.CodigoSubEtapa, SDatos.ESTADO_FINALIZADO);
        aSNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(siguienteEGSubEtapa.CodigoSubEtapa, SDatos.ESTADO_ACTIVO);
    }
    #endregion

    public void Insertar_ProyectoCompleto(string codigoProyecto, string codigoUsuario, string codigoDirector, int diasEtapa, int diasSubEtapa)
    {
        try
        {
            DateTime fechaActual = DateTime.Now;
            #region Insertar GProyecto
            EGProyecto eGProyecto = new EGProyecto();
            eGProyecto.CodigoProyecto = codigoProyecto;
            eGProyecto.ModalidadProyecto = SDatos.CHAR_SIN_MODALIDAD;
            eGProyecto.TituloProyecto = SDatos.TITULO_POR_DEFECTO;
            eGProyecto.ObjetivoGeneralProyecto = SDatos.OBJETIVO_GENERAL_POR_DEFECTO;
            eGProyecto.ObjetivosEspecificosProyecto = SDatos.OBJETIVOS_ESPECIFICOS_POR_DEFECTO;
            eGProyecto.AlcanceProyecto = SDatos.ALCANCE_POR_DEFECTO;
            eGProyecto.EnlaceDocumentoProyecto = SDatos.ENLACE_DOCUMENTO_POR_DEFECTO;
            eGProyecto.NumeroRevisiones = SDatos.NUMERO_REVISIONES_POR_DEFECTO;
            aSNETGAAP.Insertar_GProyecto_I(eGProyecto);
            #endregion
            #region Insertar GEtapas, GSubEtapas cascada
            for (int indice = 1; indice <= 4; indice++) // 4
            {
                int CodigoEtapa = aSNETGAAP.Obtener_GEtapa_O_SiguienteCodigoEtapa();
                //Crear Etapa
                EGEtapa eGEtapa = new EGEtapa();
                eGEtapa.CodigoEtapa = CodigoEtapa;
                eGEtapa.CodigoProyecto = codigoProyecto;
                eGEtapa.NumeroEtapa = (byte)indice;
                eGEtapa.FechaInicioEtapa = fechaActual;
                eGEtapa.FechaDefinidaEtapa = fechaActual.AddDays(diasEtapa);
                eGEtapa.FechaFinEtapa = fechaActual.AddDays(diasEtapa);
                eGEtapa.EstadoEtapa = (indice == 1) ? SDatos.ESTADO_ACTIVO : SDatos.ESTADO_PAUSADO;
                aSNETGAAP.Insertar_GEtapa_I(eGEtapa);
                //Crear SubEtapas
                AgregarSubEtapas(indice, CodigoEtapa, fechaActual, diasSubEtapa);
            }
            #endregion
            #region Insertar GUsuarioProyectos
            //Conectar el estuante al proyecto
            EGUsuarioProyecto eGUsuarioProyectoEstudiante = new EGUsuarioProyecto();
            eGUsuarioProyectoEstudiante.CodigoUsuarioProyecto = aSNETGAAP.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
            eGUsuarioProyectoEstudiante.CodigoProyecto = codigoProyecto;
            eGUsuarioProyectoEstudiante.CodigoUsuario = codigoUsuario;
            eGUsuarioProyectoEstudiante.CodigoRol = SDatos.ROL_ESTUDIANTE;
            eGUsuarioProyectoEstudiante.EstadoUsuarioProyecto = SDatos.ESTADO_ACTIVO;
            aSNETGAAP.Insertar_GUsuarioProyecto_I(eGUsuarioProyectoEstudiante);

            //Conectar el director al proyecto
            EGUsuarioProyecto eGUsuarioProyectoDirector = new EGUsuarioProyecto();
            eGUsuarioProyectoDirector.CodigoUsuarioProyecto = aSNETGAAP.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
            eGUsuarioProyectoDirector.CodigoProyecto = codigoProyecto;
            eGUsuarioProyectoDirector.CodigoUsuario = codigoDirector;
            eGUsuarioProyectoDirector.CodigoRol = SDatos.ROL_DIRECTOR_CARRERA;
            eGUsuarioProyectoDirector.EstadoUsuarioProyecto = SDatos.ESTADO_ACTIVO;
            aSNETGAAP.Insertar_GUsuarioProyecto_I(eGUsuarioProyectoDirector);
            #endregion
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void AgregarSubEtapas(int numeroEtapa, int codigoEtapa, DateTime fechaActual, int diasSubEtapa)
    {
        switch (numeroEtapa) //4+7+7+7=25
        {
            #region Etapa 1
            case 1:
                for (int indice = 1; indice <= 4; indice++) //4
                {
                    EGSubEtapa eGSubEtapa = new EGSubEtapa();
                    eGSubEtapa.CodigoSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
                    eGSubEtapa.CodigoEtapa = codigoEtapa;
                    eGSubEtapa.NumeroSubEtapa = (byte)indice;
                    eGSubEtapa.FechaInicioSubEtapa = fechaActual;
                    eGSubEtapa.FechaDefinidaSubEtapa = fechaActual.AddDays(diasSubEtapa);
                    eGSubEtapa.FechaFinSubEtapa = fechaActual.AddDays(diasSubEtapa);
                    eGSubEtapa.EstadoSubEtapa = (indice == 1) ? SDatos.ESTADO_ACTIVO : SDatos.ESTADO_PAUSADO;
                    aSNETGAAP.Insertar_GSubEtapa_I(eGSubEtapa);
                }
                break;
            #endregion
            #region Etapa 2
            case 2:
                for (int indice = 1; indice <= 7; indice++) //7
                {
                    EGSubEtapa eGSubEtapa = new EGSubEtapa();
                    eGSubEtapa.CodigoSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
                    eGSubEtapa.CodigoEtapa = codigoEtapa;
                    eGSubEtapa.NumeroSubEtapa = (byte)indice;
                    eGSubEtapa.FechaInicioSubEtapa = fechaActual;
                    eGSubEtapa.FechaDefinidaSubEtapa = fechaActual.AddDays(diasSubEtapa);
                    eGSubEtapa.FechaFinSubEtapa = fechaActual.AddDays(diasSubEtapa);
                    eGSubEtapa.EstadoSubEtapa = SDatos.ESTADO_PAUSADO;
                    aSNETGAAP.Insertar_GSubEtapa_I(eGSubEtapa);
                }
                break;
            #endregion
            #region Etapa 3
            case 3:
                for (int indice = 1; indice <= 7; indice++) //7
                {
                    EGSubEtapa eGSubEtapa = new EGSubEtapa();
                    eGSubEtapa.CodigoSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
                    eGSubEtapa.CodigoEtapa = codigoEtapa;
                    eGSubEtapa.NumeroSubEtapa = (byte)indice;
                    eGSubEtapa.FechaInicioSubEtapa = fechaActual;
                    eGSubEtapa.FechaDefinidaSubEtapa = fechaActual.AddDays(diasSubEtapa);
                    eGSubEtapa.FechaFinSubEtapa = fechaActual.AddDays(diasSubEtapa);
                    eGSubEtapa.EstadoSubEtapa = SDatos.ESTADO_PAUSADO;
                    aSNETGAAP.Insertar_GSubEtapa_I(eGSubEtapa);
                }
                break;
            #endregion
            #region Etapa 4
            case 4:
                for (int indice = 1; indice <= 7; indice++) //7
                {
                    EGSubEtapa eGSubEtapa = new EGSubEtapa();
                    eGSubEtapa.CodigoSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
                    eGSubEtapa.CodigoEtapa = codigoEtapa;
                    eGSubEtapa.NumeroSubEtapa = (byte)indice;
                    eGSubEtapa.FechaInicioSubEtapa = fechaActual;
                    eGSubEtapa.FechaDefinidaSubEtapa = fechaActual.AddDays(diasSubEtapa);
                    eGSubEtapa.FechaFinSubEtapa = fechaActual.AddDays(diasSubEtapa);
                    eGSubEtapa.EstadoSubEtapa = SDatos.ESTADO_PAUSADO;
                    aSNETGAAP.Insertar_GSubEtapa_I(eGSubEtapa);
                }
                break;
            #endregion
        }
    }
    #endregion

    #endregion

}