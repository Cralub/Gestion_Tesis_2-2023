using SWADNETGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
    #region Metodos privados
    private EDefecto ContruirErrorServicio(TTipoDefecto tipoDefecto, string metodo, string excepcion, string mensaje)
    {
        EDefecto eDefecto = new EDefecto();
        eDefecto.TipoDefecto = tipoDefecto;
        eDefecto.Servicio = "SWLNGAAP";
        eDefecto.Clase = "CGAAP";
        eDefecto.Metodo = metodo;
        eDefecto.Excepcion = excepcion;
        eDefecto.Mensaje = mensaje;
        return eDefecto;
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
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_GUsuarioRol_I", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eGUsuarioRol.CodigoUsuarioRol = codigoUsuarioRol;
                eGUsuarioRol.CodigoRol = codigoRol;
                eGUsuarioRol.CodigoUsuario = codigoUsuario;
                aSNETGAAP.Insertar_GUsuarioRol_I(eGUsuarioRol);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Insertar_GUsuarioRol_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }
    public int Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol()
    {
        int ultimoCodigo = 0;
        try
        {
            ultimoCodigo = aSNETGAAP.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                ultimoCodigo = aSNETGAAP.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return ultimoCodigo;
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoRol(string codigoRol)
    {
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        try
        {
            lstEGUsuarioRol = aSNETGAAP.Obtener_GUsuarioRol_O_CodigoRol(codigoRol).ToList();
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GUsuarioRol_O_CodigoRol", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstEGUsuarioRol = aSNETGAAP.Obtener_GUsuarioRol_O_CodigoRol(codigoRol).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GUsuarioRol_O_CodigoRol", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return lstEGUsuarioRol;
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoUsuario(string codigoUsuario)
    {
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        try
        {
            lstEGUsuarioRol = aSNETGAAP.Obtener_GUsuarioRol_O_CodigoUsuario(codigoUsuario).ToList();
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GUsuarioRol_O_CodigoUsuario", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstEGUsuarioRol = aSNETGAAP.Obtener_GUsuarioRol_O_CodigoUsuario(codigoUsuario).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GUsuarioRol_O_CodigoUsuario", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return lstEGUsuarioRol;
    }
    public EGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string codigoUsuario, string codigoRol)
    {
        EGUsuarioRol eGUsuarioRol = new EGUsuarioRol();
        try
        {
            eGUsuarioRol = aSNETGAAP.Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(codigoUsuario, codigoRol);

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eGUsuarioRol = aSNETGAAP.Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(codigoUsuario, codigoRol);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return eGUsuarioRol;
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
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_GUsuarioRol_A", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eGUsuarioRol.CodigoUsuarioRol = codigoUsuarioRol;
                eGUsuarioRol.CodigoUsuario = codigoUsuario;
                eGUsuarioRol.CodigoRol = codigoRol;
                aSNETGAAP.Actualizar_GUsuarioRol_A(eGUsuarioRol);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Actualizar_GUsuarioRol_A", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }
    public void Eliminar_GusuarioRol_E(int codigoUsuarioRol)
    {
        try
        {
            aSNETGAAP.Eliminar_GUsuarioRol_E(codigoUsuarioRol);

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Eliminar_GUsuarioRol_E", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                aSNETGAAP.Eliminar_GUsuarioRol_E(codigoUsuarioRol);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Eliminar_GUsuarioRol_E", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
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
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_GUsuarioProyecto_I", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eGUsuarioProyecto.CodigoUsuarioProyecto = codigoUsuarioProyecto;
                eGUsuarioProyecto.CodigoProyecto = codigoProyecto;
                eGUsuarioProyecto.CodigoUsuario = codigoUsuario;
                eGUsuarioProyecto.CodigoRol = codigoRol;
                eGUsuarioProyecto.EstadoUsuarioProyecto = estadoUsuarioProyecto;
                aSNETGAAP.Insertar_GUsuarioProyecto_I(eGUsuarioProyecto);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Insertar_GUsuarioProyecto_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }
    public int Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto()
    {
        int ultimoCodigo = 0;
        try
        {
            ultimoCodigo = aSNETGAAP.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                ultimoCodigo = aSNETGAAP.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return ultimoCodigo;

    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoProyecto(string codigoProyecto)
    {
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        try
        {
            lstEGUsuarioProyecto = aSNETGAAP.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto).ToList();
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GUsuarioProyecto_O_CodigoProyecto", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstEGUsuarioProyecto = aSNETGAAP.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GUsuarioProyecto_O_CodigoProyecto", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return lstEGUsuarioProyecto;
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoUsuario(string codigoUsuario)
    {
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        try
        {
            lstEGUsuarioProyecto = aSNETGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario(codigoUsuario).ToList();
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GUsuarioProyecto_O_CodigoUsuario", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstEGUsuarioProyecto = aSNETGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario(codigoUsuario).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GUsuarioProyecto_O_CodigoUsuario", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return lstEGUsuarioProyecto;
    }
    public EGUsuarioProyecto Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(string codigoUsuario, string codigoProyecto)
    {
        EGUsuarioProyecto eGUsuarioProyecto = new EGUsuarioProyecto();
        try
        {
            eGUsuarioProyecto = aSNETGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(codigoUsuario, codigoProyecto);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eGUsuarioProyecto = aSNETGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(codigoUsuario, codigoProyecto);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return eGUsuarioProyecto;
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
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_GUsuarioProyecto_A", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eGProyectoUsuario.CodigoUsuarioProyecto = codigoUsuarioProyecto;
                eGProyectoUsuario.CodigoProyecto = codigoProyecto;
                eGProyectoUsuario.CodigoUsuario = codigoUsuario;
                eGProyectoUsuario.CodigoRol = codigoRol;
                eGProyectoUsuario.EstadoUsuarioProyecto = estadoUsuarioProyecto;
                aSNETGAAP.Actualizar_GUsuarioProyecto_A(eGProyectoUsuario);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Actualizar_GUsuarioProyecto_A", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }
    public void Eliminar_GUsuarioProyecto_E(int codigoUsuarioProyecto)
    {
        try
        {
            aSNETGAAP.Eliminar_GUsuarioProyecto_E(codigoUsuarioProyecto);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Eliminar_GUsuarioProyecto_E", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                aSNETGAAP.Eliminar_GUsuarioProyecto_E(codigoUsuarioProyecto);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Eliminar_GUsuarioProyecto_E", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
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
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_GProyecto_I", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eGProyecto.CodigoProyecto = codigoProyecto;
                eGProyecto.ModalidadProyecto = modalidadProyecto;
                eGProyecto.TituloProyecto = tituloProyecto;
                eGProyecto.ObjetivoGeneralProyecto = objetivoGeneralProyecto;
                eGProyecto.EnlaceDocumentoProyecto = enlaceDocumentoProyecto;
                eGProyecto.EstadoProyecto = estadoProyecto;
                aSNETGAAP.Insertar_GProyecto_I(eGProyecto);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Insertar_GProyecto_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }
    public List<EGProyecto> Obtener_GProyecto_O(DateTime fechaInicio, DateTime fechaFin)
    {
        List<EGProyecto> lstEGProyecto = new List<EGProyecto>();
        try
        {
            lstEGProyecto = aSNETGAAP.Obtener_GProyecto_O(fechaInicio, fechaFin).ToList();
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GProyecto_O", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstEGProyecto = aSNETGAAP.Obtener_GProyecto_O(fechaInicio, fechaFin).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GProyecto_O", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return lstEGProyecto;
    }
    public EGProyecto Obtener_GProyecto_O_CodigoProyecto(string codigoProyecto)
    {
        EGProyecto eGProyecto = new EGProyecto();
        try
        {
            eGProyecto = aSNETGAAP.Obtener_GProyecto_O_CodigoProyecto(codigoProyecto);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GProyecto_O_CodigoProyecto", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eGProyecto = aSNETGAAP.Obtener_GProyecto_O_CodigoProyecto(codigoProyecto);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GProyecto_O_CodigoProyecto", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return eGProyecto;
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
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GProyecto_O_CodigoUsuario", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                foreach (EGUsuarioProyecto proyectos in lstEGUsuarioProyecto)
                {
                    eEGProyecto = new EGProyecto();
                    eEGProyecto = Obtener_GProyecto_O_CodigoProyecto(proyectos.CodigoProyecto);
                    lstEGProyecto.Add(eEGProyecto);
                }
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GProyecto_O_CodigoUsuario", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return lstEGProyecto;
    }
    public void Actualizar_GProyecto_A(EGProyecto eGProyecto)
    {
        try
        {
            aSNETGAAP.Actualizar_GProyecto_A(eGProyecto);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_GProyecto_A", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                aSNETGAAP.Actualizar_GProyecto_A(eGProyecto);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Actualizar_GProyecto_A", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
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
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_GEtapa_I", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
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
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Insertar_GEtapa_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }
    public List<EGEtapa> Obtener_GEtapa_O_CodigoProyecto(string codigoProyecto)
    {
        List<EGEtapa> lstEGEtapa = new List<EGEtapa>();
        try
        {
            lstEGEtapa = aSNETGAAP.Obtener_GEtapa_O_CodigoProyecto(codigoProyecto).ToList();
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GEtapa_O_CodigoProyecto", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstEGEtapa = aSNETGAAP.Obtener_GEtapa_O_CodigoProyecto(codigoProyecto).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GEtapa_O_CodigoProyecto", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return lstEGEtapa;
    }
    public int Obtener_GEtapa_O_SiguienteCodigoEtapa()
    {
        int ultimoCodigo = 0;
        try
        {
            ultimoCodigo = aSNETGAAP.Obtener_GEtapa_O_SiguienteCodigoEtapa();
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GEtapa_O_SiguienteCodigoEtapa", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                ultimoCodigo = aSNETGAAP.Obtener_GEtapa_O_SiguienteCodigoEtapa();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GEtapa_O_SiguienteCodigoEtapa", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return ultimoCodigo;
    }

    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(string codigoProyecto, char estadoEtapa)
    {
        EGEtapa eGEtapa = new EGEtapa();
        try
        {
            eGEtapa = aSNETGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto, estadoEtapa);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eGEtapa = aSNETGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto, estadoEtapa);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return eGEtapa;
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string codigoProyecto, byte numeroSubEtapa)
    {
        EGEtapa eGEtapa = new EGEtapa();
        try
        {
            eGEtapa = aSNETGAAP.Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(codigoProyecto, numeroSubEtapa);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eGEtapa = aSNETGAAP.Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(codigoProyecto, numeroSubEtapa);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return eGEtapa;
    }

    public void Actualizar_GEtapa_A_EstadoEtapa(int codigoEtapa, char estadoEtapa)
    {
        try
        {
            aSNETGAAP.Actualizar_GEtapa_A_EstadoEtapa(codigoEtapa, estadoEtapa);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_GEtapa_A_EstadoEtapa", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                aSNETGAAP.Actualizar_GEtapa_A_EstadoEtapa(codigoEtapa, estadoEtapa);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Actualizar_GEtapa_A_EstadoEtapa", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
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
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_GFormularioAceptacion_I", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                aSNETGAAP.Insertar_GFormularioAceptacion_I(eGFormularioAceptacion);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Insertar_GFormularioAceptacion_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }
    public List<EGFormularioAceptacion> Obtener_GFormularioAceptacion_O_CodigoProyecto(string codigoProyecto)
    {
        List<EGFormularioAceptacion> lstFormularioAceptacion = new List<EGFormularioAceptacion>();
        try
        {
            lstFormularioAceptacion = aSNETGAAP.Obtener_GFormularioAceptacion_O_CodigoProyecto(codigoProyecto).ToList();
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GFormularioAceptacion_O_CodigoProyecto", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstFormularioAceptacion = aSNETGAAP.Obtener_GFormularioAceptacion_O_CodigoProyecto(codigoProyecto).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GFormularioAceptacion_O_CodigoProyecto", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return lstFormularioAceptacion;
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
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_GSubEtapa_I", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
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
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Insertar_GSubEtapa_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }
    public List<EGSubEtapa> Obtener_GSubEtapa_O_CodigoEtapa(int codigoEtapa)
    {
        List<EGSubEtapa> lstEGSubEtapa = new List<EGSubEtapa>();
        try
        {
            lstEGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa(codigoEtapa).ToList();
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GSubEtapa_O_CodigoEtapa", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstEGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa(codigoEtapa).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GSubEtapa_O_CodigoEtapa", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return lstEGSubEtapa;
    }
    public int Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa()
    {
        int ultimoCodigo = 0;
        try
        {
            ultimoCodigo = aSNETGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                ultimoCodigo = aSNETGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return ultimoCodigo;
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(int codigoEtapa, char estadoSubEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        try
        {
            eGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(codigoEtapa, estadoSubEtapa);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(codigoEtapa, estadoSubEtapa);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return eGSubEtapa;
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int codigoEtapa, byte numeroSubEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        try
        {
            eGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(codigoEtapa, numeroSubEtapa);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(codigoEtapa, numeroSubEtapa);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return eGSubEtapa;
    }
    public void Actualizar_GSubEtapa_A_EstadoSubEtapa(int codigoSubEtapa, char estadoSubEtapa)
    {
        try
        {
            aSNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(codigoSubEtapa, estadoSubEtapa);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_GSubEtapa_A_EstadoSubEtapa", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                aSNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(codigoSubEtapa, estadoSubEtapa);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Actualizar_GSubEtapa_A_EstadoSubEtapa", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
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
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_GObservacion_I", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
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
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Insertar_GObservacion_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }

    public List<EGObservacion> Obtener_GObservacion_O_CodigoProyecto(string codigoProyecto)
    {
        List<EGObservacion> lstObservacion = new List<EGObservacion>();
        try
        {
            lstObservacion = aSNETGAAP.Obtener_GObservacion_O_CodigoProyecto(codigoProyecto).ToList();
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GObservacion_O_CodigoProyecto", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstObservacion = aSNETGAAP.Obtener_GObservacion_O_CodigoProyecto(codigoProyecto).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GObservacion_O_CodigoProyecto", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return lstObservacion;
    }
    public EGObservacion Obtener_GObservacion_O_CodigoObservacion(int codigoObservacion)
    {
        EGObservacion eGObservacion = new EGObservacion();
        try
        {
            eGObservacion = aSNETGAAP.Obtener_GObservacion_O_CodigoObservacion(codigoObservacion);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GObservacion_O_CodigoObservacion", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eGObservacion = aSNETGAAP.Obtener_GObservacion_O_CodigoObservacion(codigoObservacion);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GObservacion_O_CodigoObservacion", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return eGObservacion;
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
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_GObservacion_A", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
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
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Actualizar_GObservacion_A", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }
    public void Actualizar_GObservacion_A_EstadoObservacion(int codigoObservacion, char estadoObservacion)
    {
        try
        {
            aSNETGAAP.Actualizar_GObservacion_A_EstadoObservacion(codigoObservacion, estadoObservacion);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_GObservacion_A_EstadoObservacion", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                aSNETGAAP.Actualizar_GObservacion_A_EstadoObservacion(codigoObservacion, estadoObservacion);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Actualizar_GObservacion_A_EstadoObservacion", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }
    public int Obtener_GObsevacion_O_SiguienteCodigoObservacion()
    {
        int ultimoCodigo = 0;
        try
        {
            ultimoCodigo = aSNETGAAP.Obtener_GObsevacion_O_SiguienteCodigoObservacion();
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GObsevacion_O_SiguienteCodigoObservacion", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                ultimoCodigo = aSNETGAAP.Obtener_GObsevacion_O_SiguienteCodigoObservacion();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GObsevacion_O_SiguienteCodigoObservacion", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return ultimoCodigo;
    }
    #endregion    
    #region GUsuario
    public void Insertar_GUsuario_I(string codigoUsuario, string nombreCompletoUsuario, string sedeUsuario)
    {
        EGUsuario eGUsuario = new EGUsuario();
        try
        {
            eGUsuario.CodigoUsuario = codigoUsuario;
            eGUsuario.NombreCompletoUsuario = nombreCompletoUsuario;
            eGUsuario.SedeUsuario = sedeUsuario;
            aSNETGAAP.Insertar_GUsuario_I(eGUsuario);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_GUsuario_I", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eGUsuario.CodigoUsuario = codigoUsuario;
                eGUsuario.NombreCompletoUsuario = nombreCompletoUsuario;
                eGUsuario.SedeUsuario = sedeUsuario;
                aSNETGAAP.Insertar_GUsuario_I(eGUsuario);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Insertar_GUsuario_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }
    public EGUsuario Obtener_GUsuario_O_CodigoUsuario(string codigoUsuario)
    {
        EGUsuario eGUsuario = new EGUsuario();
        try
        {
            eGUsuario = aSNETGAAP.Obtener_GUsuario_O_CodigoUsuario(codigoUsuario);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GUsuario_O_CodigoUsuario", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eGUsuario = aSNETGAAP.Obtener_GUsuario_O_CodigoUsuario(codigoUsuario);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GUsuario_O_CodigoUsuario", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return eGUsuario;
    }
    public EGUsuario Obtener_GUsuario_O_NombreCompletoUsuario(string nombreCompletoUsuario)
    {
        EGUsuario eGUsuario = new EGUsuario();
        try
        {
            eGUsuario = aSNETGAAP.Obtener_GUsuario_O_NombreCompletoUsuario(nombreCompletoUsuario);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GUsuario_O_NombreCompletoUsuario", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eGUsuario = aSNETGAAP.Obtener_GUsuario_O_NombreCompletoUsuario(nombreCompletoUsuario);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GUsuario_O_NombreCompletoUsuario", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return eGUsuario;
    }
    public List<EGUsuario> Buscar_GUsuario_B_NombreCompletoUsuario(string nombreCompletoUsuario)
    {
        List<EGUsuario> lstEGUsuario = new List<EGUsuario>();
        try
        {
            lstEGUsuario = aSNETGAAP.Buscar_GUsuario_B_NombreCompletoUsuario(nombreCompletoUsuario);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Buscar_GUsuario_B_NombreCompletoUsuario", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstEGUsuario = aSNETGAAP.Buscar_GUsuario_B_NombreCompletoUsuario(nombreCompletoUsuario);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Buscar_GUsuario_B_NombreCompletoUsuario", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return lstEGUsuario;
    }
    public void Actualizar_GUsuario_A(string codigoUsuario, string nombreCompletoUsuario, string sedeUsuario)
    {
        EGUsuario eGUsuario = new EGUsuario();
        try
        {
            eGUsuario.CodigoUsuario = codigoUsuario;
            eGUsuario.NombreCompletoUsuario = nombreCompletoUsuario;
            eGUsuario.SedeUsuario = sedeUsuario;
            aSNETGAAP.Actualizar_GUsuario_A(eGUsuario);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_GUsuario_A", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eGUsuario.CodigoUsuario = codigoUsuario;
                eGUsuario.NombreCompletoUsuario = nombreCompletoUsuario;
                eGUsuario.SedeUsuario = sedeUsuario;
                aSNETGAAP.Actualizar_GUsuario_A(eGUsuario);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Actualizar_GUsuario_A", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
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
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GUsuarios_O_CodigoProyecto", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstEGUsuarioProyecto = Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto);
                foreach (EGUsuarioProyecto eGUsuarioProyecto in lstEGUsuarioProyecto)
                {
                    EGUsuario eGUsuario = Obtener_GUsuario_O_CodigoUsuario(eGUsuarioProyecto.CodigoUsuario);

                    lstEGUsuarios.Add(eGUsuario);
                }
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GUsuarios_O_CodigoProyecto", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
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
            lstEGRol = aSNETGAAP.Obtener_GRol_O().ToList();
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GRol_O", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstEGRol = aSNETGAAP.Obtener_GRol_O().ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GRol_O", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return lstEGRol;
    }
    public EGRol Obtener_GRol_O_CodigoRol(string codigoRol)
    {
        EGRol eGRol = new EGRol();
        try
        {
            eGRol = aSNETGAAP.Obtener_GRol_O_CodigoRol(codigoRol);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GRol_O_CodigoRol", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eGRol = aSNETGAAP.Obtener_GRol_O_CodigoRol(codigoRol);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GRol_O_CodigoRol", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
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
            eUsuarioNetvalle = aSNETGAAP.Obtener_UsuarioNetvalle_O_CodigoUsuario(codigoUsuario);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_UsuarioNetvalle_O_CodigoUsuario", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eUsuarioNetvalle = aSNETGAAP.Obtener_UsuarioNetvalle_O_CodigoUsuario(codigoUsuario);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_UsuarioNetvalle_O_CodigoUsuario", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return eUsuarioNetvalle;
    }
    #endregion
    #region GCelular
    public int Obtener_GCelular_O_SiguienteCodigoCelular()
    {
        int ultimoCodigo = 0;
        try
        {
            ultimoCodigo = aSNETGAAP.Obtener_GCelular_O_SiguienteCodigoCelular();
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GCelular_O_SiguienteCodigoCelular", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                ultimoCodigo = aSNETGAAP.Obtener_GCelular_O_SiguienteCodigoCelular();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GCelular_O_SiguienteCodigoCelular", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return ultimoCodigo;
    }
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
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_GCelular_I", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                celular.CodigoCelular = aSNETGAAP.Obtener_GCelular_O_SiguienteCodigoCelular();
                celular.CodigoUsuario = codigoUsuario;
                celular.CodigoAreaCelular = codigoAreaCelular;
                celular.NumeroCelular = numeroCelular;
                aSNETGAAP.Insertar_GCelular_I(celular);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Insertar_GCelular_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }
    public EGCelular Obtener_GCelular_O_CodigoUsuario(string codigoUsuario)
    {
        EGCelular eGCelular = new EGCelular();
        try
        {
            eGCelular = aSNETGAAP.Obtener_GCelular_O_CodigoUsuario(codigoUsuario);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GCelular_O_CodigoUsuario", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eGCelular = aSNETGAAP.Obtener_GCelular_O_CodigoUsuario(codigoUsuario);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GCelular_O_CodigoUsuario", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return eGCelular;
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
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_GCelular_A", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                celular.CodigoCelular = codigoCelular;
                celular.CodigoUsuario = codigoUsuario;
                celular.CodigoAreaCelular = codigoAreaCelular;
                celular.NumeroCelular = numeroCelular;
                aSNETGAAP.Actualizar_GCelular_A(celular);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Actualizar_GCelular_A", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }
    public void Eliminar_GCelular_E(int codigoCelular)
    {
        try
        {
            aSNETGAAP.Eliminar_GCelular_E(codigoCelular);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Eliminar_GCelular_E", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                aSNETGAAP.Eliminar_GCelular_E(codigoCelular);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Eliminar_GCelular_E", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }
    #endregion
    #region GTutorExterno
    public List<EGTutorExterno> Obtener_GTutorExterno_O()
    {
        List<EGTutorExterno> lstEGTutorExterno = new List<EGTutorExterno>();
        try
        {
            lstEGTutorExterno = aSNETGAAP.Obtener_GTutorExterno_O().ToList();
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GTutorExterno_O", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstEGTutorExterno = aSNETGAAP.Obtener_GTutorExterno_O().ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GTutorExterno_O", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return lstEGTutorExterno;
    }

    public EGTutorExterno Obtener_GTutorExterno_O_CodigoTutorExterno(int codigoTutorExterno)
    {
        EGTutorExterno eGTutorExterno = new EGTutorExterno();
        try
        {
            eGTutorExterno = aSNETGAAP.Obtener_GTutorExterno_O_CodigoTutorExterno(codigoTutorExterno);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GTutorExterno_O_CodigoTutorExterno", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eGTutorExterno = aSNETGAAP.Obtener_GTutorExterno_O_CodigoTutorExterno(codigoTutorExterno);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GTutorExterno_O_CodigoTutorExterno", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return eGTutorExterno;
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
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_GTutorExterno_I", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
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
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Insertar_GTutorExterno_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
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
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_GTutorExterno_A", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
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
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Actualizar_GTutorExterno_A", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }

    public void Eliminar_GTutorExterno_E(int codigoTutorExterno)
    {
        try
        {
            aSNETGAAP.Eliminar_GTutorExterno_E(codigoTutorExterno);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Eliminar_GTutorExterno_E", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                aSNETGAAP.Eliminar_GTutorExterno_E(codigoTutorExterno);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Eliminar_GTutorExterno_E", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
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
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_GEtapa_GSubEtapa_A", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                eGEtapa = aSNETGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto, SDatos.ESTADO_ACTIVO);
                eGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(eGSubEtapa.CodigoEtapa, SDatos.ESTADO_ACTIVO);
                byte NumeroSubEtapa = eGSubEtapa.NumeroSubEtapa;
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Actualizar_GEtapa_GSubEtapa_A", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
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
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_EProgresoEtapaSubEtapa_O", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
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
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_EProgresoEtapaSubEtapa_O", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return lstEProgresoEtapaSubEtapa;
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
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_EUsuarioCompleto_O_CodigoUsuario", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
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

            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_EUsuarioCompleto_O_CodigoUsuario", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return eEUsuarioCompleto;
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
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_EProyectoTiempoEntrega_O", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
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

            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_EProyectoTiempoEntrega_O", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return lstEProyectoTiempoEntrega;
    }
    #endregion
    #region GProyectoCompleja
    #region Obtener Proyecto Completo
    public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(string codigoUsuario)
    {
        List<EProyectoCompleja> lstEProyectoCompleja = new List<EProyectoCompleja>();
        try
        {
            lstEProyectoCompleja = Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(codigoUsuario, true);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstEProyectoCompleja = Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(codigoUsuario, true);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return lstEProyectoCompleja;
    }
    public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(string codigoUsuario)
    {
        List<EProyectoCompleja> lstEProyectoCompleja = new List<EProyectoCompleja>();
        try
        {
            lstEProyectoCompleja = Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(codigoUsuario, false);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstEProyectoCompleja = Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(codigoUsuario, false);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return lstEProyectoCompleja;
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
                eGProyectoComplejo.ObjetivosEspecificosProyecto = eGProyecto.ObjetivosEspecificosProyecto;
                eGProyectoComplejo.AlcanceProyecto = eGProyecto.AlcanceProyecto;
                eGProyectoComplejo.EnlaceDocumentoProyecto = eGProyecto.EnlaceDocumentoProyecto;
                eGProyectoComplejo.NumeroRevisionesProyecto = eGProyecto.NumeroRevisiones;
                eGProyectoComplejo.EstadoProyecto = eGProyecto.EstadoProyecto;

                eGProyectoComplejo.CodigosEstudiantes = lstUsuariosPorProyecto.Where(w => w.CodigoRol == SDatos.ROL_ESTUDIANTE).Select(s => s.CodigoUsuario).ToList();
                foreach (string codigoEstudiante in eGProyectoComplejo.CodigosEstudiantes)
                {
                    eGProyectoComplejo.NombresEstudiantes.Add(aSNETGAAP.Obtener_GUsuario_O_CodigoUsuario(codigoEstudiante).NombreCompletoUsuario);
                }
                eGProyectoComplejo.CodigoTutor = lstUsuariosPorProyecto.Where(w => w.CodigoRol == SDatos.ROL_TUTOR).Select(s => s.CodigoUsuario).FirstOrDefault();
                eGProyectoComplejo.NombreTutor = aSNETGAAP.Obtener_GUsuario_O_CodigoUsuario(eGProyectoComplejo.CodigoTutor).NombreCompletoUsuario;
                //Si corresponde validar y no es valido, salta al siguiente y no se agrega a la lista
                if (conValidacionDeRevision && !esValido)
                    continue;

                lstEGProyectos.Add(eGProyectoComplejo);

            }
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
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
                    eGProyectoComplejo.ObjetivosEspecificosProyecto = eGProyecto.ObjetivosEspecificosProyecto;
                    eGProyectoComplejo.AlcanceProyecto = eGProyecto.AlcanceProyecto;
                    eGProyectoComplejo.EnlaceDocumentoProyecto = eGProyecto.EnlaceDocumentoProyecto;
                    eGProyectoComplejo.NumeroRevisionesProyecto = eGProyecto.NumeroRevisiones;
                    eGProyectoComplejo.EstadoProyecto = eGProyecto.EstadoProyecto;
                    eGProyectoComplejo.CodigosEstudiantes = lstUsuariosPorProyecto.Where(w => w.CodigoRol == SDatos.ROL_ESTUDIANTE).Select(s => s.CodigoUsuario).ToList();
                    foreach (string codigoEstudiante in eGProyectoComplejo.CodigosEstudiantes)
                    {
                        eGProyectoComplejo.NombresEstudiantes.Add(aSNETGAAP.Obtener_GUsuario_O_CodigoUsuario(codigoEstudiante).NombreCompletoUsuario);
                    }
                    eGProyectoComplejo.CodigoTutor = lstUsuariosPorProyecto.Where(w => w.CodigoRol == SDatos.ROL_TUTOR).Select(s => s.CodigoUsuario).FirstOrDefault();
                    eGProyectoComplejo.NombreTutor = aSNETGAAP.Obtener_GUsuario_O_CodigoUsuario(eGProyectoComplejo.CodigoTutor).NombreCompletoUsuario;
                    //Si corresponde validar y no es valido, salta al siguiente y no se agrega a la lista
                    if (conValidacionDeRevision && !esValido)
                        continue;

                    lstEGProyectos.Add(eGProyectoComplejo);
                }
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return lstEGProyectos;
    }


    public bool Verificar_GProyecto_CorrespondeRevision(string Rol, byte Etapa, byte SubEtapa)
    {
        bool res = false;
        try
        {
            switch (Rol)
            {
                case SDatos.ROL_ESTUDIANTE:
                    res = (SubEtapa == 1);
                    break;
                case SDatos.ROL_TUTOR:
                    res = (SubEtapa == 2);
                    break;
                case SDatos.ROL_DIRECTOR_CARRERA://El codigo continua hasta encontrar break
                case SDatos.ROL_AYUDANTE_DIRECTOR:
                    switch (Etapa)
                    {
                        case 1://Etapa 1
                            res = (SubEtapa == 4);
                            break;
                        default://Etapa 2,3,4                        
                            res = (SubEtapa == 3 || SubEtapa == 7);
                            break;
                    }
                    break;
                case SDatos.ROL_TRIBUNAL_1://El codigo continua hasta encontrar break
                case SDatos.ROL_TRIBUNAL_2:
                    res = (Etapa != 1 && SubEtapa == 4);
                    break;
                case SDatos.ROL_DAAP:
                    switch (Etapa)
                    {
                        case 1://Etapa 1
                            res = (SubEtapa == 3);
                            break;
                        default://Etapa 2,3,4  
                            res = (SubEtapa == 6);
                            break;
                    }
                    break;
            }
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Verificar_GProyecto_CorrespondeRevision", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                switch (Rol)
                {
                    case SDatos.ROL_ESTUDIANTE:
                        res = (SubEtapa == 1);
                        break;
                    case SDatos.ROL_TUTOR:
                        res = (SubEtapa == 2);
                        break;
                    case SDatos.ROL_DIRECTOR_CARRERA://El codigo continua hasta encontrar break
                    case SDatos.ROL_AYUDANTE_DIRECTOR:
                        switch (Etapa)
                        {
                            case 1://Etapa 1
                                res = (SubEtapa == 4);
                                break;
                            default://Etapa 2,3,4                        
                                res = (SubEtapa == 3 || SubEtapa == 7);
                                break;
                        }
                        break;
                    case SDatos.ROL_TRIBUNAL_1://El codigo continua hasta encontrar break
                    case SDatos.ROL_TRIBUNAL_2:
                        res = (Etapa != 1 && SubEtapa == 4);
                        break;
                    case SDatos.ROL_DAAP:
                        switch (Etapa)
                        {
                            case 1://Etapa 1
                                res = (SubEtapa == 3);
                                break;
                            default://Etapa 2,3,4  
                                res = (SubEtapa == 6);
                                break;
                        }
                        break;
                }
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Verificar_GProyecto_CorrespondeRevision", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return res;
    }
    #endregion
    #region Control de Etapas y SubEtapas
    public void Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(string codigoProyecto)
    {
        try
        {
            EGEtapa eGEtapa = aSNETGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto, SDatos.ESTADO_ACTIVO);
            EGSubEtapa eGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(eGEtapa.CodigoEtapa, SDatos.ESTADO_ACTIVO);
            switch (eGEtapa.NumeroEtapa)
            {
                case 1:
                    if (eGSubEtapa.NumeroSubEtapa == SDatos.N_SUB_ETAPAS_ETAPA_1)
                        Avanzar_Etapa(eGEtapa, eGSubEtapa);
                    else
                        Avanzar_SubEtapa(eGSubEtapa, eGEtapa.NumeroEtapa);
                    break;
                case 2:
                    if (eGSubEtapa.NumeroSubEtapa == SDatos.N_SUB_ETAPAS_ETAPA_2)
                        Avanzar_Etapa(eGEtapa, eGSubEtapa);
                    else
                        Avanzar_SubEtapa(eGSubEtapa, eGEtapa.NumeroEtapa);
                    break;
                case 3:
                    if (eGSubEtapa.NumeroSubEtapa == SDatos.N_SUB_ETAPAS_ETAPA_3)
                        Avanzar_Etapa(eGEtapa, eGSubEtapa);
                    else
                        Avanzar_SubEtapa(eGSubEtapa, eGEtapa.NumeroEtapa);
                    break;
                case 4:                                                             //Falta finalizar
                    if (eGSubEtapa.NumeroSubEtapa == SDatos.N_SUB_ETAPAS_ETAPA_4)
                        Avanzar_Etapa(eGEtapa, eGSubEtapa);
                    else
                        Avanzar_SubEtapa(eGSubEtapa, eGEtapa.NumeroEtapa);
                    break;
            }
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_Etapa_SubEtapa_AvanzarEnFlujo", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                EGEtapa eGEtapa = aSNETGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto, SDatos.ESTADO_ACTIVO);
                EGSubEtapa eGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(eGEtapa.CodigoEtapa, SDatos.ESTADO_ACTIVO);
                switch (eGEtapa.NumeroEtapa)
                {
                    case 1:
                        if (eGSubEtapa.NumeroSubEtapa == SDatos.N_SUB_ETAPAS_ETAPA_1)
                            Avanzar_Etapa(eGEtapa, eGSubEtapa);
                        else
                            Avanzar_SubEtapa(eGSubEtapa, eGEtapa.NumeroEtapa);
                        break;
                    case 2:
                        if (eGSubEtapa.NumeroSubEtapa == SDatos.N_SUB_ETAPAS_ETAPA_2)
                            Avanzar_Etapa(eGEtapa, eGSubEtapa);
                        else
                            Avanzar_SubEtapa(eGSubEtapa, eGEtapa.NumeroEtapa);
                        break;
                    case 3:
                        if (eGSubEtapa.NumeroSubEtapa == SDatos.N_SUB_ETAPAS_ETAPA_3)
                            Avanzar_Etapa(eGEtapa, eGSubEtapa);
                        else
                            Avanzar_SubEtapa(eGSubEtapa, eGEtapa.NumeroEtapa);
                        break;
                    case 4:                                                             //Falta finalizar
                        if (eGSubEtapa.NumeroSubEtapa == SDatos.N_SUB_ETAPAS_ETAPA_4)
                            Avanzar_Etapa(eGEtapa, eGSubEtapa);
                        else
                            Avanzar_SubEtapa(eGSubEtapa, eGEtapa.NumeroEtapa);
                        break;
                }
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Actualizar_Etapa_SubEtapa_AvanzarEnFlujo", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }
    public void Actualizar_Etapa_SubEtapa_SaltarASubEtapa(string codigoProyecto, byte numeroSubEtapaASaltar)
    {
        try
        {
            EGEtapa eGEtapa = aSNETGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto, SDatos.ESTADO_ACTIVO);

            if ((numeroSubEtapaASaltar < 1) || (eGEtapa.NumeroEtapa == 1 && numeroSubEtapaASaltar > 4) || (eGEtapa.NumeroEtapa != 1 && numeroSubEtapaASaltar > 7))
            {
                return;
            }
            EGSubEtapa eGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(eGEtapa.CodigoEtapa, SDatos.ESTADO_ACTIVO);
            if (string.IsNullOrEmpty(eGSubEtapa.Estado))//Estamos en Etapa 2,3,4 SubEtapa 3 
                eGEtapa = aSNETGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto, SDatos.ESTADO_SALTAR);
            EGSubEtapa eGSubEtapaASaltar = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(eGEtapa.CodigoEtapa, numeroSubEtapaASaltar);

            //Para no modificar el estado de esa subEtapa
            if (eGSubEtapa.EstadoSubEtapa != SDatos.ESTADO_SALTAR)
                aSNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(eGSubEtapa.CodigoSubEtapa, SDatos.ESTADO_PAUSADO);
            if (eGSubEtapaASaltar.EstadoSubEtapa != SDatos.ESTADO_SALTAR)
                aSNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(eGSubEtapaASaltar.CodigoSubEtapa, SDatos.ESTADO_ACTIVO);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_Etapa_SubEtapa_SaltarASubEtapa", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                EGEtapa eGEtapa = aSNETGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto, SDatos.ESTADO_ACTIVO);

                if ((eGEtapa.NumeroEtapa == 1 && numeroSubEtapaASaltar > 4) || (eGEtapa.NumeroEtapa != 1 && numeroSubEtapaASaltar > 7))
                {
                    return;
                }
                EGSubEtapa eGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(eGEtapa.CodigoEtapa, SDatos.ESTADO_ACTIVO);
                if (string.IsNullOrEmpty(eGSubEtapa.Estado))//Estamos en Etapa 2,3,4 SubEtapa 3 
                    eGEtapa = aSNETGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto, SDatos.ESTADO_SALTAR);
                EGSubEtapa eGSubEtapaASaltar = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(eGEtapa.CodigoEtapa, numeroSubEtapaASaltar);

                //Para no modificar el estado de esa subEtapa
                if (eGSubEtapa.EstadoSubEtapa != SDatos.ESTADO_SALTAR)
                    aSNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(eGSubEtapa.CodigoSubEtapa, SDatos.ESTADO_PAUSADO);
                if (eGSubEtapaASaltar.EstadoSubEtapa != SDatos.ESTADO_SALTAR)
                    aSNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(eGSubEtapaASaltar.CodigoSubEtapa, SDatos.ESTADO_ACTIVO);

            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Actualizar_Etapa_SubEtapa_SaltarASubEtapa", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }

    private void Avanzar_Etapa(EGEtapa eGEtapa, EGSubEtapa eGSubEtapa)
    {
        try
        {
            EGEtapa siguienteEGEtapa = Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(eGEtapa.CodigoProyecto, (byte)((int)eGEtapa.NumeroEtapa + 1));
            aSNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(eGSubEtapa.CodigoSubEtapa, SDatos.ESTADO_FINALIZADO);
            aSNETGAAP.Actualizar_GEtapa_A_EstadoEtapa(eGEtapa.CodigoEtapa, SDatos.ESTADO_FINALIZADO);
            aSNETGAAP.Actualizar_GEtapa_A_EstadoEtapa(siguienteEGEtapa.CodigoEtapa, SDatos.ESTADO_ACTIVO);
            EGSubEtapa siguienteEGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(siguienteEGEtapa.CodigoEtapa, (byte)1);
            aSNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(siguienteEGSubEtapa.CodigoSubEtapa, SDatos.ESTADO_ACTIVO);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Avanzar_Etapa", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                EGEtapa siguienteEGEtapa = Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(eGEtapa.CodigoProyecto, (byte)((int)eGEtapa.NumeroEtapa + 1));
                aSNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(eGSubEtapa.CodigoSubEtapa, SDatos.ESTADO_FINALIZADO);
                aSNETGAAP.Actualizar_GEtapa_A_EstadoEtapa(eGEtapa.CodigoEtapa, SDatos.ESTADO_FINALIZADO);
                aSNETGAAP.Actualizar_GEtapa_A_EstadoEtapa(siguienteEGEtapa.CodigoEtapa, SDatos.ESTADO_ACTIVO);
                EGSubEtapa siguienteEGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(siguienteEGEtapa.CodigoEtapa, (byte)1);
                aSNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(siguienteEGSubEtapa.CodigoSubEtapa, SDatos.ESTADO_ACTIVO);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Avanzar_Etapa", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }
    private void Avanzar_SubEtapa(EGSubEtapa eGSubEtapa, int numeroEtapa)
    {
        try
        {
            EGSubEtapa siguienteEGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(eGSubEtapa.CodigoEtapa, (byte)((int)eGSubEtapa.NumeroSubEtapa + 1));
            //Saltamos la etapa
            if (siguienteEGSubEtapa.EstadoSubEtapa == SDatos.ESTADO_SALTAR)
                siguienteEGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(eGSubEtapa.CodigoEtapa, (byte)((int)siguienteEGSubEtapa.NumeroSubEtapa + 1));

            //Etapa 2, SubEtapa 3 solo para una vez
            if (numeroEtapa == 2 && eGSubEtapa.NumeroSubEtapa == 3)
                aSNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(eGSubEtapa.CodigoSubEtapa, SDatos.ESTADO_SALTAR);
            else
                aSNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(eGSubEtapa.CodigoSubEtapa, SDatos.ESTADO_FINALIZADO);

            aSNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(siguienteEGSubEtapa.CodigoSubEtapa, SDatos.ESTADO_ACTIVO);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Avanzar_SubEtapa", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                EGSubEtapa siguienteEGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(eGSubEtapa.CodigoEtapa, (byte)((int)eGSubEtapa.NumeroSubEtapa + 1));
                //Saltamos la etapa
                if (siguienteEGSubEtapa.EstadoSubEtapa == SDatos.ESTADO_SALTAR)
                    siguienteEGSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(eGSubEtapa.CodigoEtapa, (byte)((int)siguienteEGSubEtapa.NumeroSubEtapa + 1));

                //Etapa 2, SubEtapa 3 solo para una vez
                if (numeroEtapa == 2 && eGSubEtapa.NumeroSubEtapa == 3)
                    aSNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(eGSubEtapa.CodigoSubEtapa, SDatos.ESTADO_SALTAR);
                else
                    aSNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(eGSubEtapa.CodigoSubEtapa, SDatos.ESTADO_FINALIZADO);

                aSNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(siguienteEGSubEtapa.CodigoSubEtapa, SDatos.ESTADO_ACTIVO);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Avanzar_SubEtapa", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
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
            //Conectar el estudiante al proyecto
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
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_ProyectoCompleto", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
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
                for (int indice = 1; indice <= 4; indice++) // 4 ETAPAS
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
                //Conectar el estudiante al proyecto
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
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Insertar_ProyectoCompleto", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }
    public void AgregarSubEtapas(int numeroEtapa, int codigoEtapa, DateTime fechaActual, int diasSubEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();

        int numeroSubEtapaMaximo = 0;

        try
        {
            switch (numeroEtapa)
            {
                case 1: numeroSubEtapaMaximo = SDatos.N_SUB_ETAPAS_ETAPA_1; break;
                case 2: numeroSubEtapaMaximo = SDatos.N_SUB_ETAPAS_ETAPA_2; break;
                case 3: numeroSubEtapaMaximo = SDatos.N_SUB_ETAPAS_ETAPA_3; break;
                case 4: numeroSubEtapaMaximo = SDatos.N_SUB_ETAPAS_ETAPA_4; break;
            }
            for (int indice = 1; indice <= numeroSubEtapaMaximo; indice++)
            {
                eGSubEtapa = new EGSubEtapa();
                eGSubEtapa.CodigoSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
                eGSubEtapa.CodigoEtapa = codigoEtapa;
                eGSubEtapa.NumeroSubEtapa = (byte)indice;
                eGSubEtapa.FechaInicioSubEtapa = fechaActual;
                eGSubEtapa.CodigoUsuarioFirma = SDatos.FIRMA_POR_DEFECTO;
                eGSubEtapa.FechaDefinidaSubEtapa = fechaActual.AddDays(diasSubEtapa);
                eGSubEtapa.FechaFinSubEtapa = fechaActual.AddDays(diasSubEtapa);

                switch (numeroEtapa)
                {
                    case 1:
                        eGSubEtapa.EstadoSubEtapa = (indice == 1) ? SDatos.ESTADO_ACTIVO : SDatos.ESTADO_PAUSADO;
                        break;
                    case 3:
                    case 4:
                        eGSubEtapa.EstadoSubEtapa = (indice == 3) ? SDatos.ESTADO_SALTAR : SDatos.ESTADO_PAUSADO;
                        break;
                    default:
                        eGSubEtapa.EstadoSubEtapa = SDatos.ESTADO_PAUSADO;
                        break;
                }

                aSNETGAAP.Insertar_GSubEtapa_I(eGSubEtapa);
            }
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "AgregarSubEtapas", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                switch (numeroEtapa)
                {
                    case 1: numeroSubEtapaMaximo = SDatos.N_SUB_ETAPAS_ETAPA_1; break;
                    case 2: numeroSubEtapaMaximo = SDatos.N_SUB_ETAPAS_ETAPA_2; break;
                    case 3: numeroSubEtapaMaximo = SDatos.N_SUB_ETAPAS_ETAPA_3; break;
                    case 4: numeroSubEtapaMaximo = SDatos.N_SUB_ETAPAS_ETAPA_4; break;
                }
                for (int indice = 1; indice <= numeroSubEtapaMaximo; indice++)
                {
                    eGSubEtapa = new EGSubEtapa();
                    eGSubEtapa.CodigoSubEtapa = aSNETGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
                    eGSubEtapa.CodigoEtapa = codigoEtapa;
                    eGSubEtapa.NumeroSubEtapa = (byte)indice;
                    eGSubEtapa.FechaInicioSubEtapa = fechaActual;
                    eGSubEtapa.CodigoUsuarioFirma = SDatos.FIRMA_POR_DEFECTO;
                    eGSubEtapa.FechaDefinidaSubEtapa = fechaActual.AddDays(diasSubEtapa);
                    eGSubEtapa.FechaFinSubEtapa = fechaActual.AddDays(diasSubEtapa);
                    switch (numeroEtapa)
                    {
                        case 1:
                            eGSubEtapa.EstadoSubEtapa = (indice == 1) ? SDatos.ESTADO_ACTIVO : SDatos.ESTADO_PAUSADO;
                            break;
                        case 3:
                        case 4:
                            eGSubEtapa.EstadoSubEtapa = (indice == 3) ? SDatos.ESTADO_SALTAR : SDatos.ESTADO_PAUSADO;
                            break;
                        default:
                            eGSubEtapa.EstadoSubEtapa = SDatos.ESTADO_PAUSADO;
                            break;
                    }

                    aSNETGAAP.Insertar_GSubEtapa_I(eGSubEtapa);
                }
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "AgregarSubEtapas", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }
    #endregion
    #endregion
}