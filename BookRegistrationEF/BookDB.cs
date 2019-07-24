using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationEF
{
    /// <summary>
    /// Contains helper methods to manipulate books in the database
    /// </summary>
    static class BookDB
    {
        /// <summary>
        /// Retrieves all books sorted in alphabetical by title
        /// </summary>
        /// <returns></returns>
        public static List<Book> GetBooks()
        {
            // The 'using' statement will force the compiler to create a try/finally.
            // The 'finally' will dispose of the db context.
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement
            using (var context = new BookRegistrationEntities())
            {
                // LINQ Method Syntax
                return context
                    .Book
                    .OrderBy( book => book.Title )
                    .ToList();

                // LINQ Query Syntax
                /*
                List<Book> books =
                    (from row in context.Book
                     orderby row.Title ascending
                     select row).ToList();

                return books;
                */

                // Ditto - without variable.
                // A bit unclear about return type though.
                /*
                return
                    (from row in context.Book
                     orderby row.Title ascending
                     select row).ToList();
                */

            }
            
        }
    }
}
