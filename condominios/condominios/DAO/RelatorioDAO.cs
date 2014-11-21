using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace condominios.DAO
{
    public class RelatorioDAO : DAOGenerico
    {
        /* Uso de Procedure */
        public NpgsqlDataReader RelatorioValoresCondominio()
        {
            List<String[]> list = new List<String[]>();
            StringBuilder builder = new StringBuilder();
            builder.Append("SELECT ");
            builder.Append("nome, ");
            builder.Append("valor_luz, ");
            builder.Append("valor_agua, ");
            builder.Append("valor_gas, ");
            builder.Append("(select total_valor_condominio()) as total ");

            builder.Append("FROM condominio ");
            builder.Append(";");

            return this.Fetch(builder.ToString());
        }

        public NpgsqlDataReader RelatorioMoradoresInadimplentes()
        {
            List<String[]> list = new List<String[]>();
            StringBuilder builder = new StringBuilder();
            builder.Append("SELECT ");
            builder.Append("nome, ");
            builder.Append("cpf, ");
            builder.Append("numero_apt ");

            builder.Append("FROM morador ");

            builder.Append("WHERE adimplente = 0 ");
            builder.Append(";");

            return this.Fetch(builder.ToString());
        }
    }    
}