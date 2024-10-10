namespace SistemaGestionCursos.CapaPresentacion
{
    partial class frmGestionEstudiantes
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.txtApellidoEstudiante = new System.Windows.Forms.TextBox();
            this.txtCorreoEstudiante = new System.Windows.Forms.TextBox();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.btnAgregarEstudiante = new System.Windows.Forms.Button();
            this.btnActualizarEstudiante = new System.Windows.Forms.Button();
            this.btnEliminarEstudiante = new System.Windows.Forms.Button();
            this.btnLimpiarCamposEstudiantes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Estudiantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gmail";
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Location = new System.Drawing.Point(90, 46);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.Size = new System.Drawing.Size(170, 20);
            this.txtNombreEstudiante.TabIndex = 4;
            // 
            // txtApellidoEstudiante
            // 
            this.txtApellidoEstudiante.Location = new System.Drawing.Point(90, 85);
            this.txtApellidoEstudiante.Name = "txtApellidoEstudiante";
            this.txtApellidoEstudiante.Size = new System.Drawing.Size(170, 20);
            this.txtApellidoEstudiante.TabIndex = 5;
            // 
            // txtCorreoEstudiante
            // 
            this.txtCorreoEstudiante.Location = new System.Drawing.Point(90, 129);
            this.txtCorreoEstudiante.Name = "txtCorreoEstudiante";
            this.txtCorreoEstudiante.Size = new System.Drawing.Size(170, 20);
            this.txtCorreoEstudiante.TabIndex = 6;
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(287, 12);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.Size = new System.Drawing.Size(391, 150);
            this.dgvEstudiantes.TabIndex = 7;
            // 
            // btnAgregarEstudiante
            // 
            this.btnAgregarEstudiante.BackColor = System.Drawing.Color.Black;
            this.btnAgregarEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEstudiante.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEstudiante.Location = new System.Drawing.Point(13, 177);
            this.btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            this.btnAgregarEstudiante.Size = new System.Drawing.Size(75, 35);
            this.btnAgregarEstudiante.TabIndex = 8;
            this.btnAgregarEstudiante.Text = "Agregar Estudiante";
            this.btnAgregarEstudiante.UseVisualStyleBackColor = false;
            this.btnAgregarEstudiante.Click += new System.EventHandler(this.btnAgregarEstudiante_Click);
            // 
            // btnActualizarEstudiante
            // 
            this.btnActualizarEstudiante.BackColor = System.Drawing.Color.Black;
            this.btnActualizarEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEstudiante.ForeColor = System.Drawing.Color.White;
            this.btnActualizarEstudiante.Location = new System.Drawing.Point(110, 177);
            this.btnActualizarEstudiante.Name = "btnActualizarEstudiante";
            this.btnActualizarEstudiante.Size = new System.Drawing.Size(75, 36);
            this.btnActualizarEstudiante.TabIndex = 9;
            this.btnActualizarEstudiante.Text = "Actualizar Estudiante";
            this.btnActualizarEstudiante.UseVisualStyleBackColor = false;
            this.btnActualizarEstudiante.Click += new System.EventHandler(this.btnActualizarEstudiante_Click);
            // 
            // btnEliminarEstudiante
            // 
            this.btnEliminarEstudiante.BackColor = System.Drawing.Color.Black;
            this.btnEliminarEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEstudiante.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEstudiante.Location = new System.Drawing.Point(211, 177);
            this.btnEliminarEstudiante.Name = "btnEliminarEstudiante";
            this.btnEliminarEstudiante.Size = new System.Drawing.Size(75, 36);
            this.btnEliminarEstudiante.TabIndex = 10;
            this.btnEliminarEstudiante.Text = "Eliminar Estudiante";
            this.btnEliminarEstudiante.UseVisualStyleBackColor = false;
            this.btnEliminarEstudiante.Click += new System.EventHandler(this.btnEliminarEstudiante_Click);
            // 
            // btnLimpiarCamposEstudiantes
            // 
            this.btnLimpiarCamposEstudiantes.BackColor = System.Drawing.Color.Black;
            this.btnLimpiarCamposEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCamposEstudiantes.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCamposEstudiantes.Location = new System.Drawing.Point(310, 177);
            this.btnLimpiarCamposEstudiantes.Name = "btnLimpiarCamposEstudiantes";
            this.btnLimpiarCamposEstudiantes.Size = new System.Drawing.Size(75, 36);
            this.btnLimpiarCamposEstudiantes.TabIndex = 11;
            this.btnLimpiarCamposEstudiantes.Text = "Limpiar Campos";
            this.btnLimpiarCamposEstudiantes.UseVisualStyleBackColor = false;
            this.btnLimpiarCamposEstudiantes.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // frmGestionEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(694, 267);
            this.Controls.Add(this.btnLimpiarCamposEstudiantes);
            this.Controls.Add(this.btnEliminarEstudiante);
            this.Controls.Add(this.btnActualizarEstudiante);
            this.Controls.Add(this.btnAgregarEstudiante);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.txtCorreoEstudiante);
            this.Controls.Add(this.txtApellidoEstudiante);
            this.Controls.Add(this.txtNombreEstudiante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGestionEstudiantes";
            this.Text = "frmGestionEstudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.TextBox txtApellidoEstudiante;
        private System.Windows.Forms.TextBox txtCorreoEstudiante;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.Button btnAgregarEstudiante;
        private System.Windows.Forms.Button btnActualizarEstudiante;
        private System.Windows.Forms.Button btnEliminarEstudiante;
        private System.Windows.Forms.Button btnLimpiarCamposEstudiantes;
    }
}