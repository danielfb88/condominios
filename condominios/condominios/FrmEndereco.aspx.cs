using condominios.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace condominios
{
    public partial class FrmEndereco : System.Web.UI.Page
    {
        private void redirecionarMesmaPagina()
        {
            Response.Redirect("~/FrmEndereco.aspx");
        }

        /*
         * Grid
         * */
        private void carregarGrid()
        {
            gridView1.DataSource = new Endereco().GetTodos();
            gridView1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.carregarGrid();                
            }

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            /*
             * Obj
             * */
            Endereco obj = new Endereco();
            obj.Cidade = txCidade.Text;
            obj.Estado = txEstado.Text;
            obj.Cep = txCep.Text;
            obj.Bairro = txBairro.Text;
            obj.Numero = txNumero.Text;
            obj.Logradouro = txLogradouro.Text;
            obj.Complemento = txComplemento.Text;

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
            Endereco obj = new Endereco().GetPorId(id);
            txId.Text = Convert.ToString(obj.Id);
            txCidade.Text = obj.Cidade;
            txEstado.Text = obj.Estado;
            txCep.Text = obj.Cep;
            txBairro.Text = obj.Bairro;
            txNumero.Text = obj.Numero;
            txLogradouro.Text = obj.Logradouro;
            txComplemento.Text = obj.Complemento;
        }

        protected void DeleteRowButton_Click(Object sender, GridViewDeleteEventArgs e)
        {
            TableCell cell = gridView1.Rows[e.RowIndex].Cells[1];
            int id = Convert.ToInt32(cell.Text);

            /*
             * Obj
             * */
            Endereco obj = new Endereco();

            obj.Id = id;
            obj.Excluir();
            this.redirecionarMesmaPagina();
        }
    }
}