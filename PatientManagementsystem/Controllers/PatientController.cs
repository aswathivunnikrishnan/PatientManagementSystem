using PatientManagementsystem.DAL;
using PatientManagementsystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Tokenizer;

namespace PatientManagementsystem.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient
        public ActionResult Index()
        {
            return View();
        }

        // GET: /home/create
        [HttpGet]
        public ActionResult CreatePatient()
        {
            return View();
        }
        //GET: /home/create
        [HttpPost]
        public ActionResult CreatePatient(Patient p)
        {
            bool result = false;
            PatientDBHelper helper = new PatientDBHelper();
            try
            {
                if (ModelState.IsValid)
                {
                    result = helper.CreatePatientDetails(p);
                    ModelState.Clear();
                  //return Json(result, JsonRequestBehavior.AllowGet);
                    return View("Index");
                }
                else
                    return View();
            
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return View();
            }
        }

        //Get :
        [HttpGet]
        public ActionResult GetAll()
        {

            try
            {
                PatientDBHelper helper = new PatientDBHelper();
                List<Patient> patients = helper.GetAll();
                return Json(patients, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                return View();
            }
            
        }
    }

}