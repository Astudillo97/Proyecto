using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MerCam.Modelo
{
    public class TipoIdentificacion
    {
        public int idtidentificacion { get; set; }
        public string tid_detalle { get; set; }
        AccesoDato.Interface.IDatos Idato = new AccesoDato.Conexion.Datos();

        public DataTable Consultar()
        {
            string sql = "select * from tidentificacion";
            return Idato.ConsultarDatos(sql);
        }
    }
}