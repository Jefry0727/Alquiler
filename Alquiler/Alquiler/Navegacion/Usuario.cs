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
    public partial class Usuario : Form
    {
        ClsTipoDocumento clsTP;
        ClsCiudad clsCi;
        ClsGenero clsGe;
        ClsUsuario clsUsu;
        LinkedList<tipo_documento> tipoDocumentos;
        LinkedList<ciudad> ciudades;
        LinkedList<genero> generos;
        Int32 idGenero;
        Int32 idTipoDoc;
        Int32 idCiudad;
        String idUsuario;
        int aux;

        public Usuario()
        {
            InitializeComponent();
            clsTP = new ClsTipoDocumento();
            clsGe = new ClsGenero();
            clsCi = new ClsCiudad();
            clsUsu = new ClsUsuario();
            tipoDocumentos = new LinkedList<tipo_documento>();
            
            ciudades = new LinkedList<ciudad>();
            
            generos = new LinkedList<genero>();
           
            llenarComboTipoDocumento();
            llenarComboCiudades();
            llenarComboGeneros();

            listarTabla();
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
            tipoDocumentos = clsTP.buscar();
            
            BindingList<Item> tipo = new BindingList<Item>();
            tipo.Add(new Item("Seleccione Tipo Documento", 0));

            for (int i = 0; i < tipoDocumentos.Count; i++)
            {
                tipo.Add(new Item((tipoDocumentos.ElementAt(i)).nombre, (tipoDocumentos.ElementAt(i)).id));

            }

            cbTipoDocumento.DisplayMember = "Name";
            cbTipoDocumento.ValueMember = "Value";
            cbTipoDocumento.DataSource = tipo;
          
        }
        public void llenarComboCiudades()
        {

            ciudades = clsCi.buscarCiudades();
            BindingList<Item> ciud = new BindingList<Item>();
            ciud.Add(new Item("Seleccione La Ciudad", 0));

            for (int i = 0; i < ciudades.Count; i++)
            {
                ciud.Add(new Item((ciudades.ElementAt(i)).nombre, (ciudades.ElementAt(i)).id));

            }

            cbCiudadNac.DisplayMember = "Name";
            cbCiudadNac.ValueMember = "Value";
            cbCiudadNac.DataSource = ciud;
          
        }


        public void llenarComboGeneros()
        {
            generos = clsGe.buscarGeneros();
            BindingList<Item> gen = new BindingList<Item>();
            gen.Add(new Item("Seleccione el genero", 0));

            for (int i = 0; i < generos.Count; i++)
            {
                gen.Add(new Item((generos.ElementAt(i)).nombre, (generos.ElementAt(i)).id));

            }

            cbGenero.DisplayMember = "Name";
            cbGenero.ValueMember = "Value";
            cbGenero.DataSource = gen;
           
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

            idCiudad = (Int32)cbCiudadNac.SelectedValue;

            idGenero = (Int32)cbGenero.SelectedValue;

            idTipoDoc =(Int32)cbTipoDocumento.SelectedValue;

            String doc = txtDocumento.Text;

            String nombre = txtNombre.Text;

            String apellido = txtApellido.Text;

            int edad = 0;

            try
            {
                 edad = Convert.ToInt32(txtEdad.Text);

                 if (idCiudad == 0 || idGenero == 0 || idTipoDoc == 0 || doc == "" || nombre == "" || apellido == "")
                 {

                     MessageBox.Show("Por favor complete la información del formulario");

                 }
                 else
                 {

                     if (clsUsu.guardar(doc, nombre, apellido, edad, idGenero, idTipoDoc, idCiudad))
                     {
                         MessageBox.Show("El Usuario se creo con correctamente");
                         listarTabla();
                         limpiar();
                     }
                     else
                     {
                         MessageBox.Show("Error al tratar de crear el Usuario");
                     }

                 }
           

            }catch(Exception ex){

                MessageBox.Show("Por favor ingresar un dato numerico en el campo edad");

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

                if(temp != null){

                    btnGuardar.Enabled = false;

                    txtDocumento.Enabled = false;

                    idUsuario = temp.ElementAt(0);

                    aux = Convert.ToInt32(idUsuario);

                    txtNombre.Text = temp.ElementAt(1);

                    txtApellido.Text = temp.ElementAt(2);

                    txtEdad.Text = temp.ElementAt(3);

                    cbGenero.SelectedValue = Convert.ToInt32(temp.ElementAt(4));

                    cbTipoDocumento.SelectedValue = Convert.ToInt32(temp.ElementAt(5));

                    cbCiudadNac.SelectedValue = Convert.ToInt32(temp.ElementAt(6));
                    
                }
                else
                {
                    MessageBox.Show("Error no existe ese vehiculo");
                }
               
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            idCiudad = (Int32)cbCiudadNac.SelectedValue;

            idGenero = (Int32)cbGenero.SelectedValue; ;

            idTipoDoc = (Int32)cbTipoDocumento.SelectedValue;

            String doc = txtDocumento.Text;

            String nombre = txtNombre.Text;

            String apellido = txtApellido.Text;

            int edad = 0;

            try
            {
                edad = Convert.ToInt32(txtEdad.Text);

                if (idCiudad == 0 || idGenero == 0 || idTipoDoc == 0 || doc == "" || nombre == "" || apellido == "")
                {

                    MessageBox.Show("Por favor complete la información del formulario");

                }
                else
                {

                    if (clsUsu.modificarUsuario(aux, doc, nombre, apellido, edad, idGenero, idTipoDoc, idCiudad))
                    {
                        MessageBox.Show("El Usuario se modifico correctamente");

                        btnGuardar.Enabled = true;

                        txtDocumento.Enabled = true;

                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("error al modificar");
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Por favor ingresar un dato numerico en el campo edad");

            }

            
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(aux == 0){

                MessageBox.Show("Debe de buscar un usuario antes de eliminar");
            }
            else
            {

                if (clsUsu.eliminarUsuario(aux))
                {
                    MessageBox.Show("El Usuario fue Eliminado con exito");

                    btnGuardar.Enabled = true;

                    txtDocumento.Enabled = true;

                    aux = 0;

                    listarTabla();

                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error al tratar de eliminar, el usuario tiene relación con un alquiler");
                }


            }

            
            
        }

        private void btnGuardarNormal_Click(object sender, EventArgs e)
        {
            idCiudad = (Int32)cbCiudadNac.SelectedValue;

            idGenero = (Int32)cbGenero.SelectedValue;

            idTipoDoc = (Int32)cbTipoDocumento.SelectedValue;

            String doc = txtDocumento.Text;

            String nombre = txtNombre.Text;

            String apellido = txtApellido.Text;

            int edad = 0;

            try
            {
                edad = Convert.ToInt32(txtEdad.Text);

                if (idCiudad == 0 || idGenero == 0 || idTipoDoc == 0 || doc == "" || nombre == "" || apellido == "")
                {

                    MessageBox.Show("Por favor complete la información del formulario");

                }
                else
                {

                    if (clsUsu.guardarNormal(doc, nombre, apellido, edad, idGenero, idTipoDoc, idCiudad))
                    {
                        MessageBox.Show("El Usuario se creo con correctamente");

                        listarTabla();

                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al tratar de crear el Usuario");
                    }

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Por favor ingresar un dato numerico en el campo edad");

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
                    btnGuardarNormal.Enabled = false;

                    txtDocumento.Enabled = false;

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
            idCiudad = (Int32)cbCiudadNac.SelectedValue;

            idGenero = (Int32)cbGenero.SelectedValue; ;

            idTipoDoc = (Int32)cbTipoDocumento.SelectedValue;

            String doc = txtDocumento.Text;

            String nombre = txtNombre.Text;

            String apellido = txtApellido.Text;

            int edad = 0;

            try
            {
                edad = Convert.ToInt32(txtEdad.Text);

                if (idCiudad == 0 || idGenero == 0 || idTipoDoc == 0 || doc == "" || nombre == "" || apellido == "")
                {

                    MessageBox.Show("Por favor complete la información del formulario");

                }
                else
                {

                    if (clsUsu.modificarNormal(aux, doc, nombre, apellido, edad, idGenero, idTipoDoc, idCiudad))
                    {
                        MessageBox.Show("El Usuario se modifico correctamente");

                        btnGuardar.Enabled = true;

                        txtDocumento.Enabled = true;

                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("error al modificar");
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Por favor ingresar un dato numerico en el campo edad");

            }
        }

        private void btnEliminarNormal_Click(object sender, EventArgs e)
        {
            if (aux == 0)
            {

                MessageBox.Show("Debe de buscar un usuario antes de eliminar");
            }
            else
            {

                if (clsUsu.eliminarNormal(aux))
                {
                    MessageBox.Show("El Usuario fue Eliminado con exito");

                    btnGuardarNormal.Enabled = true;

                    txtDocumento.Enabled = true;

                    aux = 0;

                    listarTabla();

                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error al tratar de eliminar, el usuario tiene alguna relacion con un alquiler");
                }



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }


        public void listarTabla()
        {

           LinkedList<usuario> u =  clsUsu.listarUsuarios();

           dgUsuario.Rows.Clear();

            foreach(usuario us in u){
                Console.WriteLine(us.documento);
                String nombre = clsTP.obtenerIdTipoDoc(us.tipo_documento_id);
                dgUsuario.Rows.Add(us.documento ,us.nombre, nombre, us.apellido, us.edad);

            }
            

        }
    }
}
