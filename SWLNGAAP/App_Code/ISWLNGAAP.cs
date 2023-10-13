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
    void Insertar_GProyecto_I(string CodigoProyecto, char ModalidadProyecto, string TituloProyecto, string ObjetivoGeneralProyecto, string EnlaceDocumentoProyecto, char EstadoProyecto);
    [OperationContract]
    List<EGProyecto> Obtener_GProyecto_O_Todo();
    [OperationContract]
    EGProyecto Obtener_GProyecto_O_CodigoProyecto(string CodigoProyecto);
    [OperationContract]
    void Actualizar_GProyecto_A(string CodigoProyecto, char ModalidadProyecto, string TituloProyecto, string ObjetivoGeneralProyecto, string EnlaceDocumentoProyecto);
    #endregion
    #region GEtapa
    [OperationContract]
    void Insertar_GEtapa_I(int CodigoEtapa, byte NumeroEtapa, DateTime FechaInicioEtapa, DateTime FechaDefinidaEtapa, DateTime FechaFinEtapa, string CodigoProyecto, char EstadoEtapa);
    [OperationContract]
    int Obtener_GEtapa_O_SiguienteCodigoEtapa();
    [OperationContract]
    EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(string CodigoProyecto);
    [OperationContract]
    EGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string CodigoProyecto, byte NumeroSubEtapa);
    [OperationContract]
    void Actualizar_GEtapa_A_EstadoEtapa(int CodigoEtapa, char EstadoEtapa);
    #endregion
    #region GSubEtapa
    [OperationContract]
    void Insertar_GSubEtapa_I(int CodigoSubEtapa, byte NumeroSubEtapa, DateTime FechaInicioSubEtapa, DateTime FechaDefinidaSubEtapa, DateTime FechaFinSubEtapa, string CodigoUsuarioFirma, int CodigoEtapa, char EstadoSubEtapa);
    [OperationContract]
    int Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
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
    void Actualizar_GObservacion_A_EstadoObservacion(int CodigoObservacion, char EstadoObservacion);
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
    void Insertar_ProyectoCompleto(string CodigoProyecto, string CodigoUsuario, string CodigoDirector, int DiasEtapa, int DiasSubEtapa);
    #endregion

    #region EUsuarioCompleto
    [OperationContract]
    EUsuarioCompleto Obtener_EUsuarioCompleto_O(string CodigoUsuario, string CodigoProyecto);
    #endregion

    #region TiemposEntrega
    [OperationContract]
    List<EProyectoTiempoEntrega> Obtener_EProyectoTiempoEntrega_O(string CodigoUsuario);
    #endregion

    #region GTutorExterno
 
    [OperationContract]
    void Insertar_GTutorExterno_I(int codigoTutorExterno, string nombresTutorExterno, string apellidosTutorExterno, string carreraTutorExterno, string direccionTrabajoTutorExterno, string descripcionTutorExterno, string sedeTutorExterno);

    [OperationContract]
    void Actualizar_GTutorExterno_A(int codigoTutorExterno, string nombresTutorExterno, string apellidosTutorExterno, string carreraTutorExterno, string direccionTrabajoTutorExterno, string descripcionTutorExterno, string sedeTutorExterno);

    [OperationContract]
    List<EGTutorExterno> Obtener_GTutorExterno_O_Todo();

    [OperationContract]
    EGTutorExterno Obtener_GTutorExterno_O_CodigoTutorExterno(int codigoTutorExterno);

    [OperationContract]
    void Actualizar_GTutorExterno_A_Estado(int codigoTutorExterno, string estado);

    #endregion



}


