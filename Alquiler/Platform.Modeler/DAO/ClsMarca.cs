using Platform.Modeler.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Modeler.DAO
{
   public class ClsMarca
    {

       MarcaDataContext db;

       public ClsMarca() {

           db = new MarcaDataContext();

       }

       public LinkedList<marca> buscarMarca()
       {

           LinkedList<marca> temp = new LinkedList<marca>();

          
           //var consulta = from x in db.marca select x;

           var consulta = db.marca.Select(p => new { p.id, p.nombre });

           consulta.First();

           foreach (var tp in consulta)
           {
               marca m = new marca();

               m.id = tp.id;

               m.nombre = tp.nombre;

               temp.AddLast(m);
            
           }

           return temp;

       }


       public String obtenerIdMarca(int id)
       {
           // var consu = db.tipo_documentos_nombre(nombre).Single();   
           var consulta = db.marca.Where(p => p.id == id);

           consulta.First();

           String nombre = "";
           foreach (var estu in consulta)
           {
               nombre = estu.nombre;

           }

           return nombre;

       }

    }
}
