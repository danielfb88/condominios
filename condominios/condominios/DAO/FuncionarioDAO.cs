using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using condominios.Entidade;
using System.Text;
using Npgsql;

namespace condominios.DAO
{
    public class FuncionarioDAO : DAOGenerico
    {
        public FuncionarioDAO()
        {
            this.TableName = "funcionario";
        }

        public bool Adicionar(Funcionario funcionario)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("INSERT INTO ");
            builder.Append(this.TableName + " ");

            builder.Append("( ");

            builder.Append("id, ");
            builder.Append("id_endereco, ");
            builder.Append("id_condominio, ");
            builder.Append("nome, ");
            builder.Append("cpf, ");
            builder.Append("rg ");

            builder.Append(") ");

            builder.Append("VALUES ");

            builder.Append("(");

            builder.Append(funcionario.Id + ", ");
            builder.Append(funcionario.Id_endereco + ", ");
            builder.Append(funcionario.Id_condominio + ", ");
            builder.Append("'" + funcionario.Nome + "', ");
            builder.Append("'" + funcionario.Cpf + "', ");
            builder.Append("'" + funcionario.Rg + "' ");

            builder.Append(");");

            return this.Update(builder.ToString());
        }

        public bool Editar(Funcionario funcionario)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("UPDATE ");
            builder.Append(this.TableName + " ");
            builder.Append("SET ");

            builder.Append("id_endereco = ");
            builder.Append(funcionario.Id_endereco + ", ");

            builder.Append("id_condominio = ");
            builder.Append(funcionario.Id_condominio + ", ");

            builder.Append("nome = ");
            builder.Append("'" + funcionario.Nome + "', ");

            builder.Append("cpf = ");
            builder.Append("'" + funcionario.Cpf + "', ");

            builder.Append("rg = ");
            builder.Append("'" + funcionario.Rg + "' ");
            
            builder.Append("WHERE ");
            builder.Append("id = " + funcionario.Id);
            builder.Append(";");

            return this.Update(builder.ToString());
        }

        public Funcionario GetPorId(int id)
        {
            NpgsqlDataReader dataReader = base.GetPorId(id);
            Funcionario obj = new Funcionario();

            if (dataReader.HasRows && dataReader.Read())
            {
                obj = this.PreencherObjeto(dataReader);
            }

            return obj;
        }

        public List<Funcionario> GetTodos()
        {
            List<Funcionario> list = new List<Funcionario>();

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

        private Funcionario PreencherObjeto(NpgsqlDataReader dataReader)
        {
            int i = 0;
            Funcionario obj = new Funcionario();
            obj.Id = dataReader.GetInt32(i++);
            obj.Id_endereco = dataReader.GetInt32(i++);
            obj.Id_condominio = dataReader.GetInt32(i++);
            obj.Nome = dataReader.GetString(i++);
            obj.Cpf = dataReader.GetString(i++);
            obj.Rg = dataReader.GetString(i++);

            return obj;
        }
    }
}