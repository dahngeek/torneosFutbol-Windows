using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using P_4m2.Entidades;

namespace P_4m2.Controladores
{
    class pPosicion
    {
        public static void Save(Posicion p)
        {

            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Posicion (nombre) VALUES (@nombre);");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@nombre", p.Nombre));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static List<Posicion> GetAll()
        {
            List<Posicion> posiciones = new List<Posicion>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre From Posicion;");
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Posicion p = new Posicion();
                p.Id = obdr.GetInt32(0);
                p.Nombre = obdr.GetString(1);
                posiciones.Add(p);
            }
            return posiciones;
        }

        public static Posicion GetById(int id)
        {
            Posicion p = new Posicion();

            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre From Posicion WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader6
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                p.Id = obdr.GetInt32(0);
                p.Nombre = obdr.GetString(1);
            }
            return p;
        }

        public static List<Posicion> GetByNombre(string nombre)
        {
            List<Posicion> posiciones = new List<Posicion>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre From Posicion WHERE nombre like @nombre;");

            cmd.Parameters.Add(new SQLiteParameter("@nombre", nombre));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Posicion p = new Posicion();
                p.Id = obdr.GetInt32(0);
                p.Nombre = obdr.GetString(1);
                posiciones.Add(p);
            }
            return posiciones;
        }

        public static void Delete(Posicion p)
        {
            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Posicion WHERE id = @id;");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@id", p.Id));

            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }


        public static void Update(Posicion p)
        {
            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Posicion SET nombre = @nombre WHERE id = @id;");

            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@id", p.Id));
            cmd.Parameters.Add(new SQLiteParameter("@nombre", p.Nombre));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

    }
}
