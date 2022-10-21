using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PatientManagementsystem.Models;
namespace PatientManagementsystem.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        [HttpGet]
        public ActionResult login()
        {
            return View();
        }
        public ActionResult Verify()
        {
            return View();
        }
    }
}