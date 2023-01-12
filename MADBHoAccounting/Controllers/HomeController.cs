using MADBHoAccounting.Models;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace MADBHoAccounting.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

        private readonly MADBHoAccountingContext _context;

        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(ILogger<HomeController> logger, MADBHoAccountingContext context, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        //public IActionResult Index(string tspid)
        //{
        //    //read cookie from IHttpContextAccessor  
        //    //string userpkid = HttpContext.User.Identity.Name;
        //    return View();
        //}

        public async Task<IActionResult> Index()
        {

            var tspid = HttpContext.User.Identity.Name;

            var acc = _context.TbUserLogin.Where(x => x.UserPkid == Convert.ToInt32(tspid)).FirstOrDefault();
            ViewBag.AccountType = acc.AccountType;
            if (acc.AccountType == "Admin")
            {
                ViewBag.Department = acc.Department;
                ViewBag.TownCode = acc.TownshipId;
            }
            else if (acc.AccountType == "User")
            {
                TbTownAndDivision td = _context.TbTownAndDivision.Where(x => x.TownCode == acc.TownshipId).FirstOrDefault();
                ViewBag.TownCode = acc.TownshipId;
                ViewBag.TownName = td.TownName;
                ViewBag.DivisionName = td.DiviSionName;
            }
            else if (acc.AccountType == "Super Admin")
            {
                TbTownAndDivision sd = _context.TbTownAndDivision.Where(x => x.DivisionCode == acc.StateDivisionId).FirstOrDefault();
                ViewBag.DivisionName = sd.DiviSionName;
                ViewBag.DivisionCode = sd.DivisionCode;
                ViewBag.TownName = sd.TownName;
            }
            else if (acc.AccountType == "Head Admin")
            {                
                ViewBag.DivisionName = acc.StateDivisionId;
                
            }
            //ViewBag.Department = acc.Department;
            //ViewBag.TownCode = acc.TownshipId;


            ViewBag.CurrentPage = "Home";
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult ChooseBranch()
        {
            return View();
        }

        [HttpGet]
        public JsonResult StateDivision()
        {
            List<TbStateDivision> stateDivisionList = _context.TbStateDivision.ToList();
            return Json(stateDivisionList);
        }

        [HttpGet]
        public JsonResult TownShipName(string stateId)
        {
            List<TbTownship> townshipList = _context.TbTownship.Where(x => x.StateDivisionId == stateId).ToList();
            return Json(townshipList);
        }
    }
}
