<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmRelatorioMorador.aspx.cs" Inherits="condominios.FrmRelatorioMorador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Panel runat="server" ID="pnlCadastro" Visible="true">
        <form id="form1" runat="server" class="form_settings">

            <asp:GridView ID="gridView1" runat="server" />
        </form>
    </asp:Panel>

</asp:Content>
