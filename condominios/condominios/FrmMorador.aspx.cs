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
        private void redirecionarMesmaPagina()
        {
            Response.Redirect("~/FrmMorador.aspx");
        }

        /*
         * DropDownList
         * */
        private void carregarDropDownList()
        {
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
            gridView1.DataSource = new Morador().GetTodos();
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
            Morador obj = new Morador();
            obj.Id_condominio = Convert.ToInt32(dlCondominio.SelectedValue);
            obj.Nome = txNome.Text;
            obj.Cpf = txCpf.Text;
            obj.Rg = txRg.Text;
            obj.Numero_apt = Convert.ToInt32(txNumeroApt.Text);
            obj.Adimplente = cbAdimplente.Checked;

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
            Morador obj = new Morador().GetPorId(id);
            txId.Text = Convert.ToString(obj.Id);
            dlCondominio.DataValueField = Convert.ToString(obj.Id_condominio);
            txNome.Text = obj.Nome;
            txCpf.Text = obj.Cpf;
            txRg.Text = obj.Rg;
            txNumeroApt.Text = Convert.ToString(obj.Numero_apt);
            cbAdimplente.Checked = obj.Adimplente;
        }

        protected void DeleteRowButton_Click(Object sender, GridViewDeleteEventArgs e)
        {
            TableCell cell = gridView1.Rows[e.RowIndex].Cells[1];
            int id = Convert.ToInt32(cell.Text);

            /*
             * Obj
             * */
            Morador obj = new Morador();

            obj.Id = id;
            obj.Excluir();
            this.redirecionarMesmaPagina();
        }
    }
}