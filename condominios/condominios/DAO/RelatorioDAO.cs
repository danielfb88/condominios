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
        public List<String[]> RelatorioValoresCondominio()
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

            NpgsqlDataReader dataReader = this.Fetch(builder.ToString());

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    String[] linha = new String[5];
                    linha[0] = Convert.ToString(dataReader.GetValue(0));
                    linha[1] = Convert.ToString(dataReader.GetValue(1));
                    linha[2] = Convert.ToString(dataReader.GetValue(2));
                    linha[3] = Convert.ToString(dataReader.GetValue(3));
                    linha[4] = Convert.ToString(dataReader.GetValue(4));

                    list.Add(linha);
                }
            }

            return list;
        }

        public List<String[]> RelatorioMoradoresInadimplentes()
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

            NpgsqlDataReader dataReader = this.Fetch(builder.ToString());

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    String[] linha = new String[3];
                    linha[0] = Convert.ToString(dataReader.GetValue(0));
                    linha[1] = Convert.ToString(dataReader.GetValue(1));
                    linha[2] = Convert.ToString(dataReader.GetValue(2));

                    list.Add(linha);
                }
            }

            return list;
        }


    }

    
}