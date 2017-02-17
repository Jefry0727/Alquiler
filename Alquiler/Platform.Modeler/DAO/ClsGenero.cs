using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platform.Modeler.Entity;
namespace Platform.Modeler.DAO
{
    public class ClsGenero
    {
        GeneroDataContext db;

        public ClsGenero()
        {
            db = new GeneroDataContext();
        }

        public LinkedList<String> buscarGeneros()
        {

            LinkedList<String> temp = new LinkedList<string>();

            var consulta = from x in db.genero select x;
            consulta.First();

            foreach (genero tp in consulta)
            {
                temp.AddLast(tp.id.ToString());
                temp.AddLast(tp.nombre);
            }

            return temp;

        }

        public int obtenerIdGenero(String nombre)
        {
            var consu = db.genero_nombre(nombre).Single();
            return consu.id;
        }

    }
}
