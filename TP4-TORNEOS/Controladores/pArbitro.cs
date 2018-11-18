using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using P_4m2.Entidades;

namespace P_4m2.Controladores
{
    class pArbitro
    {
        public static void Save(Arbitro a)
        {

            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Arbitro (nombre, apellido) VALUES ( @nombre, @apellido);");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@nombre", a.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@apellido", a.Apellido));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static List<Arbitro> GetAll()
        {
            List<Arbitro> arbitros = new List<Arbitro>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre, apellido From Arbitro;");
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Arbitro a = new Arbitro();
                a.Id = obdr.GetInt32(0);
                a.Nombre = obdr.GetString(1);
                a.Apellido = obdr.GetString(2);
                arbitros.Add(a);
            }
            return arbitros;
        }

        public static Arbitro GetById(int id)
        {
            Arbitro a = new Arbitro();

            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre, apellido From Arbitro WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader6
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                a.Id = obdr.GetInt32(0);
                a.Nombre = obdr.GetString(1);
                a.Apellido = obdr.GetString(2);
            }
            return a;
        }

        public static List<Arbitro> GetByNombre(string nombre)
        {
            List<Arbitro> arbitros = new List<Arbitro>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre, apellido From Arbitro WHERE nombre like @nombre;");

            cmd.Parameters.Add(new SQLiteParameter("@nombre", nombre));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Arbitro a = new Arbitro();
                a.Id = obdr.GetInt32(0);
                a.Nombre = obdr.GetString(1);
                a.Apellido = obdr.GetString(2);
                arbitros.Add(a);
            }
            return arbitros;
        }

        public static List<Arbitro> GetByApellido(string ap)
        {
            List<Arbitro> arbitros = new List<Arbitro>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre, apellido From Arbitro WHERE apellido like @ap;");

            cmd.Parameters.Add(new SQLiteParameter("@ap", ap));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Arbitro a = new Arbitro();
                a.Id = obdr.GetInt32(0);
                a.Nombre = obdr.GetString(1);
                a.Apellido = obdr.GetString(2);
                arbitros.Add(a);
            }
            return arbitros;
        }

        public static void Delete(Arbitro a)
        {
            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Arbitro WHERE id = @id;");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@id", a.Id));

            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }


        public static void Update(Arbitro a)
        {
            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Arbitro SET nombre = @nombre, apellido = @apellido WHERE id = @id;");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@id", a.Id));
            cmd.Parameters.Add(new SQLiteParameter("@nombre", a.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@apellido", a.Apellido));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }




    }
}
