using condominios.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace condominios.Entidade
{
    public class Sindico
    {
        private SindicoDAO sindicoDAO;

        public int Id { get; set; }
        public int Id_endereco { get; set; }
        public int Id_condominio { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Rg { get; set; }

        public Sindico()
        {
            sindicoDAO = new SindicoDAO();
        }

        public bool Adicionar()
        {
            return this.sindicoDAO.Adicionar(this);
        }

        public bool Editar()
        {
            return this.sindicoDAO.Editar(this);
        }

        public bool Excluir()
        {
            return this.sindicoDAO.Excluir(Id);
        }

        public Sindico GetPorId(int id)
        {
            return this.sindicoDAO.GetPorId(id);
        }

        public List<Sindico> GetTodos()
        {
            return this.sindicoDAO.GetTodos();
        }    
    }
}