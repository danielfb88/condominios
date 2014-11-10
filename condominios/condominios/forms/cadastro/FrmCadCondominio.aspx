<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmCadCondominio.aspx.cs" Inherits="condominios.forms.cadastro.FrmCondominio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Panel runat="server" ID="pnlCadastro" Visible="true">
        <ul>
            <li>
                <asp:Label Text="Id Condominio" ID="lbCondominio" runat="server" />
                <asp:TextBox ID="txId" Enabled="false" Text="" runat="server" />
            </li>

            <li>
                <asp:Label Text="Id Endereco" ID="lbEndereco" runat="server" />
                <asp:TextBox ID="txIdEndereco" Text="" runat="server" />
            </li>
            
            <li>
                <asp:Label Text="Nome" ID="lbNome" runat="server" />
                <asp:TextBox ID="txNome" Text="" runat="server" />
            </li>

            <li>
                <asp:Label Text="Qtd Apt" ID="lbQtdApt" runat="server" />
                <asp:TextBox ID="txQtdApt" Text="" runat="server" />
            </li>

            <li>
                <asp:Label Text="Valor agua " ID="lbAgua" runat="server" />
                <asp:TextBox ID="txAgua" Text="" runat="server" />
            </li>

            <li>
                <asp:Label Text="Valor Luz" ID="lbLuz" runat="server" />
                <asp:TextBox ID="txLuz" Text="" runat="server" />
            </li>

            <li>
                <asp:Label Text="Valor Gas" ID="lbGas" runat="server" />
                <asp:TextBox ID="txGas" Text="" runat="server" />
            </li>

            <li>
                <asp:Button ID="btnCadastrar" runat="server" Text="Salvar" OnClick="btnCadastrar_Click"/>
                <asp:Button ID="btnNovo" runat="server" Text="Novo" OnClick="btnNovo_Click"/>
            </li>
        </ul>

    </asp:Panel>

</asp:Content>
