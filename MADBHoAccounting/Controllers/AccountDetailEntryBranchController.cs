
using MADBHoAccounting.Models;
using MADBHoAccounting.Options;
using MADBHoAccounting.StoredProcedures;
using MADBHoAccounting.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MADBHoAccounting.Controllers
{
    public class AccountDetailEntryBranchController : Controller
    {
        private readonly MADBHoAccountingContext _context;
        public readonly ConnectionStrings _connectionStrings;
        public AccountDetailEntryBranchController(MADBHoAccountingContext context,IOptions<ConnectionStrings> connectionString)
        {
            _context = context;
            _connectionStrings = connectionString.Value;
        }

        AccountSubTitleSelectDAL accTitleDAL = new AccountSubTitleSelectDAL();
        AccountDetailEntryDAL accDetailEntryDAL = new AccountDetailEntryDAL();

        [HttpGet]
        public ActionResult Index()
        {
            var tspid = HttpContext.User.Identity.Name;
            var acc = _context.TbUserLogin.Where(x => x.UserPkid == Convert.ToInt32(tspid)).FirstOrDefault();
            ViewBag.AccountType = acc.AccountType;
            //if (acc.AccountType == "Super Admin")
            //{
                List<TB_AccountDetailEntry> atd = accDetailEntryDAL.GetAccountDetailEntryForBranch(_connectionStrings.DefaultConnection,acc.AccountType, acc.TownshipId, acc.StateDivisionId, "").ToList();
                return View(atd);
            //}//
            //else if (acc.AccountType == "User")
            //{
            //    List<TB_AccountDetailEntry> atd = accDetailEntryDAL.GetAccountDetailEntryForBranch(acc.TownshipId, "", "").ToList();
            //    return View(atd);
            //}
            //else if (acc.AccountType == "Head Admin")
            //{
            //    List<TB_AccountDetailEntry> atd = accDetailEntryDAL.GetAccountDetailEntryForBranch(acc.TownshipId, "", "").ToList();
            //    return View(atd);
            //}

        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var tspid = HttpContext.User.Identity.Name;
            var acc = _context.TbUserLogin.Where(x => x.UserPkid == Convert.ToInt32(tspid)).FirstOrDefault();
            TB_AccountDetailEntry atd = accDetailEntryDAL.GetAccountDetailEntryForBranch(_connectionStrings.DefaultConnection,acc.AccountType, acc.TownshipId,acc.StateDivisionId,"").Where(x => x.AccountID == id).FirstOrDefault();

            return View(atd);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var tspid = HttpContext.User.Identity.Name;
            var acc = _context.TbUserLogin.Where(x => x.UserPkid == Convert.ToInt32(tspid)).FirstOrDefault();
            TB_AccountDetailEntry atd = accDetailEntryDAL.GetAccountDetailEntryForBranch(_connectionStrings.DefaultConnection,acc.AccountType, acc.TownshipId, acc.StateDivisionId, "").Where(x => x.AccountID == id).FirstOrDefault();
            return View(atd);
        }

        [HttpPost]
        public IActionResult Edit(TB_AccountDetailEntry atd)
        {
            if (ModelState.IsValid)
            {
                accDetailEntryDAL.UpdateAccountDetailEntry(atd, _connectionStrings.DefaultConnection);
                return RedirectToAction("Index");
            }
            return View(atd);

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            TB_AccountDetailEntry atd = new TB_AccountDetailEntry();
            if (id != 0)
            {
                var tspid = HttpContext.User.Identity.Name;
                var acc = _context.TbUserLogin.Where(x => x.UserPkid == Convert.ToInt32(tspid)).FirstOrDefault();
                atd = accDetailEntryDAL.GetAccountDetailEntryForBranch(_connectionStrings.DefaultConnection,acc.AccountType, acc.TownshipId, acc.StateDivisionId, "").Where(x => x.AccountID == id).FirstOrDefault();
            }
            return View(atd);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([Bind] TB_AccountDetailEntry atd)
        {
            if (atd.AccountID != 0)
            {
                accDetailEntryDAL.DeleteAccountDetailEntry(atd.AccountID, _connectionStrings.DefaultConnection);

            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create(int id)
        {
            if (id == 0)
            {
                var tspid = HttpContext.User.Identity.Name;
                var acc = _context.TbUserLogin.Where(x => x.UserPkid == Convert.ToInt32(tspid)).FirstOrDefault();
                ViewBag.TownCode = acc.TownshipId;
                TbTownAndDivision td = _context.TbTownAndDivision.Where(x => x.TownCode == acc.TownshipId).FirstOrDefault();
                if (td != null)
                {
                    ViewBag.TownName = td.TownName;
                    ViewBag.DivisionName = td.DiviSionName;
                }
            }
            else if (id != 0)
            {
                var tspid = HttpContext.User.Identity.Name;
                var acc = _context.TbUserLogin.Where(x => x.UserPkid == Convert.ToInt32(tspid)).FirstOrDefault();
                ViewBag.TownCode = acc.TownshipId;
                TbTownAndDivision td = _context.TbTownAndDivision.Where(x => x.TownCode == acc.TownshipId).FirstOrDefault();
                if (td != null)
                {
                    ViewBag.TownName = td.TownName;
                    ViewBag.DivisionName = td.DiviSionName;
                }
                var atd = accDetailEntryDAL.GetAccountDetailEntryForBranch(_connectionStrings.DefaultConnection,acc.AccountType, acc.TownshipId, acc.StateDivisionId, "").Where(x => x.AccountID == id).FirstOrDefault();
                return View(atd);
            }
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind] TB_AccountDetailEntry atd)
        {
            if (atd.AccountID == 0)
            {
                accDetailEntryDAL.AddAccountDetailEntry(atd, _connectionStrings.DefaultConnection);
            }
            else
            {
                accDetailEntryDAL.UpdateAccountDetailEntry(atd, _connectionStrings.DefaultConnection);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public JsonResult Account_Load(string accountCode = "")
        {
            var accList = _context.TbAccountName.Where(x => x.AccountCode.Equals(accountCode)).FirstOrDefault();
            return Json(accList);
        }

        [HttpGet]
        public JsonResult GetTownship(string gpID = "")
        {
            var stateDivision = _context.TbStateDivision.Where(x => x.StateDivisionCode == gpID).Select(x => x.StateDivision).FirstOrDefault();
            return Json(stateDivision);
        }

        [HttpGet]
        public JsonResult Name_Load(string townCode = "", string groupNumber = "")
        {
            var resultList = _context.TbTownAndDivision.Where(x => x.TownCode.Equals(townCode) && x.GroupNumber.Equals(groupNumber)).FirstOrDefault();
            return Json(resultList);
        }
    }
}
