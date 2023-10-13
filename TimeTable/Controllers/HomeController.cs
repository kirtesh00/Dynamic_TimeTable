using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeTable.Models;

namespace TimeTable.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(InputFields inputFields)
        {
            
            
                if (inputFields.Total_hours_for_week != null && inputFields.Total_hours_for_week > 0)
                {
                    if (inputFields.Total_Subjects == 1)
                    {
                        inputFields.Sub_Working_Hours = inputFields.Total_hours_for_week;
                    }
                    else if (inputFields.Total_Subjects == 2)
                    {
                        int total = inputFields.Total_hours_for_week / inputFields.Total_Subjects;
                        inputFields.Sub_Working_Hours = total;

                    }
                    else if (inputFields.Total_Subjects == 3)
                    {

                        int total = inputFields.Total_hours_for_week / inputFields.Total_Subjects;
                        inputFields.Sub_Working_Hours = total;
                    }
                    else
                    {

                        int total = inputFields.Total_hours_for_week / inputFields.Total_Subjects;
                        inputFields.Sub_Working_Hours = total;
                    }
                    return RedirectToAction("GeneratSubject", inputFields);
                }
 

            return View();
        }


        public ActionResult GeneratSubject(InputFields inputFields)
        {
            

            return View(inputFields);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}