using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Platform.Modeler.Entity;

namespace Platform.Modeler.DAO
{
    public class ClsTipoDocumento
    {

        TipoDocumentoDataContext db;

        public ClsTipoDocumento()
        {
            db = new TipoDocumentoDataContext();
        }

        public LinkedList<tipo_documento> buscar()
        {

            LinkedList<tipo_documento> temp = new LinkedList<tipo_documento>();

           // var consulta = from x in db.tipo_documento select x;

            var consulta = db.tipo_documento.Select(p => new { p.id, p.nombre });

            consulta.First();

            foreach (var tp in consulta)
            {
                tipo_documento td = new tipo_documento();

                td.id = tp.id;

                td.nombre = tp.nombre;

                temp.AddLast(td);
                
            }

            return temp;

        }

        public String obtenerIdTipoDoc(int id)
        {
           // var consu = db.tipo_documentos_nombre(nombre).Single();   

            var consulta = db.tipo_documento.Where(p => p.id == id);

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
