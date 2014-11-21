using condominios.DAO;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace condominios
{
    public partial class FrmRelatorioMorador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                RelatorioDAO dao = new RelatorioDAO();
                NpgsqlDataReader dataReader = new RelatorioDAO().RelatorioMoradoresInadimplentes();

                gridView1.DataSource = dao.RelatorioMoradoresInadimplentes();
                gridView1.DataBind();

                /*
                 * Fechando
                 * */
                dataReader.Close();
                dao.CloseCon();
            }
        }
    }
}