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

        public bool eliminarPro(int id)
        {
            try
            {

                db.eliminaraAlquilerPro(id);
                return true;

            }
            catch (Exception e)
            {

                return false;

            }


        }

        public bool guardarNormal(String codigo, int idUsuario, int idVehiculo, String fecha)
        {
            try
            {
                alquiler a = new alquiler();
                a.codigo = codigo;
                a.usuario_id = idUsuario;
                a.vehiculo_id = idVehiculo;
                a.fecha_alquiler = Convert.ToDateTime(fecha);
                db.alquiler.InsertOnSubmit(a);//ingresa el objeto temporal estu
                db.SubmitChanges();//se hace submit
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public LinkedList<String> buscarNormal(String codigo)
        {
            LinkedList<String> temp = new LinkedList<string>();
            var consulta = from x in db.alquiler where x.codigo == codigo select x;
            consulta.First();

            foreach (alquiler estu in consulta)
            {
                temp.AddLast(estu.id.ToString());
                temp.AddLast(estu.codigo);
                temp.AddLast(estu.usuario_id.ToString());
                temp.AddLast(estu.vehiculo_id.ToString());
                temp.AddLast(estu.fecha_alquiler.ToString());

            }

            return temp;
        }

        public bool modificarNormal(int id, String codigo, int idUsuario, int idVehiculo, String fecha)
        {
            try
            {
                var consulta = from x in db.alquiler where x.id == id select x;
                consulta.First();

                foreach (alquiler est in consulta)
                {
                    est.codigo=codigo;
                    est.usuario_id=idUsuario;
                    est.vehiculo_id=idVehiculo;
                    est.fecha_alquiler=Convert.ToDateTime(fecha);
                }
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool eliminarNormal(int id)
        {
            try
            {
                var consulta = from x in db.alquiler where x.id == id select x;

                foreach (alquiler est in consulta)
                {
                    db.alquiler.DeleteOnSubmit(est);
                }

                db.SubmitChanges();
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }
      
    }
}
