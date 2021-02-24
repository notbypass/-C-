﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace laba_1
{
    class DBUtils
    {
        public static MySqlConnection GetMySqlConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "makar";
            string username = "root";
            string password = "root";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}