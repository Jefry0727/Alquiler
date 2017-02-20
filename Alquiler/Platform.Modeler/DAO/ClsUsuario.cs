using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platform.Modeler.Entity;
namespace Platform.Modeler.DAO
{
    public class ClsUsuario
    {

        UsuarioDataContext db;

        public ClsUsuario()
        {
            db = new UsuarioDataContext();
        }

        //Metodo para enviar datos del usuario a la base de datos
        //utilizando Linq
        public bool guardar(String documento, String nombre, String apellido, int edad, int idGenero,
            int idTipoDoc, int idCiu)
        {
            db.guardarUsuarioPro(documento, nombre, apellido, edad, idGenero, idTipoDoc, idCiu);
            return true;
        }

        //Metodo para buscar a un usuario por el documento en la bd
        //utilizando Linq
        public LinkedList<String> buscar(String docu)
        {
            LinkedList<String> temp = new LinkedList<String>();
            var consu = db.buscarUsuarioPro(docu).Single();
            temp.AddLast(consu.id.ToString());
            temp.AddLast(consu.nombre);
            temp.AddLast(consu.apellido);
            temp.AddLast(consu.edad.ToString());
            temp.AddLast(consu.genero_id.ToString());
            temp.AddLast(consu.tipo_documento_id.ToString());
            temp.AddLast(consu.ciudad_id.ToString());
            if (temp.Count > 0)
            {
                return temp;
            }
            else
            {
                return null;
            }


        }

        public LinkedList<usuario> listarUsuarios()
        {

            LinkedList<usuario> temp = new LinkedList<usuario>();

            var consulta = from x in db.usuario select x;
            consulta.First();

            foreach (usuario tp in consulta)
            {

                temp.AddLast(tp);

            }

            return temp;
        }


        public bool modificarUsuario(int id, String documento, String nombre, String apellido, int edad,
            int idGenero, int idTipoDoc, int idCiudad)
        {
            db.modificarUsuarioPro(id, documento, nombre, apellido, edad,
             idGenero, idTipoDoc, idCiudad);
            return true;
        }

        public bool eliminarUsuario(int id)
        {
            db.eliminarUsuarioPro(id);
            return true;
        }

        public bool guardarNormal(String documento, String nombre, String apellido, int edad, int idGenero,
            int idTipoDoc, int idCiu)
        {
            try
            {
                usuario u = new usuario();
                u.documento = documento;
                u.nombre = nombre;
                u.apellido = apellido;
                u.edad = edad;
                u.genero_id = idGenero;
                u.tipo_documento_id = idTipoDoc;
                u.ciudad_id = idCiu;
                db.usuario.InsertOnSubmit(u);//ingresa el objeto temporal estu
                db.SubmitChanges();//se hace submit
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public LinkedList<String> buscarNormal(String docu)
        {
            LinkedList<String> temp = new LinkedList<string>();
            var consulta = from x in db.usuario where x.documento == docu select x;
            consulta.First();

            foreach (usuario estu in consulta)
            {
                temp.AddLast(estu.id.ToString());
                temp.AddLast(estu.nombre);
                temp.AddLast(estu.apellido);
                temp.AddLast(estu.edad.ToString());
                temp.AddLast(estu.genero_id.ToString());
                temp.AddLast(estu.tipo_documento_id.ToString());
                temp.AddLast(estu.ciudad_id.ToString());
            }

            return temp;
        }

        public bool modificarNormal(int id, String documento, String nombre, String apellido, int edad,
            int idGenero, int idTipoDoc, int idCiudad)
        {
            try
            {
                var consulta = from x in db.usuario where x.id == id select x;
                consulta.First();

                foreach (usuario est in consulta)
                {
                    est.documento = documento;
                    est.nombre = nombre;
                    est.apellido = apellido;
                    est.edad = edad;
                    est.genero_id = idGenero;
                    est.tipo_documento_id = idTipoDoc;
                    est.ciudad_id = idCiudad;
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
                var consulta = from x in db.usuario where x.id == id select x;

                foreach (usuario est in consulta)
                {
                    db.usuario.DeleteOnSubmit(est);
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

