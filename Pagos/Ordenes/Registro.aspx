<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Master.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Pagos.Ordenes.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container border-10 rounded">
        <div class="row">
            <div>
                <h1>Registrar Orden</h1>
            </div>
        </div>
        <div class="row">
            <div>
                <h2>Nueva Orden</h2>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-3">
                <asp:Label Text="Código:" runat="server" ID="lblCodigo" />
            </div>
            <div class="col-sm-3">
                <asp:TextBox runat="server" ID="txtCodigo" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtCodigo" Text="*" ValidationGroup="Orden" runat="server" />
            </div>
            <div class="col-sm-3">
                <asp:Label Text="Total:" runat="server" ID="lblTotal" />
            </div>
            <div class="col-sm-3">
                <asp:TextBox runat="server" ID="txtTotal" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtTotal" Text="*" ValidationGroup="Orden" runat="server" />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-3">
                <asp:Label Text="Tipo:" runat="server" />
            </div>
            <div class="col-sm-3">
                <asp:DropDownList runat="server" ID="ddlTipo" CssClass="form-control"></asp:DropDownList>
            <asp:RequiredFieldValidator ControlToValidate="ddlTipo" Text="*" ValidationGroup="Orden" runat="server" />
            </div>
            <div class="col-sm-3">
                <asp:Label Text="I.G.V.:" runat="server" />
            </div>
            <div class="col-sm-3">
                <asp:TextBox runat="server" ID="txtIgv" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtIgv" Text="*" ValidationGroup="Orden" runat="server" />
            </div>
        </div>


       <div class="row">
            <div class="col-sm-3">
                <asp:Label Text="Fecha:" runat="server" />
            </div>
            <div class="col-sm-3">
                <asp:TextBox runat="server" ID="txtFecha" CssClass="form-control" />
            </div>
            <div class="col-sm-3">
                <asp:Label Text="Forma de Pago:" runat="server" />
            </div>
            <div class="col-sm-3">
                <asp:DropDownList runat="server" ID="ddlFormaPago" CssClass="form-control" />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-3">
                <asp:Label Text="Proveedor:" runat="server" />
            </div>
            <div class="col-sm-3">
                <asp:DropDownList runat="server" ID="ddlProveedor" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlProveedor_SelectedIndexChanged" />
            </div>
            <div class="col-sm-3">
                <asp:Label Text="Contacto:" runat="server" />
            </div>
            <div class="col-sm-3">
                <asp:DropDownList runat="server" ID="ddlContacto" CssClass="form-control" />
            </div>
        </div>
        <div class="row py-5">
            <div class="col-sm-3">
                <asp:Label Text="Plazo de Entrega:" runat="server" />
            </div>
            <div class="col-sm-3">
                <asp:TextBox runat="server" ID="txtPlazoEntrega" CssClass="form-control" />
            </div>
            <div class="col-sm-3">
                <asp:Label Text="Lugar de Entrega:" runat="server" />
            </div>
            <div class="col-sm-3">
                <asp:TextBox runat="server" ID="txtLugarEntrega" CssClass="form-control" />
            </div>
        </div>
       <div class="row">
           <div class="col-sm-12">
               <asp:LinkButton Text="Añadir Detalle" runat="server" id="lnkAddDetalle" OnClick="lnkAddDetalle_Click" />
           </div>
           <div class="col-sm-12">
               <asp:GridView runat="server" CssClass="table " DataKeyNames="Identificador" ID="gvDetalle" AutoGenerateColumns="False" EnableModelValidation="True" OnRowCommand="gvDetalle_RowCommand">
                   <Columns>
                       <asp:BoundField DataField="CentroCosto" HeaderText="Ctos. de Costo" />
                       <asp:BoundField DataField="Item" HeaderText="Item" />
                       <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                       <asp:BoundField DataField="Codigo" HeaderText="Código" />
                       <asp:BoundField DataField="Cuotas" HeaderText="Cuotas" />
                       <asp:BoundField DataField="Unidad" HeaderText="Unidad" />
                       <asp:BoundField DataField="PrecioUnitario" HeaderText="Precio Unitario"/>
                       <asp:BoundField DataField="PrecioTotal" HeaderText="Precio Total" />
                       <asp:TemplateField>
                           <EditItemTemplate>
                               <asp:LinkButton ID="lnkGuardar" runat="server" CommandName="Guardar">Guardar</asp:LinkButton>
                           </EditItemTemplate>
                           <ItemTemplate>
                               <asp:LinkButton ID="lnkEditar" runat="server" CommandName="Editar">Editar</asp:LinkButton>
                           </ItemTemplate>
                       </asp:TemplateField>
                   </Columns>
               </asp:GridView>
           </div>
       </div>
        <div class="row">
            <div class=" col-sm-12">
                <asp:Button Text="Guardar" runat="server" CssClass="btn btn-primary" ID="btnGuardar" OnClick="btnGuardar_Click" />
            </div>
        </div>
    </div>
    
</asp:Content>
