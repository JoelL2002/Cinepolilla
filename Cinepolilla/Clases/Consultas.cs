using Cinepolilla.Modelos;
using Cinepolilla.Paginas_de_form;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cinepolilla.Clases
{
    internal class Consultas
    {

        public int ConsultaLogin(string usuario, string contraseña)
        {
            using (Progra1Entities db = new Progra1Entities())
            {

                var cuenta = db.Usuario.SqlQuery($"select * from Usuario where N_Usuario='{usuario}' and Contraseña='{contraseña}'");

                int acceso = cuenta.Count();
                return acceso;
            }
        }

        public int existe(string usuario)
        {
            using (Progra1Entities db = new Progra1Entities())
            {

                var cuenta = db.Usuario.SqlQuery($"select * from Usuario where N_Usuario='{usuario}'");

                int acceso = cuenta.Count();
                return acceso;
            }
        }

        public void crearUsuario(Usuario Temp)
        {
            using (Progra1Entities db = new Progra1Entities())
            {
                Usuario usu = new Usuario();
                usu.Nombre = Temp.Nombre;
                usu.N_Usuario = Temp.N_Usuario;
                usu.Contraseña = Temp.Contraseña;
                usu.Edad = Temp.Edad;
                usu.Sexo = Temp.Sexo;

                db.Usuario.Add(usu);
                db.SaveChanges();
            }
        }

  
     
  }
}
