using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using condominios.Entidade;
using System.Collections.Generic;
using System.Diagnostics;
using condominios.DAO;
using System.Globalization;

namespace condominios.Tests
{
    [TestClass]
    public class TestPersistencia
    {
        /*
         * Endereco
         * */

        [TestMethod]
        public void AdicaoEndereco()
        {
            Endereco endereco = new Endereco();
            endereco.Id = 1;
            endereco.Cidade = "Salvador";
            endereco.Estado = "BA";
            endereco.Bairro = "Cabula";
            endereco.Numero = "111";
            endereco.Cep = "4191221";
            endereco.Logradouro = "Rua drauzio trombeta";
            endereco.Complemento = "Perto do posto Ipiranha";

            Assert.IsTrue(endereco.Adicionar());
        }

        [TestMethod]
        public void EditarEndereco()
        {
            Endereco endereco = new Endereco();
            endereco.Id = 1;
            endereco.Cidade = "Sao Paulo";
            endereco.Estado = "SP";
            endereco.Bairro = "Dronho Andrade";
            endereco.Numero = "222";
            endereco.Cep = "1212121";
            endereco.Logradouro = "Rua drauzio trombeta 2";
            endereco.Complemento = "Ainda é Perto do posto Ipiranha";

            Assert.IsTrue(endereco.Editar());
        }

        [TestMethod]
        public void BuscaEnderecoPorId()
        {
            Endereco endereco = new Endereco().GetPorId(1);

            Assert.AreEqual("Sao Paulo", endereco.Cidade);
        }

        [TestMethod]
        public void ListarEndereco()
        {
            List<Endereco> listEndereco = new Endereco().GetTodos();

            Assert.IsTrue(listEndereco.Count == 1);
        }

        /*
         * Condominio
         * */

        [TestMethod]
        public void AdicaoCondominio()
        {
            Condominio condominio = new Condominio();
            condominio.Id = 1;
            condominio.Id_endereco = 1;
            condominio.Qtd_Apt = 20;
            condominio.Valor_agua = 30F;
            condominio.Valor_gas = 12F;
            condominio.Valor_luz = 40F;
            condominio.Nome = "Rivera";

            Assert.IsTrue(condominio.Adicionar());
        }

        [TestMethod]
        public void EditarCondominio()
        {
            Condominio condominio = new Condominio();
            condominio.Id = 1;
            condominio.Id_endereco = 1;
            condominio.Qtd_Apt = 40;
            condominio.Valor_agua = 30;
            condominio.Valor_gas = 12;
            condominio.Valor_luz = 40;
            condominio.Nome = "Rivera";

            Assert.IsTrue(condominio.Editar());
        }

        [TestMethod]
        public void BuscaCondominioPorId()
        {
            Condominio condominio = new Condominio().GetPorId(1);

            Assert.AreEqual(40, condominio.Qtd_Apt);
        }

        [TestMethod]
        public void ListarCondominio()
        {
            List<Condominio> listCondominio = new Condominio().GetTodos();

            Assert.IsTrue(listCondominio.Count == 1);
        }

        /*
         * Morador
         * */
        [TestMethod]
        public void AdicaoMorador()
        {
            Morador morador = new Morador();
            morador.Id = 1;
            morador.Id_condominio = 1;
            morador.Nome = "Maria";
            morador.Numero_apt = 102;
            morador.Rg = "1111221";
            morador.Cpf = "21313131";
            morador.Adimplente = false;

            Assert.IsTrue(morador.Adicionar());
        }

        [TestMethod]
        public void EditarMorador()
        {
            Morador morador = new Morador();
            morador.Id = 1;
            morador.Id_condominio = 1;
            morador.Nome = "Joao";
            morador.Numero_apt = 103;
            morador.Rg = "1111221";
            morador.Cpf = "21313131";
            morador.Adimplente = false;

            Assert.IsTrue(morador.Editar());
        }

        [TestMethod]
        public void BuscaMoradorPorId()
        {
            Morador morador = new Morador().GetPorId(1);

            Assert.AreEqual("Joao", morador.Nome);
        }

        [TestMethod]
        public void ListarMorador()
        {
            List<Morador> listMorador = new Morador().GetTodos();

            Assert.IsTrue(listMorador.Count == 1);
        }

        /*
         * Funcionario
         * */
        [TestMethod]
        public void AdicaoFuncionario()
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Id = 1;
            funcionario.Id_condominio = 1;
            funcionario.Id_endereco = 1;
            funcionario.Nome = "Jurandir da Silva Sauro";
            funcionario.Rg = "1212121";
            funcionario.Cpf = "12312313";

            Assert.IsTrue(funcionario.Adicionar());
        }

        [TestMethod]
        public void EditarFuncionario()
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Id = 1;
            funcionario.Id_condominio = 1;
            funcionario.Id_endereco = 1;
            funcionario.Nome = "Jurêmo dos Santos";
            funcionario.Rg = "12234";
            funcionario.Cpf = "45556";

            Assert.IsTrue(funcionario.Editar());
        }

        [TestMethod]
        public void BuscaFuncionarioPorId()
        {
            Funcionario funcionario = new Funcionario().GetPorId(1);

            Assert.AreEqual("12234", funcionario.Rg);
        }

        [TestMethod]
        public void ListarFuncionario()
        {
            List<Funcionario> listFuncionario = new Funcionario().GetTodos();

            Assert.IsTrue(listFuncionario.Count == 1);
        }

        [TestMethod]
        public void ExclusaoFuncionario()
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Id = 1;

            Assert.IsTrue(funcionario.Excluir());
        }

        /*
        * Sindico
        * */
        [TestMethod]
        public void AdicaoSindico()
        {
            Sindico sindico = new Sindico();
            sindico.Id = 1;
            sindico.Id_condominio = 1;
            sindico.Id_endereco = 1;
            sindico.Nome = "Marcela Freitas";
            sindico.Rg = "223344";
            sindico.Cpf = "3242456";

            Assert.IsTrue(sindico.Adicionar());
        }

        [TestMethod]
        public void EditarSindico()
        {
            Sindico sindico = new Sindico();
            sindico.Id = 1;
            sindico.Id_condominio = 1;
            sindico.Id_endereco = 1;
            sindico.Nome = "Fabricio Oliveira";
            sindico.Rg = "5666";
            sindico.Cpf = "657657";

            Assert.IsTrue(sindico.Editar());
        }

        [TestMethod]
        public void BuscaSindicoPorId()
        {
            Sindico sindico = new Sindico().GetPorId(1);

            Assert.AreEqual("5666", sindico.Rg);
        }

        [TestMethod]
        public void ListarSindico()
        {
            List<Sindico> listSindico = new Sindico().GetTodos();

            Assert.IsTrue(listSindico.Count == 1);
        }

        [TestMethod]
        public void ExclusaoSindico()
        {
            Sindico sindico = new Sindico();
            sindico.Id = 1;

            Assert.IsTrue(sindico.Excluir());
        }

        /*
         * Relatórios
         * *
         * */
        [TestMethod]
        public void ConsultaValoresCondominio()
        {
            RelatorioDAO relatorioDao = new RelatorioDAO();
            List<String[]> list = relatorioDao.RelatorioValoresCondominio();

            float somatorio = 0;
            foreach(String[] linha in list) {
                somatorio += float.Parse(linha[4], CultureInfo.InvariantCulture.NumberFormat);                
            }
            
            Assert.IsTrue(list.Count == 1 && somatorio == 82); // 30+ 12 + 40
        }

        [TestMethod]
        public void MoradoresInadimplentes()
        {
            RelatorioDAO relatorioDao = new RelatorioDAO();
            List<String[]> list = relatorioDao.RelatorioMoradoresInadimplentes();

            Assert.IsTrue(list.Count == 1);
        }

        /*
         * Exclusoes Restantes
         * */
        [TestMethod]
        public void ExclusaoMorador()
        {
            Morador morador = new Morador();
            morador.Id = 1;

            Assert.IsTrue(morador.Excluir());
        }

        [TestMethod]
        public void ExclusaoCondominio()
        {
            Condominio condominio = new Condominio();
            condominio.Id = 1;

            Assert.IsTrue(condominio.Excluir());
        }

        [TestMethod]
        public void ExclusaoEndereco()
        {
            Endereco endereco = new Endereco();
            endereco.Id = 1;

            Assert.IsTrue(endereco.Excluir());
        }

    }
}
