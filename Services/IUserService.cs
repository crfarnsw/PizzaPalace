namespace PizzaPalace.Services
{
    using PizzaPalace.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IUserService
    {
        Customer GetByName(string email);
    }
}
