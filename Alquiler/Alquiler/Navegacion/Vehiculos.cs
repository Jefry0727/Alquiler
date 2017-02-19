
using Alquiler.Resources;
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
    public partial class Vehiculos : Form
    {

        LinkedList<marca> marca;
        ClsMarca clsMarc;
        ClsVehiculo clsVehi;
        int aux = 0;
        
        public Vehiculos()
        {
            InitializeComponent();
            clsMarc = new ClsMarca();
            clsVehi = new ClsVehiculo();
            marca = new LinkedList<marca>();
            marca = clsMarc.buscarMarca();
            llenarComboMarca();
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {

        }

        public void llenarComboMarca()
        {

            LinkedList<marca> lista = clsMarc.buscarMarca();
            BindingList<Item> deptos = new BindingList<Item>();
            deptos.Add(new Item("Seleccione un marca",0));

            for (int i = 0; i < lista.Count; i++)
            {
                deptos.Add(new Item((lista.ElementAt(i)).nombre, (lista.ElementAt(i)).id));

            }

            cbMarca.DisplayMember = "Name";
            cbMarca.ValueMember = "Value";
            cbMarca.DataSource = deptos;
          
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String placa = txtPlaca.Text;

            int puestos = Convert.ToInt32((txtPuestos.Text == "" ? 0 : Convert.ToInt32(txtPuestos.Text)));

            int valor = Convert.ToInt32((txtValorDia.Text == "" ? 0 : Convert.ToInt32(txtValorDia.Text)));

            String color = txtColor.Text;

            Int32 idMarca = (Int32) cbMarca.SelectedValue;

            if (placa == "" || txtPuestos.Text == "" || txtValorDia.Text == "" || color == "" || idMarca == 0)
            {
                MessageBox.Show("Complete la informacion por favor.");
            }
            else
            {

                bool res = clsVehi.guardarPro(placa, puestos, valor, color, idMarca);

                if (res)
                {

                    limpiarCampos();
                    MessageBox.Show("Exito al guardar");

                }
                else
                {

                    MessageBox.Show("El Vehiculo de placas no se pudo guardar");

                }

            }

        }

        public void limpiarCampos(){

            txtPlaca.Text = "";

            txtPuestos.Text = "";

            txtValorDia.Text = "";

            txtColor.Text = "";

            cbMarca.SelectedValue = 0;
        
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            String placa = txtPlaca.Text;

            int puestos = Convert.ToInt32((txtPuestos.Text == "" ? 0 : Convert.ToInt32(txtPuestos.Text)));

            int valor = Convert.ToInt32((txtValorDia.Text == "" ? 0 : Convert.ToInt32(txtValorDia.Text)));

            String color = txtColor.Text;

            Int32 idMarca = (Int32)cbMarca.SelectedValue;

            if (placa == "" || txtPuestos.Text == "" || txtValorDia.Text == "" || color == "" || idMarca == 0)
            {
                MessageBox.Show("Complete la informacion por favor.");
            }
            else
            {

             bool res = clsVehi.modificarPro(aux, placa, puestos, valor, color, idMarca);

                if(res){

                    limpiarCampos();
                    MessageBox.Show("El vehículo se modifico correctamente");

                }
                else
                {

                    MessageBox.Show("El vehículo NO se modifico correctamente");

                }

            }

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {

            String placa = txtPlaca.Text;

            if (placa == "")
            {

                MessageBox.Show("Por favor ingresa el número de placa del Vehículo a buscar");

            }
            else
            {

                LinkedList<String> temp = new LinkedList<string>();

                temp = clsVehi.buscarPro(placa);

                if (temp == null)
                {

                    MessageBox.Show("El vehículo de placas: "+ placa+ " no existe");

                }
                else
                {

                    aux = Convert.ToInt32(temp.ElementAt(0));

                    txtPlaca.Text = temp.ElementAt(1);

                    cbMarca.SelectedValue = Convert.ToInt32(temp.ElementAt(4));

                    txtPuestos.Text = temp.ElementAt(2);

                    txtValorDia.Text = temp.ElementAt(3);

                    txtColor.Text = temp.ElementAt(5);

                    btnGuardar.Enabled = false;

                }
                       

            }

           

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if(aux == 0){


            }

           bool res = clsVehi.eliminarPro(aux);

            if(res){

                limpiarCampos();

                MessageBox.Show("El Vehículo se elimino correctamente");

            }
            else
            {

                MessageBox.Show("Ocurrio un error al eliminar el vehículo");
            }

        }

    }
}
