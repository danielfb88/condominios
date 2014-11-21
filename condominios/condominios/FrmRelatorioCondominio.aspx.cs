using condominios.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace condominios
{
    public partial class FrmRelatorioCondominio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gridView1.DataSource = new RelatorioDAO().RelatorioValoresCondominio();
                gridView1.DataBind();
            }
        }
    }
}