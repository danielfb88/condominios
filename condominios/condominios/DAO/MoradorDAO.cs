using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using condominios.Entidade;
using System.Text;
using Npgsql;

namespace condominios.DAO
{
    public class MoradorDAO : DAOGenerico
    {
        public MoradorDAO () {
            this.TableName = "morador";
        }

        public bool Adicionar(Morador morador)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("INSERT INTO ");
            builder.Append(this.TableName + " ");

            builder.Append("( ");

            builder.Append("id, ");
            builder.Append("id_condominio, ");
            builder.Append("nome, ");
            builder.Append("cpf, ");
            builder.Append("rg, ");
            builder.Append("numero_apt, ");
            builder.Append("adimplente ");

            builder.Append(") ");

            builder.Append("VALUES ");

            builder.Append("(");

            builder.Append(morador.Id + ", ");
            builder.Append(morador.Id_condominio + ", ");
            builder.Append("'" + morador.Nome + "', ");
            builder.Append("'" + morador.Cpf + "', ");
            builder.Append("'" + morador.Rg + "', ");
            builder.Append(morador.Numero_apt + ", ");
            builder.Append(((morador.Adimplente == true) ? 1 : 0) + " ");

            builder.Append(");");

            return this.Update(builder.ToString());
        }

        public bool Editar(Morador morador)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("UPDATE ");
            builder.Append(this.TableName + " ");
            builder.Append("SET ");

            builder.Append("id_condominio = ");
            builder.Append(morador.Id_condominio + ", ");

            builder.Append("nome = ");
            builder.Append("'" + morador.Nome + "', ");

            builder.Append("cpf = ");
            builder.Append("'" + morador.Cpf + "', ");

            builder.Append("rg = ");
            builder.Append("'" + morador.Rg + "', ");

            builder.Append("numero_apt = ");
            builder.Append(morador.Numero_apt + ", ");

            builder.Append("adimplente = ");
            builder.Append(((morador.Adimplente == true) ? 1 : 0) + " ");

            builder.Append("WHERE ");
            builder.Append("id = " + morador.Id);
            builder.Append(";");

            return this.Update(builder.ToString());
        }

        public Morador GetPorId(int id)
        {
            NpgsqlDataReader dataReader = base.GetPorId(id);
            Morador morador = new Morador();

            if (dataReader.HasRows && dataReader.Read())
            {
                morador.Id = (int)dataReader[0];
                morador.Id_condominio = (int)dataReader[1];
                morador.Nome = (String)dataReader[2];
                morador.Cpf = (String)dataReader[3];
                morador.Rg = (String)dataReader[4];
                morador.Numero_apt = (int)dataReader[5];
            }

            return morador;
        }

        public List<Morador> GetTodos()
        {
            List<Morador> listMorador = new List<Morador>();

            NpgsqlDataReader dataReader = base.GetTodos();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    Morador morador = new Morador();
                    morador.Id = (int)dataReader[0];
                    morador.Id_condominio = (int)dataReader[1];
                    morador.Nome = (String)dataReader[2];
                    morador.Cpf = (String)dataReader[3];
                    morador.Rg = (String)dataReader[4];
                    morador.Numero_apt = (int)dataReader[5];

                    listMorador.Add(morador);
                }
            }

            return listMorador;
        }
    }
}