using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pagos.Proyectos
{
    public partial class Consulta : System.Web.UI.Page
    {
        public List<Proyecto> Proyectos
        {
            get
            {
                if (Session["Proyectos"] == null)
                {
                    Session["Proyectos"] = new List<Proyecto> {
                        new Proyecto { CentroCosto="Centro Costo X",
                        Nombre="Proyecto 1",
                        MontoPresupuesto=15000,
                        MontoGastosGenerales=10000 }
                    };
                }
                return (List<Proyecto>)Session["Proyectos"];
            }
            set
            {
                Session.Add("Proyectos", value);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargaGrilla(Proyectos);
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }
        private void CargaGrilla(IEnumerable<Proyecto> proyectos)
        {
            gvProyectos.DataSource = proyectos;
            gvProyectos.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            var q = txtBuscar.Text;
            var proyectos = Proyectos.Where(x => x.Nombre.Contains(q)).ToList();
            CargaGrilla(proyectos);
        }
    }
}