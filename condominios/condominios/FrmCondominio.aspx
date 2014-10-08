﻿<%@ Page Title="Condomínio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmCondominio.aspx.cs" Inherits="condominios.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Cadastrar <%: Title %>.</h2>

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
            </li>
        </ul>

    </asp:Panel>

    <asp:GridView ID="gridView1" runat="server" AutoGenerateEditButton="true" 
        AutoGenerateDeleteButton="true" OnRowEditing="EditRowButton_Click" OnRowDeleting="DeleteRowButton_Click" />
</asp:Content>
