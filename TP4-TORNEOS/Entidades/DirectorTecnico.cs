using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_TORNEOS.Entidades
{
    class DirectorTecnico
    {
        int id;
        string nombre;
        string apellido;
        Equipo equipo;

        public DirectorTecnico()
        { }

        public DirectorTecnico(int id, string nombre, string apellido, Equipo equipo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Equipo = equipo;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        internal Equipo Equipo { get => equipo; set => equipo = value; }
    }
}
