using condominios.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace condominios
{
    public partial class FrmSindico : System.Web.UI.Page
    {
        List<Sindico> listSindico;

        protected void Page_Load(object sender, EventArgs e)
        {
            listSindico = new Sindico().GetTodos();
            gridView1.DataSource = listSindico;
            gridView1.DataBind();
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Sindico sindico = new Sindico();

            sindico.Id_endereco = Convert.ToInt32(txIdEndereco.Text);
            sindico.Id_condominio = Convert.ToInt32(txIdCondominio.Text);
            sindico.Nome = txNome.Text;
            sindico.Cpf = txCPF.Text;
            sindico.Rg = txRg.Text;

            if (txId.Text.Equals(""))
            {
                sindico.Id = listSindico.Count + 1;
                sindico.Adicionar();
            }
            else
            {
                sindico.Id = Convert.ToInt32(txId.Text);
                sindico.Editar();
            }

            this.redirecionarMesmaPagina();
        }

        protected void EditRowButton_Click(Object sender, GridViewEditEventArgs e)
        {
            TableCell cell = gridView1.Rows[e.NewEditIndex].Cells[1];
            int id = Convert.ToInt32(cell.Text);

            Sindico e1 = new Sindico();
            e1.Id = id;
            Sindico sindico = e1.GetPorId(e1.Id);

            txId.Text = Convert.ToString(sindico.Id);
            txIdEndereco.Text = Convert.ToString(sindico.Id_endereco);
            txIdCondominio.Text = Convert.ToString(sindico.Id_condominio);
            txNome.Text = sindico.Nome;
            txCPF.Text = sindico.Cpf;
            txRg.Text = sindico.Rg;
        }

        protected void DeleteRowButton_Click(Object sender, GridViewDeleteEventArgs e)
        {
            TableCell cell = gridView1.Rows[e.RowIndex].Cells[1];
            int id = Convert.ToInt32(cell.Text);
            Sindico sindico = new Sindico();
            sindico.Id = id;
            sindico.Excluir();
            this.redirecionarMesmaPagina();
        }

        private void redirecionarMesmaPagina()
        {
            Response.Redirect("FrmSindico.aspx");
        }
    }
}