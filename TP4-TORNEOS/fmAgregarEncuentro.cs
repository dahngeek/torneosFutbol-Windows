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
    public partial class fmAgregarEncuentro : MetroFramework.Forms.MetroForm
    {
        public fmAgregarEncuentro()
        {
            InitializeComponent();
            encuentroDate.Format = DateTimePickerFormat.Custom;
            encuentroDate.CustomFormat = "dd/MM/yyyy hh:mm tt";
            cbEquipoLocal.DataSource = Controladores.pEquipo.GetAll();
            cbEquipoVisitante.DataSource = Controladores.pEquipo.GetAll();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void cbEquipoLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Equipo> equiposrestantes = Controladores.pEquipo.GetAll();
            equiposrestantes.RemoveAt(cbEquipoLocal.SelectedIndex);
            cbEquipoVisitante.DataSource = equiposrestantes;
        }
    }
}
