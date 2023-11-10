using SWADNETGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
    #region Metodos privados
    private EDefecto ContruirErrorServicio(TTipoDefecto tipoDefecto, string metodo, string excepcion, string mensaje)
    {
        EDefecto eDefecto = new EDefecto();
        eDefecto.TipoDefecto = tipoDefecto;
        eDefecto.Servicio = "SWLNGAAP";
        eDefecto.Clase = "ASNETGAAP";
        eDefecto.Metodo = metodo;
        eDefecto.Excepcion = excepcion;
        eDefecto.Mensaje = mensaje;
        return eDefecto;    }

    #endregion

    #region Métodos públicos
    #region GUsuarioRol
    public void Insertar_GUsuarioRol_I(EGUsuarioRol eGUsuarioRol)
    {
        try
        {
            clienteSWADNETGAAP.Insertar_GUsuarioRol_I(eGUsuarioRol);
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
                clienteSWADNETGAAP.Insertar_GUsuarioRol_I(eGUsuarioRol);
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
            ultimoCodigo = clienteSWADNETGAAP.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
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
                ultimoCodigo = clienteSWADNETGAAP.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
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
            lstEGUsuarioRol = clienteSWADNETGAAP.Obtener_GUsuarioRol_O_CodigoRol(codigoRol).ToList();
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
                lstEGUsuarioRol = clienteSWADNETGAAP.Obtener_GUsuarioRol_O_CodigoRol(codigoRol).ToList();
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
            lstEGUsuarioRol = clienteSWADNETGAAP.Obtener_GUsuarioRol_O_CodigoUsuario(codigoUsuario).ToList();
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
                lstEGUsuarioRol = clienteSWADNETGAAP.Obtener_GUsuarioRol_O_CodigoUsuario(codigoUsuario).ToList();
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
            eGUsuarioRol = clienteSWADNETGAAP.Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(codigoUsuario, codigoRol);
            
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
                eGUsuarioRol = clienteSWADNETGAAP.Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(codigoUsuario, codigoRol);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return eGUsuarioRol;
    }
    public void Actualizar_GUsuarioRol_A(EGUsuarioRol eGUsuarioRol)
    {
        try
        {
            clienteSWADNETGAAP.Actualizar_GUsuarioRol_A(eGUsuarioRol);

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
                clienteSWADNETGAAP.Actualizar_GUsuarioRol_A(eGUsuarioRol);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Actualizar_GUsuarioRol_A", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }
    public void Eliminar_GUsuarioRol_E(int codigoUsuarioRol)
    {
        try
        {
            clienteSWADNETGAAP.Eliminar_GUsuarioRol_E(codigoUsuarioRol);

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
                clienteSWADNETGAAP.Eliminar_GUsuarioRol_E(codigoUsuarioRol);
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
    public void Insertar_GUsuarioProyecto_I(EGUsuarioProyecto eGUsuarioProyecto)
    {
        try
        {
            clienteSWADNETGAAP.Insertar_GUsuarioProyecto_I(eGUsuarioProyecto);
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
                clienteSWADNETGAAP.Insertar_GUsuarioProyecto_I(eGUsuarioProyecto);
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
            ultimoCodigo = clienteSWADNETGAAP.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
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
                ultimoCodigo = clienteSWADNETGAAP.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
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
            lstEGUsuarioProyecto = clienteSWADNETGAAP.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto).ToList();
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
                lstEGUsuarioProyecto = clienteSWADNETGAAP.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto).ToList();
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
            lstEGUsuarioProyecto = clienteSWADNETGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario(codigoUsuario).ToList();
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
                lstEGUsuarioProyecto = clienteSWADNETGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario(codigoUsuario).ToList();
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
        EGUsuarioProyecto  eGUsuarioProyecto = new EGUsuarioProyecto();
        try
        {
            eGUsuarioProyecto = clienteSWADNETGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(codigoUsuario, codigoProyecto);
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
                eGUsuarioProyecto = clienteSWADNETGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(codigoUsuario, codigoProyecto);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return eGUsuarioProyecto;
    }
    public void Actualizar_GUsuarioProyecto_A(EGUsuarioProyecto eGProyectoUsuario)
    {
        try
        {
            clienteSWADNETGAAP.Actualizar_GUsuarioProyecto_A(eGProyectoUsuario);
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
                clienteSWADNETGAAP.Actualizar_GUsuarioProyecto_A(eGProyectoUsuario);
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
            clienteSWADNETGAAP.Eliminar_GUsuarioProyecto_E(codigoUsuarioProyecto);
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
                clienteSWADNETGAAP.Eliminar_GUsuarioProyecto_E(codigoUsuarioProyecto);
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
    public void Insertar_GProyecto_I(EGProyecto eGProyecto)
    {
        try
        {
            clienteSWADNETGAAP.Insertar_GProyecto_I(eGProyecto);
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
                clienteSWADNETGAAP.Insertar_GProyecto_I(eGProyecto);
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
            lstEGProyecto = clienteSWADNETGAAP.Obtener_GProyecto_O(fechaInicio, fechaFin).ToList();
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
                lstEGProyecto = clienteSWADNETGAAP.Obtener_GProyecto_O(fechaInicio, fechaFin).ToList();
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
            eGProyecto = clienteSWADNETGAAP.Obtener_GProyecto_O_CodigoProyecto(codigoProyecto);
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
                eGProyecto = clienteSWADNETGAAP.Obtener_GProyecto_O_CodigoProyecto(codigoProyecto);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GProyecto_O_CodigoProyecto", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return eGProyecto;
    }
    public void Actualizar_GProyecto_A(EGProyecto eGProyecto)
    {
        try
        {
            clienteSWADNETGAAP.Actualizar_GProyecto_A(eGProyecto);
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
                clienteSWADNETGAAP.Actualizar_GProyecto_A(eGProyecto);
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
    public void Insertar_GEtapa_I(EGEtapa eGEtapa)
    {
        try
        {
            clienteSWADNETGAAP.Insertar_GEtapa_I(eGEtapa);
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
                clienteSWADNETGAAP.Insertar_GEtapa_I(eGEtapa);
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
            lstEGEtapa = clienteSWADNETGAAP.Obtener_GEtapa_O_CodigoProyecto(codigoProyecto).ToList();
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
                lstEGEtapa = clienteSWADNETGAAP.Obtener_GEtapa_O_CodigoProyecto(codigoProyecto).ToList();
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
            ultimoCodigo = clienteSWADNETGAAP.Obtener_GEtapa_O_SiguienteCodigoEtapa();
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
                ultimoCodigo = clienteSWADNETGAAP.Obtener_GEtapa_O_SiguienteCodigoEtapa();
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
            eGEtapa = clienteSWADNETGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto, estadoEtapa);
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
                eGEtapa = clienteSWADNETGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto, estadoEtapa);
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
            eGEtapa = clienteSWADNETGAAP.Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(codigoProyecto, numeroSubEtapa);
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
                eGEtapa = clienteSWADNETGAAP.Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(codigoProyecto, numeroSubEtapa);
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
            clienteSWADNETGAAP.Actualizar_GEtapa_A_EstadoEtapa(codigoEtapa, estadoEtapa);
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
                clienteSWADNETGAAP.Actualizar_GEtapa_A_EstadoEtapa(codigoEtapa, estadoEtapa);
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
            clienteSWADNETGAAP.Insertar_GFormularioAceptacion_I(eGFormularioAceptacion);
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
                clienteSWADNETGAAP.Insertar_GFormularioAceptacion_I(eGFormularioAceptacion);
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
            lstFormularioAceptacion = clienteSWADNETGAAP.Obtener_GFormularioAceptacion_O_CodigoProyecto(codigoProyecto).ToList();
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
                lstFormularioAceptacion = clienteSWADNETGAAP.Obtener_GFormularioAceptacion_O_CodigoProyecto(codigoProyecto).ToList();
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
    public void Insertar_GSubEtapa_I(EGSubEtapa eGSubEtapa)
    {
        try
        {
            clienteSWADNETGAAP.Insertar_GSubEtapa_I(eGSubEtapa);
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
                clienteSWADNETGAAP.Insertar_GSubEtapa_I(eGSubEtapa);
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
            lstEGSubEtapa = clienteSWADNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa(codigoEtapa).ToList();
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
                lstEGSubEtapa = clienteSWADNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa(codigoEtapa).ToList();
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
            ultimoCodigo = clienteSWADNETGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
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
                ultimoCodigo = clienteSWADNETGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
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
            eGSubEtapa = clienteSWADNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(codigoEtapa, estadoSubEtapa);
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
                eGSubEtapa = clienteSWADNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(codigoEtapa, estadoSubEtapa);
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
            eGSubEtapa = clienteSWADNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(codigoEtapa, numeroSubEtapa);
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
                eGSubEtapa = clienteSWADNETGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(codigoEtapa, numeroSubEtapa);
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
            clienteSWADNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(codigoSubEtapa, estadoSubEtapa);
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
                clienteSWADNETGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(codigoSubEtapa, estadoSubEtapa);
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
    public void Insertar_GObservacion_I(EGObservacion eGObservacion)
    {
        try
        {
            clienteSWADNETGAAP.Insertar_GObservacion_I(eGObservacion);
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
                clienteSWADNETGAAP.Insertar_GObservacion_I(eGObservacion);
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
            lstObservacion = clienteSWADNETGAAP.Obtener_GObservacion_O_CodigoProyecto(codigoProyecto).ToList();
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
                lstObservacion = clienteSWADNETGAAP.Obtener_GObservacion_O_CodigoProyecto(codigoProyecto).ToList();
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
            eGObservacion = clienteSWADNETGAAP.Obtener_GObservacion_O_CodigoObservacion(codigoObservacion);
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
                eGObservacion = clienteSWADNETGAAP.Obtener_GObservacion_O_CodigoObservacion(codigoObservacion);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GObservacion_O_CodigoObservacion", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return eGObservacion;
    }
    public void Actualizar_GObservacion_A(EGObservacion eGObservacion)
    {
        try
        {
            clienteSWADNETGAAP.Actualizar_GObservacion_A(eGObservacion);
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
                clienteSWADNETGAAP.Actualizar_GObservacion_A(eGObservacion);
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
            clienteSWADNETGAAP.Actualizar_GObservacion_A_EstadoObservacion(codigoObservacion, estadoObservacion);
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
                clienteSWADNETGAAP.Actualizar_GObservacion_A_EstadoObservacion(codigoObservacion, estadoObservacion);
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
            ultimoCodigo = clienteSWADNETGAAP.Obtener_GObsevacion_O_SiguienteCodigoObservacion();
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
                ultimoCodigo = clienteSWADNETGAAP.Obtener_GObsevacion_O_SiguienteCodigoObservacion();
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
    public void Insertar_GUsuario_I(EGUsuario eGUsuario)
    {
        try
        {
            clienteSWADNETGAAP.Insertar_GUsuario_I(eGUsuario);
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
                clienteSWADNETGAAP.Insertar_GUsuario_I(eGUsuario);
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
            eGUsuario = clienteSWADNETGAAP.Obtener_GUsuario_O_CodigoUsuario(codigoUsuario);
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
                eGUsuario = clienteSWADNETGAAP.Obtener_GUsuario_O_CodigoUsuario(codigoUsuario);
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
            eGUsuario = clienteSWADNETGAAP.Obtener_GUsuario_O_NombreCompletoUsuario(nombreCompletoUsuario);
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
                eGUsuario = clienteSWADNETGAAP.Obtener_GUsuario_O_NombreCompletoUsuario(nombreCompletoUsuario);
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
            lstEGUsuario = clienteSWADNETGAAP.Buscar_GUsuario_B_NombreCompletoUsuario(nombreCompletoUsuario).ToList();
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
                lstEGUsuario = clienteSWADNETGAAP.Buscar_GUsuario_B_NombreCompletoUsuario(nombreCompletoUsuario).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Buscar_GUsuario_B_NombreCompletoUsuario", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return lstEGUsuario;
    }
    public void Actualizar_GUsuario_A(EGUsuario eGUsuario)
    {
        try
        {
            clienteSWADNETGAAP.Actualizar_GUsuario_A(eGUsuario);
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
                clienteSWADNETGAAP.Actualizar_GUsuario_A(eGUsuario);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Actualizar_GUsuario_A", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }
    #endregion
    #region GRol
    public List<EGRol> Obtener_GRol_O()
    {
        List<EGRol> lstEGRol = new List<EGRol>();
        try
        {
            lstEGRol = clienteSWADNETGAAP.Obtener_GRol_O().ToList();
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
                lstEGRol = clienteSWADNETGAAP.Obtener_GRol_O().ToList();
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
            eGRol = clienteSWADNETGAAP.Obtener_GRol_O_CodigoRol(codigoRol);
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
                eGRol = clienteSWADNETGAAP.Obtener_GRol_O_CodigoRol(codigoRol);
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
            eUsuarioNetvalle = clienteSWADNETGAAP.Obtener_UsuarioNetvalle_O_CodigoUsuario(codigoUsuario);
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
                eUsuarioNetvalle = clienteSWADNETGAAP.Obtener_UsuarioNetvalle_O_CodigoUsuario(codigoUsuario);
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
    #region Tabla: GCelular
    public int Obtener_GCelular_O_SiguienteCodigoCelular()
    {
        int ultimoCodigo = 0;
        try
        {
            ultimoCodigo = clienteSWADNETGAAP.Obtener_GCelular_O_SiguienteCodigoCelular();
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
                ultimoCodigo = clienteSWADNETGAAP.Obtener_GCelular_O_SiguienteCodigoCelular();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GCelular_O_SiguienteCodigoCelular", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return ultimoCodigo;
    }
    public void Insertar_GCelular_I(EGCelular eGCelular)
    {
        try
        {
            clienteSWADNETGAAP.Insertar_GCelular_I(eGCelular);
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
                clienteSWADNETGAAP.Insertar_GCelular_I(eGCelular);
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
            eGCelular = clienteSWADNETGAAP.Obtener_GCelular_O_CodigoUsuario(codigoUsuario);
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
                eGCelular = clienteSWADNETGAAP.Obtener_GCelular_O_CodigoUsuario(codigoUsuario);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GCelular_O_CodigoUsuario", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return eGCelular;
    }
    public void Actualizar_GCelular_A(EGCelular eGCelular)
    {
        try
        {
            clienteSWADNETGAAP.Actualizar_GCelular_A(eGCelular);
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
                clienteSWADNETGAAP.Actualizar_GCelular_A(eGCelular);
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
            clienteSWADNETGAAP.Eliminar_GCelular_E(codigoCelular);
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
                clienteSWADNETGAAP.Eliminar_GCelular_E(codigoCelular);
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
    public void Insertar_GTutorExterno_I(EGTutorExterno eGTutorExterno)
    {
        try
        {
            clienteSWADNETGAAP.Insertar_GTutorExterno_I(eGTutorExterno);
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
                clienteSWADNETGAAP.Insertar_GTutorExterno_I(eGTutorExterno);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Insertar_GTutorExterno_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }

    public List<EGTutorExterno> Obtener_GTutorExterno_O()
    {
        List<EGTutorExterno> lstEGTutorExterno = new List<EGTutorExterno>();
        try
        {
            lstEGTutorExterno = clienteSWADNETGAAP.Obtener_GTutorExterno_O().ToList();
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
                lstEGTutorExterno = clienteSWADNETGAAP.Obtener_GTutorExterno_O().ToList();
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
            eGTutorExterno = clienteSWADNETGAAP.Obtener_GTutorExterno_O_CodigoTutorExterno(codigoTutorExterno);
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
                eGTutorExterno = clienteSWADNETGAAP.Obtener_GTutorExterno_O_CodigoTutorExterno(codigoTutorExterno);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Obtener_GTutorExterno_O_CodigoTutorExterno", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        return eGTutorExterno;
    }

    public void Actualizar_GTutorExterno_A(EGTutorExterno eGTutorExterno)
    {
        try
        {
            clienteSWADNETGAAP.Actualizar_GTutorExterno_A(eGTutorExterno);
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
                clienteSWADNETGAAP.Actualizar_GTutorExterno_A(eGTutorExterno);
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
            clienteSWADNETGAAP.Eliminar_GTutorExterno_E(codigoTutorExterno);
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
                clienteSWADNETGAAP.Eliminar_GTutorExterno_E(codigoTutorExterno);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Comunicacion, "Eliminar_GTutorExterno_E", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
    }
    #endregion
    #endregion
}