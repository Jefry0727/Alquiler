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

        public LinkedList<String> buscar()
        {

            LinkedList<String> temp = new LinkedList<string>();

            var consulta = from x in db.tipo_documento select x;
            consulta.First();

            foreach (tipo_documento tp in consulta)
            {
                temp.AddLast(tp.id.ToString());
                temp.AddLast(tp.nombre);
            }

            return temp;

        }

        public int obtenerIdTipoDoc(String nombre)
        {
            var consu = db.tipo_documentos_nombre(nombre).Single();            
            return consu.id;
        }

    }
}
