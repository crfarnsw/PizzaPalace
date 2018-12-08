using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPalace.Services
{
    using System.IO;

    using Newtonsoft.Json;

    using PizzaPalace.Models;
    
    /// <summary>
    /// This service class is strictly so ASP.NET will recognize the Customer database object as an authenticated login.
    /// </summary>
    public class UserService : IUserService
    {
        private PizzaPalacedbContext context = new PizzaPalacedbContext();
        IList<Customer> customers = new List<Customer>();

        /// <summary>
        /// Initializes the class property customers and sets the list as a list of customers in the database
        /// </summary>
        public UserService()
        {
            customers = context.Customer.ToList();
        }

        /// <summary>
        /// Finds customer in the database by their email
        /// </summary>
        /// <param name="Email">Email of the customer we want to return</param>
        /// <returns>Returns Customer object</returns>
        public Customer GetByName(string Email)
        {
            var q = from customer in customers where customer.Email == Email select customer;
            var user = q.FirstOrDefault();
            return user;
        }
    }

}
