//STUDENT:  PHUQUY PHAM
//COURSE:  MONDAY, C# CODELOUISVILLE BELLARMINE
//DATE:  NOV 26, 2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContactsApp
{
    public partial class AddForm : Form
    {
        ContactBLL contactBLL;
        public AddForm()
        {
            InitializeComponent();
            contactBLL = new ContactBLL();
        }

        public bool CheckData()
        {
            //check to make sure FirstName field is not empty
            if (string.IsNullOrEmpty(txtFirstName.Text))

            {
                //if FirstName field is empty, then show this message box
                MessageBox.Show("You have not put in a FirstName", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFirstName.Focus();
                return false;
            }
            return true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckData())
          
            {//create a new contact table and include the below info
                tblContacts ct = new tblContacts();
                ct.FirstName = txtFirstName.Text;
                ct.LastName = txtLastName.Text;
                ct.PhoneNumber = txtPhoneNumber.Text;
                ct.EmailAddress = txtEmailAddress.Text;
                ct.Address = txtAddress.Text;
                //insert contact 
                if (contactBLL.InsertContact(ct))
                {
                    this.DialogResult = DialogResult.OK;
                }
                //close addform
                this.Close();
                //show successful message box
                MessageBox.Show("Added Successfully!");
                
            }
            //clear text from text boxes from adding a new contact
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNumber.Text = "";
            txtEmailAddress.Text = "";
            txtAddress.Text = "";
        }
    }
}
