using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using condominios.DAO;

namespace condominios.Entidade
{
    public class Condominio
    {
        private CondominioDAO dao;
        public int Id { get; set; }
        public int Id_endereco { get; set; }
        public int Qtd_Apt { get; set; }
        public double Valor_agua { get; set; }
        public double Valor_luz { get; set; }
        public double Valor_gas { get; set; }
        public String Nome { get; set; }

        public Condominio()
        {
            dao = new CondominioDAO();
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

        public Condominio GetPorId(int id)
        {
            return this.dao.GetPorId(id);
        }

        public List<Condominio> GetTodos()
        {
            return this.dao.GetTodos();
        }

        public int NextId()
        {
            return this.dao.NextId();
        }
    }
}