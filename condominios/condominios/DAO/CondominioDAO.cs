using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using condominios.Entidade;
using System.Text;

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
            builder.Append("valor_gas ");

            builder.Append(") ");

            builder.Append("VALUES ");

            builder.Append("(");

            builder.Append(condominio.Id + ", ");
            builder.Append(condominio.Id_endereco + ", ");
            builder.Append(condominio.Qtd_Apt + ", ");
            builder.Append(condominio.Valor_agua + ", ");
            builder.Append(condominio.Valor_luz + ", ");
            builder.Append(condominio.Valor_gas + " ");

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
            builder.Append(condominio.Valor_gas + " ");

            builder.Append("WHERE ");
            builder.Append("id = " + condominio.Id);
            builder.Append(";");

            return this.Update(builder.ToString());
        }
    }
}