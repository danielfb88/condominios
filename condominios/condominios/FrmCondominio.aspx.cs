﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using condominios.Entidade;

namespace condominios.forms
{
    public partial class FrmCondominio : System.Web.UI.Page
    {
        List<Condominio> listGrid;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // DropDownList
                Endereco endereco = new Endereco();
                List<Endereco> list = endereco.GetTodos();

                int i = 0;
                foreach (Endereco end in list)
                {
                    dlEndereco.Items.Insert(i++, new ListItem(end.Logradouro, Convert.ToString(end.Id)));
                }
            }
            
            // Grid
            listGrid = new Condominio().GetTodos();
            gridView1.DataSource = listGrid;
            gridView1.DataBind();
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Condominio condominio = new Condominio();

            condominio.Id_endereco = Convert.ToInt32(dlEndereco.SelectedValue);
            condominio.Nome = Convert.ToString(txNome.Text);
            condominio.Qtd_Apt = Convert.ToInt32(condominio.Id_endereco);
            condominio.Valor_agua = Convert.ToDouble(txAgua.Text);
            condominio.Valor_gas = Convert.ToDouble(txGas.Text);
            condominio.Valor_luz = Convert.ToDouble(txLuz.Text);

            if (txId.Text.Equals(""))
            {
                condominio.Id = condominio.NextId();
                condominio.Adicionar();
            }
            else
            {
                condominio.Id = Convert.ToInt32(txId.Text);
                condominio.Editar();
            }

            this.redirecionarMesmaPagina();
        }

        protected void EditRowButton_Click(Object sender, GridViewEditEventArgs e)
        {
            TableCell cell = gridView1.Rows[e.NewEditIndex].Cells[1];
            int id = Convert.ToInt32(cell.Text);

            Condominio obj = new Condominio();
            obj.Id = id;
            Condominio condominio = obj.GetPorId(obj.Id);

            txId.Text = Convert.ToString(condominio.Id);
            dlEndereco.DataValueField = Convert.ToString(condominio.Id_endereco);
            txNome.Text = Convert.ToString(condominio.Nome);
            txQtdApt.Text = Convert.ToString(condominio.Qtd_Apt);
            txAgua.Text = Convert.ToString(condominio.Valor_agua);
            txGas.Text = Convert.ToString(condominio.Valor_gas);
            txLuz.Text = Convert.ToString(condominio.Valor_luz);
        }

        protected void DeleteRowButton_Click(Object sender, GridViewDeleteEventArgs e)
        {
            TableCell cell = gridView1.Rows[e.RowIndex].Cells[1];
            int id = Convert.ToInt32(cell.Text);
            Condominio condominio = new Condominio();
            condominio.Id = id;
            condominio.Excluir();
            this.redirecionarMesmaPagina();
        }

        private void redirecionarMesmaPagina()
        {
            Response.Redirect("~/FrmCondominio.aspx");
        }
    }
}