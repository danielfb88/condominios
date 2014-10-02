using condominios.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace condominios.Entidade
{
    public class Endereco
    {
        private EnderecoDAO enderecoDAO;

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
            enderecoDAO = new EnderecoDAO();
        }

        public bool Adicionar()
        {
            return this.enderecoDAO.Adicionar(this);
        }

        public bool Editar()
        {
            return this.enderecoDAO.Editar(this);
        }

        public bool Excluir()
        {
            return this.enderecoDAO.Excluir(Id);
        }
    }
}