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
    public partial class fmGolTarjetaAgregar : MetroFramework.Forms.MetroForm
    {
        int idencuentro;
        enum TipoVentana { AgregarGol, AgregarTarjeta }
        int tipoOperacion = 0;
        public fmGolTarjetaAgregar(int id, int tipo)
        {
            InitializeComponent();
            idencuentro = id;
            Encuentro adefinir = Controladores.pEncuentro.GetById(idencuentro);
            equipoBindingSource.Add(adefinir.EquipoLocal);
            equipoBindingSource.Add(adefinir.EquipoVisitante);
            this.tipoOperacion = tipo;
            if (tipoOperacion == (int)TipoVentana.AgregarTarjeta) {
                boxTarjeta.Visible = true;
                labelTarjeta.Visible = true;
                tipoTarjetaBindingSource.DataSource = Controladores.pTipoTarjeta.GetAll();
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            Equipo paraelgol = (Equipo)equipoBindingSource.Current;
            Jugador goleador = (Jugador)jugadorBindingSource.Current;
            int minuto = int.Parse(minuteBox.Text);
            Encuentro encu = Controladores.pEncuentro.GetById(idencuentro);

            if (tipoOperacion == (int)TipoVentana.AgregarGol) {
                Goles nuevo = new Goles(0, goleador, paraelgol, encu, minuto);
                Controladores.pGoles.Save(nuevo);
            }
            else if (tipoOperacion == (int)TipoVentana.AgregarTarjeta)
            {
                TipoTarjeta tipo = (TipoTarjeta)tipoTarjetaBindingSource.Current;
                TarjetaJugador tarj = new TarjetaJugador(0, tipo, goleador, encu, minuto);
                Controladores.pTarjetaJugador.Save(tarj);
            }
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

        private void fmGolTarjetaAgregar_Load(object sender, EventArgs e)
        {

        }
    }
}
