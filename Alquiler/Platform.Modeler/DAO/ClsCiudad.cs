using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platform.Modeler.Entity;
namespace Platform.Modeler.DAO
{
    public class ClsCiudad
    {

        CiudadesDataContext db;

        public ClsCiudad()
        {
            db = new CiudadesDataContext();
        }


        public LinkedList<String> buscar()
        {

            LinkedList<String> temp = new LinkedList<string>();

            var consulta = from x in db.ciudad select x;
            consulta.First();

            foreach (ciudad tp in consulta)
            {
                temp.AddLast(tp.id.ToString());
                temp.AddLast(tp.nombre);
            }

            return temp;

        }

        public int obtenerIdCiudad(String nombre)
        {
            var consu = db.ciudad_nombre(nombre).Single();
            return consu.id;
        }
    }
}
