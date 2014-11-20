using System;
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
        private void redirecionarMesmaPagina()
        {
            Response.Redirect("~/FrmCondominio.aspx");
        }

        /*
         * DropDownList
         * */
        private void carregarDropDownList()
        {
            Endereco endereco = new Endereco();
            List<Endereco> list = endereco.GetTodos();

            int i = 0;
            foreach (Endereco end in list)
            {
                dlEndereco.Items.Insert(i++, new ListItem(end.Logradouro, Convert.ToString(end.Id)));
            }
        }

        /*
         * Grid
         * */
        private void carregarGrid()
        {
            gridView1.DataSource = new Condominio().GetTodos();
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
            Condominio obj = new Condominio();
            obj.Id_endereco = Convert.ToInt32(dlEndereco.SelectedValue);
            obj.Nome = Convert.ToString(txNome.Text);
            obj.Qtd_Apt = Convert.ToInt32(obj.Id_endereco);
            obj.Valor_agua = Convert.ToDouble(txAgua.Text);
            obj.Valor_gas = Convert.ToDouble(txGas.Text);
            obj.Valor_luz = Convert.ToDouble(txLuz.Text);

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
            Condominio obj = new Condominio().GetPorId(id);
            txId.Text = Convert.ToString(obj.Id);
            dlEndereco.DataValueField = Convert.ToString(obj.Id_endereco);
            txNome.Text = Convert.ToString(obj.Nome);
            txQtdApt.Text = Convert.ToString(obj.Qtd_Apt);
            txAgua.Text = Convert.ToString(obj.Valor_agua);
            txGas.Text = Convert.ToString(obj.Valor_gas);
            txLuz.Text = Convert.ToString(obj.Valor_luz);
        }

        protected void DeleteRowButton_Click(Object sender, GridViewDeleteEventArgs e)
        {
            TableCell cell = gridView1.Rows[e.RowIndex].Cells[1];
            int id = Convert.ToInt32(cell.Text);

            /*
             * Obj
             * */
            Condominio obj = new Condominio();

            obj.Id = id;
            obj.Excluir();
            this.redirecionarMesmaPagina();
        }

    }
}