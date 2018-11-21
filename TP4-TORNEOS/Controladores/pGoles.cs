using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using TP4_TORNEOS.Entidades;

namespace TP4_TORNEOS.Controladores
{
    class pGoles
    {
        public static void Save(Goles g)
        {

            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Goles (idJugador, idEncuentro, idEquipo, minuto) VALUES (@idJugador, @idEncuentro, @idEquipo, @minuto);");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@idJugador", g.Jugador.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idEncuentro", g.Encuentro.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idEquipo", g.Equipo.Id));
            cmd.Parameters.Add(new SQLiteParameter("@minuto", g.Minuto));


            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static List<Goles> GetAll()
        {
            List<Goles> goless = new List<Goles>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, idJugador, idEncuentro, idEquipo, minuto From Goles;");
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Goles g = new Goles();
                g.Id = obdr.GetInt32(0);
                g.Jugador = pJugador.GetById(obdr.GetInt32(1));
                g.Encuentro = pEncuentro.GetById(obdr.GetInt32(2));
                g.Equipo = pEquipo.GetById(obdr.GetInt32(3));
                g.Minuto = obdr.GetInt32(4);
                goless.Add(g);
            }
            return goless;
        }

        public static Goles GetById(int id)
        {
            Goles g = new Goles();

            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, idJugador, idEncuentro, idEquipo, minuto From Goles WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader6
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareèdxader

            while (obdr.Read())
            {
                g.Id = obdr.GetInt32(0);
                g.Jugador = pJugador.GetById(obdr.GetInt32(1));
                g.Encuentro = pEncuentro.GetById(obdr.GetInt32(2));
                g.Equipo = pEquipo.GetById(obdr.GetInt32(3));
                g.Minuto = obdr.GetInt32(4);

            }
            return g;
        }

        public static List<Goles> GetByJugador(int idJugador)
        {
            List<Goles> goless = new List<Goles>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, idJugador, idEncuentro, idEquipo, minuto From Goles WHERE idJugador = @idJugador;");

            cmd.Parameters.Add(new SQLiteParameter("@idJugador", idJugador));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Goles g = new Goles();
                g.Id = obdr.GetInt32(0);
                g.Jugador = pJugador.GetById(obdr.GetInt32(1));
                g.Encuentro = pEncuentro.GetById(obdr.GetInt32(2));
                g.Equipo = pEquipo.GetById(obdr.GetInt32(3));
                g.Minuto = obdr.GetInt32(4);
                goless.Add(g);
            }
            return goless;
        }

        public static List<Goles> GetByEncuentro(int idEncuentro)
        {
            List<Goles> goless = new List<Goles>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, idJugador, idEncuentro, idEquipo, minuto From Goles WHERE idEncuentro = @idEncuentro;");

            cmd.Parameters.Add(new SQLiteParameter("@idEncuentro", idEncuentro));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Goles g = new Goles();
                g.Id = obdr.GetInt32(0);
                g.Jugador = pJugador.GetById(obdr.GetInt32(1));
                g.Encuentro = pEncuentro.GetById(obdr.GetInt32(2));
                g.Equipo = pEquipo.GetById(obdr.GetInt32(3));
                g.Minuto = obdr.GetInt32(4);
                goless.Add(g);
            }
            return goless;
        }


        public static List<Goles> GetByMinuto(int minuto)
        {
            List<Goles> goless = new List<Goles>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, idJugador, idEncuentro, idEquipo, minuto From Goles WHERE minuto = @minuto;");

            cmd.Parameters.Add(new SQLiteParameter("@minuto", minuto));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Goles g = new Goles();
                g.Id = obdr.GetInt32(0);
                g.Jugador = pJugador.GetById(obdr.GetInt32(1));
                g.Encuentro = pEncuentro.GetById(obdr.GetInt32(2));
                g.Equipo = pEquipo.GetById(obdr.GetInt32(3));
                g.Minuto = obdr.GetInt32(4);
                goless.Add(g);
            }
            return goless;
        }

        public static void Delete(Goles g)
        {
            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Goles WHERE id = @id;");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@id", g.Id));

            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }


        public static void Update(Goles g)
        {
            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Goles SET idJugador = @idJugador, idEncuentro = @idEncuentro, idEquipo = @idEquipo, minuto = @minuto WHERE id = @id;");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@id", g.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idJugador", g.Jugador.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idEncuentro", g.Encuentro.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idEquipo", g.Equipo.Id));
            cmd.Parameters.Add(new SQLiteParameter("@minuto", g.Minuto));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }


    }
}
