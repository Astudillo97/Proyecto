using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MerCam.Modelo
{
    public class Menu
    {
        public int idmenu { get; set; }
        public string men_detalle { get; set; }
        public string men_url { get; set; }
        public string men_ico { get; set; }
        public int men_idmenu { get; set; }

        public DataTable ConsultarPKID(Menu men)
        {
            string sql = "select * from menu m where m.MEN_IDMENU="+men.men_idmenu+"";
            AccesoDato.Interface.IDatos Idato = new AccesoDato.Conexion.Datos();
            return Idato.ConsultarDatos(sql);
        }
    }
}