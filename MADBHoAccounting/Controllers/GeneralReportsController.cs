﻿

using MADBHoAccounting.Models;
using MADBHoAccounting.Options;
using MADBHoAccounting.StoredProcedures;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Reporting.NETCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MADBHoAccounting.Controllers
{
    public class GeneralReportsController : Controller
    {
        private readonly MADBHoAccountingContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public readonly ConnectionStrings _connectionStrings;
        public GeneralReportsController(MADBHoAccountingContext context, IWebHostEnvironment webHostEnvironment,IOptions<ConnectionStrings> connectionString)
        {
            _context = context;
            this._webHostEnvironment = webHostEnvironment;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            _connectionStrings = connectionString.Value;
        }

        public TrialBalanceDAL trialBalance = new TrialBalanceDAL();
        public IActionResult Index()
        {
            var tspid = HttpContext.User.Identity.Name;

            var acc = _context.TbUserLogin.Where(x => x.UserPkid == Convert.ToInt32(tspid)).FirstOrDefault();
            if (acc.AccountType == "Admin")
            {
                ViewBag.gpID = acc.Department;
                ViewBag.tID = "";
                ViewBag.sdID = "";
            }
            else if (acc.AccountType == "User")
            {
                TbTownAndDivision td = _context.TbTownAndDivision.Where(x => x.TownCode == acc.TownshipId).FirstOrDefault();
                ViewBag.gpID = "";
                ViewBag.tID = td.TownCode;
                ViewBag.sdID = "";
            }
            else if (acc.AccountType == "Super Admin")
            {
                TbTownAndDivision sd = _context.TbTownAndDivision.Where(x => x.DivisionCode == acc.StateDivisionId).FirstOrDefault();
                ViewBag.gpID = "";
                ViewBag.tID = "";
                ViewBag.sdID = sd.DivisionCode;
            }
            else if (acc.AccountType == "Head Admin")
            {
                TbTownAndDivision sd = _context.TbTownAndDivision.Where(x => x.DivisionCode == acc.StateDivisionId).FirstOrDefault();
                ViewBag.gpID = "";
                ViewBag.tID = "";
                ViewBag.sdID = "";
            }
            return View();
        }
        //public IActionResult Print(bool condition, DateTime eDate)
        //{            
        //    var dt = new DataTable();
        //    dt = trialBalance.GetReportList(condition, eDate);

        //    String mimetype = "";
        //    int extension = 1;
        //    var path = $"{this._webHostEnvironment.WebRootPath}\\Reports\\TriReport.rdlc";
        //    Dictionary<string, string> parameters = new Dictionary<string, string>();
        //    //parameters.Add("rp1", "This is RDLC Report");
        //    LocalReport localReport = new LocalReport(path);

        //    localReport.AddDataSource("DataSet1", dt);
        //    var result = localReport.Execute(RenderType.Pdf, extension, parameters, mimetype);
        //    return File(result.MainStream, "application/pdf");

        //}

        //public JsonResult GetGeneralReportResult(string gpID, string tID, string sdID, DateTime eDate , string rpType)
        //{
        //    //DateTime d = Convert.ToDateTime(eDate);
        //    //var dN = d.ToString("dd/MM/yyyy");

        //    var reportId = trialBalance.GetReportList(gpID, tID, sdID, eDate, rpType); 
        //    return Json(reportId);
        //}

        //Excel Report
        //public IActionResult PrintReceipt()
        //{
        //    string renderFormat = "Excel";
        //    string extension = "Export.xls";
        //    string mimetype = "application/msexcel";
        //    using (var report = new LocalReport())
        //    {

        //        var userList = _context.TbUserLogin.Where(x => x.Status == "Enable").ToList();

        //        report.DataSources.Add(new ReportDataSource("dsExpense", userList));
        //        report.ReportPath = $"{_webHostEnvironment.WebRootPath}\\Reports\\Report1.rdlc";

        //        var pdf = report.Render(renderFormat);
        //        return File(pdf, mimetype, "Users_report." + extension);
        //    }
        //}
        [HttpGet]
        public IActionResult PrintReceipt()
        {
            string renderFormat = "PDF";
            string extension = "pdf";
            string mimetype = "application/pdf";
            using (var report = new LocalReport())
            {

                var userList = _context.TbUserLogin.Where(x => x.Status == "Enable").ToList();

                report.DataSources.Add(new ReportDataSource("dsExpense", userList));
                report.ReportPath = $"{_webHostEnvironment.WebRootPath}\\Reports\\Report1.rdlc";

                var pdf = report.Render(renderFormat);
                return File(pdf, mimetype, "Users_report." + extension);
            }
         
        }


        [HttpGet]
        public ActionResult GetGeneralReportResult(string gpID, string tID, string sdID, DateTime eDate, string rpType, string rdVal, DateTime sDate)
        {
            //List<TrialBalance> reportId;
            try
            {
                if (rdVal == "upto" || rdVal == "equal")
                {
                    sDate = DateTime.Now;
                }
                if (rpType == "Trial Balance")
                {
                    var reportId = trialBalance.GetTriBalanceList(gpID, tID, sdID, eDate, rpType, rdVal, sDate,_connectionStrings.DefaultConnection).ToList();
                    return PartialView("_IndexPartial", reportId);
                }
                else if (rpType == "Day Book")
                {
                    var reportId = trialBalance.GetDayBookList(gpID, tID, sdID, eDate, rpType, rdVal, sDate, _connectionStrings.DefaultConnection).ToList();
                    return PartialView("_daybookPartial", reportId);
                }
                else if (rpType == "Income")
                {
                    var reportId = trialBalance.GetIncomeList(gpID, tID, sdID, eDate, rpType, rdVal, sDate, _connectionStrings.DefaultConnection).ToList();
                    return PartialView("_incomePartial", reportId);
                }
                else if (rpType == "Expenditure")
                {
                    var reportId = trialBalance.GetExpenditureList(gpID, tID, sdID, eDate, rpType, rdVal, sDate, _connectionStrings.DefaultConnection).ToList();
                    return PartialView("_expenditurePartial", reportId);
                }
                else if (rpType == "Income Progressive")
                {
                    var reportId = trialBalance.GetIncomeProgressiveList(gpID, tID, sdID, eDate, rpType, rdVal, sDate, _connectionStrings.DefaultConnection).ToList();
                    return PartialView("_incomeProgressivePartial", reportId);
                }

            }
            catch (Exception ex)
            {

            }
            return View();
        }
    }
}
