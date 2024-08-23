using Controladora;
using Modelo;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;

namespace Vista
{
    public partial class Form1 : Form
    {
        GestorColectivo instanciaGestorColectivo = GestorColectivo.Instancia;
        GestorPasajero instanciaGestorPasajero = GestorPasajero.Instancia;
        RepositorioPasajero instanciaRepoPasajero = RepositorioPasajero.Instancia;
        RepositorioColectivo instanciaRepoColectivo = RepositorioColectivo.Instancia;
        RepositorioBoletos instanciaRepoBoleto = RepositorioBoletos.Instancia;
        Colectivo nuevoColectivo;
        Pasajero nuevoPasajero;

        int seleccionadoGrillaPasajero = -1;
        Pasajero pasajeroSeleccionado;
        int seleccionadoGrillaColectivo = -1;
        Colectivo colectivoSeleccionado;

        public Form1()
        {
            InitializeComponent();
        }
        private void btnFormularioColectivos_Click(object sender, EventArgs e)
        {
            FormBoletosVendidos form = new FormBoletosVendidos(instanciaRepoColectivo, instanciaRepoBoleto);
            form.ShowDialog();
        }

        // ******************* COLECTIVO *************************
        private void btnAgregarColectivo_Click(object sender, EventArgs e)
        {
            if (ValidarCamposColectivo())
            {
                nuevoColectivo = new Colectivo();
                nuevoColectivo.Linea = txtLineaColectivo.Text;
                nuevoColectivo.Patente = txtPatente.Text;
                nuevoColectivo.Asientos = Convert.ToInt32(txtCantAsientos.Text);
                nuevoColectivo.PrecioBoleto = Convert.ToInt32(txtPrecioBoletoColectivo.Text);

                var resultado = instanciaGestorColectivo.AgregarColectivo(nuevoColectivo, instanciaRepoColectivo);
                MessageBox.Show(resultado, "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrillaColectivo();
            }
        }

        private void btnBorrarColectivo_Click(object sender, EventArgs e)
        {
            if (seleccionadoGrillaColectivo != -1)
            {
                DialogResult r = MessageBox.Show("Desea eliminar este colectivo?", "Eliminar", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    var resultado = instanciaGestorColectivo.EliminarColectivo(colectivoSeleccionado, instanciaRepoColectivo);
                    MessageBox.Show(resultado, "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrillaColectivo();
                }
            }
        }

        private void btnModificarColectivo_Click(object sender, EventArgs e)
        {
            if (seleccionadoGrillaColectivo != -1)
            {
                DialogResult r = MessageBox.Show("Desea modificar este colectivo?", "Modificar", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    colectivoSeleccionado.Linea = txtLineaColectivo.Text;
                    colectivoSeleccionado.Patente = txtPatente.Text;
                    colectivoSeleccionado.Asientos = Convert.ToInt32(txtCantAsientos.Text);
                    colectivoSeleccionado.PrecioBoleto = Convert.ToInt32(txtPrecioBoletoColectivo.Text);

                    var resultado = instanciaGestorColectivo.ModificarColectivo(colectivoSeleccionado, instanciaRepoColectivo);
                    MessageBox.Show(resultado, "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrillaColectivo();
                }
            }
        }

        private void btnVenderBoleto_Click(object sender, EventArgs e)
        {
            if (seleccionadoGrillaColectivo != -1 && seleccionadoGrillaPasajero != -1)
            {
                DialogResult r = MessageBox.Show("Vender boleto?", "Venta", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    var resultado = instanciaGestorColectivo.VenderBoleto(pasajeroSeleccionado, colectivoSeleccionado, instanciaRepoBoleto);
                    MessageBox.Show(resultado, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        // ******************** PASAJERO ***************************
        private void btnAgregarPasajero_Click(object sender, EventArgs e)
        {
            if (ValidarCamposPasajero())
            {
                nuevoPasajero = new Pasajero();
                nuevoPasajero.Nombre = txtNombre.Text;
                nuevoPasajero.Apellido = txtApellido.Text;
                nuevoPasajero.Dni = Convert.ToInt32(txtDni.Text);
                nuevoPasajero.FechaNacimiento = dateFechaNac.Value;

                var resultado = instanciaGestorPasajero.AgregarPasajero(nuevoPasajero, instanciaRepoPasajero);
                MessageBox.Show(resultado, "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrillaPasajero();
            }
        }
        private void btnBorrarPasajero_Click(object sender, EventArgs e)
        {
            if (seleccionadoGrillaPasajero != -1)
            {
                DialogResult r = MessageBox.Show("Desea eliminar este pasajero?", "Eliminar", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    var resultado = instanciaGestorPasajero.EliminarPasajero(pasajeroSeleccionado, instanciaRepoPasajero);
                    MessageBox.Show(resultado, "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrillaPasajero();
                }
            }
        }

        private void btnModificarPasajero_Click(object sender, EventArgs e)
        {
            if (seleccionadoGrillaPasajero != -1)
            {
                DialogResult r = MessageBox.Show("Desea modificar este pasajero?", "Modificar", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    pasajeroSeleccionado.Nombre = txtNombre.Text;
                    pasajeroSeleccionado.Apellido = txtApellido.Text;
                    pasajeroSeleccionado.Dni = Convert.ToInt32(txtDni.Text);
                    pasajeroSeleccionado.FechaNacimiento = dateFechaNac.Value;

                    var resultado = instanciaGestorPasajero.ModificarPasajero(pasajeroSeleccionado, instanciaRepoPasajero);
                    MessageBox.Show(resultado, "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrillaPasajero();
                }
            }
        }


        // ***************************** GRILLAS ****************************
        public void CargarGrillaColectivo()
        {
            grillaColectivos.DataSource = null;
            grillaColectivos.DataSource = instanciaRepoColectivo.Colectivos;
        }
        public void CargarGrillaPasajero()
        {
            grillaPasajeros.DataSource = null;
            grillaPasajeros.DataSource = instanciaRepoPasajero.Pasajeros;
        }

        private void grillaPasajeros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionadoGrillaPasajero = e.RowIndex;
            pasajeroSeleccionado = instanciaRepoPasajero.Pasajeros[seleccionadoGrillaPasajero];

            txtNombre.Text = instanciaRepoPasajero.Pasajeros[seleccionadoGrillaPasajero].Nombre;
            txtApellido.Text = instanciaRepoPasajero.Pasajeros[seleccionadoGrillaPasajero].Apellido;
            txtDni.Text = instanciaRepoPasajero.Pasajeros[seleccionadoGrillaPasajero].Dni.ToString();
            dateFechaNac.Value = instanciaRepoPasajero.Pasajeros[seleccionadoGrillaPasajero].FechaNacimiento;

            lblNombre.Text = instanciaRepoPasajero.Pasajeros[seleccionadoGrillaPasajero].Nombre;
            lblDocumento.Text = instanciaRepoPasajero.Pasajeros[seleccionadoGrillaPasajero].Dni.ToString();
        }

        private void grillaColectivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionadoGrillaColectivo = e.RowIndex;
            colectivoSeleccionado = instanciaRepoColectivo.Colectivos[seleccionadoGrillaColectivo];

            txtLineaColectivo.Text = instanciaRepoColectivo.Colectivos[seleccionadoGrillaColectivo].Linea;
            txtPatente.Text = instanciaRepoColectivo.Colectivos[seleccionadoGrillaColectivo].Patente;
            txtCantAsientos.Text = instanciaRepoColectivo.Colectivos[seleccionadoGrillaColectivo].Asientos.ToString();
            txtPrecioBoletoColectivo.Text = instanciaRepoColectivo.Colectivos[seleccionadoGrillaColectivo].PrecioBoleto.ToString();

            lblLinea.Text = instanciaRepoColectivo.Colectivos[seleccionadoGrillaColectivo].Linea;
            lblPatente.Text = instanciaRepoColectivo.Colectivos[seleccionadoGrillaColectivo].Patente;
            lblPrecio.Text = instanciaRepoColectivo.Colectivos[seleccionadoGrillaColectivo].PrecioBoleto.ToString();
        }


        // *************************** VALIDACIONES CAMPOS ******************************

        private bool ValidarCamposPasajero()
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El campo 'Apellido' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return false;
            }

            // Validar que el DNI no este vacio y sea un numero entero valido
            if (string.IsNullOrWhiteSpace(txtDni.Text) || !int.TryParse(txtDni.Text, out _))
            {
                MessageBox.Show("El campo 'DNI' es obligatorio y debe ser un numero valido.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDni.Focus();
                return false;
            }

            return true;
        }

        private bool ValidarCamposColectivo()
        {

            if (string.IsNullOrWhiteSpace(txtLineaColectivo.Text))
            {
                MessageBox.Show("El campo 'Línea' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLineaColectivo.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtPatente.Text))
            {
                MessageBox.Show("El campo 'Patente' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPatente.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCantAsientos.Text) || !int.TryParse(txtCantAsientos.Text, out _))
            {
                MessageBox.Show("El campo 'Cantidad de Asientos' es obligatorio y debe ser un numero valido.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantAsientos.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecioBoletoColectivo.Text) || !decimal.TryParse(txtPrecioBoletoColectivo.Text, out _))
            {
                MessageBox.Show("El campo 'Precio del Boleto' es obligatorio y debe ser un numero valido.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioBoletoColectivo.Focus();
                return false;
            }

            return true;
        }
    }
}
