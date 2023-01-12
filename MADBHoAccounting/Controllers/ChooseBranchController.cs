
using MADBHoAccounting.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MADBHoAccounting.Controllers
{
    public class ChooseBranchController : Controller
    {
        private readonly MADBHoAccountingContext _context;

        public ChooseBranchController(MADBHoAccountingContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
