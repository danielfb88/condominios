using condominios.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace condominios.Entidade
{
    public class Sindico
    {
        private int id;
        private int id_endereco;
        private int id_condominio;
        private String nome;
        private String cpf;
        private String rg;
        private SindicoDAO sindicoDAO;

        public int Id { get; set; }
        public int Id_endereco { get; set; }
        public int Id_condominio { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Rg { get; set; }

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
            return this.sindicoDAO.Excluir(this.id);
        }
    }
}