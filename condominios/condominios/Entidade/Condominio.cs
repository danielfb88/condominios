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
        private int id;
        private int id_endereco;
        private int qtd_apt;
        private float valor_agua;
        private float valor_luz;
        private float valor_gas;

        public int Id { get; set; }
        public int Id_endereco { get; set; }
        public int Qtd_Apt { get; set; }
        public float Valor_agua { get; set; }
        public float Valor_luz { get; set; }
        public float Valor_gas { get; set; }        
    }
}