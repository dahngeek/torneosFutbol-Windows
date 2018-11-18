using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using TP4_TORNEOS.Entidades;


namespace TP4_TORNEOS.Controladores
{
    class pJugador
    {
        public static void Save(Jugador j)
        {

            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Jugador (nombre, apellido, apodo, NumeroCamiseta, idEquipo, idPosicion, urlImagen) VALUES ( @nombre, @apellido, @apodo, @NumeroCamiseta, @idEquipo, @idPosicion, @urlImagen);");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@nombre", j.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@apellido", j.Apellido));
            cmd.Parameters.Add(new SQLiteParameter("@apodo", j.Apodo));
            cmd.Parameters.Add(new SQLiteParameter("@NumeroCamiseta", j.NumeroCamiseta));
            cmd.Parameters.Add(new SQLiteParameter("@idEquipo", j.Equipo.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idPosicion", j.Posicion.Id));
            cmd.Parameters.Add(new SQLiteParameter("@urlImagen", j.UrlImagen));


            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static List<Jugador> GetAll()
        {
            List<Jugador> jugadores = new List<Jugador>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre, apellido, apodo, NumeroCamiseta, idEquipo, idPosicion, urlImagen From Jugador;");
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Jugador j = new Jugador();
                j.Id = obdr.GetInt32(0);
                j.Nombre = obdr.GetString(1);
                j.Apellido = obdr.GetString(2);
                j.Apodo = obdr.GetString(3);
                j.NumeroCamiseta = obdr.GetInt32(4);
                j.Equipo = pEquipo.GetById(obdr.GetInt32(5));
                j.Posicion = pPosicion.GetById(obdr.GetInt32(6));
                j.UrlImagen = obdr.GetString(7);
                jugadores.Add(j);
            }
            return jugadores;
        }

        public static Jugador GetById(int id)
        {
            Jugador j = new Jugador();

            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre, apellido, apodo, NumeroCamiseta, idEquipo, idPosicion, urlImagen From Jugador WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader6
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                j.Id = obdr.GetInt32(0);
                j.Nombre = obdr.GetString(1);
                j.Apellido = obdr.GetString(2);
                j.Apodo = obdr.GetString(3);
                j.NumeroCamiseta = obdr.GetInt32(4);
                j.Equipo = pEquipo.GetById(obdr.GetInt32(5));
                j.Posicion = pPosicion.GetById(obdr.GetInt32(6));
                j.UrlImagen = obdr.GetString(7);
            }
            return j;
        }

        public static List<Jugador> GetByNombre(string nombre)
        {
            List<Jugador> jugadores = new List<Jugador>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre, apellido, apodo, NumeroCamiseta, idEquipo, idPosicion, urlImagen From Jugador WHERE nombre like @nombre;");

            cmd.Parameters.Add(new SQLiteParameter("@nombre", nombre));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Jugador j = new Jugador();
                j.Id = obdr.GetInt32(0);
                j.Nombre = obdr.GetString(1);
                j.Apellido = obdr.GetString(2);
                j.Apodo = obdr.GetString(3);
                j.NumeroCamiseta = obdr.GetInt32(4);
                j.Equipo = pEquipo.GetById(obdr.GetInt32(5));
                j.Posicion = pPosicion.GetById(obdr.GetInt32(6));
                j.UrlImagen = obdr.GetString(7);
                jugadores.Add(j);
            }
            return jugadores;
        }

        public static List<Jugador> GetByApellido(string ap)
        {
            List<Jugador> jugadores = new List<Jugador>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre, apellido, apodo, NumeroCamiseta, idEquipo, idPosicion, urlImagen From Jugador WHERE apellido like @ap;");

            cmd.Parameters.Add(new SQLiteParameter("@ap", ap));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Jugador j = new Jugador();
                j.Id = obdr.GetInt32(0);
                j.Nombre = obdr.GetString(1);
                j.Apellido = obdr.GetString(2);
                j.Apodo = obdr.GetString(3);
                j.NumeroCamiseta = obdr.GetInt32(4);
                j.Equipo = pEquipo.GetById(obdr.GetInt32(5));
                j.Posicion = pPosicion.GetById(obdr.GetInt32(6));
                j.UrlImagen = obdr.GetString(7);
                jugadores.Add(j);
            }
            return jugadores;
        }

        public static List<Jugador> GetByApodo(string apo)
        {
            List<Jugador> jugadores = new List<Jugador>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre, apellido, apodo, NumeroCamiseta, idEquipo, idPosicion, urlImagen From Jugador WHERE apodo like @apo;");

            cmd.Parameters.Add(new SQLiteParameter("@apo", apo));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Jugador j = new Jugador();
                j.Id = obdr.GetInt32(0);
                j.Nombre = obdr.GetString(1);
                j.Apellido = obdr.GetString(2);
                j.Apodo = obdr.GetString(3);
                j.NumeroCamiseta = obdr.GetInt32(4);
                j.Equipo = pEquipo.GetById(obdr.GetInt32(5));
                j.Posicion = pPosicion.GetById(obdr.GetInt32(6));
                j.UrlImagen = obdr.GetString(7);
                jugadores.Add(j);
            }
            return jugadores;
        }


        public static List<Jugador> GetByCamiseta(int NumeroCamiseta)
        {
            List<Jugador> jugadores = new List<Jugador>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre, apellido, apodo, NumeroCamiseta, idEquipo, idPosicion, urlImagen From Jugador WHERE NumeroCamiseta = @NumeroCamiseta;");

            cmd.Parameters.Add(new SQLiteParameter("@NumeroCamiseta", NumeroCamiseta));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Jugador j = new Jugador();
                j.Id = obdr.GetInt32(0);
                j.Nombre = obdr.GetString(1);
                j.Apellido = obdr.GetString(2);
                j.Apodo = obdr.GetString(3);
                j.NumeroCamiseta = obdr.GetInt32(4);
                j.Equipo = pEquipo.GetById(obdr.GetInt32(5));
                j.Posicion = pPosicion.GetById(obdr.GetInt32(6));
                j.UrlImagen = obdr.GetString(7);
                jugadores.Add(j);
            }
            return jugadores;
        }

        public static List<Jugador> GetByEquipo(int idEquipo)
        {
            List<Jugador> jugadores = new List<Jugador>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre, apellido, apodo, NumeroCamiseta, idEquipo, idPosicion, urlImagen From Jugador WHERE idEquipo = @idEquipo;");

            cmd.Parameters.Add(new SQLiteParameter("@idEquipo", idEquipo));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Jugador j = new Jugador();
                j.Id = obdr.GetInt32(0);
                j.Nombre = obdr.GetString(1);
                j.Apellido = obdr.GetString(2);
                j.Apodo = obdr.GetString(3);
                j.NumeroCamiseta = obdr.GetInt32(4);
                j.Equipo = pEquipo.GetById(obdr.GetInt32(5));
                j.Posicion = pPosicion.GetById(obdr.GetInt32(6));
                j.UrlImagen = obdr.GetString(7);
                jugadores.Add(j);
            }
            return jugadores;
        }

        public static List<Jugador> GetByPosicion(int idPosicion)
        {
            List<Jugador> jugadores = new List<Jugador>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre, apellido, apodo, NumeroCamiseta, idEquipo, idPosicion, urlImagen From Jugador WHERE idPosicion = @idPosicion;");

            cmd.Parameters.Add(new SQLiteParameter("@idPosicion", idPosicion));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Jugador j = new Jugador();
                j.Id = obdr.GetInt32(0);
                j.Nombre = obdr.GetString(1);
                j.Apellido = obdr.GetString(2);
                j.Apodo = obdr.GetString(3);
                j.NumeroCamiseta = obdr.GetInt32(4);
                j.Equipo = pEquipo.GetById(obdr.GetInt32(5));
                j.Posicion = pPosicion.GetById(obdr.GetInt32(6));
                j.UrlImagen = obdr.GetString(7);
                jugadores.Add(j);
            }
            return jugadores;
        }

        public static void Delete(Jugador j)
        {
            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Jugador WHERE id = @id;");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@id", j.Id));

            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }


        public static void Update(Jugador j)
        {
            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Jugador SET nombre = @nombre, apellido = @apellido, apodo = @apodo, NumeroCamiseta = @NumeroCamiseta, idEquipo = @idEquipo, idPosicion = @idPosicion, urlImagen = @urlImagen WHERE id = @id;");

            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@id", j.Id));
            cmd.Parameters.Add(new SQLiteParameter("@nombre", j.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@apellido", j.Apellido));
            cmd.Parameters.Add(new SQLiteParameter("@apodo", j.Apodo));
            cmd.Parameters.Add(new SQLiteParameter("@NumeroCamiseta", j.NumeroCamiseta));
            cmd.Parameters.Add(new SQLiteParameter("@idEquipo", j.Equipo.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idPosicion", j.Posicion.Id));
            cmd.Parameters.Add(new SQLiteParameter("@urlImagen", j.UrlImagen));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }



    }
}
