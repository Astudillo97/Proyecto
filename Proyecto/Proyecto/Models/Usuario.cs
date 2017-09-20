using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class Usuario
    {
        public int idusuario { get; set; }
        public string usu_user { get; set; }
        public string usu_pass { get; set; }
        public int usu_idpersona { get; set; }
        public int usu_idrol { get; set; }

        App_Data.Interface.IDatos Isdato = new App_Data.Conexion.Datos();
        IDatos Idato = new Datos();

        public DataTable Validar(Usuario usu)
        {
            string sql = "select * from usuario u inner join rol r on u.USU_IDROL=r.IDROL where u.USU_USER='"+usu.usu_user+"' and u.USU_PASS='"+usu.usu_pass+"';";
            return Idato.ConsultarDatos(sql);
        }

        public DataTable ConsultaIDP(Usuario usu)
        {
            string sql = "select * from usuario where usu_idpersona="+usu.usu_idpersona+"; ";
            return Idato.ConsultarDatos(sql);
        }

        public string ActualizarUP(Usuario usu)
        {
            string sql = "update usuario set USU_USER='"+usu.usu_user+"', USU_PASS='"+usu.usu_pass+"' where USU_IDPERSONA="+usu.usu_idpersona+";";
            if (Idato.OperarDatos(sql))
            {
                return "Guardados con exito";
            }
            else
            {
                return "Error al guardar";
            }
        }
    }
}