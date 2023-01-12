
using MADBHoAccounting.Models;
using MADBHoAccounting.Options;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MADBHoAccounting.Controllers
{
    public class AccountLoginController : Controller
    {
        private readonly MADBHoAccountingContext _context;
        public readonly ConnectionStrings _connectionStrings;
        public AccountLoginController(MADBHoAccountingContext context,IOptions<ConnectionStrings> connectionString)
        {
            _context = context;
            _connectionStrings = connectionString.Value;
        }
        public IActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Login(string username, string password, string ReturnUrl)
        //{
        //    TB_UserLogin u = _context.TB_UserLogin.Where(x => x.Username.Equals(username) && x.Password.Equals(password) && x.Status.Equals("Enable")).FirstOrDefault();

        //    if (u != null)
        //    {
        //        // Generate random digit and save in database
        //        //Random rnd = new Random();
        //        //var otpValue = rnd.Next(0000, 9999);
        //        //u.OTP = otpValue.ToString().Length < 4 ? "0" + otpValue.ToString() : otpValue.ToString();
        //        //u.OTPCreatedTime = DateTime.Now.AddMinutes(5);
        //        //_context.SaveChanges();

        //        var claims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Name, Convert.ToString(u.UserLoginPkid))
        //        };

        //        var claimsIdentity = new ClaimsIdentity(claims, "Login");
        //        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
        //        //return Redirect(ReturnUrl == null ? "/Home" : ReturnUrl);


        //        //ViewBag.Message = "Success";

        //        return RedirectToAction("Index", "Home");
        //    }
        //    else
        //    {
        //        ViewBag.Error = "Your UserName or Password Wrong!";
        //        return View();
        //    }
        //}

        // Check OTP code available or unavailable and check login time within 5min
        //public async Task<IActionResult> OTPLogin(int id, string code, string ReturnUrl)
        //{
        //    DateTime dt = DateTime.Now;
        //    TB_User u = _context.TB_User.Where
        //        (x => x.UserPkid == id && x.OTP == code && x.OTPCreatedTime >= dt).FirstOrDefault();
        //    if (u != null)
        //    {
        //        var claims = new List<Claim>
        //            {
        //                new Claim(ClaimTypes.Name, Convert.ToString(u.UserPkid))
        //            };
        //        var claimsIdentity = new ClaimsIdentity(claims, "Login");
        //        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
        //        return Redirect(ReturnUrl == null ? "/Home" : ReturnUrl);
        //    }
        //    else
        //    {
        //        ViewBag.Id = id;
        //        ViewBag.Message = "Success";
        //        ViewBag.OTPError = "OTP Code is wrong! Please try again!";
        //        return View("Login");
        //    }
        //}

        public async Task<IActionResult> Branch(string tspid)
        {
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, tspid)
                };
            var claimsIdentity = new ClaimsIdentity(claims, "Login");
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
            //read cookie from IHttpContextAccessor  
            //string userpkid = HttpContext.User.Identity.Name;
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Response.Cookies.Delete(".AspNetCore.Cookies");
            TimeSpan.FromDays(-30);
            return RedirectToAction("Login", "AccountLogin");
        }

        //[HttpPost]
        //public async Task<IActionResult> Login(string username, string password)
        //{
        //    TB_UserLogin u = _context.TB_UserLogin.Where(x => x.Username.Equals(username) && x.Password.Equals(password)).FirstOrDefault();

        //    if (u != null)
        //    {
        //        // Generate random digit and save in database
        //        //Random rnd = new Random();
        //        //var otpValue = rnd.Next(0000, 9999);
        //        //u.OTP = otpValue.ToString().Length < 4 ? "0" + otpValue.ToString() : otpValue.ToString();
        //        //u.OTPCreatedTime = DateTime.Now.AddMinutes(5);
        //        //_context.SaveChanges();

        //        var claims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Name, Convert.ToString(u.UserPkid))
        //        };

        //        var claimsIdentity = new ClaimsIdentity(claims, "Login");
        //        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
        //        //return Redirect(ReturnUrl == null ? "/Home" : ReturnUrl);


        //        //ViewBag.Message = "Success";

        //        return RedirectToAction("Index", "Home");
        //    }
        //    else
        //    {
        //        ViewBag.Error = "Your UserName or Password Wrong!";
        //        return View();
        //    }
        //}

        //Test
        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            //TB_UserLogin a = _context.TB_UserLogin.Where(x => x.Username.Equals(username) && x.Password.Equals(password) && x.IsDeleted == false).FirstOrDefault();

            //TB_UserLogin a = _context.TB_UserLogin.Where( x => x.Name == username && x.Password == password).FirstOrDefault();
            TbUserLogin a = _context.TbUserLogin.Where(x => x.UsernameOrEmail == username && x.Password == password && x.Status == "Enable").FirstOrDefault();
            
            //ViewBag.TownshipId = a.TownshipId;
            if (a != null)
            {
                ViewBag.TownshipId = a.TownshipId;
                ViewBag.DivisionCode = a.StateDivisionId;
                ViewBag.AccountType = a.AccountType;
                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, Convert.ToString(a.UserPkid))
                    };

                var claimsIdentity = new ClaimsIdentity(claims, "Login");
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                //return Redirect(ReturnUrl == null ? "/Home" : ReturnUrl); 
                //ViewBag.Message = "Success";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Error = "Your UserName or Password Wrong!";
                return View();
            }
        }
    }
}
