using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MerCam
{
    public partial class MasterAdmin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //La siguiente session captura el identificador del usuario, definir en el login.aspx
            //if (Session["idusuario"]!=null)
            //{
            //    Response.Redirect("login.aspx");
            //}

            //Session["identificador"] se define en el login.aspx.cs para conectar con la persona
            try
            {
                if (Session["identificador"] != null)
                {
                    Modelo.Persona pers = new Modelo.Persona();
                    pers.idpersona = Convert.ToInt32(Session["identificador"].ToString());
                    DataRow datos = pers.ConsultarID(pers).Rows[0];
                    this.nombre.InnerHtml = datos["per_nombre"].ToString() + " " + datos["per_apellido"].ToString();
                    Session["nombre"] = datos["per_nombre"].ToString() + " " + datos["per_apellido"].ToString();
                    Cargar_Menu(Convert.ToInt32(Session["idrol"].ToString()));
                }
                else
                {
                    //Response.Redirect("../Publico/index.aspx");
                }
            }
            catch (Exception)
            {
                Response.Redirect("../Publico/Login.aspx");
            }

        }

        protected void Cerrar(object sender, EventArgs e)
        {
            Session["identificador"] = null;
            Session["identificacion"] = null;
            Session["idusuario"] = null;
            Response.Redirect("../Publico/Login.aspx");
        }
        public void Cargar_Menu(int iduser)
        {
            DataTable permiso;
            DataTable menu;
            Modelo.Permiso perm = new Modelo.Permiso();
            perm.perm_idrol = iduser;
            if (perm.ConsultarIdrol(perm)!=null)
            {
                permiso = perm.ConsultarIdrol(perm);
                foreach (DataRow item in permiso.Rows)
                {
                    System.Web.UI.HtmlControls.HtmlGenericControl nav_item1 = new System.Web.UI.HtmlControls.HtmlGenericControl("li");
                    nav_item1.Attributes.Add("class", "nav-item");

                    System.Web.UI.HtmlControls.HtmlAnchor link1 = new System.Web.UI.HtmlControls.HtmlAnchor();
                    link1.HRef = item["men_url"].ToString();
                    link1.Attributes.Add("class", "nav-link ripple");
                    nav_item1.Controls.Add(link1);

                    System.Web.UI.HtmlControls.HtmlGenericControl iclass = new System.Web.UI.HtmlControls.HtmlGenericControl("i");
                    iclass.Attributes.Add("class", item["men_icon"].ToString());
                    link1.Controls.Add(iclass);

                    System.Web.UI.HtmlControls.HtmlGenericControl span = new System.Web.UI.HtmlControls.HtmlGenericControl("span");
                    span.InnerText = item["men_detalle"].ToString();
                    link1.Controls.Add(span);

                    string dat = item["men_url"].ToString();
                    Modelo.Menu men = new Modelo.Menu();
                    men.men_idmenu = Convert.ToInt32( item["idmenu"].ToString());
                    if (men.ConsultarPKID(men).Rows.Count>0)
                    {
                        nav_item1.Attributes.Add("role", "tab");
                        nav_item1.ID = Convert.ToString(item["idmenu"].ToString()+"sss");
                        link1.Attributes.Add("class", "nav-link ripple with-arrow collapsed");
                        link1.Attributes.Add("data-toggle", "collapse");
                        link1.Attributes.Add("data-target", Convert.ToString("#"+item["idmenu"].ToString()+"kkk"));
                        link1.Attributes.Add("aria-expanded", "false");
                        link1.HRef = "#";
                        link1.Attributes.Add("aria-controls", Convert.ToString("" + item["idmenu"].ToString() + "kkk"));

                        System.Web.UI.HtmlControls.HtmlGenericControl collapse_show = new System.Web.UI.HtmlControls.HtmlGenericControl("ul");
                        collapse_show.Attributes.Add("class", "collapse");
                        collapse_show.ID = Convert.ToString("" + item["idmenu"].ToString() + "kkk");
                        collapse_show.Attributes.Add("role", "tabpanel");
                        collapse_show.Attributes.Add("aria-labelledby", Convert.ToString(item["idmenu"].ToString() + "sss"));
                        collapse_show.Attributes.Add("data-children", ".nav-item");
                        nav_item1.Controls.Add(link1);
                        menu = men.ConsultarPKID(men);
                        foreach (DataRow item1 in menu.Rows)
                        {

                            System.Web.UI.HtmlControls.HtmlGenericControl nav_item2 = new System.Web.UI.HtmlControls.HtmlGenericControl("li");
                            nav_item2.Attributes.Add("class", "nav-item");

                            System.Web.UI.HtmlControls.HtmlAnchor link2 = new System.Web.UI.HtmlControls.HtmlAnchor();
                            link2.HRef = item1["men_url"].ToString();
                            link2.Attributes.Add("class", "nav-link ripple");
                            nav_item2.Controls.Add(link2);

                            System.Web.UI.HtmlControls.HtmlGenericControl span1 = new System.Web.UI.HtmlControls.HtmlGenericControl("span");
                            span1.InnerText = item1["men_detalle"].ToString();
                            link2.Controls.Add(span1);
                            nav_item2.Controls.Add(link2);
                            collapse_show.Controls.Add(nav_item2);
                        }
                        nav_item1.Controls.Add(collapse_show);
                    }
                    sidenav.Controls.Add(nav_item1);
                }
            }
        }
    }
}