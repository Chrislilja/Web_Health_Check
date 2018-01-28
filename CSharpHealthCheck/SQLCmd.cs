using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHealthCheck
{
    class SQLCmd
    {
        public string comrun(string command)
        {
            //Create and forward SQL command to DB
            SQLCon con = new SQLCon();


            MySqlConnection connection = con.connect();



            MySqlCommand comm = new MySqlCommand(command, connection);

            comm.CommandText = command;
            comm.Connection = connection;

            return Convert.ToString(comm.ExecuteScalar());


        }
    }
}
