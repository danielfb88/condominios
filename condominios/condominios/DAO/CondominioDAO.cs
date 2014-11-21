using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using condominios.Entidade;
using System.Text;
using Npgsql;

namespace condominios.DAO
{
    public class CondominioDAO : DAOGenerico
    {
        public CondominioDAO()
        {
            this.TableName = "condominio";
        }

        public bool Adicionar(Condominio condominio)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("INSERT INTO ");
            builder.Append(this.TableName + " ");

            builder.Append("( ");

            builder.Append("id, ");
            builder.Append("id_endereco, ");
            builder.Append("qtd_apt, ");
            builder.Append("valor_agua, ");
            builder.Append("valor_luz, ");
            builder.Append("valor_gas, ");
            builder.Append("nome ");

            builder.Append(") ");

            builder.Append("VALUES ");

            builder.Append("(");

            builder.Append(condominio.Id + ", ");
            builder.Append(condominio.Id_endereco + ", ");
            builder.Append(condominio.Qtd_Apt + ", ");
            builder.Append(condominio.Valor_agua + ", ");
            builder.Append(condominio.Valor_luz + ", ");
            builder.Append(condominio.Valor_gas + ", ");
            builder.Append("'" + condominio.Nome + "' ");

            builder.Append(");");

            return this.Update(builder.ToString());
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
            builder.Append(condominio.Valor_gas + ", ");

            builder.Append("nome = ");
            builder.Append("'" + condominio.Nome + "' ");

            builder.Append("WHERE ");
            builder.Append("id = " + condominio.Id);
            builder.Append(";");

            return this.Update(builder.ToString());
        }

        public Condominio GetPorId(int id)
        {
            NpgsqlDataReader dataReader = base.GetPorId(id);
            Condominio obj = new Condominio();

            if (dataReader.HasRows && dataReader.Read())
            {
                obj = this.PreencherObjeto(dataReader);
            }

            /*
             * Fechando
             * */
            dataReader.Close();
            this.CloseCon();

            return obj;
        }

        public List<Condominio> GetTodos()
        {
            List<Condominio> list = new List<Condominio>();

            NpgsqlDataReader dataReader = base.GetTodos();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    list.Add(this.PreencherObjeto(dataReader));
                }
            }

            /*
             * Fechando
             * */
            dataReader.Close();
            this.CloseCon();

            return list;
        }

        private Condominio PreencherObjeto(NpgsqlDataReader dataReader)
        {
            int i = 0;
            Condominio obj = new Condominio();
            obj.Id = dataReader.GetInt32(i++);
            obj.Id_endereco = dataReader.GetInt32(i++);
            obj.Qtd_Apt = dataReader.GetInt32(i++);
            obj.Valor_agua = dataReader.GetFloat(i++);
            obj.Valor_luz = dataReader.GetFloat(i++);
            obj.Valor_gas = dataReader.GetFloat(i++);
            obj.Nome = dataReader.GetString(i++);

            return obj;
        }
    }
}