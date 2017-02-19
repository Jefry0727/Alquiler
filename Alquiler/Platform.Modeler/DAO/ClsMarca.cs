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

          
           var consulta = from x in db.marca select x;
           consulta.First();

           foreach (marca tp in consulta)
           {

               temp.AddLast(tp);
            
           }

           return temp;

       }

    }
}
