using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using TP4_TORNEOS.Entidades;

namespace TP4_TORNEOS.Controladores
{
    class pDirectorTecnico
    {
        public static void Save(DirectorTecnico dt)
        {

            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO DirectorTecnico (nombre, apellido, idEquipo) VALUES ( @nombre, @apellido, @idEquipo);");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@nombre", dt.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@apellido", dt.Apellido));
            cmd.Parameters.Add(new SQLiteParameter("@idEquipo", dt.Equipo.Id));


            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static List<DirectorTecnico> GetAll()
        {
            List<DirectorTecnico> directoresTecnicos = new List<DirectorTecnico>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre, apellido, idEquipo From DirectorTecnico;");
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                DirectorTecnico dt = new DirectorTecnico();
                dt.Id = obdr.GetInt32(0);
                dt.Nombre = obdr.GetString(1);
                dt.Apellido = obdr.GetString(2);
                dt.Equipo = pEquipo.GetById(obdr.GetInt32(3));
                directoresTecnicos.Add(dt);
            }
            return directoresTecnicos;
        }

        public static DirectorTecnico GetById(int id)
        {
            DirectorTecnico dt = new DirectorTecnico();

            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre, apellido, idEquipo From DirectorTecnico WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader6
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                dt.Id = obdr.GetInt32(0);
                dt.Nombre = obdr.GetString(1);
                dt.Apellido = obdr.GetString(2);
                dt.Equipo = pEquipo.GetById(obdr.GetInt32(3));

            }
            return dt;
        }

        public static List<DirectorTecnico> GetByNombre(string nombre)
        {
            List<DirectorTecnico> directoresTecnicos = new List<DirectorTecnico>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre, apellido, idEquipo From DirectorTecnico WHERE nombre like @nombre;");

            cmd.Parameters.Add(new SQLiteParameter("@nombre", nombre));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                DirectorTecnico dt = new DirectorTecnico();
                dt.Id = obdr.GetInt32(0);
                dt.Nombre = obdr.GetString(1);
                dt.Apellido = obdr.GetString(2);
                dt.Equipo = pEquipo.GetById(obdr.GetInt32(3));
                directoresTecnicos.Add(dt);
            }
            return directoresTecnicos;
        }

        public static List<DirectorTecnico> GetByApellido(string ap)
        {
            List<DirectorTecnico> directoresTecnicos = new List<DirectorTecnico>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre, apellido, idEquipo From DirectorTecnico WHERE apellido like @ap;");

            cmd.Parameters.Add(new SQLiteParameter("@ap", ap));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                DirectorTecnico dt = new DirectorTecnico();
                dt.Id = obdr.GetInt32(0);
                dt.Nombre = obdr.GetString(1);
                dt.Apellido = obdr.GetString(2);
                dt.Equipo = pEquipo.GetById(obdr.GetInt32(3));
                directoresTecnicos.Add(dt);
            }
            return directoresTecnicos;
        }

        public static void Delete(DirectorTecnico a)
        {
            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM DirectorTecnico WHERE id = @id;");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@id", a.Id));

            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }


        public static void Update(DirectorTecnico dt)
        {
            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("UPDATE DirectorTecnico SET nombre = @nombre, apellido = @apellido, idEquipo = @idEquipo WHERE id = @id;");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@id", dt.Id));
            cmd.Parameters.Add(new SQLiteParameter("@nombre", dt.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@apellido", dt.Apellido));
            cmd.Parameters.Add(new SQLiteParameter("@idEquipo", dt.Equipo.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }
    }
}
