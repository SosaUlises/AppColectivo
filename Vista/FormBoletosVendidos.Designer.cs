namespace Vista
{
    partial class FormBoletosVendidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbColectivos = new ComboBox();
            grillaColectivos = new DataGridView();
            grillaTodos = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)grillaColectivos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaTodos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 37);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar Colectivo:";
            // 
            // cmbColectivos
            // 
            cmbColectivos.FormattingEnabled = true;
            cmbColectivos.Location = new Point(184, 29);
            cmbColectivos.Name = "cmbColectivos";
            cmbColectivos.Size = new Size(185, 23);
            cmbColectivos.TabIndex = 1;
            cmbColectivos.SelectedIndexChanged += cmbColectivos_SelectedIndexChanged;
            // 
            // grillaColectivos
            // 
            grillaColectivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaColectivos.Location = new Point(29, 72);
            grillaColectivos.Name = "grillaColectivos";
            grillaColectivos.Size = new Size(373, 196);
            grillaColectivos.TabIndex = 2;
            // 
            // grillaTodos
            // 
            grillaTodos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaTodos.Location = new Point(29, 309);
            grillaTodos.Name = "grillaTodos";
            grillaTodos.Size = new Size(373, 196);
            grillaTodos.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 283);
            label2.Name = "label2";
            label2.Size = new Size(272, 15);
            label2.TabIndex = 4;
            label2.Text = "Todos los boletos vendidos de todos los colectivos";
            // 
            // FormBoletosVendidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 517);
            Controls.Add(label2);
            Controls.Add(grillaTodos);
            Controls.Add(grillaColectivos);
            Controls.Add(cmbColectivos);
            Controls.Add(label1);
            Name = "FormBoletosVendidos";
            Text = "FormBoletosVendidos";
            Load += FormBoletosVendidos_Load;
            ((System.ComponentModel.ISupportInitialize)grillaColectivos).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaTodos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbColectivos;
        private DataGridView grillaColectivos;
        private DataGridView grillaTodos;
        private Label label2;
    }
}