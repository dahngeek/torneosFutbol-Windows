using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using TP4_TORNEOS.Entidades;

namespace TP4_TORNEOS.Controladores
{
    class pTipoTarjeta
    {
        public static void Save(TipoTarjeta tp)
        {

            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO TipoTarjeta (nombre) VALUES (@nombre);");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@nombre", tp.Nombre));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static List<TipoTarjeta> GetAll()
        {
            List<TipoTarjeta> tipoTarjetas = new List<TipoTarjeta>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre From TipoTarjeta;");
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                TipoTarjeta tp = new TipoTarjeta();
                tp.Id = obdr.GetInt32(0);
                tp.Nombre = obdr.GetString(1);
                tipoTarjetas.Add(tp);
            }
            return tipoTarjetas;
        }

        public static TipoTarjeta GetById(int id)
        {
            TipoTarjeta tp = new TipoTarjeta();

            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre From TipoTarjeta WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader6
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                tp.Id = obdr.GetInt32(0);
                tp.Nombre = obdr.GetString(1);
            }
            return tp;
        }

        public static List<TipoTarjeta> GetByNombre(string nombre)
        {
            List<TipoTarjeta> tipoTarjetas = new List<TipoTarjeta>();
            //Creo el comando sql a utlizar
            SQLiteCommand cmd =
                new SQLiteCommand("SELECT id, nombre From TipoTarjeta WHERE nombre like @nombre;");

            cmd.Parameters.Add(new SQLiteParameter("@nombre", nombre));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                TipoTarjeta tp = new TipoTarjeta();
                tp.Id = obdr.GetInt32(0);
                tp.Nombre = obdr.GetString(1);
                tipoTarjetas.Add(tp);
            }
            return tipoTarjetas;
        }



        public static void Delete(TipoTarjeta tp)
        {
            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM TipoTarjeta WHERE id = @id;");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@id", tp.Id));

            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }


        public static void Update(TipoTarjeta tp)
        {
            //Creo el comando sql a utlizar
            SQLiteCommand cmd = new SQLiteCommand("UPDATE TipoTarjeta SET nombre = @nombre WHERE id = @id;");

            //Cargo el valor del parametro
            cmd.Parameters.Add(new SQLiteParameter("@id", tp.Id));
            cmd.Parameters.Add(new SQLiteParameter("@nombre", tp.Nombre));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }
    }
}
