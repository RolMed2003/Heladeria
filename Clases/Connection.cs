using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HeladeriaLosEspaciales1._0.Clases
{
    internal class Connection
    {

        static string servidor = "mssql-80110-0.cloudclusters.net";
        static string bd = "Heladeria";
        static string usuario = "admin";
        static string password = "R1812l0309";
        static string puerto = "12438";

        static string url = "Data Source=" + servidor + "," + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "Initial " +
            "Catalog=" + bd + ";" + "Persist Security Info=true";

        public static SqlConnection connect()
        {

            try
            {

                SqlConnection conex = new SqlConnection(url);
                conex.Open();

                return conex;

            }
            catch (SqlException e)
            {

                //Void.

            }

            return null;

        }

    }
}
