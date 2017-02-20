namespace Alquiler.Navegacion
{
    partial class Alquiler
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.cbVehiculo = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardarNormal = new System.Windows.Forms.Button();
            this.btnBuscarNormal = new System.Windows.Forms.Button();
            this.btnModificarNormal = new System.Windows.Forms.Button();
            this.btnEliminarNormal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vehiculo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(108, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(145, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(107, 55);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(164, 21);
            this.cbUsuario.TabIndex = 5;
            // 
            // cbVehiculo
            // 
            this.cbVehiculo.FormattingEnabled = true;
            this.cbVehiculo.Location = new System.Drawing.Point(108, 90);
            this.cbVehiculo.Name = "cbVehiculo";
            this.cbVehiculo.Size = new System.Drawing.Size(163, 21);
            this.cbVehiculo.TabIndex = 6;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(108, 118);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(163, 20);
            this.dtpFecha.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(341, 48);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(461, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(341, 90);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(461, 90);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(425, 133);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardarNormal
            // 
            this.btnGuardarNormal.Location = new System.Drawing.Point(33, 168);
            this.btnGuardarNormal.Name = "btnGuardarNormal";
            this.btnGuardarNormal.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarNormal.TabIndex = 14;
            this.btnGuardarNormal.Text = "Guar-Nor";
            this.btnGuardarNormal.UseVisualStyleBackColor = true;
            this.btnGuardarNormal.Click += new System.EventHandler(this.btnGuardarNormal_Click);
            // 
            // btnBuscarNormal
            // 
            this.btnBuscarNormal.Location = new System.Drawing.Point(114, 168);
            this.btnBuscarNormal.Name = "btnBuscarNormal";
            this.btnBuscarNormal.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarNormal.TabIndex = 15;
            this.btnBuscarNormal.Text = "Buscar-Nor";
            this.btnBuscarNormal.UseVisualStyleBackColor = true;
            this.btnBuscarNormal.Click += new System.EventHandler(this.btnBuscarNormal_Click);
            // 
            // btnModificarNormal
            // 
            this.btnModificarNormal.Location = new System.Drawing.Point(195, 168);
            this.btnModificarNormal.Name = "btnModificarNormal";
            this.btnModificarNormal.Size = new System.Drawing.Size(75, 23);
            this.btnModificarNormal.TabIndex = 16;
            this.btnModificarNormal.Text = "Mod-Nom";
            this.btnModificarNormal.UseVisualStyleBackColor = true;
            this.btnModificarNormal.Click += new System.EventHandler(this.btnModificarNormal_Click);
            // 
            // btnEliminarNormal
            // 
            this.btnEliminarNormal.Location = new System.Drawing.Point(276, 168);
            this.btnEliminarNormal.Name = "btnEliminarNormal";
            this.btnEliminarNormal.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarNormal.TabIndex = 17;
            this.btnEliminarNormal.Text = "Elim-Nomb";
            this.btnEliminarNormal.UseVisualStyleBackColor = true;
            this.btnEliminarNormal.Click += new System.EventHandler(this.btnEliminarNormal_Click);
            // 
            // Alquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 404);
            this.Controls.Add(this.btnEliminarNormal);
            this.Controls.Add(this.btnModificarNormal);
            this.Controls.Add(this.btnBuscarNormal);
            this.Controls.Add(this.btnGuardarNormal);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cbVehiculo);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Alquiler";
            this.Text = "Alquiler";
            this.Load += new System.EventHandler(this.Alquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.ComboBox cbVehiculo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardarNormal;
        private System.Windows.Forms.Button btnBuscarNormal;
        private System.Windows.Forms.Button btnModificarNormal;
        private System.Windows.Forms.Button btnEliminarNormal;
    }
}