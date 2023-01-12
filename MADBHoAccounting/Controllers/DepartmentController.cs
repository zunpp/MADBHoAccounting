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
    public class DepartmentController : Controller
    {
        private readonly MADBHoAccountingContext _context;
        public readonly ConnectionStrings _connectionStrings;
        public DepartmentController(MADBHoAccountingContext context,IOptions<ConnectionStrings> connectionString)
        {
            _context = context;
            _connectionStrings = connectionString.Value;
        }

        DepartmentDAL deptDAL = new DepartmentDAL();

        [HttpGet]
        public IActionResult Index(int pg = 1)
        {
            const int pageSize = 10;

            if (pg < 1)
                pg = 1;

            int recsCount = _context.TbDepartment.Count();

            //var pager = new Pager(recsCount, pg, pageSize, "Department");
            //int recSkip = (pg - 1) * pageSize;
            List<TbDepartment> fy = deptDAL.GetAllDepartment(_connectionStrings.DefaultConnection).ToList();//.Skip(recSkip).Take(pager.PageSize).ToList()
            //AMT.Skip(recSkip).Take(pager.PageSize).ToList();
            //this.ViewBag.Pager = pager;

            return View(fy);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            TbDepartment fy = deptDAL.GetAllDepartment(_connectionStrings.DefaultConnection).Where(x => x.DepartmentPkid == id).FirstOrDefault();

            return View(fy);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            TbDepartment fy = deptDAL.GetAllDepartment(_connectionStrings.DefaultConnection).Where(x => x.DepartmentPkid == id).FirstOrDefault();

            return View(fy);
        }

        [HttpPost]
        public IActionResult Edit(TbDepartment fy)
        {
            _context.Attach(fy);
            _context.Entry(fy).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            TbDepartment fy = deptDAL.GetAllDepartment(_connectionStrings.DefaultConnection).Where(x => x.DepartmentPkid == id).FirstOrDefault();

            return View(fy);
        }

        [HttpPost]
        public IActionResult Delete(TbDepartment fy)
        {
            _context.Attach(fy);
            _context.Entry(fy).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            TbDepartment fy = new TbDepartment();
            return View(fy);
        }

        [HttpPost]
        public IActionResult Create(TbDepartment fy)
        {
            _context.Attach(fy);
            _context.Entry(fy).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            _context.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}
