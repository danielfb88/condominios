using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using condominios.Entidade;
using System.Text;

namespace condominios.DAO
{
    public class EnderecoDAO : DAOGenerico
    {
        public EnderecoDAO()
        {
            this.TableName = "endereco";
        }

        public bool Adicionar(Endereco endereco)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("INSERT INTO ");
            builder.Append(this.TableName + " ");

            builder.Append("( ");

            builder.Append("cidade, ");
            builder.Append("estado, ");
            builder.Append("cep, ");
            builder.Append("bairro, ");
            builder.Append("numero, ");
            builder.Append("logradouro, ");
            builder.Append("complemento ");

            builder.Append(") ");

            builder.Append("VALUES ");

            builder.Append("('");

            builder.Append("'" + endereco.Cidade + "', ");
            builder.Append("'" + endereco.Estado + "', ");
            builder.Append("'" + endereco.Cep + "', ");
            builder.Append("'" + endereco.Bairro + "', ");
            builder.Append("'" + endereco.Numero + "', ");
            builder.Append("'" + endereco.Logradouro + "', ");
            builder.Append("'" + endereco.Complemento + "' ");

            builder.Append("');");

            return this.update(builder.ToString());
        }

        public bool Editar(Condominio condominio)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("UPDATE ");
            builder.Append(this.TableName + " ");
            builder.Append("SET ");

            builder.Append("id_endereco = ");
            builder.Append(condominio.Id_endereco + ", ");

            builder.Append("qtd_apt = ");
            builder.Append(condominio.Qtd_Apt + ", ");

            builder.Append("valor_agua = ");
            builder.Append(condominio.Valor_agua + ", ");

            builder.Append("valor_luz = ");
            builder.Append(condominio.Valor_luz + ", ");

            builder.Append("valor_gas = ");
            builder.Append(condominio.Valor_gas + " ");

            builder.Append("WHERE ");
            builder.Append("id = " + condominio.Id);
            builder.Append(";");

            return this.update(builder.ToString());
        }
    }
}