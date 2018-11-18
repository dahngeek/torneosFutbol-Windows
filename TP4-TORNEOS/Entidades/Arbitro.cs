using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_4m2.Entidades
{
    class Arbitro
    {
        int id;
        string nombre;
        string apellido;

        public Arbitro()
        {

        }


        public Arbitro(int id, string nombre, string apellido)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
}
