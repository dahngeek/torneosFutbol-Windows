using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using P_4m2.Entidades;

namespace P_4m2.Controladores
{
    class pEncuentro
    {
        public static void Save(Encuentro e)
        {

            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Encuentro (idEquipoLocal, idEquipoVisitante, fecha, idArbitro) VALUES ( @idEquipoLocal, @idEquipoVisitante, @fecha, @idArbitro);");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@idEquipoLocal", e.EquipoLocal.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idEquipoVisitante", e.EquipoVisitante.Id));
            cmd.Parameters.Add(new SQLiteParameter("@fecha", e.Fecha));
            cmd.Parameters.Add(new SQLiteParameter("@idArbitro", e.Arbitro.Id));


            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static List<Encuentro> GetAll()
        {
            List<Encuentro> encuentros = new List<Encuentro>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, idEquipoLocal, idEquipoVisitante, fecha, idArbitro From Encuentro;");
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Encuentro e = new Encuentro();
                e.Id = obdr.GetInt32(0);
                e.EquipoLocal = pEquipo.GetById(obdr.GetInt32(1));
                e.EquipoVisitante = pEquipo.GetById(obdr.GetInt32(2));
                e.Fecha = obdr.GetDateTime(3);
                e.Arbitro = pArbitro.GetById(obdr.GetInt32(4));
                encuentros.Add(e);
            }
            return encuentros;
        }

        public static Encuentro GetById(int id)
        {
            Encuentro e = new Encuentro();

            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, idEquipoLocal, idEquipoVisitante, fecha, idArbitro From Encuentro WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader6
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                e.Id = obdr.GetInt32(0);
                e.EquipoLocal = pEquipo.GetById(obdr.GetInt32(1));
                e.EquipoVisitante = pEquipo.GetById(obdr.GetInt32(2));
                e.Fecha = obdr.GetDateTime(3);
                e.Arbitro = pArbitro.GetById(obdr.GetInt32(4));
            }
            return e;
        }

        public static List<Encuentro> GetByLocal(int idEquipoLocal)
        {
            List<Encuentro> encuentros = new List<Encuentro>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, idEquipoLocal, idEquipoVisitante, fecha, idArbitro From Encuentro WHERE idEquipoLocal = @idEquipoLocal;");

            cmd.Parameters.Add(new SQLiteParameter("@idEquipoLocal", idEquipoLocal));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Encuentro e = new Encuentro();
                e.Id = obdr.GetInt32(0);
                e.EquipoLocal = pEquipo.GetById(obdr.GetInt32(1));
                e.EquipoVisitante = pEquipo.GetById(obdr.GetInt32(2));
                e.Fecha = obdr.GetDateTime(3);
                e.Arbitro = pArbitro.GetById(obdr.GetInt32(4));
                encuentros.Add(e);
            }
            return encuentros;
        }

        public static List<Encuentro> GetByVisit(int idEquipoVisitante)
        {
            List<Encuentro> encuentros = new List<Encuentro>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, idEquipoLocal, idEquipoVisitante, fecha, idArbitro From Encuentro WHERE idEquipoVisitante = @idEquipoVisitante;");

            cmd.Parameters.Add(new SQLiteParameter("@idEquipoVisitante", idEquipoVisitante));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Encuentro e = new Encuentro();
                e.Id = obdr.GetInt32(0);
                e.EquipoLocal = pEquipo.GetById(obdr.GetInt32(1));
                e.EquipoVisitante = pEquipo.GetById(obdr.GetInt32(2));
                e.Fecha = obdr.GetDateTime(3);
                e.Arbitro = pArbitro.GetById(obdr.GetInt32(4));
                encuentros.Add(e);
            }
            return encuentros;
        }



        public static List<Encuentro> GetByArbitro(int idArbitro)
        {
            List<Encuentro> encuentros = new List<Encuentro>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, idEquipoLocal, idEquipoVisitante, fecha, idArbitro From Encuentro WHERE idArbitro = @idArbitro;");

            cmd.Parameters.Add(new SQLiteParameter("@idArbitro", idArbitro));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Encuentro e = new Encuentro();
                e.Id = obdr.GetInt32(0);
                e.EquipoLocal = pEquipo.GetById(obdr.GetInt32(1));
                e.EquipoVisitante = pEquipo.GetById(obdr.GetInt32(2));
                e.Fecha = obdr.GetDateTime(3);
                e.Arbitro = pArbitro.GetById(obdr.GetInt32(4));
                encuentros.Add(e);
            }
            return encuentros;
        }

        public static void Delete(Encuentro e)
        {
            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Encuentro WHERE id = @id;");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@id", e.Id));

            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }


        public static void Update(Encuentro e)
        {
            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Encuentro SET idEquipoLocal = @idEquipoLocal, idEquipoVisitante = @idEquipoVisitante, fecha = @fecha, idArbitro = @idArbitro WHERE id = @id;");

            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@id", e.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idEquipoLocal", e.EquipoLocal.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idEquipoVisitante", e.EquipoVisitante.Id));
            cmd.Parameters.Add(new SQLiteParameter("@fecha", e.Fecha));
            cmd.Parameters.Add(new SQLiteParameter("@idArbitro", e.Arbitro.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

    }
}
