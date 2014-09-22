using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using condominios.Entidade;
using System.Text;

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

            builder.Append("id_condominio, ");
            builder.Append("nome, ");
            builder.Append("cpf, ");
            builder.Append("rg, ");
            builder.Append("numero_apt ");

            builder.Append(") ");

            builder.Append("VALUES ");

            builder.Append("('");

            builder.Append(morador.Id_condominio + ", ");
            builder.Append("'" + morador.Nome + "', ");
            builder.Append("'" + morador.Cpf + "', ");
            builder.Append("'" + morador.Rg + "', ");
            builder.Append(morador.Numero_apt + " ");

            builder.Append("');");

            return this.update(builder.ToString());
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
            builder.Append(morador.Numero_apt + " ");

            builder.Append("WHERE ");
            builder.Append("id = " + morador.Id);
            builder.Append(";");

            return this.update(builder.ToString());
        }
    }
}