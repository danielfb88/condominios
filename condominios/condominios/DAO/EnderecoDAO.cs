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
            Endereco obj = new Endereco();

            if (dataReader.HasRows && dataReader.Read())
            {
                obj = this.PreencherObjeto(dataReader);
            }

            return obj;
        }

        public List<Endereco> GetTodos()
        {
            List<Endereco> list = new List<Endereco>();

            NpgsqlDataReader dataReader = base.GetTodos();
            if (dataReader.HasRows)
            {
                while (dataReader.Read()) 
                {
                    list.Add(this.PreencherObjeto(dataReader));
                } 
            }

            return list;
        }

        private Endereco PreencherObjeto(NpgsqlDataReader dataReader)
        {
            int i = 0;
            Endereco obj = new Endereco();
            obj.Id = dataReader.GetInt32(i++);
            obj.Cidade = dataReader.GetString(i++);
            obj.Estado = dataReader.GetString(i++);
            obj.Cep = dataReader.GetString(i++);
            obj.Bairro = dataReader.GetString(i++);
            obj.Numero = dataReader.GetString(i++);
            obj.Logradouro = dataReader.GetString(i++);
            obj.Complemento = dataReader.GetString(i++);

            return obj;
        }
    }
}