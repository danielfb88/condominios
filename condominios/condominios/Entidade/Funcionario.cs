using condominios.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace condominios.Entidade
{
    public class Funcionario
    {
        private FuncionarioDAO dao;

        public int Id { get; set; }
        public int Id_endereco { get; set; }
        public int Id_condominio { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Rg { get; set; }

        public Funcionario()
        {
            dao = new FuncionarioDAO();
        }

        public bool Adicionar()
        {
            return this.dao.Adicionar(this);
        }

        public bool Editar()
        {
            return this.dao.Editar(this);
        }

        public bool Excluir()
        {
            return this.dao.Excluir(Id);
        }

        public Funcionario GetPorId(int id)
        {
            return this.dao.GetPorId(id);
        }

        public List<Funcionario> GetTodos()
        {
            return this.dao.GetTodos();
        }

        public int NextId()
        {
            return this.dao.NextId();
        }
    }
}