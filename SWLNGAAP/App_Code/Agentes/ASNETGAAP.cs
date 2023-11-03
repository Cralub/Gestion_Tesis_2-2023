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
    private SWADNETGAAPClient clienteSWADNETGAAP;
    #endregion
    #region Constructor
    public ASNETGAAP()
    {
        clienteSWADNETGAAP = new SWADNETGAAPClient();
    }
    #endregion
    #region GUsuarioRol
    public void Insertar_GUsuarioRol_I(EGUsuarioRol eGUsuarioRol)
    {
        try
        {
            clienteSWADNETGAAP.Insertar_GUsuarioRol_I(eGUsuarioRol);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol()
    {
        int ultimoCodigo = 0;
        try
        {
            ultimoCodigo = clienteSWADNETGAAP.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
            return ultimoCodigo;
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
            lstEGUsuarioRol = clienteSWADNETGAAP.Obtener_GUsuarioRol_O_CodigoRol(codigoRol).ToList();
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
            lstEGUsuarioRol = clienteSWADNETGAAP.Obtener_GUsuarioRol_O_CodigoUsuario(codigoUsuario).ToList();
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
            eGUsuarioRol = clienteSWADNETGAAP.Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(codigoUsuario, codigoRol);
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
            clienteSWADNETGAAP.Actualizar_GUsuarioRol_A(eGUsuarioRol);
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
            clienteSWADNETGAAP.Eliminar_GUsuarioRol_E(codigoUsuarioRol);
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
            clienteSWADNETGAAP.Insertar_GUsuarioProyecto_I(eGUsuarioProyecto);
        }
        catch (Exception)
        {

            throw;
        }
    }
    public int Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto()
    {
        int ultimoCodigo = 0;
        try
        {
            ultimoCodigo = clienteSWADNETGAAP.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
            return ultimoCodigo;
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
            lstEGUsuarioProyecto = clienteSWADNETGAAP.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto).ToList();
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
            lstEGUsuarioProyecto = clienteSWADNETGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario(codigoUsuario).ToList();
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
            return clienteSWADNETGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(codigoUsuario, codigoProyecto);
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
            clienteSWADNETGAAP.Actualizar_GUsuarioProyecto_A(eGProyectoUsuario);
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
            clienteSWADNETGAAP.Eliminar_GUsuarioProyecto_E(codigoUsuarioProyecto);
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
            clienteSWADNETGAAP.Insertar_GProyecto_I(eGProyecto);
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
            lstEGProyecto = clienteSWADNETGAAP.Obtener_GProyecto_O(fechaInicio, fechaFin).ToList();
            return lstEGProyecto;
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
            eGProyecto = clienteSWADNETGAAP.Obtener_GProyecto_O_CodigoProyecto(codigoProyecto);
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
            clienteSWADNETGAAP.Actualizar_GProyecto_A(eGProyecto);
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
            clienteSWADNETGAAP.Insertar_GEtapa_I(eGEtapa);
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
            return clienteSWADNETGAAP.Obtener_GEtapa_O_CodigoProyecto(codigoProyecto).ToList();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GEtapa_O_SiguienteCodigoEtapa()
    {
        int ultimoCodigo = 0;
        try
        {
            ultimoCodigo = clienteSWADNETGAAP.Obtener_GEtapa_O_SiguienteCodigoEtapa();
            return ultimoCodigo;
        }
        catch (Exception)
        {
            throw;
        }

    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(string codigoProyecto, char estadoEtapa)
    {
        EGEtapa eGEtapa = new EGEtapa();
        try
        {
            eGEtapa = clienteSWADNETGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto, estadoEtapa);
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
            eGEtapa = clienteSWADNETGAAP.Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(codigoProyecto, numeroSubEtapa);
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
            clienteSWADNETGAAP.Actualizar_GEtapa_A_EstadoEtapa(codigoEtapa, estadoEtapa);
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
            clienteSWADNETGAAP.Insertar_GFormularioAceptacion_I(eGFormularioAceptacion);
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
            lstFormularioAceptacion = clienteSWADNETGAAP.Obtener_GFormularioAceptacion_O_CodigoProyecto(codigoProyecto).ToList();
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
            clienteSWADNETGAAP.Insertar_GSubEtapa_I(eGSubEtapa);
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
            return clienteSWADNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa(codigoEtapa).ToList();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa()
    {
        int ultimoCodigo = 0;
        try
        {
            ultimoCodigo = clienteSWADNETGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
            return ultimoCodigo;
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
            eGSubEtapa = clienteSWADNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(codigoEtapa, estadoSubEtapa);
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
            eGSubEtapa = clienteSWADNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(codigoEtapa, numeroSubEtapa);
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
            clienteSWADNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(codigoSubEtapa, estadoSubEtapa);
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
            clienteSWADNETGAAP.Insertar_GObservacion_I(eGObservacion);
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
            lstObservacion = clienteSWADNETGAAP.Obtener_GObservacion_O_CodigoProyecto(codigoProyecto).ToList();
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
            eGObservacion = clienteSWADNETGAAP.Obtener_GObservacion_O_CodigoObservacion(codigoObservacion);
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
            clienteSWADNETGAAP.Actualizar_GObservacion_A(eGObservacion);
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
            clienteSWADNETGAAP.Actualizar_GObservacion_A_EstadoObservacion(codigoObservacion, estadoObservacion);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public int Obtener_GObsevacion_O_SiguienteCodigoObservacion()
    {
        int ultimoCodigo = 0;
        try
        {
            ultimoCodigo = clienteSWADNETGAAP.Obtener_GObsevacion_O_SiguienteCodigoObservacion();
            return ultimoCodigo;
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
            clienteSWADNETGAAP.Insertar_GUsuario_I(eGUsuario);
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
            return clienteSWADNETGAAP.Obtener_GUsuario_O_CodigoUsuario(codigoUsuario);
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
            clienteSWADNETGAAP.Actualizar_GUsuario_A(eGUsuario);
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
            return clienteSWADNETGAAP.Obtener_GRol_O().ToList();
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
            return clienteSWADNETGAAP.Obtener_GRol_O_CodigoRol(codigoRol);
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
            return clienteSWADNETGAAP.Obtener_UsuarioNetvalle_O_CodigoUsuario(codigoUsuario);
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
        int ultimoCodigo = 0;
        try
        {
            ultimoCodigo = clienteSWADNETGAAP.Obtener_GCelular_O_SiguienteCodigoCelular();
            return ultimoCodigo;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Insertar_GCelular_I(EGCelular eGCelular)
    {
        try
        {
            clienteSWADNETGAAP.Insertar_GCelular_I(eGCelular);
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
            return clienteSWADNETGAAP.Obtener_GCelular_O_CodigoUsuario(codigoUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_GCelular_A(EGCelular eGCelular)
    {
        try
        {
            clienteSWADNETGAAP.Actualizar_GCelular_A(eGCelular);
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
            clienteSWADNETGAAP.Eliminar_GCelular_E(codigoCelular);
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
            clienteSWADNETGAAP.Insertar_GTutorExterno_I(eGTutorExterno);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public List<EGTutorExterno> Obtener_GTutorExterno_O()
    {
        try
        {
            return clienteSWADNETGAAP.Obtener_GTutorExterno_O().ToList();
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

            eGTutorExterno = clienteSWADNETGAAP.Obtener_GTutorExterno_O_CodigoTutorExterno(codigoTutorExterno);
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
            clienteSWADNETGAAP.Actualizar_GTutorExterno_A(eGTutorExterno);
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
            clienteSWADNETGAAP.Eliminar_GTutorExterno_E(codigoTutorExterno);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}