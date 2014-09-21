using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace condominios.DAO
{
    public class MoradorDAO : DAOGenerico
    {
        public MoradorDAO () {
            this.TableName = "morador";
        }
    }
}