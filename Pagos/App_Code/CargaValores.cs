using Entidades;
using Entidades.Varios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Pagos
{
    public static class CargaValores
    {
        #region Cargar

        public static void CargaMonedas(this DropDownList combo)
        {
            var monedas = new List<Moneda> {
            new Moneda {Id=1, Nombre="SOL" },
            new Moneda {Id=2, Nombre="DOLAR" }
            };
            combo.DataSource = monedas;
            combo.DataValueField = "Id";
            combo.DataTextField = "Nombre";
            combo.DataBind();

            AgregarSeleccione(ref combo);
            SeleccionaPorDefecto(ref combo);
        }
        public static void CargaResidentes(this DropDownList combo)
        {
            var residentes = new List<Usuario> {
                new Usuario {Id=1, Nombre="Adan Anibal", ApellidoPaterno="Alva", ApellidoMaterno="Azcona" },
                new Usuario {Id=2, Nombre="Blas Bruno", ApellidoPaterno="Botero", ApellidoMaterno="Baca" }
            };
            combo.DataSource = residentes;
            combo.DataValueField = "Id";
            combo.DataTextField = "NombreCompleto";
            combo.DataBind();

            AgregarSeleccione(ref combo);
            SeleccionaPorDefecto(ref combo);
        }
        public static void CargaGerentes(this DropDownList combo)
        {
            var residentes = new List<Usuario> {
                new Usuario {Id=1, Nombre="Zion Zeta", ApellidoPaterno="Zorrilla", ApellidoMaterno="Zapata" },
                new Usuario {Id=2, Nombre="Yen Yuan", ApellidoPaterno="Yacto", ApellidoMaterno="Yataco" }
            };
            combo.DataSource = residentes;
            combo.DataValueField = "Id";
            combo.DataTextField = "NombreCompleto";
            combo.DataBind();

            AgregarSeleccione(ref combo);
            SeleccionaPorDefecto(ref combo);
        }
        public static void CargaTipoOrden(this DropDownList combo)
        {
            var tipoOrden = new List<Parametro> {
                new Parametro {ParametroId=1, Nombre="Orden de Servicio" },
                new Parametro {ParametroId=2, Nombre="Orden de Compra" }
            };
            combo.DataSource = tipoOrden;
            combo.DataValueField = "ParametroId";
            combo.DataTextField = "Nombre";
            combo.DataBind();

            AgregarSeleccione(ref combo);
            SeleccionaPorDefecto(ref combo);
        }
        public static void CargaFormaPago(this DropDownList combo)
        {
            var formaPago = new List<Parametro> {
                new Parametro {ParametroId=1, Nombre="Forma Pago 1" },
                new Parametro {ParametroId=2, Nombre="Forma Pago 2" }
            };
            combo.DataSource = formaPago;
            combo.DataValueField = "ParametroId";
            combo.DataTextField = "Nombre";
            combo.DataBind();

            AgregarSeleccione(ref combo);
            SeleccionaPorDefecto(ref combo);
        }
        public static void CargaProveedor(this DropDownList combo)
        {
            var proveedores = new List<Proveedor> {
                new Proveedor {ProveedorId=1, Nombre="Danita S.A." },
                new Proveedor {ProveedorId=2, Nombre="Lines S.A.C." }
            };
            combo.DataSource = proveedores;
            combo.DataValueField = "ProveedorId";
            combo.DataTextField = "Nombre";
            combo.DataBind();

            AgregarSeleccione(ref combo);
            SeleccionaPorDefecto(ref combo);
        }
        public static void CargaContacto(this DropDownList combo, int ProveedorId)
        {
            List<Usuario> contactos;
            switch (ProveedorId)
            {
                case 1:
                    contactos = new List<Usuario> {
                new Usuario {Id=1, Nombre="Dana", ApellidoPaterno="Dongo", ApellidoMaterno="Diaz" },
                new Usuario {Id=2, Nombre="Esteban", ApellidoPaterno="Eutanasio", ApellidoMaterno="Espinoza" }
            };
                    break;
                case 2:
                    contactos = new List<Usuario> {
                new Usuario {Id=1, Nombre="Filomena", ApellidoPaterno="Flores", ApellidoMaterno="Figeroa" },
                new Usuario {Id=2, Nombre="German", ApellidoPaterno="Gutierrez", ApellidoMaterno="Garcia" }
            };
                    break;
                default:
                    contactos = new List<Usuario>();
                    break;
            }

            combo.DataSource = contactos;
            combo.DataValueField = "Id";
            combo.DataTextField = "NombreCompleto";
            combo.DataBind();

            AgregarSeleccione(ref combo);
            SeleccionaPorDefecto(ref combo);
        }


        #endregion
        #region Internos

        public static void AgregarSeleccione(ref DropDownList combo)
        {
            combo.Items.Insert(0, new ListItem { Value = "0", Text = "--SELECCIONE--" });
        }
        public static void SeleccionaPorDefecto(ref DropDownList combo)
        {
            if (combo.Items.Count == 2)
            {
                combo.SelectedIndex = 1;
            }
            else
            {
                combo.SelectedIndex = 0;
            }
        }
        #endregion
    }
}