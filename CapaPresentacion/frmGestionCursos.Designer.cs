namespace SistemaGestionCursos.CapaPresentacion
{
    partial class frmGestionCursos
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
            this.nombre = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.HorasTotal = new System.Windows.Forms.Label();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.txtDescripcionCurso = new System.Windows.Forms.TextBox();
            this.txtCreditosCurso = new System.Windows.Forms.TextBox();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.btnAgregarCurso = new System.Windows.Forms.Button();
            this.btnActualizarCurso = new System.Windows.Forms.Button();
            this.btnEliminarCurso = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Cursos";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.Color.White;
            this.nombre.Location = new System.Drawing.Point(12, 43);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(71, 26);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "Nombre del\r\n    Curso";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.ForeColor = System.Drawing.Color.White;
            this.Descripcion.Location = new System.Drawing.Point(10, 96);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(95, 26);
            this.Descripcion.TabIndex = 2;
            this.Descripcion.Text = "Descripción del\r\n        Curso";
            // 
            // HorasTotal
            // 
            this.HorasTotal.AutoSize = true;
            this.HorasTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HorasTotal.ForeColor = System.Drawing.Color.White;
            this.HorasTotal.Location = new System.Drawing.Point(12, 148);
            this.HorasTotal.Name = "HorasTotal";
            this.HorasTotal.Size = new System.Drawing.Size(75, 13);
            this.HorasTotal.TabIndex = 3;
            this.HorasTotal.Text = "Horas Clase";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreCurso.Location = new System.Drawing.Point(102, 46);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(200, 20);
            this.txtNombreCurso.TabIndex = 4;
            // 
            // txtDescripcionCurso
            // 
            this.txtDescripcionCurso.Location = new System.Drawing.Point(102, 96);
            this.txtDescripcionCurso.Name = "txtDescripcionCurso";
            this.txtDescripcionCurso.Size = new System.Drawing.Size(200, 20);
            this.txtDescripcionCurso.TabIndex = 5;
            // 
            // txtCreditosCurso
            // 
            this.txtCreditosCurso.Location = new System.Drawing.Point(102, 146);
            this.txtCreditosCurso.Name = "txtCreditosCurso";
            this.txtCreditosCurso.Size = new System.Drawing.Size(80, 20);
            this.txtCreditosCurso.TabIndex = 6;
            // 
            // dgvCursos
            // 
            this.dgvCursos.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(308, 9);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(383, 178);
            this.dgvCursos.TabIndex = 7;
            // 
            // btnAgregarCurso
            // 
            this.btnAgregarCurso.BackColor = System.Drawing.Color.Black;
            this.btnAgregarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCurso.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCurso.Location = new System.Drawing.Point(30, 196);
            this.btnAgregarCurso.Name = "btnAgregarCurso";
            this.btnAgregarCurso.Size = new System.Drawing.Size(75, 34);
            this.btnAgregarCurso.TabIndex = 8;
            this.btnAgregarCurso.Text = "Agregar Curso";
            this.btnAgregarCurso.UseVisualStyleBackColor = false;
            this.btnAgregarCurso.Click += new System.EventHandler(this.btnAgregarCurso_Click);
            // 
            // btnActualizarCurso
            // 
            this.btnActualizarCurso.BackColor = System.Drawing.Color.Black;
            this.btnActualizarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCurso.ForeColor = System.Drawing.Color.White;
            this.btnActualizarCurso.Location = new System.Drawing.Point(122, 196);
            this.btnActualizarCurso.Name = "btnActualizarCurso";
            this.btnActualizarCurso.Size = new System.Drawing.Size(75, 34);
            this.btnActualizarCurso.TabIndex = 9;
            this.btnActualizarCurso.Text = "Actualizar Curso";
            this.btnActualizarCurso.UseVisualStyleBackColor = false;
            this.btnActualizarCurso.Click += new System.EventHandler(this.btnActualizarCurso_Click);
            // 
            // btnEliminarCurso
            // 
            this.btnEliminarCurso.BackColor = System.Drawing.Color.Black;
            this.btnEliminarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCurso.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCurso.Location = new System.Drawing.Point(215, 196);
            this.btnEliminarCurso.Name = "btnEliminarCurso";
            this.btnEliminarCurso.Size = new System.Drawing.Size(75, 34);
            this.btnEliminarCurso.TabIndex = 10;
            this.btnEliminarCurso.Text = "Eliminar Curso";
            this.btnEliminarCurso.UseVisualStyleBackColor = false;
            this.btnEliminarCurso.Click += new System.EventHandler(this.btnEliminarCurso_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.Black;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(308, 196);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(75, 35);
            this.btnLimpiarCampos.TabIndex = 11;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // frmGestionCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(710, 259);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnEliminarCurso);
            this.Controls.Add(this.btnActualizarCurso);
            this.Controls.Add(this.btnAgregarCurso);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.txtCreditosCurso);
            this.Controls.Add(this.txtDescripcionCurso);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.HorasTotal);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmGestionCursos";
            this.Text = "frmGestionCursos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label HorasTotal;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.TextBox txtDescripcionCurso;
        private System.Windows.Forms.TextBox txtCreditosCurso;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnAgregarCurso;
        private System.Windows.Forms.Button btnActualizarCurso;
        private System.Windows.Forms.Button btnEliminarCurso;
        private System.Windows.Forms.Button btnLimpiarCampos;
    }
}