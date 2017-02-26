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

        public LinkedList<genero> buscarGeneros()
        {

            LinkedList<genero> temp = new LinkedList<genero>();

            //var consulta = from x in db.genero select x;

            var consulta = db.genero.Select(p => new { p.id, p.nombre });
            consulta.First();

            foreach (var tp in consulta)
            {

                genero gen = new genero();

                gen.id = tp.id;

                gen.nombre = tp.nombre;

                temp.AddLast(gen);
               
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
