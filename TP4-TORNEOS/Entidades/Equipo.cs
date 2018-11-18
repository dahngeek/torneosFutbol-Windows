using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_TORNEOS.Entidades
{
    class Equipo
    {
        int id;
        string nombre;
        int puntos;
        int golesFavor;
        int golesContra;
        Configuracion configuracion;

        public Equipo()
        { }


        public Equipo(int id, string nombre, int puntos, int golesFavor, int golesContra, Configuracion configuracion)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Puntos = puntos;
            this.GolesFavor = golesFavor;
            this.GolesContra = golesContra;
            this.Configuracion = configuracion;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public int GolesFavor { get => golesFavor; set => golesFavor = value; }
        public int GolesContra { get => golesContra; set => golesContra = value; }
        internal Configuracion Configuracion { get => configuracion; set => configuracion = value; }
    }
}
