namespace pryEstructuraDeDatos
{
    partial class frmRepasoDeOperaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.lblEjemplo = new System.Windows.Forms.Label();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operacion a realizar en la base de datos";
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Items.AddRange(new object[] {
            "Diferencia",
            "Diferencia 2",
            "ORDEN 1",
            "ORDEN 2",
            "SEL. MULTIATRIBUTO POR CONVOLUCION 1",
            "SEL. MULTIATRIBUTO POR CONVOLUCION 2",
            "SEL. MULTIATRIBUTO POR INTERSECCION 1",
            "SEL. MULTIATRIBUTO POR INTERSECCION 2",
            "SELECCION SIMPLE 1",
            "SELECCION SIMPLE 2",
            "PROYECCION POR UN ATRIBUTO 1",
            "PROYECCION POR UN ATRIBUTO 2",
            "PROYECCION MULTIATRIBUTO 1",
            "PROYECCION MULTIATRIBUTO 2",
            "JUNTAR 1",
            "JUNTAR 2",
            "INTERSECCIÓN 1",
            "INTERSECCIÓN 2",
            "UNION 1",
            "UNION 2"});
            this.cmbOperacion.Location = new System.Drawing.Point(291, 12);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(351, 28);
            this.cmbOperacion.TabIndex = 1;
            // 
            // lblEjemplo
            // 
            this.lblEjemplo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEjemplo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjemplo.Location = new System.Drawing.Point(12, 55);
            this.lblEjemplo.Name = "lblEjemplo";
            this.lblEjemplo.Size = new System.Drawing.Size(776, 112);
            this.lblEjemplo.TabIndex = 2;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(12, 182);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(776, 256);
            this.dgvGrilla.TabIndex = 3;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(665, 12);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(123, 28);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // frmRepasoDeOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.lblEjemplo);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.label1);
            this.Name = "frmRepasoDeOperaciones";
            this.Text = "Repaso de Operaciones de Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Label lblEjemplo;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Button btnMostrar;
    }
}