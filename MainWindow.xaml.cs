using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment4_1Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        Dictionary<string, Contact> contacts;
        public MainWindow()
        {
            InitializeComponent();
            contacts = MockData.CreateData();
            ContactData.ItemsSource = contacts.Values;
        }

        // Buttons code used to search for a contact by key(First+LastName)
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string key = txtSearch.Text;

            var filteredContacts = Contact.FilteredData(key);

            ContactData.ItemsSource = filteredContacts;

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact() { FirstName = "Paul", LastName = "Rogers", MobilePhone = "555-555-5555", WorkPhone = "555-555-5555", Address = "Place NC" };
            string key = contact.FullName;
            Contact.AddContact(key, contact);
            ContactData.Items.Refresh();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            string key = txtRemove.Text;
            Contact.RemoveContact(key);
            ContactData.Items.Refresh();
        }
    }
}