using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pagos.Ordenes
{
    public partial class Registro : System.Web.UI.Page
    {
        public List<Factura> Facturas
        {
            get
            {
                if (Session["Facturas"] == null)
                {
                    Session.Add("Facturas", new List<Factura>());
                }
                return (List<Factura>)Session["Facturas"];
            }
            set
            {
                Session.Add("Facturas", value);
            }
        }
        public Factura Factura
        {
            get
            {
                if (ViewState["Factura"] == null)
                {
                    ViewState.Add("Factura", new Factura
                    {
                        Detalles = new List<FacturaDetalle>()
                    });
                }
                return (Factura)ViewState["Factura"];
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ddlTipo.CargaTipoOrden();
                ddlFormaPago.CargaFormaPago();
                ddlProveedor.CargaProveedor();
                ddlContacto.CargaContacto(0);
                cargarGrilla(0);
            }
        }

        public void cargarGrilla(int pagina)
        {
            gvDetalle.DataSource = Factura.Detalles;
             gvDetalle.DataBind();
        }

        protected void lnkAddDetalle_Click(object sender, EventArgs e)
        {
            Factura.Detalles.Add(new FacturaDetalle());
            cargarGrilla(gvDetalle.PageIndex);
            gvDetalle.EditIndex = gvDetalle.Rows.Count - 1;
            gvDetalle.DataBind();
        }



        protected void gvDetalle_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var RowIndex = ((GridViewRow)((Control)e.CommandSource).NamingContainer).RowIndex;
            switch (e.CommandName)
            {
                case "Guardar":
                    var detalle = new FacturaDetalle
                    {
                        CentroCosto = ((TextBox)gvDetalle.Rows[RowIndex].Cells[0].Controls[0]).Text,
                        Item = ((TextBox)gvDetalle.Rows[RowIndex].Cells[1].Controls[0]).Text,
                        Descripcion = ((TextBox)gvDetalle.Rows[RowIndex].Cells[2].Controls[0]).Text,
                        Codigo = ((TextBox)gvDetalle.Rows[RowIndex].Cells[3].Controls[0]).Text,
                        Cuotas = int.Parse(((TextBox)gvDetalle.Rows[RowIndex].Cells[4].Controls[0]).Text),
                        Unidad = int.Parse(((TextBox)gvDetalle.Rows[RowIndex].Cells[5].Controls[0]).Text),
                        PrecioUnitario = double.Parse(((TextBox)gvDetalle.Rows[RowIndex].Cells[6].Controls[0]).Text),
                        PrecioTotal = double.Parse(((TextBox)gvDetalle.Rows[RowIndex].Cells[7].Controls[0]).Text),

                    };
                    var old = Factura.Detalles.First(x => x.Identificador == gvDetalle.DataKeys[RowIndex]["Identificador"].ToString());
                    var index = Factura.Detalles.IndexOf(old);
                    Factura.Detalles[index] = detalle;
                    gvDetalle.EditIndex = -1;
                    gvDetalle.DataBind();
                    break;
                case "Editar":
                    gvDetalle.EditIndex = RowIndex;
                    gvDetalle.DataBind();
                    break;
            }
            cargarGrilla(0);
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            var factura = new Factura
            {
                FacturaId = Factura.FacturaId,
                Codigo = txtCodigo.Text,
                Total = double.Parse(txtTotal.Text),
                TipoId = int.Parse(ddlTipo.SelectedValue),
                Igv = double.Parse(txtIgv.Text),
                Fecha = DateTime.Parse(txtFecha.Text),
                FormaPagoId = int.Parse(ddlFormaPago.SelectedValue),
                ProveedorId = int.Parse(ddlProveedor.SelectedValue),
                ContactoId = int.Parse(ddlContacto.SelectedValue),
                PlazoEntrega = int.Parse(txtPlazoEntrega.Text),
                LugarEntrega = txtLugarEntrega.Text
            };
            var facturaOld = Facturas.FirstOrDefault(x => x.FacturaId == factura.FacturaId);
            if (facturaOld == null)
            {
                Facturas.Add(factura);
            }
            else
            {
                var index = Facturas.IndexOf(facturaOld);
                Facturas[index] = factura;
            }
        }

        protected void ddlProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlContacto.CargaContacto(int.Parse(ddlProveedor.SelectedValue));
        }
    }
}