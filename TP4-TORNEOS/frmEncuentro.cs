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
    public partial class frmEncuentro : MetroFramework.Forms.MetroForm
    {
        public frmEncuentro()
        {
            InitializeComponent();
            generarTabla();
        }

        public void generarTabla() {
            List<Encuentro> encuentros = Controladores.pEncuentro.GetAll();

            // Defino las columnas de la tabla
            encuentrosTable.ColumnCount = 6;
            encuentrosTable.Columns[0].Name = "Fecha del Encuentro";
            encuentrosTable.Columns[0].Width = 140;
            encuentrosTable.Columns[1].Name = "Equipo Local";
            encuentrosTable.Columns[2].Name = "Goles Local";
            encuentrosTable.Columns[2].Width = 40;
            encuentrosTable.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            encuentrosTable.Columns[3].Name = "";
            encuentrosTable.Columns[3].Width = 25;
            encuentrosTable.Columns[4].Name = "Goles Visitante";
            encuentrosTable.Columns[4].Width = 80;
            encuentrosTable.Columns[5].Name = "Equipo Visitante";

            foreach (Encuentro e in encuentros)
            {
                List<Goles> goles = Controladores.pGoles.GetByEncuentro(e.Id);
                int goleslocal = 0;
                int golesvisitante = 0;
                foreach (Goles g in goles)
                {
                    if (g.Equipo.Id == e.EquipoLocal.Id) {
                        goleslocal = goleslocal + 1;
                    }
                    else if (g.Equipo.Id == e.EquipoVisitante.Id)
                    {
                        golesvisitante = golesvisitante + 1;
                    }
                }
                string[] row0 = { e.Fecha.ToString("dd/MM/yyyy HH:mm"), e.EquipoLocal.Nombre, goleslocal.ToString(), "◈", golesvisitante.ToString(), e.EquipoVisitante.Nombre, e.Arbitro.ToString() };
                encuentrosTable.Rows.Add(row0);
            }
        }

        private void btnModificarEncuentro_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoEncuentro_Click(object sender, EventArgs e)
        {
            this.Opacity = 0; //Ocultar ventana
            new fmAgregarEncuentro().ShowDialog();
            this.Opacity = 1; //Mostrar ventana
        }
    }
}
