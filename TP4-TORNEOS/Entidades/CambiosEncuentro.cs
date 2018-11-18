using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_TORNEOS.Entidades
{
    class CambiosEncuentro
    {
        int id;
        Jugador jugadorSaliente;
        Jugador jugadorEntrante;
        Encuentro encuentro;
        int minuto;

        public CambiosEncuentro()
        {

        }


        public CambiosEncuentro(int id, Jugador jugadorSaliente, Jugador jugadorEntrante, Encuentro encuentro, int minuto)
        {
            this.Id = id;
            this.JugadorSaliente = jugadorSaliente;
            this.JugadorEntrante = jugadorEntrante;
            this.Encuentro = encuentro;
            this.Minuto = minuto;
        }

        public int Id { get => id; set => id = value; }
        public int Minuto { get => minuto; set => minuto = value; }
        internal Jugador JugadorSaliente { get => jugadorSaliente; set => jugadorSaliente = value; }
        internal Jugador JugadorEntrante { get => jugadorEntrante; set => jugadorEntrante = value; }
        internal Encuentro Encuentro { get => encuentro; set => encuentro = value; }
    }
}
