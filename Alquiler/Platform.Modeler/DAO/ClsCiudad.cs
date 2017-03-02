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


        public LinkedList<ciudad> buscarCiudades()
        {

            LinkedList<ciudad> temp = new LinkedList<ciudad>();

           // var consulta = from x in db.ciudad select x;

            var consulta = db.ciudad.Select(p => new {p.id, p.nombre });

            consulta.First();

            foreach (var tp in consulta)
            {
                ciudad c = new ciudad();
                
                c.id = tp.id;

                c.nombre = tp.nombre;

                temp.AddLast(c);
               
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
