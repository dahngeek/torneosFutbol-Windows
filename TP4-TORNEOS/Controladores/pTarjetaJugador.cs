using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using P_4m2.Entidades;


namespace P_4m2.Controladores
{
    class pTarjetaJugador
    {
        public static void Save(TarjetaJugador tj)
        {

            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO TarjetaJugador (idTarjeta, idJugador, idEncuentro, minuto) VALUES (@idTarjeta, @idJugador, @idEncuentro, @minuto);");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@idTarjeta", tj.Tarjeta.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idJugador", tj.Jugador.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idEncuentro", tj.Encuentro.Id));
            cmd.Parameters.Add(new SQLiteParameter("@minuto", tj.Minuto));


            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static List<TarjetaJugador> GetAll()
        {
            List<TarjetaJugador> tarjetasjugadores = new List<TarjetaJugador>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, idTarjeta, idJugador, idEncuentro, minuto From TarjetaJugador;");
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                TarjetaJugador tj = new TarjetaJugador();
                tj.Id = obdr.GetInt32(0);
                tj.Tarjeta = pTipoTarjeta.GetById(obdr.GetInt32(1));
                tj.Jugador = pJugador.GetById(obdr.GetInt32(2));
                tj.Encuentro = pEncuentro.GetById(obdr.GetInt32(3));
                tj.Minuto = obdr.GetInt32(4);
                tarjetasjugadores.Add(tj);
            }
            return tarjetasjugadores;
        }

        public static TarjetaJugador GetById(int id)
        {
            TarjetaJugador tj = new TarjetaJugador();

            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, idTarjeta, idJugador, idEncuentro, minuto From TarjetaJugador WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader6
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                tj.Id = obdr.GetInt32(0);
                tj.Tarjeta = pTipoTarjeta.GetById(obdr.GetInt32(1));
                tj.Jugador = pJugador.GetById(obdr.GetInt32(2));
                tj.Encuentro = pEncuentro.GetById(obdr.GetInt32(3));
                tj.Minuto = obdr.GetInt32(4);
            }
            return tj;
        }


        public static List<TarjetaJugador> GetByTarjeta(int idTarjeta)
        {
            List<TarjetaJugador> tarjetasjugadores = new List<TarjetaJugador>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, idTarjeta, idJugador, idEncuentro, minuto From Goles WHERE idTarjeta = @idTarjeta;");

            cmd.Parameters.Add(new SQLiteParameter("@idTarjeta", idTarjeta));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                TarjetaJugador tj = new TarjetaJugador();
                tj.Id = obdr.GetInt32(0);
                tj.Tarjeta = pTipoTarjeta.GetById(obdr.GetInt32(1));
                tj.Jugador = pJugador.GetById(obdr.GetInt32(2));
                tj.Encuentro = pEncuentro.GetById(obdr.GetInt32(3));
                tj.Minuto = obdr.GetInt32(4);
                tarjetasjugadores.Add(tj);
            }
            return tarjetasjugadores;
        }


        public static List<TarjetaJugador> GetByJugador(int idJugador)
        {
            List<TarjetaJugador> tarjetasjugadores = new List<TarjetaJugador>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, idTarjeta, idJugador, idEncuentro, minuto From TarjetaJugador WHERE idJugador = @idJugador;");

            cmd.Parameters.Add(new SQLiteParameter("@idJugador", idJugador));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                TarjetaJugador tj = new TarjetaJugador();
                tj.Id = obdr.GetInt32(0);
                tj.Tarjeta = pTipoTarjeta.GetById(obdr.GetInt32(1));
                tj.Jugador = pJugador.GetById(obdr.GetInt32(2));
                tj.Encuentro = pEncuentro.GetById(obdr.GetInt32(3));
                tj.Minuto = obdr.GetInt32(4);
                tarjetasjugadores.Add(tj);
            }
            return tarjetasjugadores;
        }

        public static List<TarjetaJugador> GetByEncuentro(int idEncuentro)
        {
            List<TarjetaJugador> tarjetasjugadores = new List<TarjetaJugador>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, idTarjeta, idJugador, idEncuentro, minuto From TarjetaJugador WHERE idEncuentro = @idEncuentro;");

            cmd.Parameters.Add(new SQLiteParameter("@idEncuentro", idEncuentro));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                TarjetaJugador tj = new TarjetaJugador();
                tj.Id = obdr.GetInt32(0);
                tj.Tarjeta = pTipoTarjeta.GetById(obdr.GetInt32(1));
                tj.Jugador = pJugador.GetById(obdr.GetInt32(2));
                tj.Encuentro = pEncuentro.GetById(obdr.GetInt32(3));
                tj.Minuto = obdr.GetInt32(4);
                tarjetasjugadores.Add(tj);
            }
            return tarjetasjugadores;
        }


        public static List<TarjetaJugador> GetByMinuto(int minuto)
        {
            List<TarjetaJugador> tarjetasjugadores = new List<TarjetaJugador>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, idTarjeta, idJugador, idEncuentro, minuto From TarjetaJugador WHERE minuto = @minuto;");

            cmd.Parameters.Add(new SQLiteParameter("@minuto", minuto));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                TarjetaJugador tj = new TarjetaJugador();
                tj.Id = obdr.GetInt32(0);
                tj.Tarjeta = pTipoTarjeta.GetById(obdr.GetInt32(1));
                tj.Jugador = pJugador.GetById(obdr.GetInt32(2));
                tj.Encuentro = pEncuentro.GetById(obdr.GetInt32(3));
                tj.Minuto = obdr.GetInt32(4);
                tarjetasjugadores.Add(tj);
            }
            return tarjetasjugadores;
        }

        public static void Delete(TarjetaJugador tj)
        {
            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM TarjetaJugador WHERE id = @id;");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@id", tj.Id));

            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }


        public static void Update(TarjetaJugador tj)
        {
            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("UPDATE TarjetaJugador SET idJugador = @idJugador, idEncuentro = @idEncuentro, minuto = @minuto WHERE id = @id;");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@id", tj.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idTarjeta", tj.Tarjeta.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idJugador", tj.Jugador.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idEncuentro", tj.Encuentro.Id));
            cmd.Parameters.Add(new SQLiteParameter("@minuto", tj.Minuto));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }



    }
}
