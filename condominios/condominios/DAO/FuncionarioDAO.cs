using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using condominios.Entidade;
using System.Text;

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

            builder.Append("id_endereco, ");
            builder.Append("id_condominio, ");
            builder.Append("nome, ");
            builder.Append("cpf, ");
            builder.Append("rg ");

            builder.Append(") ");

            builder.Append("VALUES ");

            builder.Append("('");

            builder.Append(funcionario.Id_endereco + ", ");
            builder.Append(funcionario.Id_condominio + ", ");
            builder.Append("'" + funcionario.Nome + "', ");
            builder.Append("'" + funcionario.Cpf + "', ");
            builder.Append("'" + funcionario.Rg + "' ");

            builder.Append("');");

            return this.update(builder.ToString());
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

            return this.update(builder.ToString());
        }
    }
}