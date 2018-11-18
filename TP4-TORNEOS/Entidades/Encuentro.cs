using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_4m2.Entidades
{
    class Encuentro
    {
        int id;
        Equipo equipoLocal;
        Equipo equipoVisitante;
        DateTime fecha;
        Arbitro arbitro;

        public Encuentro()
        { }

        public Encuentro(int id, Equipo equipoLocal, Equipo equipoVisitante, DateTime fecha, Arbitro arbitro)
        {
            this.Id = id;
            this.EquipoLocal = equipoLocal;
            this.EquipoVisitante = equipoVisitante;
            this.Fecha = fecha;
            this.Arbitro = arbitro;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        internal Equipo EquipoLocal { get => equipoLocal; set => equipoLocal = value; }
        internal Equipo EquipoVisitante { get => equipoVisitante; set => equipoVisitante = value; }
        internal Arbitro Arbitro { get => arbitro; set => arbitro = value; }
    }
}
