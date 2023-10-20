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
    ASNETGAAP asNETGAAP;
    #endregion

    #region Constructor
    public CGAAP()
    {
        asNETGAAP = new ASNETGAAP();
    }
    #endregion


    #region GRol
    //public List<EGRol> Obtener_GRol_O_Todo()
    //{
    //    try
    //    {
    //        return asNetGAAP.Obtener_GRol_O_Todo();
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    //public EGRol Obtener_GRol_O_CodigoRol(string CodigoRol)
    //{             
    //    try
    //    {
    //        return asNetGAAP.Obtener_GRol_O_CodigoRol(CodigoRol);
    //    }
    //    catch (Exception)
    //    {

    //        throw;
    //    }
    //}
    #endregion

    #region GUsuario
    //public void Insertar_GUsuario_I(string CodigoUsuario, string SedeUsuario)
    //{
    //    EGUsuario eGUsuario = new EGUsuario();
    //    try
    //    {
    //        eGUsuario.CodigoUsuario = CodigoUsuario;
    //        eGUsuario.SedeUsuario = SedeUsuario;
    //        asNetGAAP.Insertar_GUsuario_I(eGUsuario);
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    //public EGUsuario Obtener_GUsuario_O_CodigoUsuario(string CodigoUsuario)
    //{
    //    try
    //    {
    //        return asNetGAAP.Obtener_GUsuario_O_CodigoUsuario(CodigoUsuario);
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    //public void Actualizar_GUsuario_A(string CodigoUsuario, string SedeUsuario)
    //{
    //    EGUsuario eGUsuario = new EGUsuario();
    //    try
    //    {
    //        eGUsuario.CodigoUsuario = CodigoUsuario;
    //        eGUsuario.SedeUsuario = SedeUsuario;
    //        asNetGAAP.Actualizar_GUsuario_A(eGUsuario);
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    #endregion

    #region GTutorExterno
    #endregion

    #region GCelular
    public void Insertar_GCelular_I(string codigoUsuario, string codigoAreaCelular, int numeroCelular)
    {
        EGCelular celular = new EGCelular();
        try
        {
            celular.CodigoCelular = asNETGAAP.Obtener_GCelular_O_SiguienteCodigoCelular();
            celular.CodigoUsuario = codigoUsuario;
            celular.CodigoAreaCelular = codigoAreaCelular;
            celular.NumeroCelular = numeroCelular;
            asNETGAAP.Insertar_GCelular_I(celular);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGCelular Obtener_GCelular_O(int codigoCelular)
    {
        try
        {
            return asNETGAAP.Obtener_GCelular_O(codigoCelular);
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
            asNETGAAP.Actualizar_GCelular_A(celular);
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
            asNETGAAP.Eliminar_GCelular_E(codigoCelular);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region GUsuarioRol
    //public void Insertar_GUsuarioRol_I(int CodigoUsuarioRol, string CodigoRol, string CodigoUsuario)
    //{
    //    EGUsuarioRol eGUsuarioRol = new EGUsuarioRol();
    //    try
    //    {
    //        eGUsuarioRol.CodigoUsuarioRol = CodigoUsuarioRol;
    //        eGUsuarioRol.CodigoRol = CodigoRol;
    //        eGUsuarioRol.CodigoUsuario = CodigoUsuario;
    //        asNetGAAP.Insertar_GUsuarioRol_I(eGUsuarioRol);
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    //public int Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol()
    //{
    //    int res = 0;
    //    try
    //    {
    //        res = asNetGAAP.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
    //        return res;
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    //public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoRol(string CodigoRol)
    //{
    //    List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
    //    try
    //    {
    //        lstEGUsuarioRol = asNetGAAP.Obtener_GUsuarioRol_O_CodigoRol(CodigoRol);
    //        return lstEGUsuarioRol;
    //    }
    //    catch (Exception)
    //    {

    //        throw;
    //    }
    //}
    //public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoUsuario(string CodigoUsuario)
    //{
    //    List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
    //    try
    //    {
    //        lstEGUsuarioRol = asNetGAAP.Obtener_GUsuarioRol_O_CodigoUsuario(CodigoUsuario).ToList();
    //        return lstEGUsuarioRol;
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    //public EGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string CodigoUsuario, string CodigoRol)
    //{
    //    EGUsuarioRol eGUsuarioRol = new EGUsuarioRol();
    //    try
    //    {
    //        eGUsuarioRol = asNetGAAP.Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(CodigoUsuario, CodigoRol);
    //        return eGUsuarioRol;
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    //public void Actualizar_GUsuarioRol_A(string CodigoUsuario, string CodigoRol, int CodigoUsuarioRol)
    //{
    //    EGUsuarioRol eGUsuarioRol = new EGUsuarioRol();
    //    try
    //    {
    //        eGUsuarioRol.CodigoUsuarioRol = CodigoUsuarioRol;
    //        eGUsuarioRol.CodigoUsuario = CodigoUsuario;
    //        eGUsuarioRol.CodigoRol = CodigoRol;
    //        asNetGAAP.Actualizar_GUsuarioRol_A(eGUsuarioRol);
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}

    #endregion

    #region GUsuarioProyecto
    //public void Insertar_GUsuarioProyecto_I(int CodigoUsuarioProyecto, string CodigoProyecto, string CodigoUsuario, string CodigoRol, char EstadoUsuarioProyecto)
    //{
    //    EGUsuarioProyecto eGUsuarioProyecto = new EGUsuarioProyecto();
    //    try
    //    {
    //        eGUsuarioProyecto.CodigoUsuarioProyecto = CodigoUsuarioProyecto;
    //        eGUsuarioProyecto.CodigoProyecto = CodigoProyecto;
    //        eGUsuarioProyecto.CodigoUsuario = CodigoUsuario;
    //        eGUsuarioProyecto.CodigoRol = CodigoRol;
    //        eGUsuarioProyecto.EstadoUsuarioProyecto = EstadoUsuarioProyecto;
    //        asNetGAAP.Insertar_GUsuarioProyecto_I(eGUsuarioProyecto);
    //    }
    //    catch (Exception)
    //    {

    //        throw;
    //    }
    //}
    //public int Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto()
    //{
    //    try
    //    {
    //        return asNetGAAP.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }

    //}
    //public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoProyecto(string CodigoProyecto)
    //{
    //    List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
    //    try
    //    {
    //        lstEGUsuarioProyecto = asNetGAAP.Obtener_GUsuarioProyecto_O_CodigoProyecto(CodigoProyecto);
    //        return lstEGUsuarioProyecto;
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    //public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoUsuario(string CodigoUsuario)
    //{
    //    List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
    //    try
    //    {
    //        lstEGUsuarioProyecto = asNetGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario(CodigoUsuario);
    //        return lstEGUsuarioProyecto;
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    //public EGUsuarioProyecto Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(string CodigoUsuario, string CodigoProyecto)
    //{
    //    try
    //    {
    //        return asNetGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(CodigoUsuario, CodigoProyecto);
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    //public void Actualizar_GUsuarioProyecto_A(int CodigoUsuarioProyecto, string CodigoProyecto, string CodigoUsuario,string CodigoRol, char EstadoUsuarioProyecto)
    //{
    //    EGUsuarioProyecto eGProyectoUsuario = new EGUsuarioProyecto();
    //    try
    //    {
    //        eGProyectoUsuario.CodigoUsuarioProyecto = CodigoUsuarioProyecto;
    //        eGProyectoUsuario.CodigoProyecto = CodigoProyecto;
    //        eGProyectoUsuario.CodigoUsuario = CodigoUsuario;
    //        eGProyectoUsuario.CodigoRol = CodigoRol;
    //        eGProyectoUsuario.EstadoUsuarioProyecto = EstadoUsuarioProyecto;
    //        asNetGAAP.Actualizar_GUsuarioProyecto_A(eGProyectoUsuario);
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    #endregion

    #region GProyecto
    public EGProyecto Obtener_GProyecto_O(string codigoProyecto)
    {
        try
        {
            return asNETGAAP.Obtener_GProyecto_O(codigoProyecto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GProyecto_A(string codigoProyecto, char modalidadProyecto, string tituloProyecto, string objetivoGeneralProyecto, string objetivosEspecificosProyecto, string alcanceProyecto, string enlaceDocumentoProyecto)
    {
        EGProyecto proyecto = new EGProyecto();
        try
        {
            proyecto.CodigoProyecto = codigoProyecto;
            proyecto.ModalidadProyecto = modalidadProyecto;
            proyecto.TituloProyecto = tituloProyecto;
            proyecto.ObjetivoGeneralProyecto = objetivoGeneralProyecto;
            proyecto.ObjetivosEspecificosProyecto = objetivosEspecificosProyecto;
            proyecto.AlcanceProyecto = alcanceProyecto;
            proyecto.EnlaceDocumentoProyecto = enlaceDocumentoProyecto;
            asNETGAAP.Actualizar_GProyecto_A(proyecto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region GEtapa
    //public void Insertar_GEtapa_I(int CodigoEtapa, byte NumeroEtapa, DateTime FechaInicioEtapa, DateTime FechaDefinidaEtapa, DateTime FechaFinEtapa, string CodigoProyecto, char EstadoEtapa)
    //{
    //    EGEtapa eGEtapa = new EGEtapa();
    //    try
    //    {
    //        eGEtapa.CodigoEtapa = CodigoEtapa;
    //        eGEtapa.CodigoProyecto = CodigoProyecto;
    //        eGEtapa.NumeroEtapa = NumeroEtapa;
    //        eGEtapa.FechaInicioEtapa = FechaInicioEtapa;
    //        eGEtapa.FechaDefinidaEtapa = FechaDefinidaEtapa;
    //        eGEtapa.FechaFinEtapa = FechaFinEtapa;
    //        eGEtapa.EstadoEtapa = EstadoEtapa;
    //        asNetGAAP.Insertar_GEtapa_I(eGEtapa);
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    //public List<EGEtapa> Obtener_GEtapa_O_CodigoProyecto(string CodigoProyecto)
    //{
    //    try
    //    {
    //        return asNetGAAP.Obtener_GEtapa_O_CodigoProyecto(CodigoProyecto).ToList();
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    //public int Obtener_GEtapa_O_SiguienteCodigoEtapa()
    //{
    //    try
    //    {
    //        return asNetGAAP.Obtener_GEtapa_O_SiguienteCodigoEtapa();
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}

    //public EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(string CodigoProyecto)
    //{
    //    EGEtapa eGEtapa = new EGEtapa();
    //    try
    //    {
    //        eGEtapa = asNetGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(CodigoProyecto.ToUpper());
    //        return eGEtapa;
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    //public EGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string CodigoProyecto, byte NumeroSubEtapa)
    //{
    //    EGEtapa eGEtapa = new EGEtapa();
    //    try
    //    {
    //        eGEtapa = asNetGAAP.Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(CodigoProyecto.ToUpper(), NumeroSubEtapa);
    //        return eGEtapa;
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}

    //public void Actualizar_GEtapa_A_EstadoEtapa(int CodigoEtapa, char EstadoEtapa)
    //{
    //    try
    //    {
    //        asNetGAAP.Actualizar_GEtapa_A_EstadoEtapa(CodigoEtapa, EstadoEtapa);
    //    }
    //    catch (Exception)
    //    {

    //        throw;
    //    }
    //}

    #endregion

    #region GSubEtapa
    //public void Insertar_GSubEtapa_I(int CodigoSubEtapa, byte NumeroSubEtapa, DateTime FechaInicioSubEtapa, DateTime FechaDefinidaSubEtapa, DateTime FechaFinSubEtapa, string CodigoUsuarioFirma, int CodigoEtapa, char EstadoSubEtapa)
    //{
    //    EGSubEtapa eGSubEtapa = new EGSubEtapa();
    //    try
    //    {
    //        eGSubEtapa.CodigoSubEtapa = CodigoSubEtapa;
    //        eGSubEtapa.CodigoEtapa = CodigoEtapa;
    //        eGSubEtapa.CodigoUsuarioFirma = CodigoUsuarioFirma;
    //        eGSubEtapa.NumeroSubEtapa = NumeroSubEtapa;
    //        eGSubEtapa.FechaInicioSubEtapa = FechaInicioSubEtapa;
    //        eGSubEtapa.FechaDefinidaSubEtapa = FechaDefinidaSubEtapa;
    //        eGSubEtapa.FechaFinSubEtapa = FechaFinSubEtapa;
    //        eGSubEtapa.EstadoSubEtapa = EstadoSubEtapa;
    //        asNetGAAP.Insertar_GSubEtapa_I(eGSubEtapa);
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    //public List<EGSubEtapa> Obtener_GSubEtapa_O_CodigoEtapa(int CodigoEtapa)
    //{
    //    try
    //    {
    //        return asNetGAAP.Obtener_GSubEtapa_O_CodigoEtapa(CodigoEtapa).ToList();
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    //public int Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa()
    //{
    //    try
    //    {
    //        return asNetGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    //public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(int CodigoEtapa)
    //{
    //    EGSubEtapa eGSubEtapa = new EGSubEtapa();
    //    try
    //    {
    //        eGSubEtapa = asNetGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(CodigoEtapa);
    //        return eGSubEtapa;
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    //  public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int CodigoEtapa, byte NumeroSubEtapa)
    //{
    //    EGSubEtapa eGSubEtapa = new EGSubEtapa();
    //    try
    //    {
    //        eGSubEtapa = asNetGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(CodigoEtapa, NumeroSubEtapa);
    //        return eGSubEtapa;
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    //public void Actualizar_GSubEtapa_A_EstadoSubEtapa(int CodigoSubEtapa, char EstadoSubEtapa)
    //{
    //    try
    //    {
    //        asNetGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(CodigoSubEtapa, EstadoSubEtapa);
    //    }
    //    catch (Exception)
    //    {

    //        throw;
    //    }
    //}
    #endregion

    #region GObservacion
    public void Actualizar_GObservacion_A_EstadoObservacion(int codigoObservacion, char estadoObservacion)
    {
        try
        {
            asNETGAAP.Actualizar_GObservacion_A_EstadoObservacion(codigoObservacion, estadoObservacion);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region GFormularioAceptacion
    #endregion


    #region GEtapa_SubEtapa
    //public void Actualizar_GEtapa_GSubEtapa_A(string CodigoProyecto)
    //{
    //    EGEtapa eGEtapa = new EGEtapa();
    //    EGSubEtapa eGSubEtapa = new EGSubEtapa();
    //    try
    //    {
    //        eGEtapa = asNetGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(CodigoProyecto);
    //        eGSubEtapa = asNetGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(eGSubEtapa.CodigoEtapa);
    //        byte NumeroSubEtapa = eGSubEtapa.NumeroSubEtapa;


    //    }
    //    catch (Exception)
    //    {

    //        throw;
    //    }

    //}
    #endregion
    #region UsuarioNetvalle
    //public EUsuarioNetvalle Obtener_UsuarioNetvalle_O_CodigoUsuario(string CodigoUsuario)
    //{
    //    try
    //    {
    //        return asNetGAAP.Obtener_UsuarioNetvalle_O_CodigoUsuario(CodigoUsuario);
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    #endregion
    #region Metodos Complejos
    #region EProgresoEtapaSubEtapa
    //public List<EProgresoEtapaSubEtapa> Obtener_EProgresoEtapaSubEtapa_O(string CodigoProyecto)
    //{
    //    EProgresoEtapaSubEtapa eEProgresoEtapaSubEtapa;
    //    List<EProgresoEtapaSubEtapa> lstEProgresoEtapaSubEtapa = new List<EProgresoEtapaSubEtapa>();
    //    try
    //    {
    //        foreach (var etapas in Obtener_GEtapa_O_CodigoProyecto(CodigoProyecto))
    //        {
    //            eEProgresoEtapaSubEtapa = new EProgresoEtapaSubEtapa();
    //            eEProgresoEtapaSubEtapa.NumeroEtapa = etapas.NumeroEtapa;
    //            eEProgresoEtapaSubEtapa.EstadoEtapa = etapas.EstadoEtapa;
    //            eEProgresoEtapaSubEtapa.CantidadSubEtapaTotal = Obtener_GSubEtapa_O_CodigoEtapa(etapas.CodigoEtapa).Count();
    //            eEProgresoEtapaSubEtapa.CantidadSubEtapaFinalizada = Obtener_GSubEtapa_O_CodigoEtapa(etapas.CodigoEtapa).Where(subetapa => subetapa.EstadoSubEtapa == 'F').Count();
    //            lstEProgresoEtapaSubEtapa.Add(eEProgresoEtapaSubEtapa);
    //        }
    //        return lstEProgresoEtapaSubEtapa;
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    #endregion
    #region EUsuarioCompleto
    //public EUsuarioCompleto Obtener_EUsuarioCompleto_O_CodigoUsuario(string CodigoUsuario, string CodigoProyecto)
    //{
    //    EUsuarioCompleto eEUsuarioCompleto;
    //    EGUsuario eGUsuario = Obtener_GUsuario_O_CodigoUsuario(CodigoUsuario);
    //    EUsuarioNetvalle eUsuarioNetvalle = Obtener_UsuarioNetvalle_O_CodigoUsuario(eGUsuario.CodigoUsuario);
    //    EGUsuarioProyecto eGProyectoUsuario = Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(CodigoUsuario, CodigoProyecto);
    //    EGUsuarioRol eGUsuarioRol = Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(eGUsuario.CodigoUsuario, eGProyectoUsuario.CodigoRol);
    //    try
    //    {
    //        eEUsuarioCompleto = new EUsuarioCompleto();
    //        eEUsuarioCompleto.NombreCompleto = eUsuarioNetvalle.NombresUsuarioNetvalle + " " + eUsuarioNetvalle.ApellidosUsuarioNetvalle;
    //        eEUsuarioCompleto.RolNetvalle = eUsuarioNetvalle.RolUsuarioNetvalle;
    //        eEUsuarioCompleto.RolProyecto = Obtener_GRol_O_Todo().Where(w => w.CodigoRol == eGUsuarioRol.CodigoRol).Select(s => s.DescripcionRol).FirstOrDefault();
    //        eEUsuarioCompleto.Carrera = eUsuarioNetvalle.CarreraUsuarioNetvalle;
    //        eEUsuarioCompleto.Facultad = eUsuarioNetvalle.FacultadUsuarioNetvalle;
    //        eEUsuarioCompleto.Sede = eUsuarioNetvalle.SedeUsuarioNetvalle;
    //        eEUsuarioCompleto.Direccion = eUsuarioNetvalle.DireccionUsuarioNetvalle;
    //        eEUsuarioCompleto.DireccionTrabajo = eUsuarioNetvalle.DireccionTrabajoUsuarioNetvalle;
    //        eEUsuarioCompleto.Celular = eUsuarioNetvalle.CelularUsuarioNetvalle;

    //        return eEUsuarioCompleto;
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    #endregion
    #region EProyectoTiempoEntrega
    //public List<EProyectoTiempoEntrega> Obtener_EProyectoTiempoEntrega_O(string CodigoUsuario)
    //{
    //    EProyectoTiempoEntrega eEProyectoTiempoEntrega;
    //    List<EProyectoTiempoEntrega> lstEProyectoTiempoEntrega = new List<EProyectoTiempoEntrega>();
    //    List<EGProyecto> lstEGProyecto = Obtener_GProyecto_O_CodigoUsuario(CodigoUsuario);

    //    try
    //    {
    //        foreach (var entrega in lstEGProyecto)
    //        {
    //            eEProyectoTiempoEntrega = new EProyectoTiempoEntrega();
    //            switch (entrega.ModalidadProyecto)
    //            {
    //                case 'T':
    //                    eEProyectoTiempoEntrega.Modalidad = "Tesis";
    //                    break;
    //                case 'D':
    //                    eEProyectoTiempoEntrega.Modalidad = "Trabajo Dirigido";
    //                    break;
    //                case'P':
    //                    eEProyectoTiempoEntrega.Modalidad = "Proyecto de Grado";
    //                    break;
    //            }
    //            eEProyectoTiempoEntrega.Titulo = entrega.TituloProyecto;
    //            eEProyectoTiempoEntrega.Objetivo = entrega.ObjetivoGeneralProyecto;
    //            eEProyectoTiempoEntrega.Documento = entrega.EnlaceDocumentoProyecto;
    //            eEProyectoTiempoEntrega.FechaEntrega = Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(entrega.CodigoProyecto).CodigoEtapa).FechaDefinidaSubEtapa;
    //            lstEProyectoTiempoEntrega.Add(eEProyectoTiempoEntrega);
    //        }
    //        return lstEProyectoTiempoEntrega;
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    #endregion
    #region GProyectoCompleja
    //public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(string CodigoUsuario)
    //{
    //    //Lista de Proyectos Validados para revision por Rol - Etapa - SubEtapa
    //    List<EProyectoCompleja> lstEGProyectos = new List<EProyectoCompleja>();
    //    try
    //    {
    //        //Lista de GProyetoUsuario -> Todos los GProyecto que participan por Usuario
    //        List<EGUsuarioProyecto> lstEGProyectosPorUsuario = new List<EGUsuarioProyecto>();
    //        lstEGProyectosPorUsuario = asNetGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario(CodigoUsuario);

    //        //Buscamos la Etapa y SubEtapa Activas para saber el progreso/estado de cada proyecto
    //        foreach (EGUsuarioProyecto usuarioProyecto in lstEGProyectosPorUsuario)
    //        {
    //            EGEtapa eGEtapa = new EGEtapa();
    //            EGSubEtapa eGSubEtapa = new EGSubEtapa();
    //            eGEtapa = asNetGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(usuarioProyecto.CodigoProyecto);
    //            eGSubEtapa = asNetGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(eGEtapa.CodigoEtapa);

    //            //Verificamos si en ese momento(etapa y subetapa) y con ese rol le corresponde revisar el proyecto(s)
    //            if (Verificar_GProyecto_CorrespondeRevision(usuarioProyecto.CodigoRol, eGEtapa.NumeroEtapa, eGSubEtapa.NumeroSubEtapa))
    //            {
    //                //Lista de GProyetoUsuario -> Todos los Usuarios que participan por GProyecto
    //                List<EGUsuarioProyecto> lstUsuariosPorProyecto = new List<EGUsuarioProyecto>();
    //                EProyectoCompleja eGProyectoComplejo = new EProyectoCompleja();
    //                //Obtener GProyecto por CodigoProyecto
    //                EGProyecto eGProyecto = new EGProyecto();
    //                eGProyecto = asNetGAAP.Obtener_GProyecto_O_CodigoProyecto(usuarioProyecto.CodigoProyecto);

    //                lstUsuariosPorProyecto = asNetGAAP.Obtener_GUsuarioProyecto_O_CodigoProyecto(eGProyecto.CodigoProyecto);

    //                //Crear eGProyectoFormularioCompleja con la informacion de GProyecto y GProyectoUsuario
    //                eGProyectoComplejo.CodigoUsuario = usuarioProyecto.CodigoUsuario;
    //                eGProyectoComplejo.CodigoRol = usuarioProyecto.CodigoRol;

    //                eGProyectoComplejo.CodigoProyecto = usuarioProyecto.CodigoProyecto;
    //                eGProyectoComplejo.TituloProyecto = eGProyecto.TituloProyecto;
    //                eGProyectoComplejo.ModalidadProyecto = eGProyecto.ModalidadProyecto;
    //                eGProyectoComplejo.ObjetivoGeneralProyecto = eGProyecto.ObjetivoGeneralProyecto;
    //                eGProyectoComplejo.EnlaceDocumentoProyecto = eGProyecto.EnlaceDocumentoProyecto;
    //                eGProyectoComplejo.CodigosEstudiantes = lstUsuariosPorProyecto.Where(w => w.CodigoRol == "ES").Select(s => s.CodigoUsuario).ToList();
    //                eGProyectoComplejo.CodigoTutor = lstUsuariosPorProyecto.Where(w => w.CodigoRol == "TU").Select(s => s.CodigoUsuario).FirstOrDefault();

    //                lstEGProyectos.Add(eGProyectoComplejo);
    //            }
    //        }
    //        return lstEGProyectos;
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }

    //}
    //public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(string CodigoUsuario)
    //{
    //    //Lista de Proyectos Validados para revision por Rol - Etapa - SubEtapa
    //    List<EProyectoCompleja> lstEGProyectos = new List<EProyectoCompleja>();
    //    try
    //    {
    //        //Lista de GProyetoUsuario -> Todos los GProyecto que participan por Usuario
    //        List<EGUsuarioProyecto> lstEGProyectosPorUsuario = new List<EGUsuarioProyecto>();
    //        lstEGProyectosPorUsuario = asNetGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario(CodigoUsuario);

    //        foreach (EGUsuarioProyecto usuarioProyecto in lstEGProyectosPorUsuario)
    //        {
    //            //Lista de GProyetoUsuario -> Todos los Usuarios que participan por GProyecto
    //            List<EGUsuarioProyecto> lstUsuariosPorProyecto = new List<EGUsuarioProyecto>();
    //            EProyectoCompleja eGProyectoComplejo = new EProyectoCompleja();
    //            //Obtener GProyecto por CodigoProyecto
    //            EGProyecto eGProyecto = new EGProyecto();
    //            eGProyecto = asNetGAAP.Obtener_GProyecto_O_CodigoProyecto(usuarioProyecto.CodigoProyecto);

    //            lstUsuariosPorProyecto = asNetGAAP.Obtener_GUsuarioProyecto_O_CodigoProyecto(eGProyecto.CodigoProyecto);

    //            //Crear eGProyectoFormularioCompleja con la informacion de GProyecto y GProyectoUsuario
    //            eGProyectoComplejo.CodigoUsuario = usuarioProyecto.CodigoUsuario;
    //            eGProyectoComplejo.CodigoRol = usuarioProyecto.CodigoRol;
    //            eGProyectoComplejo.Rol = Obtener_GRol_O_CodigoRol(usuarioProyecto.CodigoRol).DescripcionRol;
    //            eGProyectoComplejo.CodigoProyecto = usuarioProyecto.CodigoProyecto;
    //            eGProyectoComplejo.TituloProyecto = eGProyecto.TituloProyecto;
    //            eGProyectoComplejo.ModalidadProyecto = eGProyecto.ModalidadProyecto;
    //            eGProyectoComplejo.ObjetivoGeneralProyecto = eGProyecto.ObjetivoGeneralProyecto;
    //            eGProyectoComplejo.EnlaceDocumentoProyecto = eGProyecto.EnlaceDocumentoProyecto;
    //            eGProyectoComplejo.CodigosEstudiantes = lstUsuariosPorProyecto.Where(w => w.CodigoRol == "ES").Select(s => s.CodigoUsuario).ToList();
    //            eGProyectoComplejo.CodigoTutor = lstUsuariosPorProyecto.Where(w => w.CodigoRol == "TU").Select(s => s.CodigoUsuario).FirstOrDefault();

    //            lstEGProyectos.Add(eGProyectoComplejo);
    //        }
    //        return lstEGProyectos;
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }

    //}

    //public bool Verificar_GProyecto_CorrespondeRevision(string Rol, byte Etapa, byte SubEtapa)
    //{
    //    bool res = false;
    //    switch (Rol)
    //    {
    //        case "ES"://Estudiante
    //            switch (Etapa)
    //            {
    //                case 1://Etapa 1
    //                    res = (SubEtapa == 1) ? true : false;
    //                    break;

    //            }
    //            break;
    //        case "TU"://Tutor
    //            switch (Etapa)
    //            {
    //                case 1://Etapa 1
    //                    res = (SubEtapa == 2) ? true : false;
    //                    break;

    //            }
    //            break;
    //        case "DI"://Director -> el codigo continua hasta encontrar break(entra en caso 4)
    //        case "AD"://Ayudante Director
    //            switch (Etapa)
    //            {
    //                case 1://Etapa 1
    //                    res = (SubEtapa == 3) ? true : false;
    //                    break;

    //            }
    //            break;
    //        case "T1"://Tribunal 1
    //            break;
    //        case "T2"://Tribunal 2
    //            break;
    //        case "DP"://DAAP
    //            switch (Etapa)
    //            {
    //                case 1://Etapa 1
    //                    res = (SubEtapa == 4) ? true : false;
    //                    break;

    //            }
    //            break;
    //        case "GT"://Gestor
    //            res = true;
    //            break;

    //    }
    //    return res;
    //}
    //public void Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(string CodigoProyecto)
    //{
    //    EGEtapa eGEtapa = asNetGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(CodigoProyecto);
    //    EGSubEtapa eGSubEtapa = asNetGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(eGEtapa.CodigoEtapa);
    //    switch (eGEtapa.NumeroEtapa)
    //    {
    //        case 1:
    //            if (eGSubEtapa.NumeroSubEtapa == 4)
    //                Avanzar_Etapa(eGEtapa, eGSubEtapa);
    //            else
    //                Avanzar_SubEtapa(eGSubEtapa);
    //         break;
    //         case 2:
    //            if (eGSubEtapa.NumeroSubEtapa == 12)
    //                Avanzar_Etapa(eGEtapa, eGSubEtapa);
    //            else
    //                Avanzar_SubEtapa(eGSubEtapa);
    //          break;
    //        case 3:
    //            if (eGSubEtapa.NumeroSubEtapa == 12)
    //                Avanzar_Etapa(eGEtapa, eGSubEtapa);
    //            else
    //                Avanzar_SubEtapa(eGSubEtapa);
    //            break;
    //        case 4:
    //            if (eGSubEtapa.NumeroSubEtapa == 10)
    //                Avanzar_Etapa(eGEtapa, eGSubEtapa);
    //            else
    //                Avanzar_SubEtapa(eGSubEtapa);
    //            break;
    //    }
    //}
    //private void Avanzar_Etapa(EGEtapa eGEtapa, EGSubEtapa eGSubEtapa)
    //{
    //    EGEtapa siguienteEGEtapa = Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(eGEtapa.CodigoProyecto, (byte)((int)eGEtapa.NumeroEtapa + 1));
    //    asNetGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(eGSubEtapa.CodigoSubEtapa, 'F');
    //    asNetGAAP.Actualizar_GEtapa_A_EstadoEtapa(eGEtapa.CodigoEtapa, 'F');
    //    asNetGAAP.Actualizar_GEtapa_A_EstadoEtapa(siguienteEGEtapa.CodigoEtapa, 'A');
    //    EGSubEtapa siguienteEGSubEtapa = asNetGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(siguienteEGEtapa.CodigoEtapa, (byte)1);
    //    asNetGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(siguienteEGSubEtapa.CodigoSubEtapa, 'A');
    //}
    //private void Avanzar_SubEtapa(EGSubEtapa eGSubEtapa)
    //{
    //    EGSubEtapa siguienteEGSubEtapa = asNetGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(eGSubEtapa.CodigoEtapa, (byte)((int)eGSubEtapa.NumeroSubEtapa + 1));
    //    asNetGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(eGSubEtapa.CodigoSubEtapa, 'F');
    //    asNetGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(siguienteEGSubEtapa.CodigoSubEtapa, 'A');
    //}
    #region Insert Proyect
    //public void Insertar_ProyectoCompleto(string CodigoProyecto, string CodigoUsuario, string CodigoDirector, int DiasEtapa, int DiasSubEtapa)
    //{
    //    try
    //    {
    //        DateTime FechaActual = DateTime.Now;
    //        #region Insertar GProyecto
    //        EGProyecto eGProyecto = new EGProyecto();
    //        eGProyecto.CodigoProyecto = CodigoProyecto;
    //        eGProyecto.TituloProyecto = "No definido";
    //        eGProyecto.ObjetivoGeneralProyecto = "No definido";
    //        eGProyecto.EnlaceDocumentoProyecto = "No definido";
    //        eGProyecto.ModalidadProyecto ='T';
    //        asNetGAAP.Insertar_GProyecto_I(eGProyecto);
    //        #endregion
    //        #region Insertar GEtapas, GSubEtapas cascada
    //        for (int indice = 1; indice <= 4; indice++) // 4
    //        {
    //            int CodigoEtapa = asNetGAAP.Obtener_GEtapa_O_SiguienteCodigoEtapa();
    //            //Crear Etapa
    //            EGEtapa eGEtapa = new EGEtapa();
    //            eGEtapa.CodigoEtapa = CodigoEtapa;
    //            eGEtapa.CodigoProyecto = CodigoProyecto;
    //            eGEtapa.NumeroEtapa = (byte)indice;
    //            eGEtapa.FechaInicioEtapa = FechaActual;
    //            eGEtapa.FechaDefinidaEtapa = FechaActual.AddDays(DiasEtapa);
    //            eGEtapa.FechaFinEtapa = FechaActual.AddDays(DiasEtapa);
    //            eGEtapa.EstadoEtapa = (indice == 1) ? 'A' : 'P';
    //            asNetGAAP.Insertar_GEtapa_I(eGEtapa);
    //            //Crear SubEtapas
    //            AgregarSubEtapas(indice, CodigoEtapa, FechaActual, DiasSubEtapa);
    //        }
    //        #endregion
    //        #region Insertar GUsuarioProyectos
    //        //Conectar el estuante al proyecto
    //        EGUsuarioProyecto eGUsuarioProyectoEstudiante = new EGUsuarioProyecto();
    //        eGUsuarioProyectoEstudiante.CodigoUsuarioProyecto = asNetGAAP.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
    //        eGUsuarioProyectoEstudiante.CodigoProyecto = CodigoProyecto;
    //        eGUsuarioProyectoEstudiante.CodigoUsuario = CodigoUsuario;
    //        eGUsuarioProyectoEstudiante.CodigoRol = "ES";
    //        eGUsuarioProyectoEstudiante.EstadoUsuarioProyecto = 'A';
    //        asNetGAAP.Insertar_GUsuarioProyecto_I(eGUsuarioProyectoEstudiante);

    //        //Conectar el director al proyecto
    //        EGUsuarioProyecto eGUsuarioProyectoDirector = new EGUsuarioProyecto();
    //        eGUsuarioProyectoDirector.CodigoUsuarioProyecto = asNetGAAP.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
    //        eGUsuarioProyectoDirector.CodigoProyecto = CodigoProyecto;
    //        eGUsuarioProyectoDirector.CodigoUsuario = CodigoDirector;
    //        eGUsuarioProyectoDirector.CodigoRol = "DI";
    //        eGUsuarioProyectoDirector.EstadoUsuarioProyecto = 'A';
    //        asNetGAAP.Insertar_GUsuarioProyecto_I(eGUsuarioProyectoDirector);
    //        #endregion
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    //public void AgregarSubEtapas(int NumeroEtapa, int CodigoEtapa, DateTime FechaActual, int DiasSubEtapa)
    //{
    //    switch (NumeroEtapa)
    //    {
    //        #region Etapa 1
    //        case 1:
    //            for (int indice = 1; indice <= 4; indice++) //4
    //            {
    //                EGSubEtapa eGSubEtapa = new EGSubEtapa();
    //                eGSubEtapa.CodigoSubEtapa = asNetGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
    //                eGSubEtapa.CodigoEtapa = CodigoEtapa;
    //                eGSubEtapa.NumeroSubEtapa = (byte)indice;
    //                eGSubEtapa.FechaInicioSubEtapa = FechaActual;
    //                eGSubEtapa.FechaDefinidaSubEtapa = FechaActual.AddDays(DiasSubEtapa);
    //                eGSubEtapa.FechaFinSubEtapa = FechaActual.AddDays(DiasSubEtapa);
    //                eGSubEtapa.EstadoSubEtapa = (indice == 1) ? 'A' : 'P';
    //                asNetGAAP.Insertar_GSubEtapa_I(eGSubEtapa);
    //            }
    //            break;
    //        #endregion
    //        #region Etapa 2
    //        case 2:
    //            for (int indice = 1; indice <= 12; indice++) //12
    //            {
    //                EGSubEtapa eGSubEtapa = new EGSubEtapa();
    //                eGSubEtapa.CodigoSubEtapa = asNetGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
    //                eGSubEtapa.CodigoEtapa = CodigoEtapa;
    //                eGSubEtapa.NumeroSubEtapa = (byte)indice;
    //                eGSubEtapa.FechaInicioSubEtapa = FechaActual;
    //                eGSubEtapa.FechaDefinidaSubEtapa = FechaActual.AddDays(DiasSubEtapa);
    //                eGSubEtapa.FechaFinSubEtapa = FechaActual.AddDays(DiasSubEtapa);
    //                eGSubEtapa.EstadoSubEtapa = 'P';
    //                asNetGAAP.Insertar_GSubEtapa_I(eGSubEtapa);
    //            }
    //            break;
    //        #endregion
    //        #region Etapa 3
    //        case 3:
    //            for (int indice = 1; indice <= 12; indice++) //12
    //            {
    //                EGSubEtapa eGSubEtapa = new EGSubEtapa();
    //                eGSubEtapa.CodigoSubEtapa = asNetGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
    //                eGSubEtapa.CodigoEtapa = CodigoEtapa;
    //                eGSubEtapa.NumeroSubEtapa = (byte)indice;
    //                eGSubEtapa.FechaInicioSubEtapa = FechaActual;
    //                eGSubEtapa.FechaDefinidaSubEtapa = FechaActual.AddDays(DiasSubEtapa);
    //                eGSubEtapa.FechaFinSubEtapa = FechaActual.AddDays(DiasSubEtapa);
    //                eGSubEtapa.EstadoSubEtapa = 'P';
    //                asNetGAAP.Insertar_GSubEtapa_I(eGSubEtapa);
    //            }
    //            break;
    //        #endregion
    //        #region Etapa 4
    //        case 4:
    //            for (int indice = 1; indice <= 10; indice++) //10
    //            {
    //                EGSubEtapa eGSubEtapa = new EGSubEtapa();
    //                eGSubEtapa.CodigoSubEtapa = asNetGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
    //                eGSubEtapa.CodigoEtapa = CodigoEtapa;
    //                eGSubEtapa.NumeroSubEtapa = (byte)indice;
    //                eGSubEtapa.FechaInicioSubEtapa = FechaActual;
    //                eGSubEtapa.FechaDefinidaSubEtapa = FechaActual.AddDays(DiasSubEtapa);
    //                eGSubEtapa.FechaFinSubEtapa = FechaActual.AddDays(DiasSubEtapa);
    //                eGSubEtapa.EstadoSubEtapa = 'P';
    //                asNetGAAP.Insertar_GSubEtapa_I(eGSubEtapa);
    //            }
    //            break;
    //            #endregion
    //    }
    //}
    #endregion
    #endregion
    #endregion
}