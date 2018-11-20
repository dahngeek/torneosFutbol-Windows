using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP4_TORNEOS.Entidades;
using TP4_TORNEOS.Controladores;

namespace TP4_TORNEOS
{
    public partial class fmVenderJugador : MetroFramework.Forms.MetroForm
    {
        Jugador jugadorSeleccionado = new Jugador();
        public fmVenderJugador(int idJugador)
        {
            InitializeComponent();
            equipoBindingSource.DataSource = pEquipo.GetAll();

            txNombreJugador.Text = pJugador.GetById(idJugador).Nombre + " " + pJugador.GetById(idJugador).Apellido;
            jugadorSeleccionado = pJugador.GetById(idJugador);

        }

        private void txNombreJugador_Click(object sender, EventArgs e)
        {
            
        }

        private void btVender_Click(object sender, EventArgs e)
        {
            Equipo equipo = pEquipo.GetById(cbEquipoSeleccionado.SelectedIndex+1);
            jugadorSeleccionado.Equipo = equipo;

            pJugador.Update(jugadorSeleccionado);

            
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
