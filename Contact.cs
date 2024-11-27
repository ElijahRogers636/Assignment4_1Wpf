using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Assignment4_1Wpf
{

    internal class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string WorkPhone { get; set; }
        public string Address { get; set; }
        public string FullName
        {
            get
            {
                return (FirstName+LastName).ToLower().Trim().Replace(" ","");
            }

        }

        // Method used to find a contact by key enter
        public static List<Contact> FilteredData(string key)
        {
            List<Contact> dict = new List<Contact>();

            key = key.ToLower().Trim().Replace(" ", "");

            if (MockData.Contacts.ContainsKey(key))
            {
                dict.Add(MockData.Contacts[key]);
            }

            return dict;
        }


        public static void AddContact(string key, Contact contact)
        {
            key = key.ToLower().Trim().Replace(" ", "");

            if (!MockData.Contacts.TryAdd(key, contact))
            {
                MessageBox.Show("Could not add new contact");
            }
        }

        public static void RemoveContact(string key)
        {
            key = key.ToLower().Trim().Replace(" ", "");

            if (!MockData.Contacts.Remove(key))
            {
                MessageBox.Show("No contacts match given name.");
            }
        }
    }
}
