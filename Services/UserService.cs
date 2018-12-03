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
        const string filename = "users.json";
        IList<Customer> users = new List<Customer>();

        public UserService()
        {
            this.users = context.Customer.ToList();
        }

        public Customer GetByName(string name)
        {
            var q = from x in this.users where x.Email == name select x;
            var user = q.FirstOrDefault();

            return user;
        }
    }

}
