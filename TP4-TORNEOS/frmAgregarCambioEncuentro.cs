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
    public partial class frmAgregarCambioEncuentro : MetroFramework.Forms.MetroForm
    {
        int idencuentro;
        public frmAgregarCambioEncuentro(int id)
        {
            InitializeComponent();
            idencuentro = id;
            Encuentro adefinir = Controladores.pEncuentro.GetById(idencuentro);
            equipoBindingSource.Add(adefinir.EquipoLocal);
            equipoBindingSource.Add(adefinir.EquipoVisitante);
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            Equipo eqip = (Equipo)equipoBindingSource.Current;
            Jugador saliente = (Jugador)jugadorSaleBindingSource.Current;
            Jugador entrante = (Jugador)jugadorEntraBindingSource.Current;
            int minuto = int.Parse(minuteBox.Text);
            Encuentro encu = Controladores.pEncuentro.GetById(idencuentro);
            CambiosEncuentro cb = new CambiosEncuentro(0, saliente, entrante, encu, minuto);
            Controladores.pCambiosEncuentro.Save(cb);
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
            jugadorEntraBindingSource.DataSource = Controladores.pJugador.GetByEquipo(eq.Id);
            jugadorSaleBindingSource.DataSource = Controladores.pJugador.GetByEquipo(eq.Id);
        }

        private void metroComboBox1_RightToLeftChanged(object sender, EventArgs e)
        {

        }
    }
}
