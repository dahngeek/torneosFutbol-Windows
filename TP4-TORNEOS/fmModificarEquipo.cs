using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP4_TORNEOS.Controladores;
using TP4_TORNEOS.Entidades;

namespace TP4_TORNEOS
{
    public partial class fmModificarEquipo : MetroFramework.Forms.MetroForm
    {
        public fmModificarEquipo()
        {
            InitializeComponent();
            equipoBindingSource.DataSource = pEquipo.GetAll();
        }

        private void cbEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Equipo eq = (Equipo)equipoBindingSource.Current;
                List<Jugador> todosjugadores = new List<Jugador>();
                todosjugadores = pJugador.GetAll();

                List<Jugador> jugadoresEquipo = new List<Jugador>();

                for (int i = 0; i < todosjugadores.Count; i++)
                {
                    if (todosjugadores[i].Equipo.Id == eq.Id)
                    {
                        jugadoresEquipo.Add(todosjugadores[i]);

                    }
                }
                jugadorBindingSource.DataSource = jugadoresEquipo;

            }
            catch { }



        }

        private void cbEquipos_Click(object sender, EventArgs e)
        {
            
        }
    }
}
