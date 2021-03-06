﻿namespace Alquiler.Navegacion
{
    partial class Vehiculos
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtPuestos = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtValorDia = new System.Windows.Forms.TextBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgVehiculo = new System.Windows.Forms.DataGridView();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroPuestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardarNormal = new System.Windows.Forms.Button();
            this.btnBuscarNormal = new System.Windows.Forms.Button();
            this.btnModificarNormal = new System.Windows.Forms.Button();
            this.btnEliminarNormal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVehiculo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puestos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor Dia";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(59, 9);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(131, 20);
            this.txtPlaca.TabIndex = 5;
            // 
            // txtPuestos
            // 
            this.txtPuestos.Location = new System.Drawing.Point(59, 35);
            this.txtPuestos.Name = "txtPuestos";
            this.txtPuestos.Size = new System.Drawing.Size(131, 20);
            this.txtPuestos.TabIndex = 6;
            this.txtPuestos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuestos_KeyPress);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(59, 62);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(131, 20);
            this.txtColor.TabIndex = 7;
            this.txtColor.TextChanged += new System.EventHandler(this.txtColor_TextChanged);
            this.txtColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColor_KeyPress);
            // 
            // txtValorDia
            // 
            this.txtValorDia.Location = new System.Drawing.Point(265, 42);
            this.txtValorDia.Name = "txtValorDia";
            this.txtValorDia.Size = new System.Drawing.Size(131, 20);
            this.txtValorDia.TabIndex = 8;
            this.txtValorDia.TextChanged += new System.EventHandler(this.txtValorDia_TextChanged);
            this.txtValorDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorDia_KeyPress);
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(264, 9);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(131, 21);
            this.cbMarca.TabIndex = 9;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(438, 26);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(541, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(438, 64);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(541, 64);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgVehiculo
            // 
            this.dgVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placa,
            this.numeroPuestos,
            this.color,
            this.valorDia,
            this.marcas});
            this.dgVehiculo.Location = new System.Drawing.Point(14, 13);
            this.dgVehiculo.Name = "dgVehiculo";
            this.dgVehiculo.Size = new System.Drawing.Size(537, 130);
            this.dgVehiculo.TabIndex = 14;
            // 
            // placa
            // 
            this.placa.HeaderText = "Placa";
            this.placa.Name = "placa";
            // 
            // numeroPuestos
            // 
            this.numeroPuestos.HeaderText = "Puestos";
            this.numeroPuestos.Name = "numeroPuestos";
            // 
            // color
            // 
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            // 
            // valorDia
            // 
            this.valorDia.HeaderText = "Valor";
            this.valorDia.Name = "valorDia";
            // 
            // marcas
            // 
            this.marcas.HeaderText = "Marca";
            this.marcas.Name = "marcas";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(541, 365);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardarNormal
            // 
            this.btnGuardarNormal.Location = new System.Drawing.Point(11, 130);
            this.btnGuardarNormal.Name = "btnGuardarNormal";
            this.btnGuardarNormal.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarNormal.TabIndex = 16;
            this.btnGuardarNormal.Text = "Guar-Nor";
            this.btnGuardarNormal.UseVisualStyleBackColor = true;
            this.btnGuardarNormal.Click += new System.EventHandler(this.btnGuardarNormal_Click);
            // 
            // btnBuscarNormal
            // 
            this.btnBuscarNormal.Location = new System.Drawing.Point(113, 130);
            this.btnBuscarNormal.Name = "btnBuscarNormal";
            this.btnBuscarNormal.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarNormal.TabIndex = 17;
            this.btnBuscarNormal.Text = "Busc-Norm";
            this.btnBuscarNormal.UseVisualStyleBackColor = true;
            this.btnBuscarNormal.Click += new System.EventHandler(this.btnBuscarNormal_Click);
            // 
            // btnModificarNormal
            // 
            this.btnModificarNormal.Location = new System.Drawing.Point(11, 159);
            this.btnModificarNormal.Name = "btnModificarNormal";
            this.btnModificarNormal.Size = new System.Drawing.Size(75, 23);
            this.btnModificarNormal.TabIndex = 18;
            this.btnModificarNormal.Text = "Mod-Norm";
            this.btnModificarNormal.UseVisualStyleBackColor = true;
            this.btnModificarNormal.Click += new System.EventHandler(this.btnModificarNormal_Click);
            // 
            // btnEliminarNormal
            // 
            this.btnEliminarNormal.Location = new System.Drawing.Point(113, 159);
            this.btnEliminarNormal.Name = "btnEliminarNormal";
            this.btnEliminarNormal.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarNormal.TabIndex = 19;
            this.btnEliminarNormal.Text = "Elimi-nom";
            this.btnEliminarNormal.UseVisualStyleBackColor = true;
            this.btnEliminarNormal.Click += new System.EventHandler(this.btnEliminarNormal_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPuestos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPlaca);
            this.panel1.Controls.Add(this.txtColor);
            this.panel1.Controls.Add(this.txtValorDia);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbMarca);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 106);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgVehiculo);
            this.panel2.Location = new System.Drawing.Point(12, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 160);
            this.panel2.TabIndex = 21;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(332, 144);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 401);
            this.Controls.Add(this.btnLimpiar);
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
            this.Name = "Vehiculos";
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.Vehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVehiculo)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtPuestos;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtValorDia;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgVehiculo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardarNormal;
        private System.Windows.Forms.Button btnBuscarNormal;
        private System.Windows.Forms.Button btnModificarNormal;
        private System.Windows.Forms.Button btnEliminarNormal;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLimpiar;
    }
}