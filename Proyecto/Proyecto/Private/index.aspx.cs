using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MerCam.Admin
{
    public partial class Setting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                nombre.Text = "Bienvenido ";
            }
            catch (Exception ex)
            {
                nombre.Text = "Error de sesión "+ ex;
               
            }
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Modelo.Persona per = new Modelo.Persona();
            per.per_identificacion = this.id.Text;
            try
            {
                DataRow dat = per.ConsultarNUI(per).Rows[0];
                this.error.Text = dat["per_nombre"].ToString()+" "+ dat["per_apellido"].ToString();
                Session["identificador"] = dat["idpersona"].ToString();
                Session["identificacion"] = dat["per_identificacion"];
                
            }
            catch (Exception ex)
            {
                this.error.Text = "#Error Try Catch" +ex;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.Usuario user = new Modelo.Usuario();
                user.usu_user = usuario.Text;
                user.usu_pass = paswwor.Text;
                DataRow ss=user.Validar(user).Rows[0];
                Session["idusuario"] = ss["idusuario"].ToString();
                Session["identificador"] = ss["usu_idpersona"];
                Session["idrol"] = ss["idrol"].ToString();
                error.Text = "ID usuario: "+ ss["idusuario"].ToString() +"  -Rol: "+ ss["idrol"].ToString();
            }
            catch (Exception ex)
            {
                error.Text = "Ha ocurrido un error en el logueo" + ex;
                
            }

        }
    }
}