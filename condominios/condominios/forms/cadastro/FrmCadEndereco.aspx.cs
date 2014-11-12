using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using condominios.Entidade;

namespace condominios.forms.cadastro
{
    public partial class FrmCadEndereco : System.Web.UI.Page
    {
        String nomeEntidade = "Endereco";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Endereco endereco = new Endereco();

            endereco.Id = endereco.NextId();
            endereco.Cidade = txCidade.Text;
            endereco.Estado = txEstado.Text;
            endereco.Cep = txCep.Text;
            endereco.Bairro = txBairro.Text;
            endereco.Numero = txNumero.Text;
            endereco.Logradouro = txLogradouro.Text;
            endereco.Complemento = txComplemento.Text;

            endereco.Adicionar();
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            Endereco endereco = new Endereco();
        }

        private void redirecionarPesquisa()
        {
            Response.Redirect("~/forms/pesquisa/FrmPesq" + nomeEntidade + ".aspx");
        }

        private void redirecionarMesmaPagina()
        {
            Response.Redirect("~/forms/pesquisa/FrmCad" + nomeEntidade + ".aspx");
        }
    }
}