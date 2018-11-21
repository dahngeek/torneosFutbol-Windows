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
    public partial class fmEncuentroDetalle : MetroFramework.Forms.MetroForm
    {
        List<Goles> goles;
        List<CambiosEncuentro> cambios;
        List<TarjetaJugador> tarjetas;
        int idencuentro;

        public fmEncuentroDetalle(int idEncuentro)
        {
            InitializeComponent();
            Encuentro e = Controladores.pEncuentro.GetById(idEncuentro);
            this.Text = "Encuentro: " + e.getNombreEquipoLocal() + " vs " + e.getNombreEquipoVisitante();
            this.idencuentro = idEncuentro;
            lblLocal.Text = e.getNombreEquipoLocal();
            lblVisitante.Text = e.getNombreEquipoVisitante();

            generarTabla();
        }

        public void generarTabla()
        {
            tarjetas = Controladores.pTarjetaJugador.GetByEncuentro(idencuentro).OrderBy(o=>o.Minuto).ToList();
            cambios = Controladores.pCambiosEncuentro.GetByEncuentro(idencuentro).OrderBy(o => o.Minuto).ToList();
            goles = Controladores.pGoles.GetByEncuentro(idencuentro).OrderBy(o => o.Minuto).ToList();
            Encuentro e = Controladores.pEncuentro.GetById(idencuentro);

            //Obtener goles totales
            int goleslocal = 0;
            int golesvisitante = 0;
            foreach (Goles g in goles)
            {
                if (g.Equipo.Id == e.EquipoLocal.Id)
                {
                    goleslocal = goleslocal + 1;
                }
                else if (g.Equipo.Id == e.EquipoVisitante.Id)
                {
                    golesvisitante = golesvisitante + 1;
                }
            }
            puntajeLocal.Text = goleslocal.ToString();
            puntajeVisitante.Text = golesvisitante.ToString();

            //Generar tabla

            registroTable.Rows.Clear();
            // Defino las columnas de la tabla
            registroTable.ColumnCount = 5;
            registroTable.Columns[0].Name = "id";
            registroTable.Columns[0].Visible = false;
            registroTable.Columns[1].Name = "Tipo";
            registroTable.Columns[2].Name = "Equipo";
            registroTable.Columns[3].Name = "Detalle";
            registroTable.Columns[3].Width = 250;
            registroTable.Columns[4].Name = "Minuto";
            registroTable.Columns[4].Width = 50;
            registroTable.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            List<string[]> lista = new List<string[]>();

            foreach (Goles g in goles)
            {
                string[] row = { g.Id.ToString(), "Gol", g.Equipo.Nombre, "Por "+g.Jugador.Nombre + " " + g.Jugador.Apellido + "("+ g.Jugador.Apodo + ")",g.Minuto.ToString()};
                lista.Add(row);
            }
            foreach (TarjetaJugador t in tarjetas)
            {
                string[] row = { t.Id.ToString(), "Tarjeta", t.Jugador.Equipo.Nombre, t.Tarjeta.Nombre + " para " + t.Jugador.Nombre + " [" + t.Jugador.Apodo + "]", t.Minuto.ToString() };
                lista.Add(row);
            }
            foreach (CambiosEncuentro t in cambios)
            {
                string[] row = { t.Id.ToString(), "Cambio", t.JugadorEntrante.Equipo.Nombre, t.JugadorSaliente.NumeroCamiseta.ToString()+" ["+t.JugadorSaliente.Apodo+"]"+ " <=> "+t.JugadorEntrante.NumeroCamiseta.ToString()+" ["+t.JugadorEntrante.Apodo+"]" , t.Minuto.ToString() };
                lista.Add(row);
            }
            List<string[]> ordenada = lista.OrderBy(o=>o[4]).ToList();
            foreach (string[] s in ordenada) {
                registroTable.Rows.Add(s);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            new fmGolAgregar(idencuentro).ShowDialog();
            generarTabla();
        }
    }
}
