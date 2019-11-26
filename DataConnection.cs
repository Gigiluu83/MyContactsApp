//STUDENT:  PHUQUY PHAM
//COURSE:  MONDAY, C# CODELOUISVILLE BELLARMINE
//DATE:  NOV 26, 2019

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContactsApp
{
    class DataConnection
    {
        string conStr;

        public DataConnection()
        {
            //sql data source location and name (window authentication)
            conStr = @"Data Source=LAPTOP-M9SUKVQF\SQLEXPRESS;Initial Catalog='Contacts Database';Integrated Security=True";


    }
        //connect to sql server
        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
