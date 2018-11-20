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
    public partial class TablaPosicionesEquipos : MetroFramework.Forms.MetroForm
    {
        public TablaPosicionesEquipos()
        {
            InitializeComponent();
            equipoBindingSource.DataSource = OrdenaEquipos();
        }

        private void equipoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }


        private List<Equipo> OrdenaEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            equipos = pEquipo.GetAll();
            for (int i = 0; i < equipos.Count - 1; i++)
            {
                if (equipos[i].Puntos < equipos[i + 1].Puntos)
                {
                    Equipo e = new Equipo();
                    e = equipos[i];
                    equipos[i] = equipos[i + 1];
                    equipos[i + 1] = e;
                }
            }
            return equipos;
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            fmModificarEquipo fmModEq = new fmModificarEquipo();
            fmModEq.ShowDialog();
        }

        private void btIrPantallaPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
            PantallaPrincipal pp = new PantallaPrincipal();
            pp.Show();
        }
    }
}
