using condominios.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace condominios.Entidade
{
    public class Funcionario
    {
        private FuncionarioDAO funcionarioDAO;

        public int Id { get; set; }
        public int Id_endereco { get; set; }
        public int Id_condominio { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Rg { get; set; }

        public Funcionario()
        {
            funcionarioDAO = new FuncionarioDAO();
        }

        public bool Adicionar()
        {
            return this.funcionarioDAO.Adicionar(this);
        }

        public bool Editar()
        {
            return this.funcionarioDAO.Editar(this);
        }

        public bool Excluir()
        {
            return this.funcionarioDAO.Excluir(Id);
        }
    }
}