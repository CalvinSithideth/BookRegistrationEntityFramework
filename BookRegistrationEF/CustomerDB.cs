using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationEF
{
    static class CustomerDB
    {
        /// <summary>
        /// Returns all customers from the database
        /// </summary>
        /// <returns></returns>
        public static List<Customer> GetCustomers()
        {
            // Create instance of DB Context
            var dbc = new BookRegistrationEntities();

            // Use DB Context to retreive all customers
            // Use LINQ (Language INtegrated Query) to query database

            // LINQ Query Syntax
            //List<Customer> customers =
            //    (from row in dbc.Customer
            //         where row.LastName == "Reynolds"
            //         orderby row.LastName
            //     select row).ToList();

            //return customers;

            // LINQ Method Syntax - Same query as above
            List<Customer> customers =
                dbc.Customer
                    //.Where(row => row.LastName == "Reynolds")
                    //.OrderByDescending(row => row.LastName)
                    .ToList();

            return customers;
        }

        /// <summary>
        /// Adds a customer. Returns the newly added customer
        /// with the CustomerID populated
        /// </summary>
        /// <param name="c">The new Customer to be added</param>
        /// <returns></returns>
        public static Customer AddCustomer(Customer c)
        {
            throw new NotImplementedException();
        }
    }
}
