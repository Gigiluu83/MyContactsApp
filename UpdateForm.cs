using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContactsApp
{
    public partial class UpdateForm : Form

    {

        ContactBLL contactBLL;
        public UpdateForm()
        {
            InitializeComponent();

            contactBLL = new ContactBLL();
        }

        int Id;
        public void button1_Click_1(object sender, EventArgs e)
        {
            //update contact info
                DialogResult = DialogResult.OK;
            this.Close();
            MessageBox.Show("Updated Successfully!");
            


    }


}
    }

    

