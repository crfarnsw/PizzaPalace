
namespace PizzaPalace.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Authentication.Cookies;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using PizzaPalace.Models;
    using PizzaPalace.Services;

    public class LoginController : Controller
    {
        IUserService userService;

        public LoginController(IUserService userService) => this.userService = userService;

        public Customer Customer { get; set; }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        
        [AllowAnonymous]
        [HttpPost("~/login")]
        public async Task<IActionResult> Login(Customer data)
        {
            var returnUrl = "/";

            var customer = userService.GetByName(data.Email);

            // check a password
            bool validPassword = BCrypt.Net.BCrypt.Verify(data.Password, customer.Password);
            if (!validPassword)
            {
                return LocalRedirect(returnUrl);
            }

            var props = new AuthenticationProperties
                            {
                                IsPersistent = true,
                                ExpiresUtc = DateTime.UtcNow.AddMinutes(5),
                            };

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, customer.Email)
            };

            ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props);

            return LocalRedirect(returnUrl);
        }

        [HttpPost("~/logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return LocalRedirect("/Login");
        }
    }
}