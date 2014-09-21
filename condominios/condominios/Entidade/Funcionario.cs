using condominios.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace condominios.Entidade
{
    public class Funcionario
    {
        private int id;
        private int id_endereco;
        private int id_condominio;
        private String nome;
        private String cpf;
        private String rg;
        private FuncionarioDAO funcionarioDAO;

        public int Id { get; set; }
        public int Id_endereco { get; set; }
        public int Id_condominio { get; set; }
        public String Nome { get; set; }
        public String Rg { get; set; }

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
            return this.funcionarioDAO.Excluir(this.id);
        }
    }
}