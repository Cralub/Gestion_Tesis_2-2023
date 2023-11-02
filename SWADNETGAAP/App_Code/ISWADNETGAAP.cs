using System;
using System.Collections.Generic;
using System.ServiceModel;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ISWADNETGAAP
{
    #region Tabla: GUsuarioRol
    [OperationContract]
    void Insertar_GUsuarioRol_I(EGUsuarioRol eGUsuarioRol);
    [OperationContract]
    int Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
    [OperationContract]
    List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoRol(string codigoRol);
    [OperationContract]
    List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoUsuario(string codigoUsuario);
    [OperationContract]
    EGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string codigoUsuario, string codigoRol);
    [OperationContract]
    void Actualizar_GUsuarioRol_A(EGUsuarioRol eGUsuarioRol);
    [OperationContract]
    void Eliminar_GUsuarioRol_E(int codigoUsuarioRol);
    #endregion
    #region Tabla: GUsuarioProyecto
    [OperationContract]
    void Insertar_GUsuarioProyecto_I(EGUsuarioProyecto eGUsuarioProyecto);
    [OperationContract]
    int Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
    [OperationContract]
    List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoProyecto(string codigoProyecto);
    [OperationContract]
    List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoUsuario(string codigoUsuario);
    [OperationContract]
    EGUsuarioProyecto Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(string codigoUsuario, string codigoProyecto);
    [OperationContract]
    void Actualizar_GUsuarioProyecto_A(EGUsuarioProyecto eGUsuarioProyecto);
    [OperationContract]
    void Eliminar_GUsuarioProyecto_E(int codigoUsuarioProyecto);
    #endregion
    #region Tabla: GProyecto
    [OperationContract]
    void Insertar_GProyecto_I(EGProyecto eGProyecto);
    [OperationContract]
    List<EGProyecto> Obtener_GProyecto_O(DateTime fechaInicio, DateTime fechaFin);
    [OperationContract]
    EGProyecto Obtener_GProyecto_O_CodigoProyecto(string codigoProyecto);

    [OperationContract]
    void Actualizar_GProyecto_A(EGProyecto eGProyecto);

    #endregion
    #region Tabla: GEtapa
    [OperationContract]
    void Insertar_GEtapa_I(EGEtapa eGEtapa);
    [OperationContract]
    List<EGEtapa> Obtener_GEtapa_O_CodigoProyecto(string codigoProyecto);
    [OperationContract]
    int Obtener_GEtapa_O_SiguienteCodigoEtapa();
    [OperationContract]
    EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(string codigoProyecto, char estadoEtapa);
    [OperationContract]
    EGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string codigoProyecto, byte numeroSubEtapa);

    [OperationContract]
    void Actualizar_GEtapa_A_EstadoEtapa(int codigoEtapa, char estadoEtapa);
    #endregion
    #region Tabla: GFormularioAceptacion
    [OperationContract]
    void Insertar_GFormularioAceptacion_I(EGFormularioAceptacion eGFormularioAceptacion);
    [OperationContract]
    List<EGFormularioAceptacion> Obtener_GFormularioAceptacion_O_CodigoProyecto(string codigoProyecto);
    [OperationContract]
    #endregion
    #region Tabla: GSubEtapa
    void Insertar_GSubEtapa_I(EGSubEtapa eGSubEtapa);
    [OperationContract]
    List<EGSubEtapa> Obtener_GSubEtapa_O_CodigoEtapa(int codigoEtapa);
    [OperationContract]
    int Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
    [OperationContract]
    EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(int codigoEtapa, char estadoSubEtapa);
    [OperationContract]
    EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int codigoEtapa, byte numeroSubEtapa);
    [OperationContract]
    void Actualizar_GSubEtapa_A_EstadoSubEtapa(int codigoSubEtapa, char estadoSubEtapa);
    #endregion
    #region Tabla: GObservacion
    [OperationContract]
    void Insertar_GObservacion_I(EGObservacion eGObservacion);
    [OperationContract]
    List<EGObservacion> Obtener_GObservacion_O_CodigoProyecto(string codigoProyecto);    
    [OperationContract]
    EGObservacion Obtener_GObservacion_O_CodigoObservacion(int codigoObservacion);
    [OperationContract]
    void Actualizar_GObservacion_A(EGObservacion eGObservacion);
    [OperationContract]
    void Actualizar_GObservacion_A_EstadoObservacion(int codigoObservacion, char estadoObservacion);
    [OperationContract]
    int Obtener_GObsevacion_O_SiguienteCodigoObservacion();
    #endregion
    #region Tabla: GUsuario
    [OperationContract]
    void Insertar_GUsuario_I(EGUsuario eGUsuario);
    [OperationContract]
    EGUsuario Obtener_GUsuario_O_CodigoUsuario(string codigoUsuario);
    [OperationContract]
    void Actualizar_GUsuario_A(EGUsuario eGUsuario);
    #endregion
    #region Tabla: GRol
    [OperationContract]
    List<EGRol> Obtener_GRol_O();
    [OperationContract]
    EGRol Obtener_GRol_O_CodigoRol(string codigoRol);
    #endregion
    #region Tabla : UsuarioNetvalle
    [OperationContract]
    EUsuarioNetvalle Obtener_UsuarioNetvalle_O_CodigoUsuario(string codigoUsuario);
    #endregion
    #region Tabla: GCelular
    [OperationContract]
    int Obtener_GCelular_O_SiguienteCodigoCelular();
    [OperationContract]
    void Insertar_GCelular_I(EGCelular eGCelular);
    [OperationContract]
    EGCelular Obtener_GCelular_O_CodigoUsuario(string codigoUsuario);
    [OperationContract]
    void Actualizar_GCelular_A(EGCelular eGCelular);
    [OperationContract]
    void Eliminar_GCelular_E(int codigoCelular);
    #endregion
    #region Tabla: GTutorExterno
    [OperationContract]
    void Insertar_GTutorExterno_I(EGTutorExterno eGTutorExterno);
    [OperationContract]
    EGTutorExterno Obtener_GTutorExterno_O_CodigoTutorExterno(int codigoTutorExterno);
    [OperationContract]
    void Actualizar_GTutorExterno_A(EGTutorExterno eGTutorExterno);
    [OperationContract]
    void Eliminar_GTutorExterno_E(int codigoTutorExterno);
    [OperationContract]
    List<EGTutorExterno> Obtener_GTutorExterno_O();
    #endregion
}


