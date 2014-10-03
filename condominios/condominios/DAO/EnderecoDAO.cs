using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using condominios.Entidade;
using System.Text;
using System.Data;
using Npgsql;

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

            builder.Append("id, ");
            builder.Append("cidade, ");
            builder.Append("estado, ");
            builder.Append("cep, ");
            builder.Append("bairro, ");
            builder.Append("numero, ");
            builder.Append("logradouro, ");
            builder.Append("complemento ");

            builder.Append(") ");

            builder.Append("VALUES ");

            builder.Append("(");

            builder.Append(endereco.Id + ", ");
            builder.Append("'" + endereco.Cidade + "', ");
            builder.Append("'" + endereco.Estado + "', ");
            builder.Append("'" + endereco.Cep + "', ");
            builder.Append("'" + endereco.Bairro + "', ");
            builder.Append("'" + endereco.Numero + "', ");
            builder.Append("'" + endereco.Logradouro + "', ");
            builder.Append("'" + endereco.Complemento + "' ");

            builder.Append(");");

            return this.Update(builder.ToString());
        }

        public bool Editar(Endereco endereco)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("UPDATE ");
            builder.Append(this.TableName + " ");
            builder.Append("SET ");

            builder.Append("cidade = '");
            builder.Append(endereco.Cidade + "', ");

            builder.Append("estado = '");
            builder.Append(endereco.Estado + "', ");

            builder.Append("cep = '");
            builder.Append(endereco.Cep + "', ");

            builder.Append("bairro = '");
            builder.Append(endereco.Bairro + "', ");

            builder.Append("numero = '");
            builder.Append(endereco.Numero + "', ");

            builder.Append("logradouro = '");
            builder.Append(endereco.Logradouro + "', ");

            builder.Append("complemento = '");
            builder.Append(endereco.Complemento + "' ");

            builder.Append("WHERE ");
            builder.Append("id = " + endereco.Id);
            builder.Append(";");

            return this.Update(builder.ToString());
        }

        public Endereco GetPorId(int id)
        {
            NpgsqlDataReader dataReader = base.GetPorId(id);
            Endereco endereco = new Endereco();
            endereco.Id = (int)dataReader[0];
            endereco.Cidade = (String)dataReader[1];
            endereco.Estado = (String)dataReader[2];
            endereco.Cep = (String)dataReader[3];
            endereco.Bairro = (String)dataReader[4];
            endereco.Numero = (String)dataReader[5];
            endereco.Logradouro = (String)dataReader[6];
            endereco.Complemento = (String)dataReader[7];

            return endereco;
        }

        public List<Endereco> GetTodos()
        {
            List<Endereco> listEndereco = new List<Endereco>();

            NpgsqlDataReader dataReader = base.GetTodos();
            while (dataReader.Read())
            {
                Endereco endereco = new Endereco();
                endereco.Id = (int)dataReader[0];
                endereco.Cidade = (String)dataReader[1];
                endereco.Estado = (String)dataReader[2];
                endereco.Cep = (String)dataReader[3];
                endereco.Bairro = (String)dataReader[4];
                endereco.Numero = (String)dataReader[5];
                endereco.Logradouro = (String)dataReader[6];
                endereco.Complemento = (String)dataReader[7];

                listEndereco.Add(endereco);
            }

            return listEndereco;
        }
    }
}