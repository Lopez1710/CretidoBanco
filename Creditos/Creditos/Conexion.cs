﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Creditos
{
    class Conexion
    {
        public static IDbConnection conectar()
        {
            IDbConnection connection;
            var cadena = ConfigurationManager.ConnectionStrings["conexioncreditos"].ConnectionString;
            connection = new SqlConnection(cadena);
            return connection;
        }
    }
}
