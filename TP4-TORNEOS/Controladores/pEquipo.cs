using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using P_4m2.Entidades;

namespace P_4m2.Controladores
{
    class pEquipo
    {
        public static void Save(Equipo e)
        {

            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Equipo (nombre, puntos, golesFavor, golesContra, idConfiguracion) VALUES ( @nombre, @puntos, @golesFavor, @golesContra, @idConfiguracion );");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@nombre", e.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@puntos", e.Puntos));
            cmd.Parameters.Add(new SQLiteParameter("@golesFavor", e.GolesFavor));
            cmd.Parameters.Add(new SQLiteParameter("@golesContra", e.GolesContra));
            cmd.Parameters.Add(new SQLiteParameter("@idConfiguracion", e.Configuracion.Id));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static List<Equipo> GetAll()
        {
            List<Equipo> equipos = new List<Equipo>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre, puntos, golesFavor, golesContra, idConfiguracion From Equipo;");
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Equipo e = new Equipo();
                e.Id = obdr.GetInt32(0);
                e.Nombre = obdr.GetString(1);
                e.Puntos = obdr.GetInt32(2);
                e.GolesFavor = obdr.GetInt32(3);
                e.GolesContra = obdr.GetInt32(4);
                e.Configuracion = pConfiguracion.GetById(obdr.GetInt32(5));
                equipos.Add(e);
            }
            return equipos;
        }

        public static Equipo GetById(int id)
        {
            Equipo e = new Equipo();

            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre, puntos, golesFavor, golesContra, idConfiguracion From Equipo WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader6
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                e.Id = obdr.GetInt32(0);
                e.Nombre = obdr.GetString(1);
                e.Puntos = obdr.GetInt32(2);
                e.GolesFavor = obdr.GetInt32(3);
                e.GolesContra = obdr.GetInt32(4);
                e.Configuracion = pConfiguracion.GetById(obdr.GetInt32(5));
            }
            return e;
        }

        public static List<Equipo> GetByNombre(string nombre)
        {
            List<Equipo> equipos = new List<Equipo>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre, puntos, golesFavor, golesContra, idConfiguracion From Equipo WHERE nombre like @nombre;");

            cmd.Parameters.Add(new SQLiteParameter("@nombre", nombre));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Equipo e = new Equipo();
                e.Id = obdr.GetInt32(0);
                e.Nombre = obdr.GetString(1);
                e.Puntos = obdr.GetInt32(2);
                e.GolesFavor = obdr.GetInt32(3);
                e.GolesContra = obdr.GetInt32(4);
                e.Configuracion = pConfiguracion.GetById(obdr.GetInt32(5));
                equipos.Add(e);
            }
            return equipos;
        }

        public static void Delete(Equipo e)
        {
            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Equipo WHERE id = @id;");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@id", e.Id));

            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }


        public static void Update(Equipo e)
        {
            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Equipo SET nombre = @nombre, puntos = @puntos, golesFavor = @golesFavor, golesContra = @golesContra, idConfiguracion = @idConfiguracion WHERE id = @id;");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@id", e.Id));
            cmd.Parameters.Add(new SQLiteParameter("@nombre", e.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@puntos", e.Puntos));
            cmd.Parameters.Add(new SQLiteParameter("@golesFavor", e.GolesFavor));
            cmd.Parameters.Add(new SQLiteParameter("@golesContra", e.GolesContra));
            cmd.Parameters.Add(new SQLiteParameter("@idConfiguracion", e.Configuracion.Id));

            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }



    }
}
