using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using condominios.Conexao;
using System.Text;
using Npgsql;

namespace condominios.DAO
{
    public abstract class DAOGenerico
    {
        protected String LastQuery { get; set; }
        protected String TableName { get; set; }

        private bool update(String query)
        {
            return Conn.GetInstance().Update(query);
        }

        protected NpgsqlDataReader GetTodos()
        {
            String query = "SELECT * FROM " + this.TableName + ";";
            this.LastQuery = query;
            return Conn.GetInstance().Fetch(query);
        }

        protected NpgsqlDataReader Fetch(String query)
        {
            return Conn.GetInstance().Fetch(query);
        }

        protected NpgsqlDataReader GetPorId(int id)
        {
            String query = "SELECT * FROM " + this.TableName + " WHERE id = " + id + ";";
            this.LastQuery = query;
            return Conn.GetInstance().Fetch(query);
        }

        protected NpgsqlDataReader GetLista(String query)
        {
            this.LastQuery = query;
            return Conn.GetInstance().Fetch(query);
        }

        public bool Excluir(int id)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("DELETE FROM ");
            builder.Append(this.TableName + " ");
            builder.Append("WHERE ");
            builder.Append("id = " + id);
            builder.Append(";");

            this.LastQuery = builder.ToString();
            return this.update(builder.ToString());
        }

        public int GetQuantidadeRegistros()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("SELECT COUNT(*) FROM ");
            builder.Append(this.TableName + " ");
            builder.Append(";");

            this.LastQuery = builder.ToString();

            NpgsqlDataReader dataReader = Conn.GetInstance().Fetch(builder.ToString());
            int qtdRegistros = 0;

            if (dataReader.HasRows && dataReader.Read())
            {
                qtdRegistros = Convert.ToInt32(dataReader[0]);
            }

            return qtdRegistros;
        }

        public int NextId()
        {
            return this.GetQuantidadeRegistros() + 1;
        }

        protected bool Update(String query)
        {
            this.LastQuery = query;
            return this.update(query.ToString());
        }
    }
}