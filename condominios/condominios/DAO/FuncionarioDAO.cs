﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace condominios.DAO
{
    public class FuncionarioDAO : DAOGenerico
    {
        public FuncionarioDAO()
        {
            this.TableName = "funcionario";
        }
    }
}