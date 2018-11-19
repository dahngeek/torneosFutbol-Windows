using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_TORNEOS.Entidades
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

        public string getNombreEquipoVisitante() {
            return this.EquipoVisitante.Nombre;
        }

        public string getArbitro()
        {
            return this.Arbitro.Nombre + " " + this.Arbitro.Apellido;
        }

        public string getNombreEquipoLocal()
        {
            return this.EquipoLocal.Nombre;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Equipo EquipoLocal { get => equipoLocal; set => equipoLocal = value; }
        public Equipo EquipoVisitante { get => equipoVisitante; set => equipoVisitante = value; }
        public Arbitro Arbitro { get => arbitro; set => arbitro = value; }
    }
}
