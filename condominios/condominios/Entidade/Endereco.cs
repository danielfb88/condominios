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
        private int id;
        private String cidade;
        private String estado;
        private String numero;
        private String bairro;
        private String logradouro;
        private String complemento;

        public int id { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public String Numero { get; set; }
        public String Bairro { get; set; }
        public String Logradouro { get; set; }
        public String Complemento { get; set; }
    }
}