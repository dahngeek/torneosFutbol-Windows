using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using TP4_TORNEOS.Entidades;

namespace TP4_TORNEOS.Controladores
{
    class pCambiosEncuentro
    {
        public static void Save(CambiosEncuentro ce)
        {

            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO CambiosEncuentro (idJugadorSaliente, idJugadorEntrante, idEncuentro, minuto) VALUES (@idJugadorSaliente, @idJugadorEntrante, @idEncuentro, @minuto);");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@idJugador", ce.JugadorSaliente.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idJugador", ce.JugadorEntrante.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idEncuentro", ce.Encuentro.Id));
            cmd.Parameters.Add(new SQLiteParameter("@minuto", ce.Minuto));


            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static List<CambiosEncuentro> GetAll()
        {
            List<CambiosEncuentro> cambiosEncuentros = new List<CambiosEncuentro>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, idJugadorSaliente, idJugadorEntrante, idEncuentro, minuto From CambiosEncuentro;");
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                CambiosEncuentro ce = new CambiosEncuentro();
                ce.Id = obdr.GetInt32(0);
                ce.JugadorSaliente = pJugador.GetById(obdr.GetInt32(1));
                ce.JugadorEntrante = pJugador.GetById(obdr.GetInt32(2));
                ce.Encuentro = pEncuentro.GetById(obdr.GetInt32(3));
                ce.Minuto = obdr.GetInt32(4);
                cambiosEncuentros.Add(ce);
            }
            return cambiosEncuentros;
        }

        public static CambiosEncuentro GetById(int id)
        {
            CambiosEncuentro ce = new CambiosEncuentro();

            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, idJugadorSaliente, idJugadorEntrante, idEncuentro, minuto From CambiosEncuentro WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader6
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                ce.Id = obdr.GetInt32(0);
                ce.JugadorSaliente = pJugador.GetById(obdr.GetInt32(1));
                ce.JugadorEntrante = pJugador.GetById(obdr.GetInt32(2));
                ce.Encuentro = pEncuentro.GetById(obdr.GetInt32(3));
                ce.Minuto = obdr.GetInt32(4);

            }
            return ce;
        }

        public static List<CambiosEncuentro> GetByJugadorSaliente(int idJugadorSaliente)
        {
            List<CambiosEncuentro> cambiosEncuentros = new List<CambiosEncuentro>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, idJugadorSaliente, idJugadorEntrante, idEncuentro, minuto From CambiosEncuentro WHERE idJugadorSaliente = @idJugadorSaliente;");

            cmd.Parameters.Add(new SQLiteParameter("@idJugadorSaliente", idJugadorSaliente));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                CambiosEncuentro ce = new CambiosEncuentro();
                ce.Id = obdr.GetInt32(0);
                ce.JugadorSaliente = pJugador.GetById(obdr.GetInt32(1));
                ce.JugadorEntrante = pJugador.GetById(obdr.GetInt32(2));
                ce.Encuentro = pEncuentro.GetById(obdr.GetInt32(3));
                ce.Minuto = obdr.GetInt32(4);
                cambiosEncuentros.Add(ce);
            }
            return cambiosEncuentros;
        }

        public static List<CambiosEncuentro> GetByJugadorEntrante(int idJugadorEntrante)
        {
            List<CambiosEncuentro> cambiosEncuentros = new List<CambiosEncuentro>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, idJugadorSaliente, idJugadorEntrante, idEncuentro, minuto From CambiosEncuentro WHERE idJugadorEntrante = @idJugadorEntrante;");

            cmd.Parameters.Add(new SQLiteParameter("@idJugadorEntrante", idJugadorEntrante));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                CambiosEncuentro ce = new CambiosEncuentro();
                ce.Id = obdr.GetInt32(0);
                ce.JugadorSaliente = pJugador.GetById(obdr.GetInt32(1));
                ce.JugadorEntrante = pJugador.GetById(obdr.GetInt32(2));
                ce.Encuentro = pEncuentro.GetById(obdr.GetInt32(3));
                ce.Minuto = obdr.GetInt32(4);
                cambiosEncuentros.Add(ce);
            }
            return cambiosEncuentros;
        }



        public static List<CambiosEncuentro> GetByEncuentro(int idEncuentro)
        {
            List<CambiosEncuentro> cambiosEncuentros = new List<CambiosEncuentro>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, idJugadorSaliente, idJugadorEntrante, idEncuentro, minuto From CambiosEncuentro WHERE idEncuentro = @idEncuentro;");

            cmd.Parameters.Add(new SQLiteParameter("@idEncuentro", idEncuentro));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                CambiosEncuentro ce = new CambiosEncuentro();
                ce.Id = obdr.GetInt32(0);
                ce.JugadorSaliente = pJugador.GetById(obdr.GetInt32(1));
                ce.JugadorEntrante = pJugador.GetById(obdr.GetInt32(2));
                ce.Encuentro = pEncuentro.GetById(obdr.GetInt32(3));
                ce.Minuto = obdr.GetInt32(4);
                cambiosEncuentros.Add(ce);
            }
            return cambiosEncuentros;
        }


        public static List<CambiosEncuentro> GetByMinuto(int minuto)
        {
            List<CambiosEncuentro> cambiosEncuentros = new List<CambiosEncuentro>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, idJugadorSaliente, idJugadorEntrante, idEncuentro, minuto From CambiosEncuentro WHERE minuto = @minuto;");

            cmd.Parameters.Add(new SQLiteParameter("@minuto", minuto));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                CambiosEncuentro ce = new CambiosEncuentro();
                ce.Id = obdr.GetInt32(0);
                ce.JugadorSaliente = pJugador.GetById(obdr.GetInt32(1));
                ce.JugadorEntrante = pJugador.GetById(obdr.GetInt32(2));
                ce.Encuentro = pEncuentro.GetById(obdr.GetInt32(3));
                ce.Minuto = obdr.GetInt32(4);
                cambiosEncuentros.Add(ce);
            }
            return cambiosEncuentros;
        }

        public static void Delete(CambiosEncuentro ce)
        {
            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM CambiosEncuentro WHERE id = @id;");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@id", ce.Id));

            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }


        public static void Update(CambiosEncuentro ce)
        {
            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("UPDATE CambiosEncuentro SET idJugadorSaliente = @idJugadorSaliente, idJugadorEntrante = @idJugadorEntrante, idEncuentro = @idEncuentro, minuto = @minuto WHERE id = @id;");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@id", ce.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idJugador", ce.JugadorSaliente.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idJugador", ce.JugadorEntrante.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idEncuentro", ce.Encuentro.Id));
            cmd.Parameters.Add(new SQLiteParameter("@minuto", ce.Minuto));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }



    }
}
