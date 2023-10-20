using Microsoft.Practices.EnterpriseLibrary.Data;
using System;

/// <summary>
/// Descripción breve de SBaseDatos
/// </summary>
public static class SBaseDatos
{
    // Cadena de conexión para la base de datos NETGAAP
    public static Database BDNETGAAP = DatabaseFactory.CreateDatabase("BDGestionDeApoyoYAsesoriaAProyectosDeGradoCadenaConexion");

    // Cadena de conexión para la base de datos NETVALLE
    public static Database BDNETVALLE = DatabaseFactory.CreateDatabase("BDNetvalleCadenaConexion");
}