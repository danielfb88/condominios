<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmCadMorador.aspx.cs" Inherits="condominios.forms.cadastro.FrmCadMorador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Panel runat="server" ID="pnlCadastro" Visible="true">
        <ul>

            <li>
                <asp:Label Text="Id" ID="lbId" runat="server" />
                <asp:TextBox ID="txId" Enabled="false" Text="" runat="server" />
            </li>

            <li>
                <asp:Label Text="Id Condominio" ID="lbidCondominio" runat="server" />
                <asp:TextBox ID="txIdCondominio" Text="" runat="server" />
            </li>

            <li>
                <asp:Label Text="Nome" ID="lbNome" runat="server" />
                <asp:TextBox ID="txNome" Text="" runat="server" />
            </li>

            <li>
                <asp:Label Text="Cpf" ID="lbCpf" runat="server" />
                <asp:TextBox ID="txCpf" Text="" runat="server" />
            </li>

            <li>
                <asp:Label Text="Rg" ID="lbRg" runat="server" />
                <asp:TextBox ID="txRg" Text="" runat="server" />
            </li>

            <li>
                <asp:Label Text="Numero Apt" ID="lbNumeroApt" runat="server" />
                <asp:TextBox ID="txNumeroApt" Text="" runat="server" />
            </li>

            <li>
                <asp:Label Text="Adimplente" ID="lbAdimplente" runat="server" />
                <asp:CheckBox ID="cbAdimplente" runat="server" />
            </li>

            <li>
                <asp:Button ID="btnCadastrar" runat="server" Text="Salvar" OnClick="btnCadastrar_Click" />
            </li>

        </ul>

    </asp:Panel>

</asp:Content>
