using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using TP4_TORNEOS.Entidades;


namespace TP4_TORNEOS.Controladores
{
    class pConfiguracion
    {
        public static void Save(Configuracion c)
        {

            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Configuracion (nombre) VALUES (@nombre);");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@nombre", c.Nombre));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static List<Configuracion> GetAll()
        {
            List<Configuracion> configuraciones = new List<Configuracion>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre From Configuracion;");
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Configuracion c = new Configuracion();
                c.Id = obdr.GetInt32(0);
                c.Nombre = obdr.GetString(1);
                configuraciones.Add(c);
            }
            return configuraciones;
        }

        public static Configuracion GetById(int id)
        {
            Configuracion c = new Configuracion();

            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre From Configuracion WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader6
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                c.Id = obdr.GetInt32(0);
                c.Nombre = obdr.GetString(1);
            }
            return c;
        }

        public static List<Configuracion> GetByNombre(string nombre)
        {
            List<Configuracion> configuraciones = new List<Configuracion>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre From Configuracion WHERE nombre like @nombre;");

            cmd.Parameters.Add(new SQLiteParameter("@nombre", nombre));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Configuracion c = new Configuracion();
                c.Id = obdr.GetInt32(0);
                c.Nombre = obdr.GetString(1);
                configuraciones.Add(c);
            }
            return configuraciones;
        }

        public static void Delete(Configuracion c)
        {
            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Configuracion WHERE id = @id;");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@id", c.Id));

            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }


        public static void Update(Configuracion c)
        {
            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Configuracion SET nombre = @nombre WHERE id = @id;");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@id", c.Id));
            cmd.Parameters.Add(new SQLiteParameter("@nombre", c.Nombre));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }



    }
}
