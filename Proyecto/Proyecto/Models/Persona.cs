using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MerCam.Modelo
{
    public class Persona
    {
        public int idpersona { get; set; }
        public string per_identificacion { get; set; }
        public string per_nombre { get; set; }
        public string per_apellido { get; set; }
        public int per_idtidentificacion { get; set; }
        public string per_correo { get; set; }
        public string per_local { get; set; }
        public int per_idestado { get; set; }
        AccesoDato.Interface.IDatos Idato = new AccesoDato.Conexion.Datos();
        public DataTable ConsultarNUI(Persona per)
        {
            string sql = "select * from persona where per_identificacion='" + per.per_identificacion + "'; ";
            return Idato.ConsultarDatos(sql);
        }
        public DataTable ConsultarID(Persona per)
        {
            string sql = "select * from persona where idpersona=" + per.idpersona + "; ";
            return Idato.ConsultarDatos(sql);
        }
        public string Actualizar(Persona per)
        {
            string sql = "update persona set per_identificacion='" + per.per_identificacion + "', per_nombre='"+per.per_nombre+"', per_apellido='"+per.per_apellido+"', per_idtidentificacion="+per.per_idtidentificacion+", per_correo='"+per.per_correo+"', per_local='"+per.per_local+"' where idpersona="+per.idpersona+";";
            if (Idato.OperarDatos(sql))
            {
                return "Datos guardados correctamente";
            }
            else
            {
                return "Error al guardar los datos";
            }
        }
    }
}