using condominios.Entidade;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace condominios.DAO
{
    public class SindicoDAO : DAOGenerico
    {
        public SindicoDAO()
        {
            this.TableName = "sindico";
        }

        public bool Adicionar(Sindico sindico)
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

            builder.Append(sindico.Id + ", ");
            builder.Append(sindico.Id_endereco + ", ");
            builder.Append(sindico.Id_condominio + ", ");
            builder.Append("'" + sindico.Nome + "', ");
            builder.Append("'" + sindico.Cpf + "', ");
            builder.Append("'" + sindico.Rg + "' ");

            builder.Append(");");

            return this.Update(builder.ToString());
        }

        public bool Editar(Sindico sindico)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("UPDATE ");
            builder.Append(this.TableName + " ");
            builder.Append("SET ");
            
            builder.Append("id_endereco = ");
            builder.Append(sindico.Id_endereco + ", ");

            builder.Append("id_condominio = ");
            builder.Append(sindico.Id_condominio + ", ");

            builder.Append("nome = ");
            builder.Append("'" + sindico.Nome + "', ");

            builder.Append("cpf = "); 
            builder.Append("'" + sindico.Cpf + "', ");

            builder.Append("rg = ");
            builder.Append("'" + sindico.Rg + "' ");

            builder.Append("WHERE ");
            builder.Append("id = " + sindico.Id);
            builder.Append(";");

            return this.Update(builder.ToString());
        }


        public Sindico GetPorId(int id)
        {
            NpgsqlDataReader dataReader = base.GetPorId(id);
            Sindico obj = new Sindico();

            if (dataReader.HasRows && dataReader.Read())
            {
                obj = this.PreencherObjeto(dataReader);
            }

            return obj;
        }

        public List<Sindico> GetTodos()
        {
            List<Sindico> list = new List<Sindico>();

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

        private Sindico PreencherObjeto(NpgsqlDataReader dataReader)
        {
            int i = 0;
            Sindico obj = new Sindico();
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