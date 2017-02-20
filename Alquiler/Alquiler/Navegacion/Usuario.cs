using Platform.Modeler.DAO;
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
    public partial class Usuario : Form
    {
        ClsTipoDocumento clsTP;
        ClsCiudad clsCi;
        ClsGenero clsGe;
        ClsUsuario clsUsu;
        LinkedList<String> tipoDocumentos;
        LinkedList<String> ciudades;
        LinkedList<String> generos;
        int idGenero;
        int idTipoDoc;
        int idCiudad;
        String idUsuario;
        int aux;

        public Usuario()
        {
            InitializeComponent();
            clsTP = new ClsTipoDocumento();
            clsGe = new ClsGenero();
            clsCi = new ClsCiudad();
            clsUsu = new ClsUsuario();
            tipoDocumentos = new LinkedList<string>();
            tipoDocumentos = clsTP.buscar();
            ciudades = new LinkedList<string>();
            ciudades = clsCi.buscarCiudades();
            generos = new LinkedList<string>();
            generos = clsGe.buscarGeneros();
            llenarComboTipoDocumento();
            llenarComboCiudades();
            llenarComboGeneros();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'alquilerVehiculosDataSet.usuario' Puede moverla o quitarla según sea necesario.
            

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

        private void cbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
                       
        }

        public void llenarComboTipoDocumento()
        {
            
            for (int i = 0; i < tipoDocumentos.Count; i++)
            {
                i++;
                cbTipoDocumento.Items.Add(tipoDocumentos.ElementAt(i));
            }
        }
        public void llenarComboCiudades()
        {
            for (int i = 0; i < ciudades.Count; i++)
            {
                i++;
                cbCiudadNac.Items.Add(ciudades.ElementAt(i));
            }
        }
        public void llenarComboGeneros()
        {
            for (int i = 0; i < generos.Count; i++)
            {
                i++;
                cbGenero.Items.Add(generos.ElementAt(i));
            }
        }
        public void limpiar()
        {
            txtApellido.Text = "";
            txtDocumento.Text = "";
            txtEdad.Text = "";
            txtNombre.Text = "";
            cbCiudadNac.SelectedValue = 0;
            cbGenero.SelectedValue = 0;
            cbTipoDocumento.SelectedValue = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            String nombreTipoDoc = cbTipoDocumento.SelectedItem.ToString();
            String nombreCiu = cbCiudadNac.SelectedItem.ToString();
            String nombreGen = cbGenero.SelectedItem.ToString();
            idCiudad = clsCi.obtenerIdCiudad(nombreCiu);
            idGenero = clsGe.obtenerIdGenero(nombreGen);
            idTipoDoc = clsTP.obtenerIdTipoDoc(nombreTipoDoc);
            String doc = txtDocumento.Text;
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            if(clsUsu.guardar(doc,nombre,apellido,edad,idGenero,idTipoDoc,idCiudad)){
                MessageBox.Show("Se creo con exito");
                limpiar();
            }
            else
            {
                MessageBox.Show("Error al tratar de crear");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String doc = txtDocumento.Text;
            if(doc==""){
                MessageBox.Show("Por favor ingrese el documento");
            }else{
                LinkedList<String> temp = new LinkedList<string>();
                temp = clsUsu.buscar(doc);
                if(temp.Count > 0){
                    idUsuario = temp.ElementAt(0);
                    aux = Convert.ToInt32(idUsuario);
                    txtNombre.Text = temp.ElementAt(1);
                    txtApellido.Text = temp.ElementAt(2);
                    txtEdad.Text = temp.ElementAt(3);
                    cbGenero.SelectedText = temp.ElementAt(4);
                    cbTipoDocumento.SelectedText = temp.ElementAt(5);
                    cbCiudadNac.SelectedText = temp.ElementAt(6);
                    
                }
                else
                {
                    MessageBox.Show("No se encontro");
                }
               
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            String doc = txtDocumento.Text;
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            String nombreTipoDoc = cbTipoDocumento.SelectedItem.ToString();
            String nombreCiu = cbCiudadNac.SelectedItem.ToString();
            String nombreGen = cbGenero.SelectedItem.ToString();
            idCiudad = clsCi.obtenerIdCiudad(nombreCiu);
            idGenero = clsGe.obtenerIdGenero(nombreGen);
            idTipoDoc = clsTP.obtenerIdTipoDoc(nombreTipoDoc);
            if(clsUsu.modificarUsuario(aux,doc,nombre,apellido,edad,idGenero,idTipoDoc,idCiudad)){
                MessageBox.Show("Se modifico con exito");
                limpiar();
            }
            else
            {
                MessageBox.Show("error al modificar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(clsUsu.eliminarUsuario(aux)){
                MessageBox.Show("Eliminado con exito");
                limpiar();
            }else{
                MessageBox.Show("Error al tratar de eliminar");
            }
            
        }

        private void btnGuardarNormal_Click(object sender, EventArgs e)
        {
            String nombreTipoDoc = cbTipoDocumento.SelectedItem.ToString();
            String nombreCiu = cbCiudadNac.SelectedItem.ToString();
            String nombreGen = cbGenero.SelectedItem.ToString();
            idCiudad = clsCi.obtenerIdCiudad(nombreCiu);
            idGenero = clsGe.obtenerIdGenero(nombreGen);
            idTipoDoc = clsTP.obtenerIdTipoDoc(nombreTipoDoc);
            String doc = txtDocumento.Text;
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            if (clsUsu.guardarNormal(doc, nombre, apellido, edad, idGenero, idTipoDoc, idCiudad))
            {
                MessageBox.Show("Se creo con exito");
                limpiar();
            }
            else
            {
                MessageBox.Show("Error al tratar de crear");
            }
        }

        private void btnBuscarNormal_Click(object sender, EventArgs e)
        {
            String doc = txtDocumento.Text;
            if (doc == "")
            {
                MessageBox.Show("Por favor ingrese el documento");
            }
            else
            {
                LinkedList<String> temp = new LinkedList<string>();
                temp = clsUsu.buscarNormal(doc);
                if(temp == null){
                    MessageBox.Show("Error no existe ese vehiculo");
                }
                else
                {
                    MessageBox.Show("Encontrado");
                    aux = Convert.ToInt32(temp.ElementAt(0));
                    txtNombre.Text = temp.ElementAt(1);
                    txtApellido.Text = temp.ElementAt(2);
                    txtEdad.Text = temp.ElementAt(3);
                    cbGenero.SelectedValue = Convert.ToInt32(temp.ElementAt(4));
                    cbTipoDocumento.SelectedValue = Convert.ToInt32(temp.ElementAt(4));
                    cbCiudadNac.SelectedValue = Convert.ToInt32(temp.ElementAt(4));
                }
            }
        }

        private void btnModificarNormal_Click(object sender, EventArgs e)
        {
            String doc = txtDocumento.Text;
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            String nombreTipoDoc = cbTipoDocumento.SelectedItem.ToString();
            String nombreCiu = cbCiudadNac.SelectedItem.ToString();
            String nombreGen = cbGenero.SelectedItem.ToString();
            idCiudad = clsCi.obtenerIdCiudad(nombreCiu);
            idGenero = clsGe.obtenerIdGenero(nombreGen);
            idTipoDoc = clsTP.obtenerIdTipoDoc(nombreTipoDoc);
            if (clsUsu.modificarNormal(aux, doc, nombre, apellido, edad, idGenero, idTipoDoc, idCiudad))
            {
                MessageBox.Show("Se modifico con exito");
                limpiar();
            }
            else
            {
                MessageBox.Show("error al modificar");
            }
        }

        private void btnEliminarNormal_Click(object sender, EventArgs e)
        {
            if (clsUsu.eliminarNormal(aux))
            {
                MessageBox.Show("Eliminado con exito");
                limpiar();
            }
            else
            {
                MessageBox.Show("Error al tratar de eliminar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

    }
}
