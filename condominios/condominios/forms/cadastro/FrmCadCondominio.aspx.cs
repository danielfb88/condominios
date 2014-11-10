using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using condominios.Entidade;

namespace condominios.forms.cadastro
{
    public partial class FrmCondominio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Condominio condominio = new Condominio();

            condominio.Id = condominio.NextId();
            condominio.Id_endereco = Convert.ToInt32(txIdEndereco.Text);
            condominio.Nome = txNome.Text;
            condominio.Qtd_Apt = Convert.ToInt32(condominio.Id_endereco);
            condominio.Valor_agua = Convert.ToDouble(txAgua.Text);
            condominio.Valor_gas = Convert.ToDouble(txGas.Text);
            condominio.Valor_luz = Convert.ToDouble(txLuz.Text);

            condominio.Adicionar();
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            Condominio condominio = new Condominio();
        }

        private void redirecionarPesquisa()
        {
            Response.Redirect("~/forms/pesquisa/FrmPesqCondominio.aspx");
        }

        private void redirecionarMesmaPagina()
        {
            Response.Redirect("~/forms/pesquisa/FrmCadCondominio.aspx");
        }
    }
}