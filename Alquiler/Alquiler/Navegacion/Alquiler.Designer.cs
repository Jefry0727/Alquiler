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
            this.dgAlquiler = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardarNormal = new System.Windows.Forms.Button();
            this.btnBuscarNormal = new System.Windows.Forms.Button();
            this.btnModificarNormal = new System.Windows.Forms.Button();
            this.btnEliminarNormal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlquiler)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vehiculo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(72, 7);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(145, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // cbUsuario
            // 
            this.cbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(71, 37);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(164, 21);
            this.cbUsuario.TabIndex = 5;
            // 
            // cbVehiculo
            // 
            this.cbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehiculo.FormattingEnabled = true;
            this.cbVehiculo.Location = new System.Drawing.Point(72, 72);
            this.cbVehiculo.Name = "cbVehiculo";
            this.cbVehiculo.Size = new System.Drawing.Size(163, 21);
            this.cbVehiculo.TabIndex = 6;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(72, 100);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(163, 20);
            this.dtpFecha.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(322, 77);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(415, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(322, 113);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(415, 113);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgAlquiler
            // 
            this.dgAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlquiler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.fecha,
            this.usuario,
            this.placa});
            this.dgAlquiler.Location = new System.Drawing.Point(3, 11);
            this.dgAlquiler.Name = "dgAlquiler";
            this.dgAlquiler.Size = new System.Drawing.Size(496, 142);
            this.dgAlquiler.TabIndex = 12;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha Alquiler";
            this.fecha.Name = "fecha";
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            // 
            // placa
            // 
            this.placa.HeaderText = "Placa Vehiculo";
            this.placa.Name = "placa";
            this.placa.Width = 150;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(444, 388);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardarNormal
            // 
            this.btnGuardarNormal.Location = new System.Drawing.Point(12, 157);
            this.btnGuardarNormal.Name = "btnGuardarNormal";
            this.btnGuardarNormal.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarNormal.TabIndex = 14;
            this.btnGuardarNormal.Text = "Guar-Nor";
            this.btnGuardarNormal.UseVisualStyleBackColor = true;
            this.btnGuardarNormal.Click += new System.EventHandler(this.btnGuardarNormal_Click);
            // 
            // btnBuscarNormal
            // 
            this.btnBuscarNormal.Location = new System.Drawing.Point(12, 186);
            this.btnBuscarNormal.Name = "btnBuscarNormal";
            this.btnBuscarNormal.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarNormal.TabIndex = 15;
            this.btnBuscarNormal.Text = "Buscar-Nor";
            this.btnBuscarNormal.UseVisualStyleBackColor = true;
            this.btnBuscarNormal.Click += new System.EventHandler(this.btnBuscarNormal_Click);
            // 
            // btnModificarNormal
            // 
            this.btnModificarNormal.Location = new System.Drawing.Point(120, 157);
            this.btnModificarNormal.Name = "btnModificarNormal";
            this.btnModificarNormal.Size = new System.Drawing.Size(75, 23);
            this.btnModificarNormal.TabIndex = 16;
            this.btnModificarNormal.Text = "Mod-Nom";
            this.btnModificarNormal.UseVisualStyleBackColor = true;
            this.btnModificarNormal.Click += new System.EventHandler(this.btnModificarNormal_Click);
            // 
            // btnEliminarNormal
            // 
            this.btnEliminarNormal.Location = new System.Drawing.Point(120, 186);
            this.btnEliminarNormal.Name = "btnEliminarNormal";
            this.btnEliminarNormal.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarNormal.TabIndex = 17;
            this.btnEliminarNormal.Text = "Elim-Nomb";
            this.btnEliminarNormal.UseVisualStyleBackColor = true;
            this.btnEliminarNormal.Click += new System.EventHandler(this.btnEliminarNormal_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbVehiculo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.cbUsuario);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 139);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dgAlquiler);
            this.panel2.Location = new System.Drawing.Point(12, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 167);
            this.panel2.TabIndex = 19;
            // 
            // Alquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 423);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminarNormal);
            this.Controls.Add(this.btnModificarNormal);
            this.Controls.Add(this.btnBuscarNormal);
            this.Controls.Add(this.btnGuardarNormal);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "Alquiler";
            this.Text = "Alquiler";
            this.Load += new System.EventHandler(this.Alquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlquiler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dgAlquiler;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardarNormal;
        private System.Windows.Forms.Button btnBuscarNormal;
        private System.Windows.Forms.Button btnModificarNormal;
        private System.Windows.Forms.Button btnEliminarNormal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}