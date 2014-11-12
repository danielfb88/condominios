using condominios.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace condominios.Entidade
{
    public class Morador
    {
        private MoradorDAO dao;

        public int Id { get; set; }
        public int Id_condominio { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Rg { get; set; }
        public int Numero_apt { get; set; }
        public bool Adimplente { get; set; }

        public Morador()
        {
            dao = new MoradorDAO();
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

        public Morador GetPorId(int id)
        {
            return this.dao.GetPorId(id);
        }

        public List<Morador> GetTodos()
        {
            return this.dao.GetTodos();
        }

        public int NextId()
        {
            return this.dao.NextId();
        }
    }
}