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
        List<Funcionario> listFuncionario;

        protected void Page_Load(object sender, EventArgs e)
        {
            listFuncionario = new Funcionario().GetTodos();
            gridView1.DataSource = listFuncionario;
            gridView1.DataBind();
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            
            funcionario.Id_endereco = Convert.ToInt32(txIdEndereco.Text);
            funcionario.Id_condominio = Convert.ToInt32(txIdCondominio.Text);
            funcionario.Nome = txNome.Text;
            funcionario.Cpf = txCPF.Text;
            funcionario.Rg = txRg.Text;

            if(txId.Text.Equals("")) {
                funcionario.Id = listFuncionario.Count + 1;
                funcionario.Adicionar();
            }
            else
            {
                funcionario.Id = Convert.ToInt32(txId.Text);
                funcionario.Editar();
            }
            
            this.redirecionarMesmaPagina();
        }

        protected void EditRowButton_Click(Object sender, GridViewEditEventArgs e)
        {
            TableCell cell = gridView1.Rows[e.NewEditIndex].Cells[1];
            int id = Convert.ToInt32(cell.Text);

            Funcionario e1 = new Funcionario();
            e1.Id = id;
            Funcionario funcionario = e1.GetPorId(e1.Id);

            txId.Text = Convert.ToString(funcionario.Id);
            txIdEndereco.Text = Convert.ToString(funcionario.Id_endereco);
            txIdCondominio.Text = Convert.ToString(funcionario.Id_condominio);
            txNome.Text = funcionario.Nome;
            txCPF.Text = funcionario.Cpf;
            txRg.Text = funcionario.Rg;
        }

        protected void DeleteRowButton_Click(Object sender, GridViewDeleteEventArgs e)
        {
            TableCell cell = gridView1.Rows[e.RowIndex].Cells[1];
            int id = Convert.ToInt32(cell.Text);
            Funcionario funcionario = new Funcionario();
            funcionario.Id = id;
            funcionario.Excluir();
            this.redirecionarMesmaPagina();
        }

        private void redirecionarMesmaPagina()
        {
            Response.Redirect("FrmFuncionario.aspx");
        }
    }
}