
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
    public class FinancialYearController : Controller
    {
        private readonly MADBHoAccountingContext _context;
        public readonly ConnectionStrings _connectionStrings;
        public FinancialYearController(MADBHoAccountingContext context,IOptions<ConnectionStrings> connectionString)
        {
            _context = context;
            _connectionStrings = connectionString.Value;
        }

        FinancialYearDAL financialYearDAL = new FinancialYearDAL();

        [HttpGet]
        public IActionResult Index(int pg = 1)
        {
            const int pageSize = 10;

            if (pg < 1)
                pg = 1;

            int recsCount = _context.TbFinancialYear.Count();

            //var pager = new Pager(recsCount, pg, pageSize, "FinancialYear");
            //int recSkip = (pg - 1) * pageSize;
            List<TB_FinancialYear> fy = financialYearDAL.GetAllFinancialYear(_connectionStrings.DefaultConnection).ToList();//.Skip(recSkip).Take(pager.PageSize).ToList();
            //AMT.Skip(recSkip).Take(pager.PageSize).ToList();
            //this.ViewBag.Pager = pager;

            return View(fy);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            TB_FinancialYear fy = financialYearDAL.GetAllFinancialYear(_connectionStrings.DefaultConnection).Where(x => x.FinancialYearPkid == id).FirstOrDefault();

            return View(fy);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            TB_FinancialYear fy = financialYearDAL.GetAllFinancialYear(_connectionStrings.DefaultConnection).Where(x => x.FinancialYearPkid == id).FirstOrDefault();

            return View(fy);
        }

        [HttpPost]
        public IActionResult Edit(TbFinancialYear fy)
        {
            _context.Attach(fy);
            _context.Entry(fy).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            TB_FinancialYear fy = financialYearDAL.GetAllFinancialYear(_connectionStrings.DefaultConnection).Where(x => x.FinancialYearPkid == id).FirstOrDefault();

            return View(fy);
        }

        [HttpPost]
        public IActionResult Delete(TbFinancialYear fy)
        {
            _context.Attach(fy);
            _context.Entry(fy).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            TbFinancialYear fy = new TbFinancialYear();
            return View(fy);
        }

        [HttpPost]
        public IActionResult Create(TbFinancialYear fy)
        {
            _context.Attach(fy);
            _context.Entry(fy).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
