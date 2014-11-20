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
            Morador obj = new Morador();

            if (dataReader.HasRows && dataReader.Read())
            {
                obj = this.PreencherObjeto(dataReader);
            }

            return obj;
        }

        public List<Morador> GetTodos()
        {
            List<Morador> list = new List<Morador>();

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

        private Morador PreencherObjeto(NpgsqlDataReader dataReader)
        {
            int i = 0;
            Morador obj = new Morador();
            obj.Id = dataReader.GetInt32(i++);
            obj.Id_condominio = dataReader.GetInt32(i++);
            obj.Nome = dataReader.GetString(i++);
            obj.Cpf = dataReader.GetString(i++);
            obj.Rg = dataReader.GetString(i++);
            obj.Numero_apt = dataReader.GetInt32(i++);

            return obj;
        }

    }
}