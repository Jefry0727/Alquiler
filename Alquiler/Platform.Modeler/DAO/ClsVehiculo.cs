using Platform.Modeler.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Modeler.DAO
{
    public class ClsVehiculo
    {
        VehiculoDataContext db;

        public ClsVehiculo()
        {

            db = new VehiculoDataContext();

        }

        public bool guardarPro(String placa, int puestos, int valor, String color, int idMarca)
        {
            try
            {

                db.guardarVehiculoPro(placa, puestos, color, valor, idMarca);
                return true;

            }
            catch (Exception e)
            {

                return false;

            }

        }

        public bool modificarPro(int id, String placa, int puestos, int valor, String color, int idMarca)
        {
            try
            {

                db.modificarVehiculoPro(id, placa, puestos, color, valor, idMarca);

                return true;

            }
            catch (Exception e)
            {

                return false;

            }


        }

        public LinkedList<String> buscarPro(String placa)
        {
            LinkedList<String> temp = new LinkedList<String>();

            try
            {

                var consu = db.buscarVehiculo(placa).Single();

                temp.AddLast(consu.id.ToString());
                temp.AddLast(consu.placa);
                temp.AddLast(consu.numero_puestos.ToString());
                temp.AddLast(consu.valor_dia.ToString());
                temp.AddLast(consu.marca_id.ToString());
                temp.AddLast(consu.color);

                return temp;
              
                
            }catch(Exception ex){

                return null;

            }

            


        }

        public LinkedList<vehiculo> listarVehiculo()
        {

            LinkedList<vehiculo> temp = new LinkedList<vehiculo>();

            //var consulta = from x in db.vehiculo select x;

            var consulta = db.vehiculo.Select(p => new { p.id, p.placa, p.numero_puestos, p.marca_id, p.valor_dia, p.color});

            consulta.First();

            foreach (var tp in consulta)
            {

                vehiculo ve = new vehiculo();

                ve.id = tp.id;

                ve.placa = tp.placa;

                ve.color = tp.color;

                ve.marca_id = tp.marca_id;

                ve.valor_dia = tp.valor_dia;

                ve.numero_puestos = tp.numero_puestos;

                temp.AddLast(ve);

            }

            return temp;
        }

        public bool eliminarPro(int id)
        {
            try
            {

                db.eliminarVehiculoPro(id);
                return true;

            }
            catch (Exception e)
            {

                return false;

            }


        }

        public bool guardarNormal(String placa, int numPuestos,String color,int valorDia, int idMarca)
        {
            try
            {
                vehiculo v = new vehiculo();

                v.placa = placa;
                v.numero_puestos = numPuestos;
                v.color = color;
                v.valor_dia = valorDia;
                v.marca_id = idMarca;

                db.vehiculo.InsertOnSubmit(v);//ingresa el objeto temporal estu

                db.SubmitChanges();//se hace submit

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public LinkedList<String> buscarNormal(String placa)
        {
            LinkedList<String> temp = new LinkedList<string>();
            //var consulta = from x in db.vehiculo where x.placa == placa select x;
            try
            {

                var consulta = db.vehiculo.Where(p => p.placa == placa);

                consulta.First();

                foreach (vehiculo estu in consulta)
                {
                    temp.AddLast(estu.id.ToString());
                    temp.AddLast(estu.placa);
                    temp.AddLast(estu.numero_puestos.ToString());
                    temp.AddLast(estu.color);
                    temp.AddLast(estu.marca_id.ToString());
                    temp.AddLast(estu.valor_dia.ToString());

                }

                return temp;

            }catch(Exception ex){

                return null;

            }
            

        }

        public bool modificarNormal(int id, String placa, int numPuestos, String color, int valorDia, int idMarca)
        {
            try
            {
               // var consulta = from x in db.vehiculo where x.id == id select x;

                var consulta = db.vehiculo.Where(p => p.id == id);

                consulta.First();

                foreach (vehiculo est in consulta)
                {
                    est.placa = placa;
                    est.numero_puestos=numPuestos;
                    est.color=color;
                    est.valor_dia=valorDia;
                    est.marca_id=idMarca;
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
               //var consulta = from x in db.vehiculo where x.id == id select x;

                var consulta = db.vehiculo.Where(p => p.id == id);

                foreach (vehiculo est in consulta)
                {
                    db.vehiculo.DeleteOnSubmit(est);
                }

                db.SubmitChanges();
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public String buscarVehiculoId(int id)
        {

            var consulta = db.vehiculo.Where(p => p.id == id);

            consulta.First();

            String placa = "";

            foreach (var estu in consulta)
            {
                placa = estu.placa;

            }

            return placa;
        }


        public bool guardarNormal(string placa, global::System.Windows.Forms.DataGridViewTextBoxColumn numeroPuestos, string color, global::System.Windows.Forms.DataGridViewTextBoxColumn valorDia, int idMarca)
        {
            throw new NotImplementedException();
        }
    }
}
