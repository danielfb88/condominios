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
            Sindico sindico = new Sindico();

            if (dataReader.HasRows && dataReader.Read())
            {
                sindico.Id = (int)dataReader[0];
                sindico.Id_endereco = (int)dataReader[1];
                sindico.Id_condominio = (int)dataReader[2];
                sindico.Nome = (String)dataReader[3];
                sindico.Cpf = (String)dataReader[4];
                sindico.Rg = (String)dataReader[5];
            }

            return sindico;
        }

        public List<Sindico> GetTodos()
        {
            List<Sindico> listSindico = new List<Sindico>();

            NpgsqlDataReader dataReader = base.GetTodos();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    Sindico sindico = new Sindico();
                    sindico.Id = (int)dataReader[0];
                    sindico.Id_endereco = (int)dataReader[1];
                    sindico.Id_condominio = (int)dataReader[2];
                    sindico.Nome = (String)dataReader[3];
                    sindico.Cpf = (String)dataReader[4];
                    sindico.Rg = (String)dataReader[5];

                    listSindico.Add(sindico);
                }
            }

            return listSindico;
        }
    }
}