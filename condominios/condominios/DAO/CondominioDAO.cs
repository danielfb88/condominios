using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace condominios.DAO
{
    public class CondominioDAO : DAOGenerico
    {
        public CondominioDAO()
        {
            this.TableName = "condominio";
        }
    }
}