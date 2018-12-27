<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Master.Master" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="Pagos.Proyectos.Consulta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <h1>Consultar Proyecto</h1>
        </div>
        <div class="row">
            <div class="col-sm-1">
                <asp:Button Text="Añadir" runat="server" ID="btnAdd" CssClass="btn btn-info" OnClick="btnAdd_Click" />
            </div>
            <div class="col-sm-1">
                <asp:Button Text="Eliminar" runat="server" ID="btnDel" CssClass="btn btn-info" />
            </div>
            <div class="col-sm-10">
                <asp:TextBox runat="server" ID="txtBuscar" CssClass="form-control" />
                <asp:Button Text="Buscar" runat="server" ID="btnBuscar" CssClass="btn btn-primary" OnClick="btnBuscar_Click" />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <asp:GridView runat="server" ID="gvProyectos" AllowPaging="True" AutoGenerateColumns="False" CssClass="table" EmptyDataText="No se encontraron Proyectos" EnableModelValidation="True" DataKeyNames="Id">
                    <Columns>
                        <asp:BoundField DataField="CentroCosto" HeaderText="Centro Costo" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="MontoPresupuesto" HeaderText="Monto Presupuestado" />
                        <asp:BoundField DataField="MontoGastosGenerales" HeaderText="Monto Gastos Generales" />
                        <asp:BoundField HeaderText="Monto Total" />
                        <asp:TemplateField HeaderText="Presupuesto">
                            <ItemTemplate>
                                <asp:LinkButton runat="server" ID="lnkPresupuesto" Text="Ojo" CommandName="VerPresupuesto" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Acciones"></asp:TemplateField>
                    </Columns>
                    <HeaderStyle CssClass="thead-dark" />
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
