using SWADNETGAAP;
using System;
using System.Collections.Generic;
using System.ServiceModel;

[ServiceContract]
public interface ISWLNGAAP
{
    #region GUsuarioRol
    [OperationContract]
    void Insertar_GUsuarioRol_I(int CodigoUsuarioRol, string CodigoRol, string CodigoUsuario);
    [OperationContract]
    int Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
    [OperationContract]
    List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoRol(string CodigoRol);
    [OperationContract]
    List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoUsuario(string CodigoUsuario);
    [OperationContract]
    EGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string CodigoUsuario, string CodigoRol);
    [OperationContract]
    void Actualizar_GUsuarioRol_A(string CodigoUsuario, string CodigoRol, int CodigoUsuarioRol);
    #endregion

    #region GUsuarioProyecto
    [OperationContract]
    void Insertar_GUsuarioProyecto_I(int CodigoUsuarioProyecto, string CodigoProyecto, string CodigoUsuario, string CodigoRol, char EstadoUsuarioProyecto);
    [OperationContract]
    int Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
    [OperationContract]
    List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoProyecto(string CodigoProyecto);
    [OperationContract]
    List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoUsuario(string CodigoUsuario);
    [OperationContract]
    void Actualizar_GUsuarioProyecto_A(int CodigoUsuarioProyecto, string CodigoProyecto, string CodigoUsuario, string CodigoRol, char EstadoUsuarioProyecto);
    #endregion

    #region GProyecto
    [OperationContract]
    string Obtener_GProyecto_O_ExisteCodigoProyecto(string codigoProyecto);
    [OperationContract]
    void Insertar_GProyecto_I(string codigoProyecto, char modalidadProyecto, string tituloProyecto, string objetivoGeneralProyecto, string objetivosEspecificosProyecto, string alcanceProyecto, string enlaceDocumentoProyecto, byte numeroRevisiones);
    [OperationContract]
    List<EGProyecto> Obtener_GProyecto_O_Todo();
    [OperationContract]
    EGProyecto Obtener_GProyecto_O(string codigoProyecto);
    [OperationContract]
    void Actualizar_GProyecto_A(string codigoProyecto, char modalidadProyecto, string tituloProyecto, string objetivoGeneralProyecto, string objetivosEspecificosProyecto, string alcanceProyecto, string enlaceDocumentoProyecto);
    #endregion

    #region GEtapa
    [OperationContract]
    void Insertar_GEtapa_I(byte numeroEtapa, DateTime fechaInicioEtapa, DateTime fechaDefinidaEtapa, DateTime fechaFinEtapa, string codigoProyecto, char estadoEtapa);
    [OperationContract]
    EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(string CodigoProyecto);
    [OperationContract]
    EGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string CodigoProyecto, byte NumeroSubEtapa);
    [OperationContract]
    void Actualizar_GEtapa_A_EstadoEtapa(int CodigoEtapa, char EstadoEtapa);
    #endregion

    #region GSubEtapa
    [OperationContract]
    void Insertar_GSubEtapa_I(byte numeroSubEtapa, DateTime fechaInicioSubEtapa, DateTime fechaDefinidaSubEtapa, DateTime fechaFinSubEtapa, string codigoUsuarioFirma, int codigoEtapa, char estadoSubEtapa);
    [OperationContract]
    EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(int CodigoEtapa);
    [OperationContract]
    EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int CodigoEtapa, byte NumeroSubEtapa);
    [OperationContract]
    void Actualizar_GSubEtapa_A_EstadoSubEtapa(int CodigoSubEtapa, char Estado);
    #endregion

    #region GObservacion
    [OperationContract]
    void Insertar_GObservacion_I(int CodigoObservacion, string CodigoProyecto, int CodigoSubEtapa, string CodigoUsuarioObservacion, string ComentarioObservacion, char TipoObservacion, char EstadoObservacion);
    [OperationContract]
    List<EGObservacion> Obtener_GObservacion_O_CodigoProyecto(string CodigoProyecto);
    [OperationContract]
    EGObservacion Obtener_GObservacion_O_CodigoObservacion(int CodigoObservacion);
    [OperationContract]
    void Actualizar_GObservacion_A(int CodigoObservacion, string CodigoProyecto, int CodigoSubEtapa, string CodigoUsuarioObservacion, string ComentarioObservacion, char TipoObservacion, char EstadoObservacion);
    [OperationContract]
    void Actualizar_GObservacion_A_EstadoObservacion(int codigoObservacion, char estadoObservacion);
    [OperationContract]
    int Obtener_GObsevacion_O_SiguienteCodigoObservacion();
    #endregion

    #region GUsuario
    [OperationContract]
    void Insertar_GUsuario_I(string CodigoUsuario, string sede);
    [OperationContract]
    EGUsuario Obtener_GUsuario_O_CodigoUsuario(string CodigoUsuario);
    [OperationContract]
    void Actualizar_GUsuario_A(string codigoUsuario, string sede);
    #endregion

    #region GRol
    [OperationContract]
    List<EGRol> Obtener_GRol_O_Todo();
    [OperationContract]
    EGRol Obtener_GRol_O_CodigoRol(string CodigoRol);
    #endregion

    #region GCelular
    [OperationContract]
    void Insertar_GCelular_I(string codigoUsuario, string codigoAreaCelular, int numeroCelular);
    [OperationContract]
    EGCelular Obtener_GCelular_O(int codigoCelular);
    [OperationContract]
    void Actualizar_GCelular_A(int codigoCelular, string codigoUsuario, string codigoAreaCelular, int numeroCelular);
    [OperationContract]
    void Eliminar_GCelular_E(int codigoCelular);
    #endregion

    #region GTutorExterno
    #endregion


    #region UsuarioNetvalle
    [OperationContract]
    EUsuarioNetvalle Obtener_UsuarioNetvalle_O_CodigoUsuario(string CodigoUsuario);
    #endregion
    #region GProyectoComplejo
    [OperationContract]
    List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(string CodigoUsuario);
    [OperationContract]
    List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(string CodigoUsuario);
    #region Opciones Proyecto
    [OperationContract]
    bool Verificar_GProyecto_CorrespondeRevision(string CodigoRol, byte NumeroEtapa, byte NumeroSubEtapa);
    [OperationContract]
    void Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(string CodigoProyecto);
    #endregion
    #endregion
    #region EProgresoEtapaSubEtapa
    [OperationContract]
    List<EProgresoEtapaSubEtapa> Obtener_EProgresoEtapaSubEtapa_O(string CodigoProyecto);
    [OperationContract]
    void Insertar_ProyectoCompleto(string codigoProyecto, int diasEtapa, int diasSubEtapa, string codigoUsuario, string codigoDirector);
    #endregion
    #region EUsuarioCompleto
    [OperationContract]
    EUsuarioCompleto Obtener_EUsuarioCompleto_O(string CodigoUsuario, string CodigoProyecto);
    #endregion
    #region TiemposEntrega
    [OperationContract]
    List<EProyectoTiempoEntrega> Obtener_EProyectoTiempoEntrega_O(string CodigoUsuario);
    #endregion
}