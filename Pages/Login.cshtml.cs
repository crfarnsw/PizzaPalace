using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaPalace.Pages
{
    using System.ComponentModel.DataAnnotations;
    using System.Security.Claims;

    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Authentication.Cookies;
    using Microsoft.AspNetCore.Authorization;

    using PizzaPalace.Models;
    using PizzaPalace.Services;

    public class LoginModel : PageModel
    {
        IUserService userService;

        public Models.Customer Customer { get; set; }

        [BindProperty]
        public LoginData data { get; set; }

        private readonly PizzaPalacedbContext _context;

        public LoginModel(PizzaPalacedbContext context)
        {
            _context = context;
        }

        

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Customer = _context.Customer.FirstOrDefault(c => c.Email == data.Email);
        //        if (Customer == null)
        //        {
        //            ModelState.AddModelError(string.Empty, "username or password is invalid");
        //            return Page();
        //        }

        //        var isValid = Customer.Password == data.Password;
        //        if (!isValid)
        //        {
        //            ModelState.AddModelError(string.Empty, "username or password is invalid");
        //            return Page();
        //        }

        //        ClaimsIdentity identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
        //        identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, Customer.Email));
        //        identity.AddClaim(new Claim(ClaimTypes.Name, Customer.Email));
        //        var principal = new ClaimsPrincipal(identity);
        //        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
        //        return RedirectToPage("/Customer/Index");
        //    }
        //    else
        //    {
        //        ModelState.AddModelError(string.Empty, "username or password is blank");
        //        return Page();
        //    }
        //}

        public class LoginData
        {
            [Required]
            public string Email { get; set; }

            [Required, DataType(DataType.Password)]
            public string Password { get; set; }
        }
    }
}