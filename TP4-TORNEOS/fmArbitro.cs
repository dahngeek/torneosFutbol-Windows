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
    public partial class fmArbitro : MetroFramework.Forms.MetroForm
    {
        bool creando = false;
        public fmArbitro()
        {
            InitializeComponent();
            //tablaArbitros.BackgroundColor = Color.Azure;
            arbitroBindingSource.DataSource = Controladores.pArbitro.GetAll();
        }

        private void deleteArbitroBtn_Click(object sender, EventArgs e)
        {
            Arbitro arbitroeliminar = (Arbitro) arbitroBindingSource.Current;
            Controladores.pArbitro.Delete(arbitroeliminar);
            actualizar();
        }

        private void tablaArbitros_SelectionChanged(object sender, EventArgs e)
        {
            try {
                Arbitro arbitroselection = (Arbitro)arbitroBindingSource.Current;
                nombreTextBox.Text = arbitroselection.Nombre;
                apellidoTextBox.Text = arbitroselection.Apellido;
				}
            catch
				{

				}
            saveBtn.Visible = false;
            nombreTextBox.ReadOnly = true;
            apellidoTextBox.ReadOnly = true;
        }

        private void modifyArbitroBtn_Click(object sender, EventArgs e)
        {
            saveBtn.Visible = true;
            nombreTextBox.ReadOnly = false;
            apellidoTextBox.ReadOnly = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (creando)
            {
                Arbitro nuevo = new Arbitro(1, nombreTextBox.Text, apellidoTextBox.Text);
                Controladores.pArbitro.Save(nuevo);
            }
            else {
                Arbitro arbitroselection = (Arbitro)arbitroBindingSource.Current;
                arbitroselection.Nombre = nombreTextBox.Text;
                arbitroselection.Apellido = apellidoTextBox.Text;
                Controladores.pArbitro.Update(arbitroselection);
            }
            creando = false;
            saveBtn.Visible = false;
            nombreTextBox.ReadOnly = true;
            apellidoTextBox.ReadOnly = true;
            actualizar();
        }

        private void newArbitroBtn_Click(object sender, EventArgs e)
        {
            nombreTextBox.Text = "";
            apellidoTextBox.Text = "";
            nombreTextBox.ReadOnly = false;
            apellidoTextBox.ReadOnly = false;
            saveBtn.Visible = true;
            creando = true;
        }

        private void actualizar()
        {
            arbitroBindingSource.DataSource = null;
            arbitroBindingSource.DataSource = Controladores.pArbitro.GetAll();
        }

		private void nombreTextBox_Click(object sender, EventArgs e)
		{

		}
	}
}
