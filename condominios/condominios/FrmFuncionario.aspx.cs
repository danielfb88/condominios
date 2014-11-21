using condominios.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace condominios
{
    public partial class FrmFuncionario : System.Web.UI.Page
    {
        private void redirecionarMesmaPagina()
        {
            Response.Redirect("~/FrmFuncionario.aspx");
        }

        /*
         * DropDownList
         * */
        private void carregarDropDownList()
        {
            // Endereco
            Endereco endereco = new Endereco();
            List<Endereco> listEnd = endereco.GetTodos();

            int i = 0;
            foreach (Endereco end in listEnd)
            {
                dlEndereco.Items.Insert(i++, new ListItem(end.Logradouro, Convert.ToString(end.Id)));
            }

            // Condomínio
            Condominio condominio = new Condominio();
            List<Condominio> listCond = condominio.GetTodos();

            int k = 0;
            foreach (Condominio cond in listCond)
            {
                dlCondominio.Items.Insert(k++, new ListItem(cond.Nome, Convert.ToString(cond.Id)));
            }
        }

        /*
         * Grid
         * */
        private void carregarGrid()
        {
            gridView1.DataSource = new Funcionario().GetTodos();
            gridView1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.carregarDropDownList();
            }

            this.carregarGrid();
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            /*
             * Obj
             * */
            Funcionario obj = new Funcionario();
            obj.Id_endereco = Convert.ToInt32(dlEndereco.SelectedValue);
            obj.Id_condominio = Convert.ToInt32(dlCondominio.SelectedValue);
            obj.Nome = Convert.ToString(txNome.Text);
            obj.Cpf = txCPF.Text;
            obj.Rg = txRg.Text;

            if (txId.Text.Equals(""))
            {
                obj.Id = obj.NextId();
                obj.Adicionar();
            }
            else
            {
                obj.Id = Convert.ToInt32(txId.Text);
                obj.Editar();
            }

            this.redirecionarMesmaPagina();
        }

        protected void EditRowButton_Click(Object sender, GridViewEditEventArgs e)
        {
            TableCell cell = gridView1.Rows[e.NewEditIndex].Cells[1];
            int id = Convert.ToInt32(cell.Text);

            /*
             * Obj
             * */
            Funcionario obj = new Funcionario().GetPorId(id);
            txId.Text = Convert.ToString(obj.Id);
            dlEndereco.DataValueField = Convert.ToString(obj.Id_endereco);
            txNome.Text = Convert.ToString(obj.Nome);
            txNome.Text = obj.Nome;
            txCPF.Text = obj.Cpf;
            txRg.Text = obj.Rg;
        }

        protected void DeleteRowButton_Click(Object sender, GridViewDeleteEventArgs e)
        {
            TableCell cell = gridView1.Rows[e.RowIndex].Cells[1];
            int id = Convert.ToInt32(cell.Text);

            /*
             * Obj
             * */
            Funcionario obj = new Funcionario();

            obj.Id = id;
            obj.Excluir();
            this.redirecionarMesmaPagina();
        }
    }
}