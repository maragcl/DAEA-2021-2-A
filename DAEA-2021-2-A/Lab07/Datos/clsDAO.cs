﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class clsDAO
    {
        public SqlConnection con;
        //Conexión a SQL SERVER
        String servidor = "LAPTOP-AOPQJ586\\SQLEXPRESS";
        String db = "School";

        public clsDAO()
        {
            String str = "Server=" + servidor + ";Database=" + db + ";Integrated Security=true";
            con = new SqlConnection(str);
        }
    }
}
