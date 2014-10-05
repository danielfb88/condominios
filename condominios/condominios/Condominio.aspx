<%@ Page Title="Condomínio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Condominio.aspx.cs" Inherits="condominios.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Cadastrar <%: Title %>.</h2>

    <asp:Panel runat="server" ID="pnlCadastro" Visible="true">
        <ul>
            <li>
                <asp:Label Text="Cidade" ID="lbCidade" runat="server" />
                <asp:TextBox ID="txCidade" Text="" runat="server" />
            </li>
            
            <li>
                <asp:Label Text="Estado" ID="lbEstado" runat="server" />
                <asp:TextBox ID="txEstado" Text="" runat="server" />
            </li>

            <li>
                <asp:Label Text="Cep" ID="lbCep" runat="server" />
                <asp:TextBox ID="txCep" Text="" runat="server" />
            </li>

            <li>
                <asp:Label Text="Bairro" ID="lblBairro" runat="server" />
                <asp:TextBox ID="txBairro" Text="" runat="server" />
            </li>

            <li>
                <asp:Label Text="Numero" ID="lbNumero" runat="server" />
                <asp:TextBox ID="txNumero" Text="" runat="server" />
            </li>

            <li>
                <asp:Label Text="Logradouro" ID="lbLogradouro" runat="server" />
                <asp:TextBox ID="txLogradouro" Text="" runat="server" />
            </li>

            <li>
                <asp:Label Text="Complemento" ID="lbComplemento" runat="server" />
                <asp:TextBox ID="txComplemento" Text="" runat="server" />
            </li>

            <li>
                <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" />
            </li>

        </ul>

    </asp:Panel>
</asp:Content>
