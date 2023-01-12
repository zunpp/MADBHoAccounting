
using MADBHoAccounting.Models;
using MADBHoAccounting.Options;
using MADBHoAccounting.StoredProcedures;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MADBHoAccounting.Controllers
{
    public class AccountNameController : Controller
    {
        private readonly MADBHoAccountingContext _context;
        public readonly ConnectionStrings _connectionStrings;

        public AccountNameController(MADBHoAccountingContext context,IOptions<ConnectionStrings> connectionString)
        {
            _context = context;
            _connectionStrings = connectionString.Value;
        }

        AccountNameDAL accNameDAL = new AccountNameDAL();

        //[HttpGet]
        //public IActionResult Index(int pg = 1)
        //{
        //    const int pageSize = 15;

        //    if (pg < 1)
        //        pg = 1;

        //    int recsCount = _context.TB_AccountName.Count();

        //    var pager = new Pager(recsCount, pg, pageSize, "AccountName");
        //    int recSkip = (pg - 1) * pageSize;
        //    List<TB_AccountName> an = accNameDAL.GetAllAccountName().ToList().Skip(recSkip).Take(pager.PageSize).ToList();
        //    //an.Skip(recSkip).Take(pager.PageSize).ToList();
        //    this.ViewBag.Pager = pager;


        //    return View(an);
        //}
        [HttpGet]
        public ActionResult Index()
        {
            var tspid = HttpContext.User.Identity.Name;
            var acc = _context.TbUserLogin.Where(x => x.UserPkid == Convert.ToInt32(tspid)).FirstOrDefault();
            ViewBag.AccountType = acc.AccountType;
            List<TbAccountName> atd = accNameDAL.GetAllAccountName(_connectionStrings.DefaultConnection).ToList();
            //return View(db.Posts.OrderByDescending(p => p.Id).ToList());
            return View(atd);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            TbAccountName AccHead = accNameDAL.GetAllAccountName(_connectionStrings.DefaultConnection).Where(x => x.AccountId == id).FirstOrDefault();

            return View(AccHead);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            TbAccountName an = accNameDAL.GetAllAccountName(_connectionStrings.DefaultConnection).Where(x => x.AccountId == id).FirstOrDefault();

            return View(an);
        }

        [HttpPost]
        public IActionResult Edit(TbAccountName an)
        {
            if (ModelState.IsValid)
            {
                accNameDAL.UpdateAccountMainTitle(an, _connectionStrings.DefaultConnection);
                return RedirectToAction("Index");
            }
            return View(an);


        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            TbAccountName an = new TbAccountName();
            if (id != 0)
            {
                an = accNameDAL.GetAllAccountName(_connectionStrings.DefaultConnection).Where(x => x.AccountId == id).FirstOrDefault();
            }
            return View(an);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([Bind] TbAccountName an)
        {
            if (an.AccountId != 0)
            {
                accNameDAL.DeleteAccountMainTitle(an.AccountId, _connectionStrings.DefaultConnection);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create(int id)
        {
            TbAccountName an = new TbAccountName();
            if (id != 0)
            {
                an = accNameDAL.GetAllAccountName(_connectionStrings.DefaultConnection).Where(x => x.AccountId == id).FirstOrDefault();
            }
            return View(an);
        }

        [HttpPost]
        public IActionResult Create([Bind] TbAccountName an)
        {
            var accCode = an.AccountCode;
            //var accLst = _context.TB_AccountName.Where(x => x.AccountCode.Equals("") && x.IsDeleted.Equals(false)).ToList();
            var result = _context.TbAccountName.Any( x => x.AccountCode.Equals(accCode) && x.IsDeleted.Equals(false));
            if (result == true)
            {
                ViewBag.ErrorMsg = "Already exists Account Code";
            }
            else
            {
                if (an.AccountId == 0)
                {
                    accNameDAL.AddAccountMainTitle(an, _connectionStrings.DefaultConnection);
                    return RedirectToAction("Index");
                }
            }

            if (an.AccountId > 0)
            {
                accNameDAL.UpdateAccountMainTitle(an, _connectionStrings.DefaultConnection);
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
