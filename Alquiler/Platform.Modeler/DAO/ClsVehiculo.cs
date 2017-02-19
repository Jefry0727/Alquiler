using Platform.Modeler.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Modeler.DAO
{
    public class ClsVehiculo
    {
        VehiculoDataContext db;

        public ClsVehiculo()
        {

            db = new VehiculoDataContext();

        }

        public bool guardarPro(String placa, int puestos, int valor, String color, int idMarca)
        {
            try
            {

                db.guardarVehiculoPro(placa, puestos, color, valor, idMarca);
                return true;

            }
            catch (Exception e)
            {

                return false;

            }

        }

        public bool modificarPro(int id, String placa, int puestos, int valor, String color, int idMarca)
        {
            try
            {

                db.modificarVehiculoPro(id, placa, puestos, color, valor, idMarca);

                return true;

            }
            catch (Exception e)
            {

                return false;

            }


        }

        public LinkedList<String> buscarPro(String placa)
        {
            LinkedList<String> temp = new LinkedList<String>();
            var consu = db.buscarVehiculo(placa).Single();
            temp.AddLast(consu.id.ToString());
            temp.AddLast(consu.placa);
            temp.AddLast(consu.numero_puestos.ToString());
            temp.AddLast(consu.valor_dia.ToString());
            temp.AddLast(consu.marca_id.ToString());
            temp.AddLast(consu.color);

            if (temp.Count > 0)
            {
                return temp;
            }
            else
            {
                return null;
            }


        }

        public bool eliminarPro(int id)
        {
            try
            {

                db.eliminarVehiculoPro(id);
                return true;

            }
            catch (Exception e)
            {

                return false;

            }


        }

    }
}
