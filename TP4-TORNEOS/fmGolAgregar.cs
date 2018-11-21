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

namespace TP4_TORNEOS
{
    public partial class fmGolAgregar : MetroFramework.Forms.MetroForm
    {
        int idencuentro;
        public fmGolAgregar(int id)
        {
            InitializeComponent();
            idencuentro = id;
            Encuentro adefinir = Controladores.pEncuentro.GetById(idencuentro);
            equipoBindingSource.Add(adefinir.EquipoLocal);
            equipoBindingSource.Add(adefinir.EquipoVisitante);
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            Equipo paraelgol = (Equipo)equipoBindingSource.Current;
            Jugador goleador = (Jugador)jugadorBindingSource.Current;
            int minuto = int.Parse(minuteBox.Text);
            Encuentro encu = Controladores.pEncuentro.GetById(idencuentro);
            Goles nuevo = new Goles(0, goleador, paraelgol, encu, minuto);
            Controladores.pGoles.Save(nuevo);
            Close();
        }

        private void minuteBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void minuteBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(minuteBox.Text, "[^0-9]"))
            {
                MetroFramework.MetroMessageBox.Show(this, "Los minutos deben de estar en numeros enteros.");
                minuteBox.Text = 0.ToString();
            }
        }

        private void equipoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Equipo eq = (Equipo)equipoBindingSource.Current;
            jugadorBindingSource.DataSource = Controladores.pJugador.GetByEquipo(eq.Id);
        }
    }
}
