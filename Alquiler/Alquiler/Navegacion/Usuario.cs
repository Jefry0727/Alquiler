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
        LinkedList<String> tipoDocumentos;
        int idTipoDoc;

        public Usuario()
        {
            InitializeComponent();
            clsTP = new ClsTipoDocumento();
            tipoDocumentos = new LinkedList<string>();
            tipoDocumentos = clsTP.buscar();
            llenarComboTipoDocumento();

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            String o = cbTipoDocumento.SelectedItem.ToString();
            idTipoDoc = clsTP.obtenerIdTipoDoc(o);
            MessageBox.Show("" + idTipoDoc);
        }


    }
}
