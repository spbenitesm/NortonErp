<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Master.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Pagos.Proyectos.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container border-10 rounded">
        <div class="row">
            <div>
                <h1>Registrar Proyecto</h1>
            </div>
        </div>
        <div class="row">
            <div>
                <h2>Nuevo Proyecto</h2>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-3">
                <asp:Label Text="Centro de Costo:" runat="server" ID="lblCentroCosto" />
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="txtCentroCosto" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtCentroCosto" Text="*" ValidationGroup="Proyecto" runat="server" />
            </div>
            <div class="col-sm-3">
                <asp:Label Text="Moneda:" runat="server" ID="lblMoneda" />
            </div>
            <div class="col-sm-3">
                <asp:DropDownList ID="ddlMoneda" runat="server" CssClass="form-control"></asp:DropDownList>
                <asp:RequiredFieldValidator InitialValue="0" ControlToValidate="ddlMoneda" Text="*" ValidationGroup="Proyecto" runat="server" />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-3">
                <asp:Label Text="Nombre Proyecto:" runat="server" ID="lblProyecto" />
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="txtProyecto" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtProyecto" Text="*" ValidationGroup="Proyecto" runat="server" />
            </div>
            <div class="col-sm-3">
                <asp:Label Text="Monto Presupuesto:" runat="server" ID="lblMontoPresupuesto" />
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="txtMontoPresupuesto" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtMontoPresupuesto" Text="*" ValidationGroup="Proyecto" runat="server" />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-3">
                <asp:Label Text="Residente de Obra:" runat="server" ID="lblResidenteObra" />
            </div>
            <div class="col-sm-3">
                <asp:DropDownList ID="ddlResidenteObra" runat="server" CssClass="form-control"></asp:DropDownList>
                <asp:RequiredFieldValidator InitialValue="0" ControlToValidate="ddlResidenteObra" Text="*" ValidationGroup="Proyecto" runat="server" />
            </div>
            <div class="col-sm-3">
                <asp:Label Text="% Utilidad Contratado:" runat="server" ID="lblUtilidadContratado" />
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="txtUtilidadContratado" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtUtilidadContratado" Text="*" ValidationGroup="Proyecto" runat="server" />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-3">
                <asp:Label Text="Gerente de Obra:" runat="server" ID="lblGerenteObra" />
            </div>
            <div class="col-sm-3">
                <asp:DropDownList ID="ddlGerenteObra" runat="server" CssClass="form-control"></asp:DropDownList>
                <asp:RequiredFieldValidator InitialValue="0" ControlToValidate="ddlGerenteObra" Text="*" ValidationGroup="Proyecto" runat="server" />
            </div>
            <div class="col-sm-3">
                <asp:Label Text="% Utilidad Real:" runat="server" ID="lblUtilidadReal" />
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="txtUtilidadReal" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtUtilidadReal" Text="*" ValidationGroup="Proyecto" runat="server" />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6"></div>
            <div class="col-sm-3">
                <asp:Label Text="Monto Gastos Generales" ID="lblMontoGastosGenerales" runat="server" />
            </div>
            <div class="col-sm-3">
                <asp:TextBox runat="server" ID="txtMontoGastosGenerales" CssClass="form-control" />
                <asp:RequiredFieldValidator ControlToValidate="txtMontoGastosGenerales" Text="*" ValidationGroup="Proyecto" runat="server" />
            </div>
        </div>
         <div class="row">
            <div class="col-sm-6"></div>
            <div class="col-sm-3">
                <asp:Label Text="Impuesto I.G.V." ID="lblImpuestoIgv" runat="server" />
            </div>
            <div class="col-sm-3">
                <asp:TextBox runat="server" ID="txtImpuestoIgv" CssClass="form-control" />
                <asp:RequiredFieldValidator ControlToValidate="txtImpuestoIgv" Text="*" ValidationGroup="Proyecto" runat="server" />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6"></div>
            <div class="col-sm-3">
                <asp:Label Text="Monto Total Proyecto" ID="lblMontoTotalProyecto" runat="server" />
            </div>
            <div class="col-sm-3">
                <asp:TextBox runat="server" ID="txtMontoTotalProyecto" CssClass="form-control" />
                <asp:RequiredFieldValidator ControlToValidate="txtMontoTotalProyecto" Text="*" ValidationGroup="Proyecto" runat="server" />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                <asp:Button ValidationGroup="Proyecto" Text="Guardar Proyecto" runat="server" ID="btnGuardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" OnClientClick="confirmacion(this)" />
            </div>
             <div class="col-sm-6">
                <asp:Button Text="Cancelar" runat="server" ID="btnCancelar" CssClass="btn btn-secondary" OnClick="btnCancelar_Click"/>
            </div>
        </div>
    </div>
    <script src="../Scripts/pages/ProyectoRegistro.js"></script>
</asp:Content>
