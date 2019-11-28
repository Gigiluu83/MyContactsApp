//STUDENT:  PHUQUY PHAM
//COURSE:  MONDAY, C# CODELOUISVILLE BELLARMINE
//DATE:  NOV 26, 2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;


namespace MyContactsApp
{
    class ContactDAL
    {
        DataConnection datacon;
        SqlDataAdapter dataap;
        SqlCommand comm;
        public ContactDAL()
        {
            datacon = new DataConnection();
        }

        //get all contacts method
        public DataTable getAllContacts()
        {
            //get data statement
            string sql = "SELECT * FROM tblContacts";
            SqlConnection conn = datacon.getConnect();
            dataap = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            dataap.Fill(dt);
            conn.Close();
            return dt;
        }

        //insert contact method
        public bool InsertContact(tblContacts ct)
        {
            //insert statement
            string query = "INSERT INTO tblContacts(FirstName, LastName, PhoneNumber, EmailAddress, Address) VALUES(@FirstName, @LastName, @PhoneNumber,@EmailAddress, @Address)";
            SqlConnection conn = datacon.getConnect();

             try
            {
                //create a command object
                comm = new SqlCommand(query, conn);
                //open the connection
                conn.Open();
                //add parameter @FirstName
                comm.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = ct.FirstName;
                //add parameter @LastName
                comm.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = ct.LastName;
                //add parameter @PhoneNumber
                comm.Parameters.Add("@PhoneNumber",SqlDbType.NVarChar).Value = ct.PhoneNumber;
                //add parameter @EmailAddress
                comm.Parameters.Add("@EmailAddress", SqlDbType.NVarChar).Value = ct.EmailAddress;
                //add parameter @Address
                comm.Parameters.Add("@Address", SqlDbType.NVarChar).Value = ct.Address;
                //execute command
                comm.ExecuteNonQuery();
                //close connection
                conn.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        //Update Contact Method
        public bool UpdateContact(tblContacts ct)
        {
            //update statement
            string query = "UPDATE tblContacts SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, EmailAddress = @EmailAddress, Address = @Address WHERE ID = @ID";
            SqlConnection conn = datacon.getConnect();

            try
            {
                //create a command object
                comm = new SqlCommand(query, conn);
                //open connection
                conn.Open();
                comm.Parameters.Add("@ID", SqlDbType.Int).Value = ct.ID;
                comm.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = ct.FirstName;
                comm.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = ct.LastName;
                comm.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = ct.PhoneNumber;
                comm.Parameters.Add("@EmailAddress", SqlDbType.NVarChar).Value = ct.EmailAddress;
                comm.Parameters.Add("@Address", SqlDbType.NVarChar).Value = ct.Address;
                //execute command
                comm.ExecuteNonQuery();
                //close connection
                conn.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        //Delete Contact Method
        public bool DeleteContact(tblContacts ct)
        {
            //delete statement
            string sql = "DELETE tblContacts WHERE ID = @ID";
            SqlConnection conn = datacon.getConnect();
            try
            {
                //create a command object
                comm = new SqlCommand(sql, conn);
                conn.Open();
                comm.Parameters.Add("@ID", SqlDbType.Int).Value = ct.ID;
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        //find contact method
        public DataTable FindConact(string ct)
        {
            //find statement using first name or last name
            string sql = "SELECT * FROM tblContacts WHERE FirstName like '%" + ct + "%' OR LastName like '%" + ct + "%'";
            SqlConnection conn = datacon.getConnect();
            dataap = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            dataap.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}