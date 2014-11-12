using condominios.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace condominios.Entidade
{
    public class Endereco
    {
        private EnderecoDAO dao;

        public int Id { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public String Numero { get; set; }
        public String Bairro { get; set; }
        public String Cep { get; set; }
        public String Logradouro { get; set; }
        public String Complemento { get; set; }

        public Endereco()
        {
            dao = new EnderecoDAO();
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

        public Endereco GetPorId(int id)
        {
            return this.dao.GetPorId(id);
        }

        public List<Endereco> GetTodos()
        {
            return this.dao.GetTodos();
        }

        public int NextId()
        {
            return this.dao.NextId();
        }

    }
}