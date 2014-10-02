using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using condominios.DAO;

namespace condominios.Entidade
{
    public class Condominio
    {
        private CondominioDAO condominioDAO;
        public int Id { get; set; }
        public int Id_endereco { get; set; }
        public int Qtd_Apt { get; set; }
        public float Valor_agua { get; set; }
        public float Valor_luz { get; set; }
        public float Valor_gas { get; set; }

        public Condominio()
        {
            condominioDAO = new CondominioDAO();
        }

        public bool Adicionar()
        {
            return this.condominioDAO.Adicionar(this);
        }

        public bool Editar()
        {
            return this.condominioDAO.Editar(this);
        }

        public bool Excluir()
        {
            return this.condominioDAO.Excluir(Id);
        }
    }
}