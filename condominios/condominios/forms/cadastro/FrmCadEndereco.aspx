<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmCadEndereco.aspx.cs" Inherits="condominios.forms.cadastro.FrmCadEndereco" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<asp:Panel runat="server" ID="pnlCadastro" Visible="true">
            <ul><li>
                    <asp:Label Text="Id" ID="lbId" runat="server" />
                    <asp:TextBox ID="txId" Enabled="false" Text="" runat="server" />
                </li>

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
                    <asp:Button ID="btnCadastrar" runat="server" Text="Salvar" OnClick="btnCadastrar_Click"/>
                </li>

            </ul>

        </asp:Panel>

</asp:Content>
