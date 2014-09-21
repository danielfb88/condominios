using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using condominios.Conexao;

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
    }
}