namespace Vista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnModificarColectivo = new Button();
            btnBorrarColectivo = new Button();
            btnAgregarColectivo = new Button();
            txtPrecioBoletoColectivo = new TextBox();
            txtCantAsientos = new TextBox();
            txtPatente = new TextBox();
            txtLineaColectivo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnModificarPasajero = new Button();
            btnBorrarPasajero = new Button();
            btnAgregarPasajero = new Button();
            dateFechaNac = new DateTimePicker();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            grillaColectivos = new DataGridView();
            grillaPasajeros = new DataGridView();
            groupBox3 = new GroupBox();
            lblDocumento = new Label();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblPatente = new Label();
            lblLinea = new Label();
            btnVenderBoleto = new Button();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            btnFormularioColectivos = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaColectivos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaPasajeros).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnModificarColectivo);
            groupBox1.Controls.Add(btnBorrarColectivo);
            groupBox1.Controls.Add(btnAgregarColectivo);
            groupBox1.Controls.Add(txtPrecioBoletoColectivo);
            groupBox1.Controls.Add(txtCantAsientos);
            groupBox1.Controls.Add(txtPatente);
            groupBox1.Controls.Add(txtLineaColectivo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 230);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Colectivo";
            // 
            // btnModificarColectivo
            // 
            btnModificarColectivo.Location = new Point(204, 190);
            btnModificarColectivo.Name = "btnModificarColectivo";
            btnModificarColectivo.Size = new Size(92, 23);
            btnModificarColectivo.TabIndex = 12;
            btnModificarColectivo.Text = "Modificar";
            btnModificarColectivo.UseVisualStyleBackColor = true;
            btnModificarColectivo.Click += btnModificarColectivo_Click;
            // 
            // btnBorrarColectivo
            // 
            btnBorrarColectivo.Location = new Point(106, 190);
            btnBorrarColectivo.Name = "btnBorrarColectivo";
            btnBorrarColectivo.Size = new Size(92, 23);
            btnBorrarColectivo.TabIndex = 11;
            btnBorrarColectivo.Text = "Borrar";
            btnBorrarColectivo.UseVisualStyleBackColor = true;
            btnBorrarColectivo.Click += btnBorrarColectivo_Click;
            // 
            // btnAgregarColectivo
            // 
            btnAgregarColectivo.Location = new Point(14, 190);
            btnAgregarColectivo.Name = "btnAgregarColectivo";
            btnAgregarColectivo.Size = new Size(86, 23);
            btnAgregarColectivo.TabIndex = 8;
            btnAgregarColectivo.Text = "Agregar";
            btnAgregarColectivo.UseVisualStyleBackColor = true;
            btnAgregarColectivo.Click += btnAgregarColectivo_Click;
            // 
            // txtPrecioBoletoColectivo
            // 
            txtPrecioBoletoColectivo.Location = new Point(100, 144);
            txtPrecioBoletoColectivo.Name = "txtPrecioBoletoColectivo";
            txtPrecioBoletoColectivo.Size = new Size(100, 23);
            txtPrecioBoletoColectivo.TabIndex = 7;
            // 
            // txtCantAsientos
            // 
            txtCantAsientos.Location = new Point(100, 105);
            txtCantAsientos.Name = "txtCantAsientos";
            txtCantAsientos.Size = new Size(100, 23);
            txtCantAsientos.TabIndex = 6;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(100, 69);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(100, 23);
            txtPatente.TabIndex = 5;
            // 
            // txtLineaColectivo
            // 
            txtLineaColectivo.Location = new Point(100, 35);
            txtLineaColectivo.Name = "txtLineaColectivo";
            txtLineaColectivo.Size = new Size(100, 23);
            txtLineaColectivo.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 152);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 3;
            label4.Text = "Precio boleto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 113);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Asientos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 77);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Patente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 38);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Linea:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnModificarPasajero);
            groupBox2.Controls.Add(btnBorrarPasajero);
            groupBox2.Controls.Add(btnAgregarPasajero);
            groupBox2.Controls.Add(dateFechaNac);
            groupBox2.Controls.Add(txtDni);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(24, 247);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 227);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pasajero";
            // 
            // btnModificarPasajero
            // 
            btnModificarPasajero.Location = new Point(202, 189);
            btnModificarPasajero.Name = "btnModificarPasajero";
            btnModificarPasajero.Size = new Size(92, 23);
            btnModificarPasajero.TabIndex = 10;
            btnModificarPasajero.Text = "Modificar";
            btnModificarPasajero.UseVisualStyleBackColor = true;
            btnModificarPasajero.Click += btnModificarPasajero_Click;
            // 
            // btnBorrarPasajero
            // 
            btnBorrarPasajero.Location = new Point(106, 189);
            btnBorrarPasajero.Name = "btnBorrarPasajero";
            btnBorrarPasajero.Size = new Size(92, 23);
            btnBorrarPasajero.TabIndex = 9;
            btnBorrarPasajero.Text = "Borrar";
            btnBorrarPasajero.UseVisualStyleBackColor = true;
            btnBorrarPasajero.Click += btnBorrarPasajero_Click;
            // 
            // btnAgregarPasajero
            // 
            btnAgregarPasajero.Location = new Point(14, 189);
            btnAgregarPasajero.Name = "btnAgregarPasajero";
            btnAgregarPasajero.Size = new Size(86, 23);
            btnAgregarPasajero.TabIndex = 8;
            btnAgregarPasajero.Text = "Agregar";
            btnAgregarPasajero.UseVisualStyleBackColor = true;
            btnAgregarPasajero.Click += btnAgregarPasajero_Click;
            // 
            // dateFechaNac
            // 
            dateFechaNac.Location = new Point(98, 140);
            dateFechaNac.Name = "dateFechaNac";
            dateFechaNac.Size = new Size(127, 23);
            dateFechaNac.TabIndex = 7;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(98, 101);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(98, 69);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(98, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 148);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 3;
            label8.Text = "Fecha Nac:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 109);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 2;
            label7.Text = "Dni:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 77);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 1;
            label6.Text = "Apellido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 46);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 0;
            label5.Text = "Nombre:";
            // 
            // grillaColectivos
            // 
            grillaColectivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaColectivos.Location = new Point(407, 18);
            grillaColectivos.Name = "grillaColectivos";
            grillaColectivos.Size = new Size(382, 150);
            grillaColectivos.TabIndex = 2;
            grillaColectivos.CellClick += grillaColectivos_CellClick;
            // 
            // grillaPasajeros
            // 
            grillaPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaPasajeros.Location = new Point(407, 180);
            grillaPasajeros.Name = "grillaPasajeros";
            grillaPasajeros.Size = new Size(382, 150);
            grillaPasajeros.TabIndex = 3;
            grillaPasajeros.CellClick += grillaPasajeros_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblDocumento);
            groupBox3.Controls.Add(lblNombre);
            groupBox3.Controls.Add(lblPrecio);
            groupBox3.Controls.Add(lblPatente);
            groupBox3.Controls.Add(lblLinea);
            groupBox3.Controls.Add(btnVenderBoleto);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(407, 344);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(382, 226);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Vender Boleto";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(96, 201);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(0, 15);
            lblDocumento.TabIndex = 12;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(97, 175);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 15);
            lblNombre.TabIndex = 11;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(77, 118);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(0, 15);
            lblPrecio.TabIndex = 10;
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(77, 92);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(0, 15);
            lblPatente.TabIndex = 9;
            // 
            // lblLinea
            // 
            lblLinea.AutoSize = true;
            lblLinea.Location = new Point(77, 64);
            lblLinea.Name = "lblLinea";
            lblLinea.Size = new Size(0, 15);
            lblLinea.TabIndex = 8;
            // 
            // btnVenderBoleto
            // 
            btnVenderBoleto.Location = new Point(238, 193);
            btnVenderBoleto.Name = "btnVenderBoleto";
            btnVenderBoleto.Size = new Size(119, 23);
            btnVenderBoleto.TabIndex = 7;
            btnVenderBoleto.Text = "Vender";
            btnVenderBoleto.UseVisualStyleBackColor = true;
            btnVenderBoleto.Click += btnVenderBoleto_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(14, 118);
            label15.Name = "label15";
            label15.Size = new Size(43, 15);
            label15.TabIndex = 6;
            label15.Text = "Precio:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(14, 202);
            label14.Name = "label14";
            label14.Size = new Size(73, 15);
            label14.TabIndex = 5;
            label14.Text = "Documento:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(14, 175);
            label13.Name = "label13";
            label13.Size = new Size(54, 15);
            label13.TabIndex = 4;
            label13.Text = "Nombre:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 151);
            label12.Name = "label12";
            label12.Size = new Size(123, 15);
            label12.TabIndex = 3;
            label12.Text = "Pasajero seleccionado";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 92);
            label11.Name = "label11";
            label11.Size = new Size(50, 15);
            label11.TabIndex = 2;
            label11.Text = "Patente:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 64);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 1;
            label10.Text = "Linea:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 35);
            label9.Name = "label9";
            label9.Size = new Size(129, 15);
            label9.TabIndex = 0;
            label9.Text = "Colectivo seleccionado";
            // 
            // btnFormularioColectivos
            // 
            btnFormularioColectivos.Location = new Point(239, 545);
            btnFormularioColectivos.Name = "btnFormularioColectivos";
            btnFormularioColectivos.Size = new Size(152, 23);
            btnFormularioColectivos.TabIndex = 5;
            btnFormularioColectivos.Text = "Ver Boletos Vendidos";
            btnFormularioColectivos.UseVisualStyleBackColor = true;
            btnFormularioColectivos.Click += btnFormularioColectivos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 580);
            Controls.Add(btnFormularioColectivos);
            Controls.Add(groupBox3);
            Controls.Add(grillaPasajeros);
            Controls.Add(grillaColectivos);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaColectivos).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaPasajeros).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Button btnAgregarColectivo;
        private TextBox txtPrecioBoletoColectivo;
        private TextBox txtCantAsientos;
        private TextBox txtPatente;
        private TextBox txtLineaColectivo;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnAgregarPasajero;
        private DateTimePicker dateFechaNac;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        public DataGridView grillaColectivos;
        public DataGridView grillaPasajeros;
        private Button btnModificarPasajero;
        private Button btnBorrarPasajero;
        private Button btnModificarColectivo;
        private Button btnBorrarColectivo;
        private GroupBox groupBox3;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label lblDocumento;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblPatente;
        private Label lblLinea;
        private Button btnVenderBoleto;
        private Label label15;
        private Button btnFormularioColectivos;
    }
}
