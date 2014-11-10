using condominios.DAO;
using condominios.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace condominios
{
    public partial class About : Page
    {
        List<Endereco> listEndereco;

        protected void Page_Load(object sender, EventArgs e)
        {
            listEndereco = new Endereco().GetTodos();
            gridView1.DataSource = listEndereco;
            gridView1.DataBind();
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Endereco endereco = new Endereco();
            
            endereco.Cidade = txCidade.Text;
            endereco.Estado = txEstado.Text;
            endereco.Cep = txCep.Text;
            endereco.Bairro = txBairro.Text;
            endereco.Numero = txNumero.Text;
            endereco.Logradouro = txLogradouro.Text;
            endereco.Complemento = txComplemento.Text;

            if(txId.Text.Equals("")) {
                endereco.Id = listEndereco.Count + 1;
                endereco.Adicionar();
            }
            else
            {
                endereco.Id = Convert.ToInt32(txId.Text);
                endereco.Editar();
            }
            
            this.redirecionarMesmaPagina();
        }

        protected void EditRowButton_Click(Object sender, GridViewEditEventArgs e)
        {
            TableCell cell = gridView1.Rows[e.NewEditIndex].Cells[1];
            int id = Convert.ToInt32(cell.Text);

            Endereco e1 = new Endereco();
            e1.Id = id;
            Endereco endereco = e1.GetPorId(e1.Id);

            txId.Text = Convert.ToString(endereco.Id);
            txCidade.Text = endereco.Cidade;
            txEstado.Text = endereco.Estado;
            txCep.Text = endereco.Cep;
            txBairro.Text = endereco.Bairro;
            txNumero.Text = endereco.Numero;
            txLogradouro.Text = endereco.Logradouro;
            txComplemento.Text = endereco.Complemento;

            //this.redirecionarMesmaPagina();
        }

        protected void DeleteRowButton_Click(Object sender, GridViewDeleteEventArgs e)
        {
            TableCell cell = gridView1.Rows[e.RowIndex].Cells[1];
            int id = Convert.ToInt32(cell.Text);
            Endereco endereco = new Endereco();
            endereco.Id = id;
            endereco.Excluir();
            this.redirecionarMesmaPagina();
        }

        private void redirecionarMesmaPagina()
        {
            Response.Redirect("FrmEndereco.aspx");
        }
    }
}