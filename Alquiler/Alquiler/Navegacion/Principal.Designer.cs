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
            this.SuspendLayout();
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(37, 12);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnVehiculo
            // 
            this.btnVehiculo.Location = new System.Drawing.Point(37, 63);
            this.btnVehiculo.Name = "btnVehiculo";
            this.btnVehiculo.Size = new System.Drawing.Size(75, 23);
            this.btnVehiculo.TabIndex = 1;
            this.btnVehiculo.Text = "Vehiculos";
            this.btnVehiculo.UseVisualStyleBackColor = true;
            this.btnVehiculo.Click += new System.EventHandler(this.btnVehiculo_Click);
            // 
            // btnAsignarVehiculo
            // 
            this.btnAsignarVehiculo.Location = new System.Drawing.Point(13, 110);
            this.btnAsignarVehiculo.Name = "btnAsignarVehiculo";
            this.btnAsignarVehiculo.Size = new System.Drawing.Size(125, 23);
            this.btnAsignarVehiculo.TabIndex = 2;
            this.btnAsignarVehiculo.Text = "Asignar Vehiculos";
            this.btnAsignarVehiculo.UseVisualStyleBackColor = true;
            this.btnAsignarVehiculo.Click += new System.EventHandler(this.btnAsignarVehiculo_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(157, 157);
            this.Controls.Add(this.btnAsignarVehiculo);
            this.Controls.Add(this.btnVehiculo);
            this.Controls.Add(this.btnUsuario);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnVehiculo;
        private System.Windows.Forms.Button btnAsignarVehiculo;
    }
}