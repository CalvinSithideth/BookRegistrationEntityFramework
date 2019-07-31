using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationEF
{
    /// <summary>
    /// Basic CRUD functionality for customers
    /// </summary>
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
            using (var context = new BookRegistrationEntities())
            {
                context.Customer.Add(c);
                // SaveChanges MUST BE CALLED for insert/update/delete
                context.SaveChanges();

                // Return newly added customer with CustomerID populated
                return c;
            }
        }

        public static Customer UpdateCustomer(Customer c)
        {
            using (var context = new BookRegistrationEntities())
            {
                context.Customer.Add(c); // Add to context
                // Tell EF we are updating an existing entity
                context.Entry(c).State = EntityState.Modified; // Tell EF it has been modified
                context.SaveChanges();
                return c;
            }
        }

        public static void DeleteCustomer(Customer c)
        {
            using (var context = new BookRegistrationEntities())
            {
                context.Customer.Add(c); // "Track" with EF
                context.Entry(c).State = EntityState.Deleted; // Tell EF we are removing it
                int rowsAffected = context.SaveChanges(); // Update on database
                // int rowsAffected is optional
            }
        }
    }
}
