
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
            llenarComboMarca();
            listarTabla();
            btnModificar.Enabled = false;
            btnModificarNormal.Enabled = false;
            btnEliminar.Enabled = false;
            btnEliminarNormal.Enabled = false;
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
            BindingList<Item> vehi = new BindingList<Item>();
            vehi.Add(new Item("Seleccione un marca", 0));

            for (int i = 0; i < lista.Count; i++)
            {
                vehi.Add(new Item((lista.ElementAt(i)).nombre, (lista.ElementAt(i)).id));

            }

            cbMarca.DisplayMember = "Name";
            cbMarca.ValueMember = "Value";
            cbMarca.DataSource = vehi;

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

            String color = txtColor.Text;

            Int32 idMarca = (Int32)cbMarca.SelectedValue;

            int puestos = 0;

            int valor = 0;

            try
            {

                LinkedList<String> temp = new LinkedList<string>();

                temp = clsVehi.buscarPro(placa);

                puestos = Convert.ToInt32((txtPuestos.Text == "" ? 0 : Convert.ToInt32(txtPuestos.Text)));

                valor = Convert.ToInt32((txtValorDia.Text == "" ? 0 : Convert.ToInt32(txtValorDia.Text)));

                if (temp != null)
                {

                    MessageBox.Show("El vehículo de placas: " + placa + " ya existe");

                }
                else if (placa == "" || txtPuestos.Text == "" || txtValorDia.Text == "" || color == "" || idMarca == 0
                    || puestos <= 0 || valor < 0)
                {
                    MessageBox.Show("Complete bien la informacion por favor.");
                }
                else
                {

                    bool res = clsVehi.guardarPro(placa, puestos, valor, color, idMarca);

                    if (res)
                    {
                        listarTabla();

                        limpiarCampos();
                        MessageBox.Show("Exito al guardar");

                    }
                    else
                    {

                        MessageBox.Show("El Vehiculo de placas no se pudo guardar");

                    }

                }

            }
            catch (Exception es)
            {

                MessageBox.Show("Por favor ingrese un dato numérico entero en los campos puestos o valor ");

            }


        }

        public void limpiarCampos()
        {

            txtPlaca.Text = "";

            txtPuestos.Text = "";

            txtValorDia.Text = "";

            txtColor.Text = "";

            cbMarca.SelectedValue = 0;

            btnModificar.Enabled = false;
            btnModificarNormal.Enabled = false;
            btnEliminar.Enabled = false;
            btnEliminarNormal.Enabled = false;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            String placa = txtPlaca.Text;

            int puestos = 0;

            int valor = 0;

            String color = txtColor.Text;

            Int32 idMarca = (Int32)cbMarca.SelectedValue;


            try
            {

                puestos = Convert.ToInt32((txtPuestos.Text == "" ? 0 : Convert.ToInt32(txtPuestos.Text)));

                valor = Convert.ToInt32((txtValorDia.Text == "" ? 0 : Convert.ToInt32(txtValorDia.Text)));

                if (placa == "" || txtPuestos.Text == "" || txtValorDia.Text == "" || color == "" || idMarca == 0
                     || puestos <= 0 || valor < 0)
                {
                    MessageBox.Show("Complete bien la informacion por favor.");
                }
                else
                {

                    bool res = clsVehi.modificarPro(aux, placa, puestos, valor, color, idMarca);

                    if (res)
                    {
                        btnGuardar.Enabled = true;

                        btnGuardarNormal.Enabled = true;

                        txtPlaca.Enabled = true;

                        aux = 0;

                        limpiarCampos();

                        MessageBox.Show("El vehículo se modifico correctamente");

                    }
                    else
                    {

                        MessageBox.Show("El vehículo NO se modifico correctamente");

                    }

                }

            }
            catch (Exception es)
            {

                MessageBox.Show("Por favor ingrese un dato numérico entero en los campos puestos o valor ");

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

                    MessageBox.Show("El vehículo de placas: " + placa + " no existe");

                }
                else
                {

                    btnModificar.Enabled = true;
                    btnModificarNormal.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnEliminarNormal.Enabled = true;

                    aux = Convert.ToInt32(temp.ElementAt(0));

                    txtPlaca.Text = temp.ElementAt(1);

                    cbMarca.SelectedValue = Convert.ToInt32(temp.ElementAt(4));

                    txtPuestos.Text = temp.ElementAt(2);

                    txtValorDia.Text = temp.ElementAt(3);

                    txtColor.Text = temp.ElementAt(5);

                    btnGuardar.Enabled = false;

                    btnGuardarNormal.Enabled = false;

                    txtPlaca.Enabled = false;

                }


            }



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (aux == 0)
            {

                MessageBox.Show("Por favor ingresa el número de placa del Vehículo a Eliminar");

            }
            else
            {

                if (clsVehi.eliminarPro(aux))
                {
                    btnGuardar.Enabled = true;

                    btnGuardarNormal.Enabled = true;

                    txtPlaca.Enabled = true;

                    aux = 0;

                    limpiarCampos();

                    listarTabla();

                    MessageBox.Show("El Vehículo se elimino correctamente");

                }
                else
                {

                    MessageBox.Show("Ocurrio un error al eliminar el vehículo");
                }
            }



        }

        private void btnGuardarNormal_Click(object sender, EventArgs e)
        {

            String placa = txtPlaca.Text;

            String color = txtColor.Text;

            Int32 idMarca = (Int32)cbMarca.SelectedValue;

            int puestos = 0;

            int valor = 0;

            try
            {

                LinkedList<String> temp = new LinkedList<string>();

                temp = clsVehi.buscarPro(placa);

                puestos = Convert.ToInt32((txtPuestos.Text == "" ? 0 : Convert.ToInt32(txtPuestos.Text)));

                valor = Convert.ToInt32((txtValorDia.Text == "" ? 0 : Convert.ToInt32(txtValorDia.Text)));

                if (temp != null)
                {

                    MessageBox.Show("El vehículo de placas: " + placa + " ya existe");

                }
                else if (placa == "" || txtPuestos.Text == "" || txtValorDia.Text == "" || color == "" || idMarca == 0
                    || puestos <= 0 || valor < 0)
                {
                    MessageBox.Show("Complete bien la informacion por favor.");
                }
                else
                {

                    bool res = clsVehi.guardarNormal(placa, puestos, valor, color, idMarca);

                    if (res)
                    {
                        listarTabla();

                        limpiarCampos();
                        MessageBox.Show("Exito al guardar");

                    }
                    else
                    {

                        MessageBox.Show("El Vehiculo de placas no se pudo guardar");

                    }

                }

            }
            catch (Exception es)
            {

                MessageBox.Show("Por favor ingrese un dato numérico entero en los campos puestos o valor ");

            }

        }

        private void btnBuscarNormal_Click(object sender, EventArgs e)
        {
            String placa = txtPlaca.Text;

            if (placa == "")
            {

                MessageBox.Show("Por favor ingresa el número de placa del Vehículo a buscar");

            }
            else
            {

                LinkedList<String> temp = new LinkedList<string>();

                temp = clsVehi.buscarNormal(placa);

                if (temp == null)
                {

                    MessageBox.Show("El vehículo de placas: " + placa + " no existe");

                }
                else
                {
                    btnModificar.Enabled = true;
                    btnModificarNormal.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnEliminarNormal.Enabled = true;

                    aux = Convert.ToInt32(temp.ElementAt(0));

                    txtPlaca.Text = temp.ElementAt(1);

                    txtPuestos.Text = temp.ElementAt(2);

                    txtColor.Text = temp.ElementAt(3);

                    cbMarca.SelectedValue = Convert.ToInt32(temp.ElementAt(4));

                    txtValorDia.Text = temp.ElementAt(5);

                    btnGuardarNormal.Enabled = false;

                    txtPlaca.Enabled = false;

                    btnGuardar.Enabled = false;

                }


            }
        }

        private void btnModificarNormal_Click(object sender, EventArgs e)
        {
            String placa = txtPlaca.Text;

            String color = txtColor.Text;

            Int32 idMarca = (Int32)cbMarca.SelectedValue;

            int puestos = 0;

            int valor = 0;

            try
            {

                puestos = Convert.ToInt32((txtPuestos.Text == "" ? 0 : Convert.ToInt32(txtPuestos.Text)));

                valor = Convert.ToInt32((txtValorDia.Text == "" ? 0 : Convert.ToInt32(txtValorDia.Text)));

                if (placa == "" || txtPuestos.Text == "" || txtValorDia.Text == "" || color == "" || idMarca == 0
                    || puestos <= 0 || valor < 0)
                {
                    MessageBox.Show("Complete bien la información por favor.");
                }
                else
                {

                    bool res = clsVehi.modificarNormal(aux, placa, puestos, color, valor, idMarca);

                    if (res)
                    {
                        btnGuardarNormal.Enabled = true;

                        btnGuardar.Enabled = true;

                        txtPlaca.Enabled = true;

                        limpiarCampos();

                        MessageBox.Show("Exito al Modificar");

                    }
                    else
                    {

                        MessageBox.Show("El Vehiculo de placas no se pudo Modificar");

                    }

                }

            }
            catch (Exception es)
            {

                MessageBox.Show("Por favor ingrese un dato numérico entero en los campos puestos o valor ");

            }

        }

        private void btnEliminarNormal_Click(object sender, EventArgs e)
        {

            if (aux == 0)
            {

                MessageBox.Show("Por favor ingresa el número de placa del Vehículo a Eliminar");

            }
            else
            {

                if (clsVehi.eliminarNormal(aux))
                {
                    btnGuardarNormal.Enabled = true;

                    btnGuardar.Enabled = true;

                    txtPlaca.Enabled = true;

                    aux = 0;

                    limpiarCampos();

                    listarTabla();

                    MessageBox.Show("El Vehículo se elimino correctamente");

                }
                else
                {

                    MessageBox.Show("El vehículo esta relacionado con un alquiler, por favor verifique");
                }
            }
        }

        public void listarTabla()
        {

            LinkedList<vehiculo> vu = clsVehi.listarVehiculo();
            dgVehiculo.Rows.Clear();


            foreach (vehiculo us in vu)
            {

                String marca = clsMarc.obtenerIdMarca(us.marca_id);
                dgVehiculo.Rows.Add(us.placa, us.numero_puestos, us.color, us.valor_dia, marca);

            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarTodo();
        }

        public void limpiarTodo()
        {
            btnGuardar.Enabled = true;
            btnGuardarNormal.Enabled = true;
            btnBuscar.Enabled = true;
            btnBuscarNormal.Enabled = true;
            btnModificar.Enabled = false;
            btnModificarNormal.Enabled = false;
            btnEliminar.Enabled = false;
            btnEliminarNormal.Enabled = false;
            txtPlaca.Enabled = true;
            txtPlaca.Text = "";
            txtColor.Text = "";
            txtPuestos.Text = "";
            txtValorDia.Text = "";
            cbMarca.SelectedValue = 0;
            aux = 0;
        }

        private void txtPuestos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtValorDia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}

