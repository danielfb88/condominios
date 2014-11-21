using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using System.Data.SqlClient;

namespace condominios.Conexao
{
    public class Conn
    {
        private static Conn instance;
        private NpgsqlConnection conn;

        private Conn()
        {

        }

        public static Conn GetInstance()
        {
            if (instance == null)
                instance = new Conn();

            return instance;
        }

        public Boolean Update(String query)
        {
            bool retornoOk = false;
            try
            {
                using (conn = new NpgsqlConnection(DBSettings.GetStringConnection()))
                {
                    conn.Open();
                    using (NpgsqlCommand sqlCommand = new NpgsqlCommand(query, conn))
                    {
                        retornoOk = sqlCommand.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //conn.Close();
            }

            return retornoOk;
        }

        public NpgsqlDataReader Fetch(String query)
        {
            NpgsqlDataReader dataReader = null;
            try
            {
                conn = new NpgsqlConnection(DBSettings.GetStringConnection());
                
                    conn.Open();
                    NpgsqlCommand command = new NpgsqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //conn.Close();
            }

            return dataReader;
        }
    }
}