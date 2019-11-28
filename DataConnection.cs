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
            //sql data source location and name (sql server authentication)
            conStr = @"Data Source=den1.mssql7.gear.host;Initial Catalog='mycontactsapp'; UID=mycontactsapp; PWD=Qq4XJK6-w!cj;";


    }
        //connect to sql server
        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
