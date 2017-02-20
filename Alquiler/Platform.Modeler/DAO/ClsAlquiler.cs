using Platform.Modeler.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Modeler.DAO
{
    public class ClsAlquiler
    {

        AlquilerDataContext db;

        public ClsAlquiler()
        {
            db = new AlquilerDataContext();
        }
        public bool guardarPro(String codigo, int idUsuario, int idVehiculo, String fecha)
        {
            db.guardarAlquilerPro(codigo,idUsuario,idVehiculo,fecha);
            return true;
        }

        public Boolean modificarPro(int id, String codigo, int idUsuario, int idVehiculo, String fecha)
        {

            db.modificarAlquilerPro(id, codigo, idUsuario, idVehiculo, fecha);

            return true;

        }

        public LinkedList<String> buscarPro(String codigo)
        {
            LinkedList<String> temp = new LinkedList<String>();

            var consu = db.buscarAlquilerPro(codigo).Single();

            temp.AddLast(consu.id.ToString());
            temp.AddLast(consu.codigo);
            temp.AddLast(consu.usuario_id.ToString());
            temp.AddLast(consu.vehiculo_id.ToString());
            temp.AddLast(consu.fecha_alquiler.ToString());
            
           
            if (temp.Count > 0)
            {
                return temp;
            }
            else
            {
                return null;
            }


        }

      
    }
}
