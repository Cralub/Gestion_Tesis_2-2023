using System;
using System.Collections.Generic;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class SWADNETGAAP : ISWADNETGAAP
{
    #region Tabla: GUsuarioRol
    public void Insertar_GUsuarioRol_I(EGUsuarioRol eGUsuarioRol)
    {
        CGUsuarioRol cGUsuarioRol = new CGUsuarioRol();
        cGUsuarioRol.Insertar_GUsuarioRol_I(eGUsuarioRol);
    }
    public int Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol()
    {
        CGUsuarioRol cGUsuarioRol = new CGUsuarioRol();
        return cGUsuarioRol.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoRol(string codigoRol)
    {
        CGUsuarioRol cGUsuarioRol = new CGUsuarioRol();
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        lstEGUsuarioRol = cGUsuarioRol.Obtener_GUsuarioRol_O_CodigoRol(codigoRol);
        return lstEGUsuarioRol;
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoUsuario(string codigoUsuario)
    {
        CGUsuarioRol cGUsuarioRol = new CGUsuarioRol();
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        lstEGUsuarioRol = cGUsuarioRol.Obtener_GUsuarioRol_O_CodigoUsuario(codigoUsuario);
        return lstEGUsuarioRol;
    }
    public EGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string codigoUsuario, string codigoRol)
    {
        CGUsuarioRol cGUsuarioRol = new CGUsuarioRol();
        return cGUsuarioRol.Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(codigoUsuario, codigoRol);
    }
    public void Actualizar_GUsuarioRol_A(EGUsuarioRol eGUsuarioRol)
    {
        CGUsuarioRol cGUsuarioRol = new CGUsuarioRol();
        cGUsuarioRol.Actualizar_GUsuarioRol_A(eGUsuarioRol);
    }
    public void Eliminar_GUsuarioRol_E(int codigoUsuarioRol)
    {
        CGUsuarioRol cGUsuarioRol = new CGUsuarioRol();
        cGUsuarioRol.Eliminar_GUsuarioRol_E(codigoUsuarioRol);
    }
    #endregion
    #region Tabla: GUsuarioProyecto
    public void Insertar_GUsuarioProyecto_I(EGUsuarioProyecto eGUsuarioProyecto)
    {
        CGUsuarioProyecto cGUsuarioProyecto = new CGUsuarioProyecto();
        cGUsuarioProyecto.Insertar_GUsuarioProyecto_I(eGUsuarioProyecto);
    }
    public int Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto()
    {
        CGUsuarioProyecto cGProyectoUsuario = new CGUsuarioProyecto();
        return cGProyectoUsuario.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoProyecto(string codigoProyecto)
    {
        CGUsuarioProyecto cGUsuarioProyecto = new CGUsuarioProyecto();
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        lstEGUsuarioProyecto = cGUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto);
        return lstEGUsuarioProyecto;
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoUsuario(string codigoUsuario)
    {
        CGUsuarioProyecto cGUsuarioProyecto = new CGUsuarioProyecto();
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        lstEGUsuarioProyecto = cGUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoUsuario(codigoUsuario);
        return lstEGUsuarioProyecto;
    }
    public EGUsuarioProyecto Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(string codigoUsuario, string codigoProyecto)
    {
        CGUsuarioProyecto cGProyectoUsuario = new CGUsuarioProyecto();
        return cGProyectoUsuario.Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(codigoUsuario, codigoProyecto);
    }
    public void Actualizar_GUsuarioProyecto_A(EGUsuarioProyecto eGUsuarioProyecto)
    {
        CGUsuarioProyecto cGUsuarioProyecto = new CGUsuarioProyecto();
        cGUsuarioProyecto.Actualizar_GUsuarioProyecto_A(eGUsuarioProyecto);
    }
    public void Eliminar_GUsuarioProyecto_E(int codigoUsuarioProyecto)
    {
        CGUsuarioProyecto cGUsuarioProyecto = new CGUsuarioProyecto();
        cGUsuarioProyecto.Eliminar_GUsuarioProyecto_E(codigoUsuarioProyecto);
    }
    #endregion
    #region Tabla: GProyecto
    public void Insertar_GProyecto_I(EGProyecto eGProyecto)
    {
        CGProyecto cGProyecto = new CGProyecto();
        cGProyecto.Insertar_GProyecto_I(eGProyecto);
    }
    
    public EGProyecto Obtener_GProyecto_O_CodigoProyecto(string codigoProyecto)
    {
        CGProyecto cGProyecto = new CGProyecto();
        EGProyecto eGProyecto = new EGProyecto();
        eGProyecto = cGProyecto.Obtener_GProyecto_O_CodigoProyecto(codigoProyecto);
        return eGProyecto;
    }
    public void Actualizar_GProyecto_A(EGProyecto egProyecto)
    {
        CGProyecto cGProyecto = new CGProyecto();
        cGProyecto.Actualizar_GProyecto_A(egProyecto);
    }
    #endregion
    #region Tabla: GEtapa
    public void Insertar_GEtapa_I(EGEtapa eGEtapa)
    {
        CGEtapa cGEtapa = new CGEtapa();
        cGEtapa.Insertar_GEtapa_I(eGEtapa);
    }
    public List<EGEtapa> Obtener_GEtapa_O_CodigoProyecto(string codigoProyecto)
    {
        CGEtapa cGEtapa = new CGEtapa();
        return cGEtapa.Obtener_GEtapa_O_CodigoProyecto(codigoProyecto);
    }
    public int Obtener_GEtapa_O_SiguienteCodigoEtapa()
    {
        CGEtapa cGEtapa = new CGEtapa();
        return cGEtapa.Obtener_GEtapa_O_SiguienteCodigoEtapa();
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(string codigoProyecto, char estadoEtapa)
    {
        CGEtapa cGEtapa = new CGEtapa();
        EGEtapa eGEtapa = new EGEtapa();
        eGEtapa = cGEtapa.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto, estadoEtapa);
        return eGEtapa;
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string codigoProyecto, byte numeroEtapa)
    {
        CGEtapa cGEtapa = new CGEtapa();
        EGEtapa eGEtapa = new EGEtapa();
        eGEtapa = cGEtapa.Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(codigoProyecto, numeroEtapa);
        return eGEtapa;
    }
    public void Actualizar_GEtapa_A_EstadoEtapa(int codigoEtapa, char estadoEtapa)
    {
        CGEtapa cGEtapa = new CGEtapa();
        cGEtapa.Actualizar_GEtapa_A_EstadoEtapa(codigoEtapa, estadoEtapa);
    }

    #endregion
    #region Tabla: GFormularioAceptacion
    public void Actualizar_GFormularioAceptacion_A(EGFormularioAceptacion eGFormularioAceptacion)
    {
        CGFormularioAceptacion cGFormularioAceptacion = new CGFormularioAceptacion();
        cGFormularioAceptacion.Actualizar_GFormularioAceptacion_A(eGFormularioAceptacion);
    }
    public void Insertar_GFormularioAceptacion_I(EGFormularioAceptacion eGFormularioAceptacion)
    {
        CGFormularioAceptacion cGFormularioAceptacion = new CGFormularioAceptacion();
        cGFormularioAceptacion.Insertar_GFormularioAceptacion_I(eGFormularioAceptacion);
    }
    public List<EGFormularioAceptacion> Obtener_GFormularioAceptacion_O_CodigoProyecto(string codigoProyecto)
    {
        CGFormularioAceptacion cGFormularioAceptacion = new CGFormularioAceptacion();
        List<EGFormularioAceptacion> lstEGFormularioAceptacion = new List<EGFormularioAceptacion>();
        lstEGFormularioAceptacion = cGFormularioAceptacion.Obtener_GFormularioAceptacion_O_CodigoProyecto(codigoProyecto);
        return lstEGFormularioAceptacion;
    }

    public int Obtener_GFormularioAceptacion_O_SiguienteCodigoFormularioAceptacion()
    {
        CGSubEtapa cGSubEtapa = new CGSubEtapa();
        return cGSubEtapa.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
    }

    #endregion
    #region Tabla: GSubEtapa
    public void Insertar_GSubEtapa_I(EGSubEtapa eGSubEtapa)
    {
        CGSubEtapa cGSubEtapa = new CGSubEtapa();
        cGSubEtapa.Insertar_GSubEtapa_I(eGSubEtapa);
    }
    public List<EGSubEtapa> Obtener_GSubEtapa_O_CodigoEtapa(int codigoEtapa)
    {
        CGSubEtapa cGSubEtapa = new CGSubEtapa();
        return cGSubEtapa.Obtener_GSubEtapa_O_CodigoEtapa(codigoEtapa);
    }
    public int Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa()
    {
        CGSubEtapa cGSubEtapa = new CGSubEtapa();
        return cGSubEtapa.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(int codigoEtapa, char estadoSubEtapa)
    {
        CGSubEtapa cGSubEtapa = new CGSubEtapa();
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        eGSubEtapa = cGSubEtapa.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(codigoEtapa, estadoSubEtapa);
        return eGSubEtapa;
    }
    public void Actualizar_GSubEtapa_A_CodigoUsuarioFirmaSubEtapa_EstadoSubEtapa(string codigoUsuarioFirmaSubEtapa, int codigoSubEtapa, char estadoSubEtapa)
    {
        CGSubEtapa cGSubEtapa = new CGSubEtapa();
        cGSubEtapa.Actualizar_GSubEtapa_A_CodigoUsuarioFirmaSubEtapa_EstadoSubEtapa(codigoUsuarioFirmaSubEtapa, codigoSubEtapa, estadoSubEtapa);
    }
    public void Actualizar_GSubEtapa_A_EstadoSubEtapa(int codigoSubEtapa, char estadoSubEtapa)
    {
        CGSubEtapa cGSubEtapa = new CGSubEtapa();
        cGSubEtapa.Actualizar_GSubEtapa_A_EstadoSubEtapa(codigoSubEtapa, estadoSubEtapa);
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int codigoEtapa, byte numeroSubEtapa)
    {
        CGSubEtapa cGSubEtapa = new CGSubEtapa();
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        eGSubEtapa = cGSubEtapa.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(codigoEtapa, numeroSubEtapa);
        return eGSubEtapa;
    }
    #endregion
    #region Tabla: GObservacion
    public void Insertar_GObservacion_I(EGObservacion eGObservacion)
    {
        CGObservacion cGObservacion = new CGObservacion();
        cGObservacion.Insertar_GObservacion_I(eGObservacion);
    }
    public List<EGObservacion> Obtener_GObservacion_O_CodigoProyecto(string codigoProyecto)
    {
        CGObservacion cGObservacion = new CGObservacion();
        List<EGObservacion> lstEGObservaciones = new List<EGObservacion>();
        lstEGObservaciones = cGObservacion.Obtener_GObservacion_O_CodigoProyecto(codigoProyecto);
        return lstEGObservaciones;
    }


    public EGObservacion Obtener_GObservacion_O_CodigoObservacion(int codigoObservacion)
    {
        CGObservacion cGObservacion = new CGObservacion();
        return cGObservacion.Obtener_GObservacion_O_CodigoObservacion(codigoObservacion);
    }

    public void Actualizar_GObservacion_A(EGObservacion eGObservacion)
    {
        CGObservacion cGObservacion = new CGObservacion();
        cGObservacion.Actualizar_GObservacion_A(eGObservacion);
    }

    public void Actualizar_GObservacion_A_EstadoObservacion(int codigoObservacion, char estadoObservacion)
    {
        CGObservacion cGObservacion = new CGObservacion();
        cGObservacion.Actualizar_GObservacion_A_EstadoObservacion(codigoObservacion, estadoObservacion);
    }
    public int Obtener_GObsevacion_O_SiguienteCodigoObservacion()
    {
        CGObservacion cGObservacion = new CGObservacion();
        return cGObservacion.Obtener_GObsevacion_O_SiguienteCodigoObservacion();
    }
    #endregion
    #region Tabla: GUsuario
    public void Insertar_GUsuario_I(EGUsuario eGUsuario)
    {
        CGUsuario cGUsuario = new CGUsuario();
        cGUsuario.Insertar_GUsuario_I(eGUsuario);
    }
    public EGUsuario Obtener_GUsuario_O_CodigoUsuario(string codigoUsuario)
    {
        CGUsuario cGUsuario = new CGUsuario();
        return cGUsuario.Obtener_GUsuario_O_CodigoUsuario(codigoUsuario);
    }
    public EGUsuario Obtener_GUsuario_O_NombreCompletoUsuario(string nombreCompletoUsuario)
    {
        CGUsuario cGUsuario = new CGUsuario();
        return cGUsuario.Obtener_GUsuario_O_NombreCompletoUsuario(nombreCompletoUsuario);
    }
    public List<EGUsuario> Buscar_GUsuario_B_NombreCompletoUsuario(string nombreCompletoUsuario)
    {
        CGUsuario cGUsuario = new CGUsuario();
        return cGUsuario.Buscar_GUsuario_B_NombreCompletoUsuario(nombreCompletoUsuario);
    }
    public void Actualizar_GUsuario_A(EGUsuario eGUsuario)
    {
        CGUsuario cGUsuario = new CGUsuario();
        cGUsuario.Actualizar_GUsuario_A(eGUsuario);
    }
    #endregion
    #region Tabla: GRol
    public List<EGRol> Obtener_GRol_O()
    {
        CGRol cGRol = new CGRol();
        return cGRol.Obtener_GRol_O();
    }
    public EGRol Obtener_GRol_O_CodigoRol(string codigoRol)
    {
        CGRol cGRol = new CGRol();
        return cGRol.Obtener_GRol_O_CodigoRol(codigoRol);
    }
    #endregion
    #region Tabla: UsuarioNetvalle
    public EUsuarioNetvalle Obtener_UsuarioNetvalle_O_CodigoUsuario(string codigoUsuario)
    {
        CUsuarioNetvalle cUsuarioNetvalle = new CUsuarioNetvalle();
        return cUsuarioNetvalle.Obtener_UsuarioNetvalle_O_CodigoUsuario(codigoUsuario);
    }
    #endregion
    #region Tabla: GCelular
    public int Obtener_GCelular_O_SiguienteCodigoCelular()
    {
        CGCelular cGCelular = new CGCelular();
        return cGCelular.Obtener_GCelular_O_SiguienteCodigoCelular();
    }
    public void Insertar_GCelular_I(EGCelular eGCelular)
    {
        CGCelular cGCelular = new CGCelular();
        cGCelular.Insertar_GCelular_I(eGCelular);
    }
    public EGCelular Obtener_GCelular_O_CodigoUsuario(string codigoUsuario)
    {
        CGCelular cGCelular = new CGCelular();
        return cGCelular.Obtener_GCelular_O_CodigoUsuario(codigoUsuario);
    }
    public void Actualizar_GCelular_A(EGCelular eGCelular)
    {
        CGCelular cGCelular = new CGCelular();
        cGCelular.Actualizar_GCelular_A(eGCelular);
    }
    public void Eliminar_GCelular_E(int codigoCelular)
    {
        CGCelular cGCelular = new CGCelular();
        cGCelular.Eliminar_GCelular_E(codigoCelular);
    }
    #endregion
    #region Tabla: GTutorExterno
    public void Insertar_GTutorExterno_I(EGTutorExterno eGTutorExterno)
    {
        CGTutorExterno cGTutorExterno = new CGTutorExterno();
        cGTutorExterno.Insertar_GTutorExterno_I(eGTutorExterno);
    }
    public void Actualizar_GTutorExterno_A(EGTutorExterno eGTutorExterno)
    {
        CGTutorExterno cGTutorExterno = new CGTutorExterno();
        cGTutorExterno.Actualizar_GTutorExterno_A(eGTutorExterno);
    }

    public void Eliminar_GTutorExterno_E(string codigoTutorExterno)
    {
        CGTutorExterno cGTutorExterno = new CGTutorExterno();
        cGTutorExterno.Eliminar_GTutorExterno_E(codigoTutorExterno);
    }

    public List<EGTutorExterno> Obtener_GTutorExterno_O()
    {
        CGTutorExterno cGTutorExterno = new CGTutorExterno();
        return cGTutorExterno.Obtener_GTutorExterno_O();
    }

    public EGTutorExterno Obtener_GTutorExterno_O_CodigoTutorExterno(string codigoTutorExterno)
    {
        CGTutorExterno cGTutorExterno = new CGTutorExterno();
        return cGTutorExterno.Obtener_GTutorExterno_O_CodigoTutorExterno(codigoTutorExterno);
    }
    #endregion
}
