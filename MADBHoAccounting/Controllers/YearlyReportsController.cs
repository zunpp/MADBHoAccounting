using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MADBHoAccounting.Controllers
{
    public class YearlyReportsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
