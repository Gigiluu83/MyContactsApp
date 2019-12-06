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
using Microsoft.Office.Interop.Excel;

namespace MyContactsApp
{
    public partial class MyContactsApp : Form
    {
        ContactBLL bllContact;

        public MyContactsApp()
        {
            InitializeComponent();
            bllContact = new ContactBLL();
        }

        //show all contacts
        public void ShowAllContacts()
        {
            System.Data.DataTable dt = bllContact.getAllContacts();
            dataGridView1.DataSource = dt;

        }

        //show all contacts when the app loads
        private void MyContactsApp_Load(object sender, EventArgs e)
        {
            ShowAllContacts();

            //show "add new contact" when mouse hovers Add Button
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(this.btnAdd, "Add New Contact");

            //show "Delete Contact" when mouse hovers Delete Button
            System.Windows.Forms.ToolTip toolTip2 = new System.Windows.Forms.ToolTip();
            toolTip2.SetToolTip(this.btnDelete, "Delete Contact");

            //show "Update Contect" when mouse hovers Update Button
            System.Windows.Forms.ToolTip toolTip3 = new System.Windows.Forms.ToolTip();
            toolTip3.SetToolTip(this.Update, "Update Contact");
            
            //show "Export to Excel" when mouse hovers Export Button
            System.Windows.Forms.ToolTip toolTip4 = new System.Windows.Forms.ToolTip();
            toolTip4.SetToolTip(this.btnExport, "Export to Excel");

        }
        //Add New Contact when the Add button is clicked
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addform = new AddForm())
            {
                //shows Add Form and check if DialogResult is OK
                if (addform.ShowDialog() == DialogResult.OK)
                {
                    //shows all contacts
                    this.ShowAllContacts();
                }
            }

        }

        int Id;
        UpdateForm updateForm = new UpdateForm();
        //showing contact info in datagridview
        public void dataGridViewCt(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                Id = Int32.Parse(dataGridView1.Rows[index].Cells["ID"].Value.ToString());
                updateForm.txtFirstName.Text = dataGridView1.Rows[index].Cells["FirstName"].Value.ToString();
                updateForm.txtLastName.Text = dataGridView1.Rows[index].Cells["LastName"].Value.ToString();
                updateForm.txtPhoneNumber.Text = dataGridView1.Rows[index].Cells["PhoneNumber"].Value.ToString();
                updateForm.txtEmailAddress.Text = dataGridView1.Rows[index].Cells["EmailAddress"].Value.ToString();
                updateForm.txtAddress.Text = dataGridView1.Rows[index].Cells["Address"].Value.ToString();
            }
        }


        //when user clicks on Update Button
        private void Update_Click(object sender, EventArgs e)
        {
            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                tblContacts ct = new tblContacts();
                ct.ID = Id;
                ct.FirstName = updateForm.txtFirstName.Text.ToUpper();
                ct.LastName = updateForm.txtLastName.Text.ToUpper();
                ct.PhoneNumber = updateForm.txtPhoneNumber.Text;
                ct.Address = updateForm.txtAddress.Text.ToUpper();
                ct.EmailAddress = updateForm.txtEmailAddress.Text.ToUpper();
                ct.Address = updateForm.txtAddress.Text.ToUpper();
                //update contact info
                if (bllContact.UpdateContact(ct))
                    //after updating, show new data for all contacts
                    this.ShowAllContacts();
            }
        }

        //when Delete button is clicked
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //prompt user if they are sure they want to delete the contact
            if (MessageBox.Show("Are You Sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //create new contact table
                tblContacts ct = new tblContacts();
                //use contact ID to delete
                ct.ID = Id;
                //delete contact
                if (bllContact.DeleteContact(ct))
                    //after deleting, show all contacts
                    ShowAllContacts();
                else
                    MessageBox.Show("Error, please try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //find contact as user keys in Find text box
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            //show contact if find text box is not empty
            string value = txtFind.Text.ToUpper();
            if (!string.IsNullOrEmpty(value))
            {
                System.Data.DataTable dt = bllContact.FindContact(value);
                dataGridView1.DataSource = dt;
            }

            //if empty then show all contacts
            else
                ShowAllContacts();
        }

        //export file to Microsoft Excel spreadsheet
        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;

            ws.Cells[1, 1] = "ID";
            ws.Cells[1, 2] = "FirstName";
            ws.Cells[1, 3] = "LastName";
            ws.Cells[1, 4] = "PhoneNumber";
            ws.Cells[1, 5] = "EmailAddress";
            ws.Cells[1, 6] = "Address";

            for (int j = 2; j <= dataGridView1.Rows.Count; j++)
            {
                for (int i = 2; i <= 6; i++)
                {
                    ws.Cells[j, i] = dataGridView1.Rows[j-2].Cells[i-1].Value;
                }
            }


        }
    }

}
