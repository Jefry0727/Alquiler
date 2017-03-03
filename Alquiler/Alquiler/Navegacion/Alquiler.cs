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
    public partial class Alquiler : Form
    {
        ClsUsuario clsUsu;
        ClsVehiculo clsVehi;
        ClsAlquiler clsAlqui;
        int aux = 0;

        public Alquiler()
        {
            InitializeComponent();

            clsUsu = new ClsUsuario();

            clsVehi = new ClsVehiculo();

            clsAlqui = new ClsAlquiler();

            llenarComboUsuario();

            llenarComboVehiculo();

            listarTabla();
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

            Int32 idUsuario = (Int32)cbUsuario.SelectedValue;

            Int32 idVehiculo = (Int32)cbVehiculo.SelectedValue;

            String fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

            if (codigo == "" || idUsuario == 0 || idVehiculo == 0)
            {

                MessageBox.Show("Complete la informacion por favor.");

            }
            else
            {

                bool res = clsAlqui.guardarPro(codigo, idUsuario, idVehiculo, fecha);

                if (res)
                {

                    listarTabla();

                    limpiarCampos();

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

            String codigo = txtCodigo.Text;

            if (codigo == "")
            {

                MessageBox.Show("Por favor ingresa el número de codigo del alquiler a buscar");

            }
            else
            {

                LinkedList<String> temp = new LinkedList<String>();

                temp = clsAlqui.buscarPro(codigo);

                if (temp != null)
                {

                    aux = Convert.ToInt32(temp.ElementAt(0));

                    txtCodigo.Text = temp.ElementAt(1);

                    cbUsuario.SelectedValue = Convert.ToInt32(temp.ElementAt(2));

                    cbVehiculo.SelectedValue = Convert.ToInt32(temp.ElementAt(3));

                    dtpFecha.Text = temp.ElementAt(4);

                    btnGuardar.Enabled = false;

                    txtCodigo.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Error no existe el alquiler");
                }

               

            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            String codigo = txtCodigo.Text;

            Int32 idUsuario = (Int32)cbUsuario.SelectedValue;

            Int32 idVehiculo = (Int32)cbVehiculo.SelectedValue;

            String fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

            if (codigo == "" || idUsuario == 0 || idVehiculo == 0)
            {

                MessageBox.Show("Complete la informacion por favor.");

            }
            else
            {

                bool res = clsAlqui.modificarPro(aux, codigo, idUsuario, idVehiculo, fecha);

                if (res)
                {

                    listarTabla();

                    limpiarCampos();

                    btnGuardar.Enabled = true;

                    txtCodigo.Enabled = true;

                    MessageBox.Show("El alquiler se modifico correctamente");
                }
                else
                {

                    MessageBox.Show("El alquiler NO se modifico correctamente");

                }

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (aux == 0)
            {

                MessageBox.Show("Por favor ingresa el número de codigo del Alquiler a Eliminar");

            }
            else
            {
                bool res = clsAlqui.eliminarPro(aux);

                if (res)
                {

                    aux = 0;

                    listarTabla();

                    limpiarCampos();

                    btnGuardar.Enabled = true;

                    txtCodigo.Enabled = true;

                    MessageBox.Show("El Alquiler se elimino correctamente");

                }
                else
                {

                    MessageBox.Show("Ocurrio un error al eliminar el Alquiler");
                }
            }


        }

        public void limpiarCampos()
        {

            txtCodigo.Text = "";

            cbUsuario.SelectedValue = 0;

            cbVehiculo.SelectedValue = 0;

        }

        private void btnGuardarNormal_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;

            Int32 idUsuario = (Int32)cbUsuario.SelectedValue;

            Int32 idVehiculo = (Int32)cbVehiculo.SelectedValue;

            String fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

            if (codigo == "" || idUsuario == 0 || idVehiculo == 0)
            {

                MessageBox.Show("Complete la informacion por favor.");

            }
            else
            {

                bool res = clsAlqui.guardarNormal(codigo, idUsuario, idVehiculo, fecha);

                if (res)
                {

                    listarTabla();

                    limpiarCampos();
                    MessageBox.Show("El alquiler se realizo correctamente");
                }
                else
                {

                    MessageBox.Show("El alquiler NO se realizo correctamente");

                }

            }
        }

        private void btnBuscarNormal_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;

            if (codigo == "")
            {

                MessageBox.Show("Por favor ingresa el número de codigo del alquiler a buscar");

            }
            else
            {

                LinkedList<String> temp = new LinkedList<String>();

                temp = clsAlqui.buscarNormal(codigo);

                if (temp != null)
                {

                    aux = Convert.ToInt32(temp.ElementAt(0));

                    txtCodigo.Text = temp.ElementAt(1);

                    cbUsuario.SelectedValue = Convert.ToInt32(temp.ElementAt(2));

                    cbVehiculo.SelectedValue = Convert.ToInt32(temp.ElementAt(3));

                    dtpFecha.Text = temp.ElementAt(4);

                    btnGuardarNormal.Enabled = false;

                    txtCodigo.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Error no existe el alquiler");
                }

            }
        }

        private void btnModificarNormal_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;

            Int32 idUsuario = (Int32)cbUsuario.SelectedValue;

            Int32 idVehiculo = (Int32)cbVehiculo.SelectedValue;

            String fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

            if (codigo == "" || idUsuario == 0 || idVehiculo == 0)
            {

                MessageBox.Show("Complete la informacion por favor.");

            }
            else
            {

                bool res = clsAlqui.modificarNormal(aux, codigo, idUsuario, idVehiculo, fecha);

                if (res)
                {
                    listarTabla();

                    limpiarCampos();

                    btnGuardarNormal.Enabled = true;

                    txtCodigo.Enabled = true;

                    MessageBox.Show("El alquiler se modifico correctamente");
                }
                else
                {

                    MessageBox.Show("El alquiler NO se modifico correctamente");

                }

            }
        }

        private void btnEliminarNormal_Click(object sender, EventArgs e)
        {
            if (aux == 0)
            {

                MessageBox.Show("Por favor ingresa el número de codigo del Alquiler a Eliminar");

            }
            else
            {

                if (clsAlqui.eliminarNormal(aux))
                {

                    listarTabla();

                    aux = 0;

                    limpiarCampos();

                    btnGuardarNormal.Enabled = true;

                    txtCodigo.Enabled = true;

                    MessageBox.Show("El Alquiler se elimino correctamente");

                }
                else
                {

                    MessageBox.Show("Ocurrio un error al eliminar el Alquiler");
                }
            }

        }

        private void Alquiler_Load(object sender, EventArgs e)
        {

        }

        public void listarTabla()
        {

            LinkedList<alquiler> u = clsAlqui.listarAlquiler();

            dgAlquiler.Rows.Clear();

            foreach (alquiler us in u)
            {
                Console.WriteLine(us.codigo);

                String nombre = clsUsu.buscarUsuarioId(us.usuario_id);

                String placa = clsVehi.buscarVehiculoId(us.vehiculo_id);

                dgAlquiler.Rows.Add(us.codigo, us.fecha_alquiler, nombre, placa);

            }


        }
    }
}
