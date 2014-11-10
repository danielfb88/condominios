﻿<%@ Page Title="Sindico" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmSindico.aspx.cs" Inherits="condominios.FrmSindico" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Cadastrar <%: Title %>.</h2>

    <asp:Panel runat="server" ID="pnlCadastro" Visible="true">
        <ul>

            <li>
                <asp:Label Text="Id" ID="lbId" runat="server" />
                <asp:TextBox ID="txId" Enabled="false" Text="" runat="server" />
            </li>

            <li>
                <asp:Label Text="Id Endereco" ID="lbIdEndereco" runat="server" />
                <asp:TextBox ID="txIdEndereco" Text="" runat="server" />
            </li>

            <li>
                <asp:Label Text="Id Condominio" ID="lbIdCondominio" runat="server" />
                <asp:TextBox ID="txIdCondominio" Text="" runat="server" />
            </li>

            <li>
                <asp:Label Text="Nome" ID="lbNome" runat="server" />
                <asp:TextBox ID="txNome" Text="" runat="server" />
            </li>

            <li>
                <asp:Label Text="CPF" ID="lbCPF" runat="server" />
                <asp:TextBox ID="txCPF" Text="" runat="server" />
            </li>

            <li>
                <asp:Label Text="RG" ID="lbRg" runat="server" />
                <asp:TextBox ID="txRg" Text="" runat="server" />
            </li>


            <li>
                <asp:Button ID="btnCadastrar" runat="server" Text="Salvar" OnClick="btnCadastrar_Click" />
            </li>

        </ul>

    </asp:Panel>

    <asp:GridView ID="gridView1" runat="server" AutoGenerateEditButton="true" 
        AutoGenerateDeleteButton="true" OnRowEditing="EditRowButton_Click" OnRowDeleting="DeleteRowButton_Click" />
    
</asp:Content>