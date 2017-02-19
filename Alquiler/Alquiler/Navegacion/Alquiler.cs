﻿using Alquiler.Resources;
using Platform.Modeler.DAO;
using Platform.Modeler.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alquiler.Navegacion
{
    public partial class Alquiler : Form
    {
        ClsUsuario clsUsu;
        ClsVehiculo clsVehi;
        ClsAlquiler clsAlqui;
        public Alquiler()
        {
            InitializeComponent();
            
            clsUsu = new ClsUsuario();

            clsVehi = new ClsVehiculo();

            clsAlqui = new ClsAlquiler();

            llenarComboUsuario();

            llenarComboVehiculo();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Thread hiloInterfaz;
            hiloInterfaz = new System.Threading.Thread(new System.Threading.ThreadStart(abrirGestionPrincipal));
            this.Close();
            hiloInterfaz.SetApartmentState(System.Threading.ApartmentState.STA);
            hiloInterfaz.Start();
        }
        public void abrirGestionPrincipal()
        {
            Principal pri = new Principal();
            pri.ShowDialog();
        }

        public void llenarComboUsuario()
        {

            LinkedList<usuario> lista = clsUsu.listarUsuarios();
            BindingList<Item> usua = new BindingList<Item>();
            usua.Add(new Item("Seleccione un usuario", 0));

            for (int i = 0; i < lista.Count; i++)
            {
                usua.Add(new Item((lista.ElementAt(i)).nombre, (lista.ElementAt(i)).id));

            }

            cbUsuario.DisplayMember = "Name";
            cbUsuario.ValueMember = "Value";
            cbUsuario.DataSource = usua;

        }


        public void llenarComboVehiculo()
        {

            LinkedList<vehiculo> lista = clsVehi.listarVehiculo();
            BindingList<Item> vehi = new BindingList<Item>();
            vehi.Add(new Item("Seleccione un Vehiculo", 0));

            for (int i = 0; i < lista.Count; i++)
            {
                vehi.Add(new Item((lista.ElementAt(i)).placa, (lista.ElementAt(i)).id));

            }

            cbVehiculo.DisplayMember = "Name";
            cbVehiculo.ValueMember = "Value";
            cbVehiculo.DataSource = vehi;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            String codigo = txtCodigo.Text;
            
            Int32 idUsuario = (Int32) cbUsuario.SelectedValue;

            Int32 idVehiculo = (Int32)cbVehiculo.SelectedValue;

            String fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

            if (codigo == "" || idUsuario == 0 || idVehiculo == 0 )
            {

                MessageBox.Show("Complete la informacion por favor.");

            }
            else
            {

                bool res = clsAlqui.guardarPro(codigo, idUsuario, idVehiculo, fecha);

                if(res){

                    MessageBox.Show("El alquiler se realizo correctamente");
                }
                else
                {

                    MessageBox.Show("El alquiler NO se realizo correctamente");

                }

            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {



        }

    }
}
