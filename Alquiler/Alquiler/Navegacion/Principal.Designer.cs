namespace Alquiler.Navegacion
{
    partial class Principal
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
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnVehiculo = new System.Windows.Forms.Button();
            this.btnAsignarVehiculo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(15, 23);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnVehiculo
            // 
            this.btnVehiculo.Location = new System.Drawing.Point(153, 23);
            this.btnVehiculo.Name = "btnVehiculo";
            this.btnVehiculo.Size = new System.Drawing.Size(75, 23);
            this.btnVehiculo.TabIndex = 1;
            this.btnVehiculo.Text = "Vehiculos";
            this.btnVehiculo.UseVisualStyleBackColor = true;
            this.btnVehiculo.Click += new System.EventHandler(this.btnVehiculo_Click);
            // 
            // btnAsignarVehiculo
            // 
            this.btnAsignarVehiculo.Location = new System.Drawing.Point(58, 68);
            this.btnAsignarVehiculo.Name = "btnAsignarVehiculo";
            this.btnAsignarVehiculo.Size = new System.Drawing.Size(125, 23);
            this.btnAsignarVehiculo.TabIndex = 2;
            this.btnAsignarVehiculo.Text = "Asignar Vehiculos";
            this.btnAsignarVehiculo.UseVisualStyleBackColor = true;
            this.btnAsignarVehiculo.Click += new System.EventHandler(this.btnAsignarVehiculo_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAsignarVehiculo);
            this.panel1.Controls.Add(this.btnUsuario);
            this.panel1.Controls.Add(this.btnVehiculo);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 116);
            this.panel1.TabIndex = 3;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 121);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnVehiculo;
        private System.Windows.Forms.Button btnAsignarVehiculo;
        private System.Windows.Forms.Panel panel1;
    }
}