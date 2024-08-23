using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormBoletosVendidos : Form
    {
        public RepositorioColectivo repositorioColectivos;
        public RepositorioBoletos repositorioBoletos;
        int seleccionado = -1;

        public FormBoletosVendidos()
        {
            InitializeComponent();
        }
        public FormBoletosVendidos(RepositorioColectivo repositorioColectivos, RepositorioBoletos repositorioBoletos)
        {
            InitializeComponent();
            this.repositorioColectivos = repositorioColectivos;
            this.repositorioBoletos = repositorioBoletos;
        }

        private void FormBoletosVendidos_Load(object sender, EventArgs e)
        {
            // Llenamos comboBox
            cmbColectivos.Items.Clear();
            foreach (var colectivo in repositorioColectivos.Colectivos)
            {
                cmbColectivos.Items.Add(colectivo);
            }

            CargarGrillaTodos();
        }

        public void CargarGrillaSeleccionado()
        {
            grillaColectivos.DataSource = null;
            grillaColectivos.DataSource = repositorioColectivos.Colectivos[seleccionado].Boletos;
        }

        private void cmbColectivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionado = cmbColectivos.SelectedIndex;
            CargarGrillaSeleccionado();
        }

        public void CargarGrillaTodos()
        {
            grillaTodos.DataSource = null;
            grillaTodos.DataSource = repositorioBoletos.Boletos;
        }
    }
}
