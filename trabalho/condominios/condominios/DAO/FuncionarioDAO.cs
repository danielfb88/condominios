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
            Funcionario funcionario = new Funcionario();

            if (dataReader.HasRows && dataReader.Read())
            {
                funcionario.Id = (int)dataReader[0];
                funcionario.Id_endereco = (int)dataReader[1];
                funcionario.Id_condominio = (int)dataReader[2];
                funcionario.Nome = (String)dataReader[3];
                funcionario.Cpf = (String)dataReader[4];
                funcionario.Rg = (String)dataReader[5];
            }

            return funcionario;
        }

        public List<Funcionario> GetTodos()
        {
            List<Funcionario> listFuncionario = new List<Funcionario>();

            NpgsqlDataReader dataReader = base.GetTodos();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    Funcionario funcionario = new Funcionario();
                    funcionario.Id = (int)dataReader[0];
                    funcionario.Id_endereco = (int)dataReader[1];
                    funcionario.Id_condominio = (int)dataReader[2];
                    funcionario.Nome = (String)dataReader[3];
                    funcionario.Cpf = (String)dataReader[4];
                    funcionario.Rg = (String)dataReader[5];

                    listFuncionario.Add(funcionario);
                } 
            }

            return listFuncionario;
        }
    }
}