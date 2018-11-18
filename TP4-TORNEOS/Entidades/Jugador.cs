using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_4m2.Entidades
{
    class Jugador
    {
        int id;
        string nombre;
        string apellido;
        string apodo;
        int numeroCamiseta;
        Equipo equipo;
        Posicion posicion;
        string urlImagen;

        public Jugador()
        { }

        public Jugador(int id, string nombre, string apellido, string apodo, int numeroCamiseta, Equipo equipo, Posicion posicion, string urlImagen)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Apodo = apodo;
            this.NumeroCamiseta = numeroCamiseta;
            this.Equipo = equipo;
            this.Posicion = posicion;
            this.UrlImagen = urlImagen;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public int NumeroCamiseta { get => numeroCamiseta; set => numeroCamiseta = value; }
        public Equipo Equipo { get => equipo; set => equipo = value; }
        public Posicion Posicion { get => posicion; set => posicion = value; }
        public string UrlImagen { get => urlImagen; set => urlImagen = value; }
    }
}
