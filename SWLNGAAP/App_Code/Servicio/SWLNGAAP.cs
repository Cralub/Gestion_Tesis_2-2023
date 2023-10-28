using SWADNETGAAP;
using System;
using System.Collections.Generic;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class SWLNGAAP : ISWLNGAAP
{
    #region GUsuarioRol
    public void Insertar_GUsuarioRol_I(int CodigoUsuarioRol, string CodigoRol, string CodigoUsuario)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Insertar_GUsuarioRol_I(CodigoUsuarioRol, CodigoRol, CodigoUsuario);
    }
    public int Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol()
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoRol(string CodigoRol)
    {
        CGAAP cGAAP = new CGAAP();
        List<EGUsuarioRol> lstEgUsuarioRol = new List<EGUsuarioRol>();
        lstEgUsuarioRol = cGAAP.Obtener_GUsuarioRol_O_CodigoRol(CodigoRol);
        return lstEgUsuarioRol;
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoUsuario(string CodigoUsuario)
    {
        CGAAP cGAAP = new CGAAP();
        List<EGUsuarioRol> lstEgUsuarioRol = new List<EGUsuarioRol>();
        lstEgUsuarioRol = cGAAP.Obtener_GUsuarioRol_O_CodigoUsuario(CodigoUsuario);
        return lstEgUsuarioRol;
    }
    public EGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string CodigoUsuario, string CodigoRol)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(CodigoUsuario, CodigoRol);
    }
    public void Actualizar_GUsuarioRol_A(string CodigoUsuario, string CodigoRol, int CodigoUsuarioRol)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Actualizar_GUsuarioRol_A(CodigoUsuario, CodigoRol, CodigoUsuarioRol);
    }
    #endregion

    #region GUsuarioProyecto
    public void Insertar_GUsuarioProyecto_I(int CodigoUsuarioProyecto, string CodigoProyecto, string CodigoUsuario, string CodigoRol, char EstadoUsuarioProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Insertar_GUsuarioProyecto_I(CodigoUsuarioProyecto, CodigoProyecto, CodigoUsuario, CodigoRol, EstadoUsuarioProyecto);
    }
    public int Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto()
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoProyecto(string CodigoProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto> ();
        lstEGUsuarioProyecto = cGAAP.Obtener_GUsuarioProyecto_O_CodigoProyecto (CodigoProyecto);
        return lstEGUsuarioProyecto;
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoUsuario(string CodigoUsuario)
    {
        CGAAP cGAAP = new CGAAP();
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        lstEGUsuarioProyecto = cGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario(CodigoUsuario);
        return lstEGUsuarioProyecto;
    }
    public void Actualizar_GUsuarioProyecto_A(int CodigoUsuarioProyecto, string CodigoProyecto, string CodigoUsuario, string CodigoRol, char EstadoUsuarioProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Actualizar_GUsuarioProyecto_A(CodigoUsuarioProyecto, CodigoProyecto, CodigoUsuario, CodigoRol,EstadoUsuarioProyecto);
    }
    #endregion

    #region GProyecto
    public string Obtener_GProyecto_O_ExisteCodigoProyecto(string codigoProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GProyecto_O_ExisteCodigoProyecto(codigoProyecto);
    }
    public void Insertar_GProyecto_I(string codigoProyecto, char modalidadProyecto, string tituloProyecto, string objetivoGeneralProyecto, string objetivosEspecificosProyecto, string alcanceProyecto, string enlaceDocumentoProyecto, byte numeroRevisiones)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Insertar_GProyecto_I(codigoProyecto, modalidadProyecto, tituloProyecto, objetivoGeneralProyecto, objetivosEspecificosProyecto, alcanceProyecto, enlaceDocumentoProyecto, numeroRevisiones);
    }
    public List<EGProyecto> Obtener_GProyecto_O_Todo()
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GProyecto_O_Todo();
    }
    public EGProyecto Obtener_GProyecto_O(string codigoProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GProyecto_O(codigoProyecto);
    }
    public void Actualizar_GProyecto_A(string codigoProyecto, char modalidadProyecto, string tituloProyecto, string objetivoGeneralProyecto, string objetivosEspecificosProyecto, string alcanceProyecto, string enlaceDocumentoProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Actualizar_GProyecto_A(codigoProyecto, modalidadProyecto, tituloProyecto, objetivoGeneralProyecto, objetivosEspecificosProyecto, alcanceProyecto, enlaceDocumentoProyecto);
    }
    #endregion

    #region GEtapa
    public void Insertar_GEtapa_I(byte numeroEtapa, DateTime fechaInicioEtapa, DateTime fechaDefinidaEtapa, DateTime fechaFinEtapa, string codigoProyecto, char estadoEtapa)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Insertar_GEtapa_I(numeroEtapa, fechaInicioEtapa, fechaDefinidaEtapa, fechaFinEtapa, codigoProyecto, estadoEtapa);
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(string CodigoProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        EGEtapa eGEtapa = new EGEtapa();
        eGEtapa = cGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(CodigoProyecto);
        return eGEtapa;
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string CodigoProyecto, byte NumeroSubEtapa)
    {
        CGAAP cGAAP = new CGAAP();
        EGEtapa eGEtapa = new EGEtapa();
        eGEtapa = cGAAP.Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(CodigoProyecto, NumeroSubEtapa);
        return eGEtapa;
    }
    public void Actualizar_GEtapa_A_EstadoEtapa(int CodigoEtapa, char EstadoEtapa)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Actualizar_GEtapa_A_EstadoEtapa(CodigoEtapa, EstadoEtapa);
    }
    #endregion

    #region GSubEtapa
    public void Insertar_GSubEtapa_I(byte numeroSubEtapa, DateTime fechaInicioSubEtapa, DateTime fechaDefinidaSubEtapa, DateTime fechaFinSubEtapa, string codigoUsuarioFirma, int codigoEtapa, char estadoSubEtapa)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Insertar_GSubEtapa_I(numeroSubEtapa, fechaInicioSubEtapa, fechaDefinidaSubEtapa, fechaFinSubEtapa, codigoUsuarioFirma, codigoEtapa, estadoSubEtapa);
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(int CodigoEtapa)
    {
        CGAAP cGAAP = new CGAAP();
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        eGSubEtapa = cGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(CodigoEtapa); 
        return eGSubEtapa;
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int CodigoEtapa, byte NumeroSubEtapa)
    {
        CGAAP cGAAP = new CGAAP();
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        eGSubEtapa = cGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(CodigoEtapa, NumeroSubEtapa);
        return eGSubEtapa;
    }
    public void Actualizar_GSubEtapa_A_EstadoSubEtapa(int CodigoSubEtapa, char EstadoSubEtapa)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(CodigoSubEtapa, EstadoSubEtapa);
    }
    #endregion

    #region GObservacion
    public void Insertar_GObservacion_I(int CodigoObservacion, string CodigoProyecto, int CodigoSubEtapa, string CodigoUsuarioObservacion, string ComentarioObservacion, char TipoObservacion, char EstadoObservacion)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Insertar_GObservacion_I(CodigoObservacion, CodigoProyecto, CodigoSubEtapa, CodigoUsuarioObservacion, ComentarioObservacion, TipoObservacion, EstadoObservacion);

    }
    public List<EGObservacion> Obtener_GObservacion_O_CodigoProyecto(string CodigoProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        List<EGObservacion> lstObservacion = new List<EGObservacion>();
        lstObservacion = cGAAP.Obtener_GObservacion_O_CodigoProyecto(CodigoProyecto);
        return lstObservacion;

    }
    public EGObservacion Obtener_GObservacion_O_CodigoObservacion(int CodigoObservacion)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GObservacion_O_CodigoObservacion(CodigoObservacion);
    }
    public void Actualizar_GObservacion_A(int CodigoObservacion, string CodigoProyecto, int CodigoSubEtapa, string CodigoUsuarioObservacion, string ComentarioObservacion, char TipoObservacion, char EstadoObservacion)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Actualizar_GObservacion_A(CodigoObservacion, CodigoProyecto, CodigoSubEtapa, CodigoUsuarioObservacion, ComentarioObservacion, TipoObservacion, EstadoObservacion);
    }
    public void Actualizar_GObservacion_A_EstadoObservacion(int codigoObservacion, char estadoObservacion)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Actualizar_GObservacion_A_EstadoObservacion(codigoObservacion, estadoObservacion);
    }
    public int Obtener_GObsevacion_O_SiguienteCodigoObservacion()
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GObsevacion_O_SiguienteCodigoObservacion();
    }
    #endregion

    #region GUsuario
    public void Insertar_GUsuario_I(string CodigoUsuario, string sede)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Insertar_GUsuario_I(CodigoUsuario, sede);
    }
    public EGUsuario Obtener_GUsuario_O_CodigoUsuario(string CodigoUsuario)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GUsuario_O_CodigoUsuario(CodigoUsuario);
    }
    public void Actualizar_GUsuario_A(string codigoUsuario, string sede)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Actualizar_GUsuario_A(codigoUsuario, sede);
    }
    #endregion

    #region GRol
    public List<EGRol> Obtener_GRol_O_Todo()
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GRol_O_Todo();
    }
    public EGRol Obtener_GRol_O_CodigoRol(string CodigoRol)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GRol_O_CodigoRol(CodigoRol);
    }
    #endregion

    #region GCelular
    public void Insertar_GCelular_I(string codigoUsuario, string codigoAreaCelular, int numeroCelular)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Insertar_GCelular_I(codigoUsuario, codigoAreaCelular, numeroCelular);
    }
    public EGCelular Obtener_GCelular_O(int codigoCelular)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GCelular_O(codigoCelular);
    }
    public void Actualizar_GCelular_A(int codigoCelular, string codigoUsuario, string codigoAreaCelular, int numeroCelular)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Actualizar_GCelular_A(codigoCelular, codigoUsuario, codigoAreaCelular, numeroCelular);
    }
    public void Eliminar_GCelular_E(int codigoCelular)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Eliminar_GCelular_E(codigoCelular);
    }
    #endregion

    #region GTutorExterno
    #endregion


    #region UsuarioNetvalle
    public EUsuarioNetvalle Obtener_UsuarioNetvalle_O_CodigoUsuario(string CodigoUsuario)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_UsuarioNetvalle_O_CodigoUsuario(CodigoUsuario);
    }
    #endregion
    #region GProyectoCompleja
    public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(string CodigoUsuario)
    {
        CGAAP cGAAP = new CGAAP();
        List<EProyectoCompleja> lstEGProyectos = new List<EProyectoCompleja>();
        lstEGProyectos = cGAAP.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(CodigoUsuario);
        return lstEGProyectos;
    }
    public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(string CodigoUsuario)
    {
        CGAAP cGAAP = new CGAAP();
        List<EProyectoCompleja> lstEGProyectos = new List<EProyectoCompleja>();
        lstEGProyectos = cGAAP.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(CodigoUsuario);
        return lstEGProyectos;
    }
    #region Opciones
    public bool Verificar_GProyecto_CorrespondeRevision(string CodigoRol, byte NumeroEtapa, byte NumeroSubEtapa)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Verificar_GProyecto_CorrespondeRevision(CodigoRol, NumeroEtapa, NumeroSubEtapa);
    }
    public void Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(string CodigoProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(CodigoProyecto);
    }
    public void Insertar_ProyectoCompleto(string codigoProyecto, int diasEtapa, int diasSubEtapa, string codigoUsuario, string codigoDirector)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Insertar_ProyectoCompleto(codigoProyecto, diasEtapa, diasSubEtapa, codigoUsuario, codigoDirector);
    }
    #endregion
    #endregion
    #region EProgresoEtapaSubEtapa
    public List<EProgresoEtapaSubEtapa> Obtener_EProgresoEtapaSubEtapa_O(string CodigoProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_EProgresoEtapaSubEtapa_O(CodigoProyecto);
    }
    #endregion
    #region EUsuarioCompleto
    public EUsuarioCompleto Obtener_EUsuarioCompleto_O(string CodigoUsuario, string CodigoProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_EUsuarioCompleto_O_CodigoUsuario(CodigoUsuario, CodigoProyecto);
    }
    #endregion
    #region EProyectoTiempoEntrega
    public List<EProyectoTiempoEntrega> Obtener_EProyectoTiempoEntrega_O(string CodigoUsuario)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_EProyectoTiempoEntrega_O(CodigoUsuario);
    }
    #endregion
}