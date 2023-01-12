


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
    public class UserLoginController : Controller
    {
        private readonly MADBHoAccountingContext _context;
        public readonly ConnectionStrings _connectionStrings;
        public UserLoginController(MADBHoAccountingContext context,IOptions<ConnectionStrings> connectionString)
        {
            _context = context;
        }

        UserLoginDAL UserLoginDAL = new UserLoginDAL();

        [HttpGet]
        public IActionResult Index(int pg = 1)
        {
            const int pageSize = 10;

            if (pg < 1)
                pg = 1;

            int recsCount = _context.TbUserLogin.Count();

            //var pager = new Pager(recsCount, pg, pageSize, "FinancialYear");
            //int recSkip = (pg - 1) * pageSize;
            //List<TB_UserLogin> ul = UserLoginDAL.GetAllUser().ToList().Skip(recSkip).Take(pager.PageSize).ToList();
            List<TbUserLogin> ul = UserLoginDAL.GetAllUser(_connectionStrings.DefaultConnection).ToList();//.Skip(recSkip).Take(pager.PageSize).ToList();
            //AMT.Skip(recSkip).Take(pager.PageSize).ToList();
            //this.ViewBag.Pager = pager;

            return View(ul);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            TbUserLogin ul = UserLoginDAL.GetAllUser(_connectionStrings.DefaultConnection).Where(x => x.UserPkid == id).FirstOrDefault();

            return View(ul);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            TbUserLogin ul = UserLoginDAL.GetAllUser(_connectionStrings.DefaultConnection).Where(x => x.UserPkid == id).FirstOrDefault();

            return View(ul);
        }

        [HttpPost]
        public IActionResult Edit(TbUserLogin ul)
        {
            _context.Attach(ul);
            _context.Entry(ul).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            TbUserLogin ul = UserLoginDAL.GetAllUser(_connectionStrings.DefaultConnection).Where(x => x.UserPkid == id).FirstOrDefault();

            return View(ul);
        }

        [HttpPost]
        public IActionResult Delete(TbUserLogin ul)
        {
            _context.Attach(ul);
            _context.Entry(ul).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            TbUserLogin ul = new TbUserLogin();
            return View(ul);
        }

        [HttpPost]
        public IActionResult Create(TbUserLogin ul)
        {
            _context.Attach(ul);
            _context.Entry(ul).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            _context.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}
