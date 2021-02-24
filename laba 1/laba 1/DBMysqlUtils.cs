﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace laba_1
{
    class DBMySQLUtils

    {
        public static MySqlConnection

            GetDBConnection(string host, int port, string database, string username, string password)
        {
            String connString = "Server=" + host + "; Database=" + database + "; port=" + port + "; user=" + username + "; password=" + password;
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
    }
}