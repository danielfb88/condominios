using condominios.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace condominios.Entidade
{
    public class Morador
    {
        private MoradorDAO moradorDAO;

        public int Id { get; set; }
        public int Id_condominio { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Rg { get; set; }
        public int Numero_apt { get; set; }

        public Morador()
        {
            moradorDAO = new MoradorDAO();
        }

        public bool Adicionar()
        {
            return this.moradorDAO.Adicionar(this);
        }

        public bool Editar()
        {
            return this.moradorDAO.Editar(this);
        }

        public bool Excluir()
        {
            return this.moradorDAO.Excluir(Id);
        }
    }
}