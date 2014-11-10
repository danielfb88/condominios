using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace condominios.Conexao
{
    public class DBSettings
    {
        private static String serverName = "localhost";
        private static String port = "5432";
        private static String userName = "postgres";
        private static String password = "postgres";
        private static String dataBaseName = "condominios";

        public static String GetStringConnection()
        {
            return String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                                    serverName, port, userName, password, dataBaseName);
        }
    }
}