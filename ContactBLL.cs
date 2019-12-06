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
        
        ContactDAL daContacts;
        public ContactBLL()
        {
            //create a new Contact Data Access Layer
            daContacts = new ContactDAL();
        }

        public DataTable getAllContacts()
        {
            //return All contacts
            return daContacts.getAllContacts();
        }

        public bool InsertContact(tblContacts ct)
        {
            //return insert contact
            return daContacts.InsertContact(ct);
        }

        public bool UpdateContact(tblContacts ct)
        {
            //return update contact
            return daContacts.UpdateContact(ct);
        }

        public bool DeleteContact(tblContacts ct)
        {
            return daContacts.DeleteContact(ct);
        }

        public DataTable FindContact(string ct)
        {
            return daContacts.FindConact(ct);
        }

    }
}
