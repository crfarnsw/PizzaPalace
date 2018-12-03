using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPalace.Services
{
    using System.IO;

    using Newtonsoft.Json;

    using PizzaPalace.Models;

    public class UserService : IUserService
    {
        private PizzaPalacedbContext context = new PizzaPalacedbContext();
        IList<Customer> customers = new List<Customer>();

        public UserService()
        {
            customers = context.Customer.ToList();
        }

        public Customer GetByName(string Email)
        {
            var q = from customer in customers where customer.Email == Email select customer;
            var user = q.FirstOrDefault();
            return user;
        }
    }

}
