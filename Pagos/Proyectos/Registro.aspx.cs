using Entidades;
using System;
using System.Collections.Generic;
using Pagos;

namespace Pagos.Proyectos
{
    public partial class Registro : System.Web.UI.Page
    {
        public List<Proyecto> Proyectos
        {
            get
            {
                if (Session["Proyectos"] == null)
                {
                    Session["Proyectos"] = new List<Proyecto>();
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
                ddlMoneda.CargaMonedas();
                ddlResidenteObra.CargaResidentes();
                ddlGerenteObra.CargaGerentes();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            var proyecto = new Proyecto
            {
                CentroCosto = txtCentroCosto.Text,
                Moneda = Convert.ToInt32(ddlMoneda.SelectedValue),
                Nombre = txtProyecto.Text,
                MontoPresupuesto = Convert.ToDouble(txtMontoPresupuesto.Text),
                ResidenteObra = Convert.ToInt32(ddlResidenteObra.SelectedValue),
                GerenteObra = Convert.ToInt32(ddlGerenteObra.SelectedValue),
                UtilidadContratado = txtUtilidadContratado.Text,
                UtilidadReal = txtUtilidadReal.Text,
                MontoGastosGenerales = Convert.ToInt32(txtMontoGastosGenerales.Text),
            };
            Proyectos.Add(proyecto);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Consulta.aspx");
        }
    }
}