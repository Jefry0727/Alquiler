﻿using System;
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
        public bool guardar(String documento,String nombre,String apellido,int edad,int idGenero,
            int idTipoDoc, int idCiu)
        {
            db.guardarUsuarioPro(documento,nombre,apellido,edad,idGenero,idTipoDoc,idCiu);
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
            if(temp.Count>0){
                return temp;
            }
            else
            {
                return null;
            }
            
            
        }

    }
}