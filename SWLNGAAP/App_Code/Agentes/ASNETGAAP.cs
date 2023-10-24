using SWADNETGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Descripción breve de ASNETGAAP
/// </summary>
public class ASNETGAAP
{
    #region Atributos
    private SWADNETGAAPClient SWADNETGAAP;
    #endregion
    #region Constructor
    public ASNETGAAP()
    {
        SWADNETGAAP = new SWADNETGAAPClient();
    }
    #endregion
    #region GUsuarioRol
    public void Insertar_GUsuarioRol_I(EGUsuarioRol eGUsuarioRol)
    {
        try
        {
            SWADNETGAAP.Insertar_GUsuarioRol_I(eGUsuarioRol);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol()
    {
        int res = 0;
        try
        {
            res = SWADNETGAAP.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
            return res;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoRol(string CodigoRol)
    {
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        try
        {
            lstEGUsuarioRol = SWADNETGAAP.Obtener_GUsuarioRol_O_CodigoRol(CodigoRol).ToList();
            return lstEGUsuarioRol;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoUsuario(string CodigoUsuario)
    {
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        try
        {
            lstEGUsuarioRol = SWADNETGAAP.Obtener_GUsuarioRol_O_CodigoUsuario(CodigoUsuario).ToList();
            return lstEGUsuarioRol;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string CodigoUsuario, string CodigoRol)
    {
        EGUsuarioRol eGUsuarioRol = new EGUsuarioRol();
        try
        {
            eGUsuarioRol = SWADNETGAAP.Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(CodigoUsuario,CodigoRol);
            return eGUsuarioRol;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GUsuarioRol_A(EGUsuarioRol eGUsuarioRol)
    {
        try
        {
            SWADNETGAAP.Actualizar_GUsuarioRol_A(eGUsuarioRol);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region GUsuarioProyecto
    public void Insertar_GUsuarioProyecto_I(EGUsuarioProyecto eGUsuarioProyecto)
    {
        try
        {
            SWADNETGAAP.Insertar_GUsuarioProyecto_I(eGUsuarioProyecto);
        }
        catch (Exception)
        {

            throw;
        }
    }
    public int Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto()
    {
        int res = 0;
        try
        {
            res = SWADNETGAAP.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
            return res;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoProyecto(string CodigoProyecto)
    {
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        try
        {
            lstEGUsuarioProyecto = SWADNETGAAP.Obtener_GUsuarioProyecto_O_CodigoProyecto(CodigoProyecto).ToList();
            return lstEGUsuarioProyecto;
        }
        catch (Exception)
        {

            throw;
        }
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoUsuario(string CodigoUsuario)
    {
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        try
        {
            lstEGUsuarioProyecto = SWADNETGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario(CodigoUsuario).ToList();
            return lstEGUsuarioProyecto;
        }
        catch (Exception)
        {

            throw;
        }
    }
    public EGUsuarioProyecto Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(string CodigoUsuario, string CodigoProyecto)
    {
        try
        {
            return SWADNETGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(CodigoUsuario, CodigoProyecto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GUsuarioProyecto_A(EGUsuarioProyecto eGProyectoUsuario)
    {
        try
        {
            SWADNETGAAP.Actualizar_GUsuarioProyecto_A(eGProyectoUsuario);
        }
        catch (Exception)
        {

            throw;
        }
    }
    #endregion
    #region GProyecto
    public void Insertar_GProyecto_I(EGProyecto eGProyecto)
    {
        try
        {
            SWADNETGAAP.Insertar_GProyecto_I(eGProyecto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGProyecto> Obtener_GProyecto_O_Todo()
    {
        List <EGProyecto> lstEGProyecto = new List<EGProyecto>();
        try
        {
            lstEGProyecto = SWADNETGAAP.Obtener_GProyecto_O_Todo().ToList();
            return lstEGProyecto;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGProyecto Obtener_GProyecto_O_CodigoProyecto(string CodigoProyecto)
    {
        EGProyecto eGProyecto = new EGProyecto();
        try
        {
            eGProyecto = SWADNETGAAP.Obtener_GProyecto_O_CodigoProyecto(CodigoProyecto);
            return eGProyecto;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GProyecto_A(EGProyecto eGProyecto)
    {
        try
        {
            SWADNETGAAP.Actualizar_GProyecto_A(eGProyecto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region GEtapa
    public void Insertar_GEtapa_I(EGEtapa eGEtapa)
    {
        try
        {
            SWADNETGAAP.Insertar_GEtapa_I(eGEtapa);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGEtapa> Obtener_GEtapa_O_CodigoProyecto(string CodigoProyecto)
    {
        try
        {
            return SWADNETGAAP.Obtener_GEtapa_O_CodigoProyecto(CodigoProyecto).ToList();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GEtapa_O_SiguienteCodigoEtapa()
    {
        int res = 0;
        try
        {
            res = SWADNETGAAP.Obtener_GEtapa_O_SiguienteCodigoEtapa();
            return res;
        }
        catch (Exception)
        {
            throw;
        }

    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(string CodigoProyecto)
    {
        EGEtapa eGEtapa = new EGEtapa();
        try
        {
            eGEtapa = SWADNETGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(CodigoProyecto);
            return eGEtapa;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string CodigoProyecto, byte NumeroSubEtapa)
    {
        EGEtapa eGEtapa = new EGEtapa();
        try
        {
            eGEtapa = SWADNETGAAP.Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(CodigoProyecto, NumeroSubEtapa);
            return eGEtapa;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GEtapa_A_EstadoEtapa(int CodigoEtapa, char EstadoEtapa)
    {
        try
        {
            SWADNETGAAP.Actualizar_GEtapa_A_EstadoEtapa(CodigoEtapa, EstadoEtapa);
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
            SWADNETGAAP.Insertar_GFormularioAceptacion_I(eGFormularioAceptacion);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGFormularioAceptacion> Obtener_GFormularioAceptacion_O_CodigoProyecto(string CodigoProyecto)
    {
        List<EGFormularioAceptacion> lstFormularioAceptacion = new List<EGFormularioAceptacion>(); 
        try
        {
            lstFormularioAceptacion = SWADNETGAAP.Obtener_GFormularioAceptacion_O_CodigoProyecto(CodigoProyecto).ToList();
            return lstFormularioAceptacion;
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region GSubEtapa
    public void Insertar_GSubEtapa_I(EGSubEtapa eGSubEtapa)
    {
        try
        {
            SWADNETGAAP.Insertar_GSubEtapa_I(eGSubEtapa);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGSubEtapa> Obtener_GSubEtapa_O_CodigoEtapa(int CodigoEtapa)
    {
        try
        {
            return SWADNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa(CodigoEtapa).ToList();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa()
    {
        int res = 0;
        try
        {
            res = SWADNETGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
            return res;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(int CodigoEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        try
        {
            eGSubEtapa = SWADNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(CodigoEtapa);
            return eGSubEtapa;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int CodigoEtapa, byte NumeroSubEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        try
        {
            eGSubEtapa = SWADNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(CodigoEtapa, NumeroSubEtapa);
            return eGSubEtapa;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GSubEtapa_A_EstadoSubEtapa(int CodigoSubEtapa, char EstadoSubEtapa)
    {
        try
        {
            SWADNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(CodigoSubEtapa, EstadoSubEtapa);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region GObservacion
    public void Insertar_GObservacion_I(EGObservacion eGObservacion)
    {
        try
        {
            SWADNETGAAP.Insertar_GObservacion_I(eGObservacion);
        }
        catch (Exception)
        {

            throw;
        }
    }
    public List<EGObservacion> Obtener_GObservacion_O_CodigoProyecto(string CodigoProyecto)
    {
        List<EGObservacion> lstObservacion = new List<EGObservacion>();
        try
        {
            lstObservacion = SWADNETGAAP.Obtener_GObservacion_O_CodigoProyecto(CodigoProyecto).ToList();
            return lstObservacion;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EGObservacion> Obtener_GObservacion_O_TipoObservacion(char TipoObservacion)
    {
        List<EGObservacion> lstObservacion = new List<EGObservacion>();
        try
        {
            lstObservacion = SWADNETGAAP.Obtener_GObservacion_O_TipoObservacion(TipoObservacion).ToList();
            return lstObservacion;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGObservacion Obtener_GObservacion_O_CodigoObservacion(int CodigoObservacion)
    {
        EGObservacion eGObservacion = new EGObservacion();
        try
        {
            eGObservacion = SWADNETGAAP.Obtener_GObservacion_O_CodigoObservacion(CodigoObservacion);
            return eGObservacion;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GObservacion_A(EGObservacion eGObservacion)
    {
        try
        {
            SWADNETGAAP.Actualizar_GObservacion_A(eGObservacion);
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
            SWADNETGAAP.Actualizar_GObservacion_A_EstadoObservacion(CodigoObservacion, EstadoObservacion);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GObsevacion_O_SiguienteCodigoObservacion()
    {
        int res = 0;
        try
        {
            res = SWADNETGAAP.Obtener_GObsevacion_O_SiguienteCodigoObservacion();
            return res;
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region GUsuario
    public void Insertar_GUsuario_I(EGUsuario eGUsuario)
    {
        try
        {
            SWADNETGAAP.Insertar_GUsuario_I(eGUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EGUsuario Obtener_GUsuario_O_CodigoUsuario(string CodigoUsuario)
    {
        try
        {
            return SWADNETGAAP.Obtener_GUsuario_O_CodigoUsuario(CodigoUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GUsuario_A(EGUsuario eGUsuario)
    {
        try
        {
            SWADNETGAAP.Actualizar_GUsuario_A(eGUsuario);
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
        try
        {
            return SWADNETGAAP.Obtener_GRol_O_Todo().ToList();
        }
        catch (Exception)
        {
            throw;
        }
    }
    
    public EGRol Obtener_GRol_O_CodigoRol(string CodigoRol) 
    { 
        try
        {
        return SWADNETGAAP.Obtener_GRol_O_CodigoRol(CodigoRol);
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
        try
        {
            return SWADNETGAAP.Obtener_UsuarioNetvalle_O_CodigoUsuario(CodigoUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region Tabla: GCelular
    public int Obtener_GCelular_O_SiguienteCodigoCelular()
    {
        try
        {
            return SWADNETGAAP.Obtener_GCelular_O_SiguienteCodigoCelular();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Insertar_GCelular_I(EGCelular celular)
    {
        try
        {
            SWADNETGAAP.Insertar_GCelular_I(celular);
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
            return SWADNETGAAP.Obtener_GCelular_O(codigoCelular);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GCelular_A(EGCelular celular)
    {
        try
        {
            SWADNETGAAP.Actualizar_GCelular_A(celular);
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
            SWADNETGAAP.Eliminar_GCelular_E(codigoCelular);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region GTutorExterno
    public void Insertar_GTutorExterno_I(EGTutorExterno eGTutorExterno)
    {
        try
        {
            SWADNETGAAP.Insertar_GTutorExterno_I(eGTutorExterno);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public List<EGTutorExterno> Obtener_GTutorExterno_O_Todo()
    {
        try
        {
            return SWADNETGAAP.Obtener_GTutorExterno_O_Todo().ToList();
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
            EGTutorExterno eGTutorExterno = new EGTutorExterno();

            eGTutorExterno = SWADNETGAAP.Obtener_GTutorExterno_O_CodigoTutorExterno(codigoTutorExterno);
            return eGTutorExterno;

        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Actualizar_GTutorExterno_A(EGTutorExterno eGTutorExterno)
    {
        try
        {
            SWADNETGAAP.Actualizar_GTutorExterno_A(eGTutorExterno);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Actualizar_GTutorExterno_A_EstadoTutorExterno(int codigoTutorExterno, string estadoTutorExterno)
    {
        try
        {
            SWADNETGAAP.Actualizar_GTutorExterno_A_Estado(codigoTutorExterno, estadoTutorExterno);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}