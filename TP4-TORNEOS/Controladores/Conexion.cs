using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace P_4m2.Controladores
{
    class Conexion
    {
        public static string cadena = "Data Source=../../db/P_4copia.s3db;";
        private static SQLiteConnection connection = new SQLiteConnection(cadena);


        public static void OpenConexion()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public static void CloseConexion()
        {
            connection.Close();
        }



        public static SQLiteConnection Connection
        {
            set { connection = value; }
            get { return connection; }
        }

    }
}
