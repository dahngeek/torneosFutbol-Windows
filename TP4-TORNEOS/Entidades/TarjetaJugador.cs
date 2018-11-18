using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_TORNEOS.Entidades
{
    class TarjetaJugador
    {
        int id;
        TipoTarjeta tarjeta;
        Jugador jugador;
        Encuentro encuentro;
        int minuto;

        public TarjetaJugador()
        {

        }


        public TarjetaJugador(int id, TipoTarjeta tarjeta, Jugador jugador, Encuentro encuentro, int minuto)
        {
            this.Id = id;
            this.Tarjeta = tarjeta;
            this.Jugador = jugador;
            this.Encuentro = encuentro;
            this.Minuto = minuto;
        }

        public int Id { get => id; set => id = value; }
        public int Minuto { get => minuto; set => minuto = value; }
        internal TipoTarjeta Tarjeta { get => tarjeta; set => tarjeta = value; }
        internal Jugador Jugador { get => jugador; set => jugador = value; }
        internal Encuentro Encuentro { get => encuentro; set => encuentro = value; }
    }
}
