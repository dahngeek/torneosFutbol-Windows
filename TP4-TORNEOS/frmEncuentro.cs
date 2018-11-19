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
            encuentrosTable.Columns[1].Name = "Equipo Local";
            encuentrosTable.Columns[2].Name = "Goles Local";
            encuentrosTable.Columns[2].Width = 40;
            encuentrosTable.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            encuentrosTable.Columns[3].Name = "";
            encuentrosTable.Columns[3].Width = 25;
            encuentrosTable.Columns[4].Name = "Goles Visitante";
            encuentrosTable.Columns[4].Width = 100;
            encuentrosTable.Columns[5].Name = "Equipo Visitante";

            foreach (Encuentro e in encuentros)
            {
                string[] row0 = { e.Fecha.ToString("dd/MM/yyyy HH:mm"), e.EquipoLocal.Nombre, "9", "◈", "12", e.EquipoVisitante.Nombre, e.Arbitro.ToString() };
                encuentrosTable.Rows.Add(row0);
            }
        }
    }
}
