using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_1Wpf
{
    internal class MockData
    {
         public static Dictionary<string, Contact> Contacts { get; set; }

        public static Dictionary<string, Contact> CreateData()
        {
            Contacts = new Dictionary<string, Contact>();

            Contact contact1 = new Contact() { FirstName = "Elijah", LastName = "Rogers", MobilePhone = "555-555-5555", WorkPhone = "555-555-5555", Address = "Place NC" };
            Contacts.Add(contact1.FullName, contact1);

            Contact contact2 = new Contact() { FirstName = "John", LastName = "Smith", MobilePhone = "555-555-5555", WorkPhone = "555-555-5555", Address = "Place2 NC" };
            Contacts.Add(contact2.FullName, contact2);


            return Contacts;

        }
    }
}
