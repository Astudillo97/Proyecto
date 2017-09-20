using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MerCam.Admin
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Modelo.TipoIdentificacion tipide = new Modelo.TipoIdentificacion();
                DataTable tabtip = tipide.Consultar();
                if (!IsPostBack)
                {
                    foreach (DataRow itemss in tabtip.Rows)
                    {
                        ListItem list = new ListItem();
                        list.Text = itemss["tid_detalle"].ToString();
                        list.Value = itemss["idtidentificacion"].ToString();
                        tipoID.Items.Add(list);
                    }
                }

            }
            catch (Exception)
            {

                msmpers.InnerText = "Error! no se encuentra ningun registro";
            }

        }
        protected void Actualizar(object sender, EventArgs e)
        {
            try
            {
                Modelo.Usuario user = new Modelo.Usuario();
                if (password.Value == confpassword.Value)
                {
                    user.usu_user = usuario.Value;
                    user.usu_pass = password.Value;
                    user.usu_idpersona = Convert.ToInt32(Session["identificador"].ToString());
                    msmlabel.InnerHtml = user.ActualizarUP(user);
                }
                else
                {
                    msmlabel.InnerHtml = "Las Contraseñas no coninceden";
                }
            }
            catch (Exception)
            {

                msmlabel.InnerHtml = "Error de inicio de sesión";
            }
            
        }
        protected void ActualizarPersona(object sender, EventArgs e)
        {
            try
            {
                Modelo.Persona pers = new Modelo.Persona();
                pers.per_identificacion = identificacion.Value;
                pers.per_nombre = nombres.Value;
                pers.per_apellido = apellidos.Value;
                pers.per_idtidentificacion = tipoID.SelectedIndex;
                pers.per_correo = correo.Value;
                pers.per_local = local.Value;
                pers.idpersona = Convert.ToInt32(Session["identificador"].ToString());
                msmpers.InnerHtml = pers.Actualizar(pers);
            }
            catch (Exception ex)
            {
                msmpers.InnerHtml = "Error de inicio de sesión "+ex;
            }

        }
    }
}