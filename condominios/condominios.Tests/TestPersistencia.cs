using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using condominios.Entidade;

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

            Assert.IsTrue(condominio.Adicionar());
        }

        [TestMethod]
        public void EditarCondominio()
        {
            Condominio condominio = new Condominio();
            condominio.Id = 1;
            condominio.Id_endereco = 1;
            condominio.Qtd_Apt = 40;
            condominio.Valor_agua = 30F;
            condominio.Valor_gas = 12F;
            condominio.Valor_luz = 40F;

            Assert.IsTrue(condominio.Editar());
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

            Assert.IsTrue(morador.Editar());
        }

        [TestMethod]
        public void ExclusaoMorador()
        {
            Morador morador = new Morador();
            morador.Id = 1;

            Assert.IsTrue(morador.Excluir());
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
        public void ExclusaoSindico()
        {
            Sindico sindico = new Sindico();
            sindico.Id = 1;

            Assert.IsTrue(sindico.Excluir());
        }

        /*
         * Exclusoes Restantes
         * */
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
