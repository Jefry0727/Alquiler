namespace Alquiler.Navegacion
{
    partial class Usuario
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.cbCiudadNac = new System.Windows.Forms.ComboBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.alquilerVehiculosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnVolver = new System.Windows.Forms.Button();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGuardarNormal = new System.Windows.Forms.Button();
            this.btnBuscarNormal = new System.Windows.Forms.Button();
            this.btnModificarNormal = new System.Windows.Forms.Button();
            this.btnEliminarNormal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgUsuario = new System.Windows.Forms.DataGridView();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerVehiculosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Genero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ciudad Nacimiento";
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Location = new System.Drawing.Point(437, 19);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(121, 21);
            this.cbTipoDocumento.TabIndex = 2;
            this.cbTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cbTipoDocumento_SelectedIndexChanged);
            // 
            // cbCiudadNac
            // 
            this.cbCiudadNac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCiudadNac.FormattingEnabled = true;
            this.cbCiudadNac.Location = new System.Drawing.Point(157, 78);
            this.cbCiudadNac.Name = "cbCiudadNac";
            this.cbCiudadNac.Size = new System.Drawing.Size(121, 21);
            this.cbCiudadNac.TabIndex = 5;
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(157, 114);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 7;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(157, 19);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(121, 20);
            this.txtDocumento.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(157, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(438, 46);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(121, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(438, 78);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(121, 20);
            this.txtEdad.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(329, 118);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 22);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(432, 118);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(329, 146);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(432, 146);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(524, 132);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardarNormal
            // 
            this.btnGuardarNormal.Location = new System.Drawing.Point(12, 146);
            this.btnGuardarNormal.Name = "btnGuardarNormal";
            this.btnGuardarNormal.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarNormal.TabIndex = 20;
            this.btnGuardarNormal.Text = "Guar-Nor";
            this.btnGuardarNormal.UseVisualStyleBackColor = true;
            this.btnGuardarNormal.Click += new System.EventHandler(this.btnGuardarNormal_Click);
            // 
            // btnBuscarNormal
            // 
            this.btnBuscarNormal.Location = new System.Drawing.Point(108, 146);
            this.btnBuscarNormal.Name = "btnBuscarNormal";
            this.btnBuscarNormal.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarNormal.TabIndex = 21;
            this.btnBuscarNormal.Text = "Busc-Nor";
            this.btnBuscarNormal.UseVisualStyleBackColor = true;
            this.btnBuscarNormal.Click += new System.EventHandler(this.btnBuscarNormal_Click);
            // 
            // btnModificarNormal
            // 
            this.btnModificarNormal.Location = new System.Drawing.Point(12, 176);
            this.btnModificarNormal.Name = "btnModificarNormal";
            this.btnModificarNormal.Size = new System.Drawing.Size(75, 23);
            this.btnModificarNormal.TabIndex = 22;
            this.btnModificarNormal.Text = "Mod-Nor";
            this.btnModificarNormal.UseVisualStyleBackColor = true;
            this.btnModificarNormal.Click += new System.EventHandler(this.btnModificarNormal_Click);
            // 
            // btnEliminarNormal
            // 
            this.btnEliminarNormal.Location = new System.Drawing.Point(108, 175);
            this.btnEliminarNormal.Name = "btnEliminarNormal";
            this.btnEliminarNormal.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarNormal.TabIndex = 23;
            this.btnEliminarNormal.Text = "Elim-Nor";
            this.btnEliminarNormal.UseVisualStyleBackColor = true;
            this.btnEliminarNormal.Click += new System.EventHandler(this.btnEliminarNormal_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgUsuario);
            this.panel1.Location = new System.Drawing.Point(42, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 165);
            this.panel1.TabIndex = 24;
            // 
            // dgUsuario
            // 
            this.dgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Documento,
            this.Nombre,
            this.TipoDocumento,
            this.Apellido,
            this.edad});
            this.dgUsuario.Location = new System.Drawing.Point(3, 12);
            this.dgUsuario.Name = "dgUsuario";
            this.dgUsuario.Size = new System.Drawing.Size(543, 137);
            this.dgUsuario.TabIndex = 0;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "TipoDocumento";
            this.TipoDocumento.Name = "TipoDocumento";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // edad
            // 
            this.edad.HeaderText = "edad";
            this.edad.Name = "edad";
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 398);
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
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.cbCiudadNac);
            this.Controls.Add(this.cbTipoDocumento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alquilerVehiculosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTipoDocumento;
        private System.Windows.Forms.ComboBox cbCiudadNac;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolver;
        private AlquilerVehiculosDataSet alquilerVehiculosDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private AlquilerVehiculosDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.BindingSource alquilerVehiculosDataSetBindingSource;
        private System.Windows.Forms.Button btnGuardarNormal;
        private System.Windows.Forms.Button btnBuscarNormal;
        private System.Windows.Forms.Button btnModificarNormal;
        private System.Windows.Forms.Button btnEliminarNormal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
    }
}