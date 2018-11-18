using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_4m2.Entidades
{
    class Goles
    {
        int id;
        Jugador jugador;
        Encuentro encuentro;
        int minuto;

        public Goles()
        {

        }

        public Goles(int id, Jugador jugador, Encuentro encuentro, int minuto)
        {
            this.Id = id;
            this.Jugador = jugador;
            this.Encuentro = encuentro;
            this.Minuto = minuto;
        }

        public int Id { get => id; set => id = value; }
        public int Minuto { get => minuto; set => minuto = value; }
        internal Jugador Jugador { get => jugador; set => jugador = value; }
        internal Encuentro Encuentro { get => encuentro; set => encuentro = value; }
    }
}
