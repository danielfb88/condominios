using condominios.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace condominios
{
    public partial class FrmMorador : System.Web.UI.Page
    {
        List<Morador> listMorador;

        protected void Page_Load(object sender, EventArgs e)
        {
            listMorador = new Morador().GetTodos();
            gridView1.DataSource = listMorador;
            gridView1.DataBind();
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Morador morador = new Morador();

            morador.Id_condominio = Convert.ToInt32(txIdCondominio.Text);
            morador.Nome = txNome.Text;
            morador.Cpf = txCpf.Text;
            morador.Rg = txRg.Text;
            morador.Numero_apt = Convert.ToInt32(txNumeroApt.Text);
            morador.Adimplente = cbAdimplente.Checked;

            if (txId.Text.Equals(""))
            {
                morador.Id = listMorador.Count + 1;
                morador.Adicionar();
            }
            else
            {
                morador.Id = Convert.ToInt32(txId.Text);
                morador.Editar();
            }

            this.redirecionarMesmaPagina();
        }

        protected void EditRowButton_Click(Object sender, GridViewEditEventArgs e)
        {
            TableCell cell = gridView1.Rows[e.NewEditIndex].Cells[1];
            int id = Convert.ToInt32(cell.Text);

            Morador e1 = new Morador();
            e1.Id = id;
            Morador morador = e1.GetPorId(e1.Id);

            txId.Text = Convert.ToString(morador.Id);
            txIdCondominio.Text = Convert.ToString(morador.Id_condominio);
            txNome.Text = morador.Nome;
            txCpf.Text = morador.Cpf;
            txRg.Text = morador.Rg;
            txNumeroApt.Text = Convert.ToString(morador.Numero_apt);
            cbAdimplente.Checked = morador.Adimplente;
        }

        protected void DeleteRowButton_Click(Object sender, GridViewDeleteEventArgs e)
        {
            TableCell cell = gridView1.Rows[e.RowIndex].Cells[1];
            int id = Convert.ToInt32(cell.Text);
            Morador morador = new Morador();
            morador.Id = id;
            morador.Excluir();
            this.redirecionarMesmaPagina();
        }

        private void redirecionarMesmaPagina()
        {
            Response.Redirect("FrmMorador.aspx");
        }
    }
}