using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContactsApp
{
    //contact business logic layer class
    class ContactBLL
    {
        //
        ContactDAL daContacts;
        public ContactBLL()
        {
            //create a new Contact Data Access Layer
            daContacts = new ContactDAL();
        }

        //call the getallcontacts method
        public DataTable getAllContacts()
        {
            return daContacts.getAllContacts();
        }

        //call the insert contact method
        public bool InsertContact(tblContacts ct)
        {
            return daContacts.InsertContact(ct);
        }

        //call the update contact method
        public bool UpdateContact(tblContacts ct)
        {
            return daContacts.UpdateContact(ct);
        }

        //call the delete contact method
        public bool DeleteContact(tblContacts ct)
        {
            return daContacts.DeleteContact(ct);
        }

        //call the find contact method
        public DataTable FindContact(string ct)
        {
            return daContacts.FindConact(ct);
        }

    }
}
