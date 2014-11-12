using condominios.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace condominios.Entidade
{
    public class Sindico
    {
        private SindicoDAO dao;

        public int Id { get; set; }
        public int Id_endereco { get; set; }
        public int Id_condominio { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Rg { get; set; }

        public Sindico()
        {
            dao = new SindicoDAO();
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

        public Sindico GetPorId(int id)
        {
            return this.dao.GetPorId(id);
        }

        public List<Sindico> GetTodos()
        {
            return this.dao.GetTodos();
        }

        public int NextId()
        {
            return this.dao.NextId();
        }
    }
}