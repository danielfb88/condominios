using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using condominios.Conexao;
using System.Text;

namespace condominios.DAO
{
    public abstract class DAOGenerico
    {
        private String tableName;

        public String TableName { get; set; }

        public bool update(String query)
        {
            return Conn.GetInstance().Update(query);
        }

        public DataTable GetTodos()
        {
            String query = "SELECT * FROM " + this.tableName + ";";
            return Conn.GetInstance().Fetch(query);
        }

        public DataTable GetLista(String query)
        {
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

            return this.update(builder.ToString());
        }
    }
}