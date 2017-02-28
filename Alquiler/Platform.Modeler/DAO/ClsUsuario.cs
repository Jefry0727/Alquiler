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
            try
            {

                db.guardarUsuarioPro(documento, nombre, apellido, edad, idGenero, idTipoDoc, idCiu);
                return true;

            }
            catch (Exception e)
            {

                return false;

            }

        }

        //Metodo para buscar a un usuario por el documento en la bd
        //utilizando Linq
        public LinkedList<String> buscar(String docu)
        {
            try
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
            }catch(Exception ex){

                return null;

            }
            


        }

        public LinkedList<usuario> listarUsuarios()
        {

            LinkedList<usuario> temp = new LinkedList<usuario>();

            //var consulta = from x in db.usuario select x;

            var consulta = db.usuario.Select(p => new { p.documento, p.nombre, p.apellido, p.edad, p.id, p.tipo_documento_id });

            consulta.First();

            foreach (var tp in consulta)
            {
                usuario us = new usuario();

                us.id = tp.id;

                us.documento = tp.documento;

                us.nombre = tp.nombre;

                us.apellido = tp.apellido;

                us.edad = tp.edad;

                us.tipo_documento_id = tp.tipo_documento_id;

                temp.AddLast(us);

            }

            return temp;
        }


        public bool modificarUsuario(int id, String documento, String nombre, String apellido, int edad,
            int idGenero, int idTipoDoc, int idCiudad)
        {
            try
            {

               db.modificarUsuarioPro(id, documento, nombre, apellido, edad,
            idGenero, idTipoDoc, idCiudad);
                return true;

            }
            catch (Exception e)
            {

                return false;

            }

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
            try
            {
                LinkedList<String> temp = new LinkedList<string>();
                // var consulta = from x in db.usuario where x.documento == docu select x;

                var consulta = db.usuario.Where(p => p.documento == docu);

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


            }catch(Exception ex){

                return null;

            }
          
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

