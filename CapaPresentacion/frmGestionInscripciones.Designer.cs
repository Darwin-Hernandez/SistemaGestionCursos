namespace SistemaGestionCursos.CapaPresentacion
{
    partial class frmGestionInscripciones
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstudiantes = new System.Windows.Forms.ComboBox();
            this.cmbCursos = new System.Windows.Forms.ComboBox();
            this.dgvInscripciones = new System.Windows.Forms.DataGridView();
            this.btnAgregarInscripcion = new System.Windows.Forms.Button();
            this.btnEliminarInscripcion = new System.Windows.Forms.Button();
            this.btnLimpiarCamposInscripcion = new System.Windows.Forms.Button();
            this.dtpFechaInscripcion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Inscripciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estudiante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Curso";
            // 
            // cmbEstudiantes
            // 
            this.cmbEstudiantes.FormattingEnabled = true;
            this.cmbEstudiantes.Location = new System.Drawing.Point(93, 56);
            this.cmbEstudiantes.Name = "cmbEstudiantes";
            this.cmbEstudiantes.Size = new System.Drawing.Size(121, 21);
            this.cmbEstudiantes.TabIndex = 3;
            // 
            // cmbCursos
            // 
            this.cmbCursos.FormattingEnabled = true;
            this.cmbCursos.Location = new System.Drawing.Point(93, 96);
            this.cmbCursos.Name = "cmbCursos";
            this.cmbCursos.Size = new System.Drawing.Size(121, 21);
            this.cmbCursos.TabIndex = 4;
            // 
            // dgvInscripciones
            // 
            this.dgvInscripciones.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripciones.Location = new System.Drawing.Point(299, 12);
            this.dgvInscripciones.Name = "dgvInscripciones";
            this.dgvInscripciones.Size = new System.Drawing.Size(437, 150);
            this.dgvInscripciones.TabIndex = 5;
            // 
            // btnAgregarInscripcion
            // 
            this.btnAgregarInscripcion.BackColor = System.Drawing.Color.Black;
            this.btnAgregarInscripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInscripcion.ForeColor = System.Drawing.Color.White;
            this.btnAgregarInscripcion.Location = new System.Drawing.Point(19, 190);
            this.btnAgregarInscripcion.Name = "btnAgregarInscripcion";
            this.btnAgregarInscripcion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAgregarInscripcion.Size = new System.Drawing.Size(83, 35);
            this.btnAgregarInscripcion.TabIndex = 6;
            this.btnAgregarInscripcion.Text = "Agregar Inscripción";
            this.btnAgregarInscripcion.UseVisualStyleBackColor = false;
            this.btnAgregarInscripcion.Click += new System.EventHandler(this.btnAgregarInscripcion_Click);
            // 
            // btnEliminarInscripcion
            // 
            this.btnEliminarInscripcion.BackColor = System.Drawing.Color.Black;
            this.btnEliminarInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarInscripcion.ForeColor = System.Drawing.Color.White;
            this.btnEliminarInscripcion.Location = new System.Drawing.Point(129, 189);
            this.btnEliminarInscripcion.Name = "btnEliminarInscripcion";
            this.btnEliminarInscripcion.Size = new System.Drawing.Size(85, 36);
            this.btnEliminarInscripcion.TabIndex = 7;
            this.btnEliminarInscripcion.Text = "Eliminar Inscripción";
            this.btnEliminarInscripcion.UseVisualStyleBackColor = false;
            this.btnEliminarInscripcion.Click += new System.EventHandler(this.btnEliminarInscripcion_Click);
            // 
            // btnLimpiarCamposInscripcion
            // 
            this.btnLimpiarCamposInscripcion.BackColor = System.Drawing.Color.Black;
            this.btnLimpiarCamposInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCamposInscripcion.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCamposInscripcion.Location = new System.Drawing.Point(225, 189);
            this.btnLimpiarCamposInscripcion.Name = "btnLimpiarCamposInscripcion";
            this.btnLimpiarCamposInscripcion.Size = new System.Drawing.Size(82, 36);
            this.btnLimpiarCamposInscripcion.TabIndex = 8;
            this.btnLimpiarCamposInscripcion.Text = "Limpiar Campos";
            this.btnLimpiarCamposInscripcion.UseVisualStyleBackColor = false;
            this.btnLimpiarCamposInscripcion.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // dtpFechaInscripcion
            // 
            this.dtpFechaInscripcion.Location = new System.Drawing.Point(93, 142);
            this.dtpFechaInscripcion.Name = "dtpFechaInscripcion";
            this.dtpFechaInscripcion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInscripcion.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Horas/Clase";
            // 
            // frmGestionInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(759, 258);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechaInscripcion);
            this.Controls.Add(this.btnLimpiarCamposInscripcion);
            this.Controls.Add(this.btnEliminarInscripcion);
            this.Controls.Add(this.btnAgregarInscripcion);
            this.Controls.Add(this.dgvInscripciones);
            this.Controls.Add(this.cmbCursos);
            this.Controls.Add(this.cmbEstudiantes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGestionInscripciones";
            this.Text = "frmGestionInscripciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEstudiantes;
        private System.Windows.Forms.ComboBox cmbCursos;
        private System.Windows.Forms.DataGridView dgvInscripciones;
        private System.Windows.Forms.Button btnAgregarInscripcion;
        private System.Windows.Forms.Button btnEliminarInscripcion;
        private System.Windows.Forms.Button btnLimpiarCamposInscripcion;
        private System.Windows.Forms.DateTimePicker dtpFechaInscripcion;
        private System.Windows.Forms.Label label4;
    }
}