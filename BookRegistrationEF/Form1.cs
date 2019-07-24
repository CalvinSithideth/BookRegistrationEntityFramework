using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRegistrationEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCustomerList();
            PopulateBooks();
        }

        /// <summary>
        /// Adds all books to the form in alphabetical order
        /// </summary>
        private void PopulateBooks()
        {
            List<Book> books = BookDB.GetBooks();
            CboBooks.DataSource = books;
            CboBooks.DisplayMember = nameof(Book.Title);
        }

        /// <summary>
        /// Populates customer list from the database
        /// </summary>
        private void PopulateCustomerList()
        {
            List<Customer> customers = CustomerDB.GetCustomers();

            CboCustomers.DataSource = customers;
            CboCustomers.DisplayMember = nameof(Customer.FullName);
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            // Hard code customer for testing purposes
            Customer cust = new Customer()
            {
                FirstName = "D",
                LastName = "Reynolds",
                DateOfBirth = DateTime.Now,
                Title = "Mr."
            };

            CustomerDB.AddCustomer(cust);

            string output = $"Added {cust.CustomerID} : {cust.FullName}";
            MessageBox.Show(output);

            PopulateCustomerList();
        }
    }
}
